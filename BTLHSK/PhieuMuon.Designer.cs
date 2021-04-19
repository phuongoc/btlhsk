namespace BTLHSK
{
    partial class PhieuMuon
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
            this.components = new System.ComponentModel.Container();
            this.dataGridPhieuMuon = new System.Windows.Forms.DataGridView();
            this.phieuMuonChiTietDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuThuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPhieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlysachDataSet2 = new BTLHSK.quanlysachDataSet2();
            this.report = new System.Windows.Forms.Button();
            this.traSach = new System.Windows.Forms.Button();
            this.tblPhieuMuonTableAdapter = new BTLHSK.quanlysachDataSet2TableAdapters.tblPhieuMuonTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mụcLụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thủThưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuMượnChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.làmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalReportPhieuMuon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.back = new System.Windows.Forms.Button();
            this.daTra = new System.Windows.Forms.RadioButton();
            this.chuaTra = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhieuMuonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysachDataSet2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridPhieuMuon
            // 
            this.dataGridPhieuMuon.AutoGenerateColumns = false;
            this.dataGridPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phieuMuonChiTietDataGridViewTextBoxColumn,
            this.sinhVienDataGridViewTextBoxColumn,
            this.thuThuDataGridViewTextBoxColumn,
            this.sachDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn});
            this.dataGridPhieuMuon.DataSource = this.tblPhieuMuonBindingSource;
            this.dataGridPhieuMuon.Location = new System.Drawing.Point(323, 89);
            this.dataGridPhieuMuon.Name = "dataGridPhieuMuon";
            this.dataGridPhieuMuon.RowHeadersWidth = 51;
            this.dataGridPhieuMuon.RowTemplate.Height = 24;
            this.dataGridPhieuMuon.Size = new System.Drawing.Size(727, 449);
            this.dataGridPhieuMuon.TabIndex = 17;
            this.dataGridPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPhieuMuon_CellClick);
            // 
            // phieuMuonChiTietDataGridViewTextBoxColumn
            // 
            this.phieuMuonChiTietDataGridViewTextBoxColumn.DataPropertyName = "phieuMuonChiTiet";
            this.phieuMuonChiTietDataGridViewTextBoxColumn.HeaderText = "phieuMuonChiTiet";
            this.phieuMuonChiTietDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phieuMuonChiTietDataGridViewTextBoxColumn.Name = "phieuMuonChiTietDataGridViewTextBoxColumn";
            this.phieuMuonChiTietDataGridViewTextBoxColumn.Width = 125;
            // 
            // sinhVienDataGridViewTextBoxColumn
            // 
            this.sinhVienDataGridViewTextBoxColumn.DataPropertyName = "sinhVien";
            this.sinhVienDataGridViewTextBoxColumn.HeaderText = "sinhVien";
            this.sinhVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sinhVienDataGridViewTextBoxColumn.Name = "sinhVienDataGridViewTextBoxColumn";
            this.sinhVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // thuThuDataGridViewTextBoxColumn
            // 
            this.thuThuDataGridViewTextBoxColumn.DataPropertyName = "thuThu";
            this.thuThuDataGridViewTextBoxColumn.HeaderText = "thuThu";
            this.thuThuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thuThuDataGridViewTextBoxColumn.Name = "thuThuDataGridViewTextBoxColumn";
            this.thuThuDataGridViewTextBoxColumn.Width = 125;
            // 
            // sachDataGridViewTextBoxColumn
            // 
            this.sachDataGridViewTextBoxColumn.DataPropertyName = "sach";
            this.sachDataGridViewTextBoxColumn.HeaderText = "sach";
            this.sachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sachDataGridViewTextBoxColumn.Name = "sachDataGridViewTextBoxColumn";
            this.sachDataGridViewTextBoxColumn.Width = 125;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "trangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "trangThai";
            this.trangThaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPhieuMuonBindingSource
            // 
            this.tblPhieuMuonBindingSource.DataMember = "tblPhieuMuon";
            this.tblPhieuMuonBindingSource.DataSource = this.quanlysachDataSet2;
            // 
            // quanlysachDataSet2
            // 
            this.quanlysachDataSet2.DataSetName = "quanlysachDataSet2";
            this.quanlysachDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(562, 557);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(104, 52);
            this.report.TabIndex = 18;
            this.report.Text = "Báo cáo";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // traSach
            // 
            this.traSach.Location = new System.Drawing.Point(691, 557);
            this.traSach.Name = "traSach";
            this.traSach.Size = new System.Drawing.Size(107, 52);
            this.traSach.TabIndex = 19;
            this.traSach.Text = "Trả sách";
            this.traSach.UseVisualStyleBackColor = true;
            this.traSach.Click += new System.EventHandler(this.traSach_Click);
            // 
            // tblPhieuMuonTableAdapter
            // 
            this.tblPhieuMuonTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mụcLụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1317, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mụcLụcToolStripMenuItem
            // 
            this.mụcLụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sáchToolStripMenuItem,
            this.thểLoạiToolStripMenuItem,
            this.sinhViênToolStripMenuItem,
            this.thủThưToolStripMenuItem,
            this.phiếuMượnChiTiếtToolStripMenuItem,
            this.làmMớiToolStripMenuItem});
            this.mụcLụcToolStripMenuItem.Name = "mụcLụcToolStripMenuItem";
            this.mụcLụcToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.mụcLụcToolStripMenuItem.Text = "Mục lục";
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.sáchToolStripMenuItem.Text = "Sách";
            this.sáchToolStripMenuItem.Click += new System.EventHandler(this.sáchToolStripMenuItem_Click);
            // 
            // thểLoạiToolStripMenuItem
            // 
            this.thểLoạiToolStripMenuItem.Name = "thểLoạiToolStripMenuItem";
            this.thểLoạiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.thểLoạiToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.thểLoạiToolStripMenuItem.Text = "Thể loại";
            this.thểLoạiToolStripMenuItem.Click += new System.EventHandler(this.thểLoạiToolStripMenuItem_Click);
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.sinhViênToolStripMenuItem.Text = "Sinh viên";
            this.sinhViênToolStripMenuItem.Click += new System.EventHandler(this.sinhViênToolStripMenuItem_Click);
            // 
            // thủThưToolStripMenuItem
            // 
            this.thủThưToolStripMenuItem.Name = "thủThưToolStripMenuItem";
            this.thủThưToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.thủThưToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.thủThưToolStripMenuItem.Text = "Thủ thư";
            this.thủThưToolStripMenuItem.Click += new System.EventHandler(this.thủThưToolStripMenuItem_Click);
            // 
            // phiếuMượnChiTiếtToolStripMenuItem
            // 
            this.phiếuMượnChiTiếtToolStripMenuItem.Name = "phiếuMượnChiTiếtToolStripMenuItem";
            this.phiếuMượnChiTiếtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.phiếuMượnChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.phiếuMượnChiTiếtToolStripMenuItem.Text = "Phiếu mượn chi tiết";
            this.phiếuMượnChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.phiếuMượnChiTiếtToolStripMenuItem_Click);
            // 
            // làmMớiToolStripMenuItem
            // 
            this.làmMớiToolStripMenuItem.Name = "làmMớiToolStripMenuItem";
            this.làmMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.làmMớiToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.làmMớiToolStripMenuItem.Text = "Làm mới";
            this.làmMớiToolStripMenuItem.Click += new System.EventHandler(this.làmMớiToolStripMenuItem_Click);
            // 
            // crystalReportPhieuMuon
            // 
            this.crystalReportPhieuMuon.ActiveViewIndex = -1;
            this.crystalReportPhieuMuon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportPhieuMuon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportPhieuMuon.DisplayStatusBar = false;
            this.crystalReportPhieuMuon.DisplayToolbar = false;
            this.crystalReportPhieuMuon.Location = new System.Drawing.Point(98, 74);
            this.crystalReportPhieuMuon.Name = "crystalReportPhieuMuon";
            this.crystalReportPhieuMuon.Size = new System.Drawing.Size(1207, 535);
            this.crystalReportPhieuMuon.TabIndex = 21;
            this.crystalReportPhieuMuon.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(609, 625);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(127, 53);
            this.back.TabIndex = 68;
            this.back.Text = "Quay lại";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // daTra
            // 
            this.daTra.AutoSize = true;
            this.daTra.Location = new System.Drawing.Point(569, 47);
            this.daTra.Name = "daTra";
            this.daTra.Size = new System.Drawing.Size(68, 21);
            this.daTra.TabIndex = 69;
            this.daTra.TabStop = true;
            this.daTra.Text = "Đã trả";
            this.daTra.UseVisualStyleBackColor = true;
            this.daTra.CheckedChanged += new System.EventHandler(this.daTra_CheckedChanged);
            // 
            // chuaTra
            // 
            this.chuaTra.AutoSize = true;
            this.chuaTra.Location = new System.Drawing.Point(669, 47);
            this.chuaTra.Name = "chuaTra";
            this.chuaTra.Size = new System.Drawing.Size(83, 21);
            this.chuaTra.TabIndex = 70;
            this.chuaTra.TabStop = true;
            this.chuaTra.Text = "Chưa trả";
            this.chuaTra.UseVisualStyleBackColor = true;
            this.chuaTra.CheckedChanged += new System.EventHandler(this.chuaTra_CheckedChanged);
            // 
            // PhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 690);
            this.Controls.Add(this.chuaTra);
            this.Controls.Add(this.daTra);
            this.Controls.Add(this.back);
            this.Controls.Add(this.crystalReportPhieuMuon);
            this.Controls.Add(this.traSach);
            this.Controls.Add(this.report);
            this.Controls.Add(this.dataGridPhieuMuon);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PhieuMuon";
            this.Text = "PhieuMuon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhieuMuonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysachDataSet2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridPhieuMuon;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button traSach;
        private quanlysachDataSet2 quanlysachDataSet2;
        private System.Windows.Forms.BindingSource tblPhieuMuonBindingSource;
        private quanlysachDataSet2TableAdapters.tblPhieuMuonTableAdapter tblPhieuMuonTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mụcLụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thểLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thủThưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuMượnChiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem làmMớiToolStripMenuItem;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportPhieuMuon;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.RadioButton daTra;
        private System.Windows.Forms.RadioButton chuaTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn phieuMuonChiTietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuThuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
    }

}