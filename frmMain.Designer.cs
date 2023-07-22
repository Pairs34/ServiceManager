namespace ServiceManager
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSystemServiceList = new System.Windows.Forms.Label();
            this.btnRefreshWinServiceList = new System.Windows.Forms.Button();
            this.lstWatchedServices = new System.Windows.Forms.ListView();
            this.btnAddWatchService = new System.Windows.Forms.Button();
            this.btnRemoveWatchService = new System.Windows.Forms.Button();
            this.lstSystemServiceList = new System.Windows.Forms.ListView();
            this.clScDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clScServiceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clWatchScDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clWatchServiceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clWatchServiceStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStartAll = new System.Windows.Forms.Button();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.btnSaveWatchServices = new System.Windows.Forms.Button();
            this.pnlServiceDetail = new System.Windows.Forms.Panel();
            this.lblInfoScDispName = new System.Windows.Forms.Label();
            this.txtInfoScDispName = new System.Windows.Forms.Label();
            this.txtInfoScName = new System.Windows.Forms.Label();
            this.lblInfoScName = new System.Windows.Forms.Label();
            this.txtInfoScStatus = new System.Windows.Forms.Label();
            this.lblInfoScStatus = new System.Windows.Forms.Label();
            this.txtInfoScCanStop = new System.Windows.Forms.Label();
            this.lblInfoScCanStop = new System.Windows.Forms.Label();
            this.pnlServiceDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSystemServiceList
            // 
            this.lblSystemServiceList.AutoSize = true;
            this.lblSystemServiceList.Location = new System.Drawing.Point(12, 13);
            this.lblSystemServiceList.Name = "lblSystemServiceList";
            this.lblSystemServiceList.Size = new System.Drawing.Size(68, 13);
            this.lblSystemServiceList.TabIndex = 1;
            this.lblSystemServiceList.Text = "Servis Listesi";
            // 
            // btnRefreshWinServiceList
            // 
            this.btnRefreshWinServiceList.Location = new System.Drawing.Point(264, 3);
            this.btnRefreshWinServiceList.Name = "btnRefreshWinServiceList";
            this.btnRefreshWinServiceList.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshWinServiceList.TabIndex = 2;
            this.btnRefreshWinServiceList.Text = "Yenile";
            this.btnRefreshWinServiceList.UseVisualStyleBackColor = true;
            this.btnRefreshWinServiceList.Click += new System.EventHandler(this.btnRefreshWinServiceList_Click);
            // 
            // lstWatchedServices
            // 
            this.lstWatchedServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clWatchScDisplayName,
            this.clWatchServiceName,
            this.clWatchServiceStatus});
            this.lstWatchedServices.FullRowSelect = true;
            this.lstWatchedServices.HideSelection = false;
            this.lstWatchedServices.Location = new System.Drawing.Point(378, 32);
            this.lstWatchedServices.Name = "lstWatchedServices";
            this.lstWatchedServices.Size = new System.Drawing.Size(410, 181);
            this.lstWatchedServices.TabIndex = 3;
            this.lstWatchedServices.UseCompatibleStateImageBehavior = false;
            this.lstWatchedServices.View = System.Windows.Forms.View.Details;
            this.lstWatchedServices.SelectedIndexChanged += new System.EventHandler(this.lstWatchedServices_SelectedIndexChanged);
            // 
            // btnAddWatchService
            // 
            this.btnAddWatchService.Location = new System.Drawing.Point(345, 109);
            this.btnAddWatchService.Name = "btnAddWatchService";
            this.btnAddWatchService.Size = new System.Drawing.Size(27, 23);
            this.btnAddWatchService.TabIndex = 4;
            this.btnAddWatchService.Text = ">";
            this.btnAddWatchService.UseVisualStyleBackColor = true;
            this.btnAddWatchService.Click += new System.EventHandler(this.btnAddWatchService_Click);
            // 
            // btnRemoveWatchService
            // 
            this.btnRemoveWatchService.Location = new System.Drawing.Point(345, 138);
            this.btnRemoveWatchService.Name = "btnRemoveWatchService";
            this.btnRemoveWatchService.Size = new System.Drawing.Size(27, 23);
            this.btnRemoveWatchService.TabIndex = 5;
            this.btnRemoveWatchService.Text = "<";
            this.btnRemoveWatchService.UseVisualStyleBackColor = true;
            this.btnRemoveWatchService.Click += new System.EventHandler(this.btnRemoveWatchService_Click);
            // 
            // lstSystemServiceList
            // 
            this.lstSystemServiceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clScDisplayName,
            this.clScServiceName,
            this.clStatus});
            this.lstSystemServiceList.FullRowSelect = true;
            this.lstSystemServiceList.HideSelection = false;
            this.lstSystemServiceList.Location = new System.Drawing.Point(15, 32);
            this.lstSystemServiceList.Name = "lstSystemServiceList";
            this.lstSystemServiceList.Size = new System.Drawing.Size(324, 403);
            this.lstSystemServiceList.TabIndex = 6;
            this.lstSystemServiceList.UseCompatibleStateImageBehavior = false;
            this.lstSystemServiceList.View = System.Windows.Forms.View.Details;
            // 
            // clScDisplayName
            // 
            this.clScDisplayName.Text = "Görünen Ad";
            this.clScDisplayName.Width = 118;
            // 
            // clScServiceName
            // 
            this.clScServiceName.Text = "Servis Adı";
            this.clScServiceName.Width = 98;
            // 
            // clStatus
            // 
            this.clStatus.Text = "Durumu";
            this.clStatus.Width = 82;
            // 
            // clWatchScDisplayName
            // 
            this.clWatchScDisplayName.Text = "Görünen Adı";
            this.clWatchScDisplayName.Width = 213;
            // 
            // clWatchServiceName
            // 
            this.clWatchServiceName.Text = "Servis Adı";
            this.clWatchServiceName.Width = 120;
            // 
            // clWatchServiceStatus
            // 
            this.clWatchServiceStatus.Text = "Durumu";
            // 
            // btnStartAll
            // 
            this.btnStartAll.Location = new System.Drawing.Point(378, 220);
            this.btnStartAll.Name = "btnStartAll";
            this.btnStartAll.Size = new System.Drawing.Size(75, 23);
            this.btnStartAll.TabIndex = 7;
            this.btnStartAll.Text = "Tüm. Başlat";
            this.btnStartAll.UseVisualStyleBackColor = true;
            this.btnStartAll.Click += new System.EventHandler(this.btnStartAll_Click);
            // 
            // btnStopAll
            // 
            this.btnStopAll.Location = new System.Drawing.Point(459, 220);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(75, 23);
            this.btnStopAll.TabIndex = 8;
            this.btnStopAll.Text = "Tüm. Durdur";
            this.btnStopAll.UseVisualStyleBackColor = true;
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // btnSaveWatchServices
            // 
            this.btnSaveWatchServices.Location = new System.Drawing.Point(713, 3);
            this.btnSaveWatchServices.Name = "btnSaveWatchServices";
            this.btnSaveWatchServices.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWatchServices.TabIndex = 9;
            this.btnSaveWatchServices.Text = "Kaydet";
            this.btnSaveWatchServices.UseVisualStyleBackColor = true;
            this.btnSaveWatchServices.Click += new System.EventHandler(this.btnSaveWatchServices_Click);
            // 
            // pnlServiceDetail
            // 
            this.pnlServiceDetail.Controls.Add(this.txtInfoScCanStop);
            this.pnlServiceDetail.Controls.Add(this.lblInfoScCanStop);
            this.pnlServiceDetail.Controls.Add(this.txtInfoScStatus);
            this.pnlServiceDetail.Controls.Add(this.lblInfoScStatus);
            this.pnlServiceDetail.Controls.Add(this.txtInfoScName);
            this.pnlServiceDetail.Controls.Add(this.lblInfoScName);
            this.pnlServiceDetail.Controls.Add(this.txtInfoScDispName);
            this.pnlServiceDetail.Controls.Add(this.lblInfoScDispName);
            this.pnlServiceDetail.Location = new System.Drawing.Point(378, 249);
            this.pnlServiceDetail.Name = "pnlServiceDetail";
            this.pnlServiceDetail.Size = new System.Drawing.Size(410, 186);
            this.pnlServiceDetail.TabIndex = 10;
            // 
            // lblInfoScDispName
            // 
            this.lblInfoScDispName.AutoSize = true;
            this.lblInfoScDispName.Location = new System.Drawing.Point(12, 16);
            this.lblInfoScDispName.Name = "lblInfoScDispName";
            this.lblInfoScDispName.Size = new System.Drawing.Size(72, 13);
            this.lblInfoScDispName.TabIndex = 0;
            this.lblInfoScDispName.Text = "Görünen Adı :";
            // 
            // txtInfoScDispName
            // 
            this.txtInfoScDispName.AutoSize = true;
            this.txtInfoScDispName.Location = new System.Drawing.Point(102, 16);
            this.txtInfoScDispName.Name = "txtInfoScDispName";
            this.txtInfoScDispName.Size = new System.Drawing.Size(16, 13);
            this.txtInfoScDispName.TabIndex = 1;
            this.txtInfoScDispName.Text = "...";
            // 
            // txtInfoScName
            // 
            this.txtInfoScName.AutoSize = true;
            this.txtInfoScName.Location = new System.Drawing.Point(102, 38);
            this.txtInfoScName.Name = "txtInfoScName";
            this.txtInfoScName.Size = new System.Drawing.Size(16, 13);
            this.txtInfoScName.TabIndex = 3;
            this.txtInfoScName.Text = "...";
            // 
            // lblInfoScName
            // 
            this.lblInfoScName.AutoSize = true;
            this.lblInfoScName.Location = new System.Drawing.Point(12, 38);
            this.lblInfoScName.Name = "lblInfoScName";
            this.lblInfoScName.Size = new System.Drawing.Size(67, 13);
            this.lblInfoScName.TabIndex = 2;
            this.lblInfoScName.Text = "Service Adı :";
            // 
            // txtInfoScStatus
            // 
            this.txtInfoScStatus.AutoSize = true;
            this.txtInfoScStatus.Location = new System.Drawing.Point(102, 61);
            this.txtInfoScStatus.Name = "txtInfoScStatus";
            this.txtInfoScStatus.Size = new System.Drawing.Size(16, 13);
            this.txtInfoScStatus.TabIndex = 5;
            this.txtInfoScStatus.Text = "...";
            // 
            // lblInfoScStatus
            // 
            this.lblInfoScStatus.AutoSize = true;
            this.lblInfoScStatus.Location = new System.Drawing.Point(12, 61);
            this.lblInfoScStatus.Name = "lblInfoScStatus";
            this.lblInfoScStatus.Size = new System.Drawing.Size(50, 13);
            this.lblInfoScStatus.TabIndex = 4;
            this.lblInfoScStatus.Text = "Durumu :";
            // 
            // txtInfoScCanStop
            // 
            this.txtInfoScCanStop.AutoSize = true;
            this.txtInfoScCanStop.Location = new System.Drawing.Point(102, 82);
            this.txtInfoScCanStop.Name = "txtInfoScCanStop";
            this.txtInfoScCanStop.Size = new System.Drawing.Size(16, 13);
            this.txtInfoScCanStop.TabIndex = 7;
            this.txtInfoScCanStop.Text = "...";
            // 
            // lblInfoScCanStop
            // 
            this.lblInfoScCanStop.AutoSize = true;
            this.lblInfoScCanStop.Location = new System.Drawing.Point(12, 82);
            this.lblInfoScCanStop.Name = "lblInfoScCanStop";
            this.lblInfoScCanStop.Size = new System.Drawing.Size(84, 13);
            this.lblInfoScCanStop.TabIndex = 6;
            this.lblInfoScCanStop.Text = "Durdurulabilirlik :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlServiceDetail);
            this.Controls.Add(this.btnSaveWatchServices);
            this.Controls.Add(this.btnStopAll);
            this.Controls.Add(this.btnStartAll);
            this.Controls.Add(this.lstSystemServiceList);
            this.Controls.Add(this.btnRemoveWatchService);
            this.Controls.Add(this.btnAddWatchService);
            this.Controls.Add(this.lstWatchedServices);
            this.Controls.Add(this.btnRefreshWinServiceList);
            this.Controls.Add(this.lblSystemServiceList);
            this.Name = "frmMain";
            this.Text = "ServiceManager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlServiceDetail.ResumeLayout(false);
            this.pnlServiceDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSystemServiceList;
        private System.Windows.Forms.Button btnRefreshWinServiceList;
        private System.Windows.Forms.ListView lstWatchedServices;
        private System.Windows.Forms.Button btnAddWatchService;
        private System.Windows.Forms.Button btnRemoveWatchService;
        private System.Windows.Forms.ListView lstSystemServiceList;
        private System.Windows.Forms.ColumnHeader clScDisplayName;
        private System.Windows.Forms.ColumnHeader clScServiceName;
        private System.Windows.Forms.ColumnHeader clStatus;
        private System.Windows.Forms.ColumnHeader clWatchScDisplayName;
        private System.Windows.Forms.ColumnHeader clWatchServiceName;
        private System.Windows.Forms.ColumnHeader clWatchServiceStatus;
        private System.Windows.Forms.Button btnStartAll;
        private System.Windows.Forms.Button btnStopAll;
        private System.Windows.Forms.Button btnSaveWatchServices;
        private System.Windows.Forms.Panel pnlServiceDetail;
        private System.Windows.Forms.Label txtInfoScCanStop;
        private System.Windows.Forms.Label lblInfoScCanStop;
        private System.Windows.Forms.Label txtInfoScStatus;
        private System.Windows.Forms.Label lblInfoScStatus;
        private System.Windows.Forms.Label txtInfoScName;
        private System.Windows.Forms.Label lblInfoScName;
        private System.Windows.Forms.Label txtInfoScDispName;
        private System.Windows.Forms.Label lblInfoScDispName;
    }
}

