using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using ServiceManager.Models;
using Newtonsoft.Json;
using System.IO;

namespace ServiceManager
{
    public partial class frmMain : Form
    {
        string APPDIR = AppDomain.CurrentDomain.BaseDirectory;
        string servicePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "services.json");
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRefreshWinServiceList_Click(object sender, EventArgs e)
        {
            GetALlServices();
        }

        #region Procedures
        void GetALlServices()
        {
            var services = ServiceController.GetServices();

            foreach (var service in services)
            {
                var lItem = new ListViewItem();
                lItem.Text = service.DisplayName;
                lItem.SubItems.Add(service.ServiceName);
                lItem.SubItems.Add(service.Status.ToString());

                lstSystemServiceList.Items.Add(lItem);
            }
        }

        void SaveToFile()
        {
            var services = new List<CustomServices>();
            var listItems = lstWatchedServices.Items;
            foreach (ListViewItem service in listItems)
            {
                services.Add(new CustomServices
                {
                    ScDisplayName = service.SubItems[0].Text,
                    ScServiceName = service.SubItems[1].Text,
                    Status = service.SubItems[2].Text
                });
            }

            var servicesObject = JsonConvert.SerializeObject(services, Formatting.Indented);

            File.WriteAllText(servicePath, servicesObject);
        }

        void ReadAllWatchServices()
        {
            if (!File.Exists(servicePath))
                return;

            var servicesJsonText = File.ReadAllText(servicePath);
            var servicesObject = JsonConvert.DeserializeObject<List<CustomServices>>(servicesJsonText);
            foreach (CustomServices service in servicesObject)
            {
                var lItem = new ListViewItem();
                lItem.Text = service.ScDisplayName;
                lItem.SubItems.Add(service.ScServiceName);
                lItem.SubItems.Add(service.Status);

                lstWatchedServices.Items.Add(lItem);
            }
        }

        private void ChangeStatusOfServices(bool stop = false)
        {
            var selectedServices = lstWatchedServices.SelectedItems;

            foreach (ListViewItem service in selectedServices)
            {
                var serviceName = service.SubItems[1].Text;

                var systemService = ServiceController.GetServices().FirstOrDefault(x => x.ServiceName == serviceName);

                if (systemService != null)
                {
                    if (stop)
                        systemService.Stop();
                    else
                        systemService.Start();
                }
            }
        }

        #endregion

        private void btnAddWatchService_Click(object sender, EventArgs e)
        {
            var selectedServices = lstSystemServiceList.SelectedItems;

            foreach (ListViewItem service in selectedServices)
            {
                var lItem = new ListViewItem();
                lItem.Text = service.SubItems[0].Text;
                lItem.SubItems.Add(service.SubItems[1].Text);
                lItem.SubItems.Add(service.SubItems[2].Text);

                lstWatchedServices.Items.Add(lItem);
            }

            SaveToFile();
        }

        private void btnSaveWatchServices_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            GetALlServices();
            ReadAllWatchServices();
        }

        private void btnRemoveWatchService_Click(object sender, EventArgs e)
        {
            var selectedServices = lstWatchedServices.SelectedItems;

            foreach(ListViewItem service in selectedServices)
            {
                lstWatchedServices.Items.Remove(service);
            }

            SaveToFile() ;
        }

        private void btnStopAll_Click(object sender, EventArgs e)
        {
            ChangeStatusOfServices(true);
        }

        private void lstWatchedServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedServices = lstWatchedServices.SelectedItems;

            if (selectedServices.Count > 1)
            {
                MessageBox.Show("Sadece birtane seçebilirsiniz");
                return;
            }

            var selectedService = selectedServices[0].SubItems[1].Text;

            var systemService = ServiceController.GetServices().FirstOrDefault(x => x.ServiceName == selectedService);

            if (systemService != null)
            {
                txtInfoScDispName.Text = systemService.DisplayName;
                txtInfoScName.Text = systemService.ServiceName;
                txtInfoScStatus.Text = systemService.Status.ToString();
                txtInfoScCanStop.Text = systemService.CanStop.ToString();
            }
        }

        private void btnStartAll_Click(object sender, EventArgs e)
        {
            ChangeStatusOfServices(false);
        }
    }
}
