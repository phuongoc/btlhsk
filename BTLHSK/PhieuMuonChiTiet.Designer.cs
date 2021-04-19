namespace BTLHSK
{
    partial class PhieuMuonChiTiet
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
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.soPhieuMuon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.dataGridPhieuChiTiet = new System.Windows.Forms.DataGridView();
            this.soPhieuMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuThuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPhieuMuonChiTietBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlysachDataSet2 = new BTLHSK.quanlysachDataSet2();
            this.soLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ngayMuon = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.thuThu = new System.Windows.Forms.ComboBox();
            this.sach = new System.Windows.Forms.ComboBox();
            this.sinhVien = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.tblPhieuMuonChiTietTableAdapter = new BTLHSK.quanlysachDataSet2TableAdapters.tblPhieuMuonChiTietTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mụcLụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thủThưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuMượnChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.làmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.back = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.timKiem = new System.Windows.Forms.TextBox();
            this.timKiemLabel = new System.Windows.Forms.Label();
            this.crystalReportPhieuMuonChiTiet = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.inforGroup = new System.Windows.Forms.GroupBox();
            this.danhSachGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPhieuChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhieuMuonChiTietBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysachDataSet2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.inforGroup.SuspendLayout();
            this.danhSachGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(471, 204);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 46);
            this.update.TabIndex = 0;
            this.update.Text = "Sửa";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số phiếu mượn";
            // 
            // soPhieuMuon
            // 
            this.soPhieuMuon.Location = new System.Drawing.Point(289, 36);
            this.soPhieuMuon.Name = "soPhieuMuon";
            this.soPhieuMuon.Size = new System.Drawing.Size(206, 22);
            this.soPhieuMuon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sách";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(346, 204);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 46);
            this.delete.TabIndex = 11;
            this.delete.Text = "Xoá";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(230, 204);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 46);
            this.addition.TabIndex = 12;
            this.addition.Text = "Thêm";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(596, 204);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(75, 46);
            this.report.TabIndex = 15;
            this.report.Text = "Báo cáo";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // dataGridPhieuChiTiet
            // 
            this.dataGridPhieuChiTiet.AutoGenerateColumns = false;
            this.dataGridPhieuChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPhieuChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soPhieuMuonDataGridViewTextBoxColumn,
            this.sachDataGridViewTextBoxColumn,
            this.sinhVienDataGridViewTextBoxColumn,
            this.thuThuDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.ngayMuonDataGridViewTextBoxColumn});
            this.dataGridPhieuChiTiet.DataSource = this.tblPhieuMuonChiTietBindingSource;
            this.dataGridPhieuChiTiet.Location = new System.Drawing.Point(19, 30);
            this.dataGridPhieuChiTiet.Name = "dataGridPhieuChiTiet";
            this.dataGridPhieuChiTiet.RowTemplate.Height = 24;
            this.dataGridPhieuChiTiet.Size = new System.Drawing.Size(862, 202);
            this.dataGridPhieuChiTiet.TabIndex = 17;
            this.dataGridPhieuChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblSinhVien_CellClick);
            // 
            // soPhieuMuonDataGridViewTextBoxColumn
            // 
            this.soPhieuMuonDataGridViewTextBoxColumn.DataPropertyName = "soPhieuMuon";
            this.soPhieuMuonDataGridViewTextBoxColumn.HeaderText = "soPhieuMuon";
            this.soPhieuMuonDataGridViewTextBoxColumn.Name = "soPhieuMuonDataGridViewTextBoxColumn";
            // 
            // sachDataGridViewTextBoxColumn
            // 
            this.sachDataGridViewTextBoxColumn.DataPropertyName = "sach";
            this.sachDataGridViewTextBoxColumn.HeaderText = "sach";
            this.sachDataGridViewTextBoxColumn.Name = "sachDataGridViewTextBoxColumn";
            // 
            // sinhVienDataGridViewTextBoxColumn
            // 
            this.sinhVienDataGridViewTextBoxColumn.DataPropertyName = "sinhVien";
            this.sinhVienDataGridViewTextBoxColumn.HeaderText = "sinhVien";
            this.sinhVienDataGridViewTextBoxColumn.Name = "sinhVienDataGridViewTextBoxColumn";
            // 
            // thuThuDataGridViewTextBoxColumn
            // 
            this.thuThuDataGridViewTextBoxColumn.DataPropertyName = "thuThu";
            this.thuThuDataGridViewTextBoxColumn.HeaderText = "thuThu";
            this.thuThuDataGridViewTextBoxColumn.Name = "thuThuDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "soLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "soLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // ngayMuonDataGridViewTextBoxColumn
            // 
            this.ngayMuonDataGridViewTextBoxColumn.DataPropertyName = "ngayMuon";
            this.ngayMuonDataGridViewTextBoxColumn.HeaderText = "ngayMuon";
            this.ngayMuonDataGridViewTextBoxColumn.Name = "ngayMuonDataGridViewTextBoxColumn";
            // 
            // tblPhieuMuonChiTietBindingSource
            // 
            this.tblPhieuMuonChiTietBindingSource.DataMember = "tblPhieuMuonChiTiet";
            this.tblPhieuMuonChiTietBindingSource.DataSource = this.quanlysachDataSet2;
            // 
            // quanlysachDataSet2
            // 
            this.quanlysachDataSet2.DataSetName = "quanlysachDataSet2";
            this.quanlysachDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soLuong
            // 
            this.soLuong.Location = new System.Drawing.Point(289, 90);
            this.soLuong.Name = "soLuong";
            this.soLuong.Size = new System.Drawing.Size(206, 22);
            this.soLuong.TabIndex = 19;
            this.soLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soLuong_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày mượn";
            // 
            // ngayMuon
            // 
            this.ngayMuon.CustomFormat = "dd/MM/yyyy";
            this.ngayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayMuon.Location = new System.Drawing.Point(615, 90);
            this.ngayMuon.MaxDate = new System.DateTime(2020, 4, 15, 22, 11, 12, 0);
            this.ngayMuon.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.ngayMuon.Name = "ngayMuon";
            this.ngayMuon.Size = new System.Drawing.Size(200, 22);
            this.ngayMuon.TabIndex = 22;
            this.ngayMuon.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Thủ thư";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sinh viên";
            // 
            // thuThu
            // 
            this.thuThu.FormattingEnabled = true;
            this.thuThu.Location = new System.Drawing.Point(615, 148);
            this.thuThu.Name = "thuThu";
            this.thuThu.Size = new System.Drawing.Size(200, 24);
            this.thuThu.TabIndex = 27;
            // 
            // sach
            // 
            this.sach.FormattingEnabled = true;
            this.sach.Location = new System.Drawing.Point(615, 32);
            this.sach.Name = "sach";
            this.sach.Size = new System.Drawing.Size(200, 24);
            this.sach.TabIndex = 28;
            // 
            // sinhVien
            // 
            this.sinhVien.FormattingEnabled = true;
            this.sinhVien.Location = new System.Drawing.Point(289, 148);
            this.sinhVien.Name = "sinhVien";
            this.sinhVien.Size = new System.Drawing.Size(206, 24);
            this.sinhVien.TabIndex = 29;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(709, 204);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 46);
            this.cancel.TabIndex = 30;
            this.cancel.Text = "Huỷ";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // tblPhieuMuonChiTietTableAdapter
            // 
            this.tblPhieuMuonChiTietTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mụcLụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1319, 28);
            this.menuStrip1.TabIndex = 31;
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
            this.mụcLụcToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.mụcLụcToolStripMenuItem.Text = "Mục lục";
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.sáchToolStripMenuItem.Text = "Sách";
            this.sáchToolStripMenuItem.Click += new System.EventHandler(this.sáchToolStripMenuItem_Click);
            // 
            // thểLoạiToolStripMenuItem
            // 
            this.thểLoạiToolStripMenuItem.Name = "thểLoạiToolStripMenuItem";
            this.thểLoạiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.thểLoạiToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.thểLoạiToolStripMenuItem.Text = "Thể loại";
            this.thểLoạiToolStripMenuItem.Click += new System.EventHandler(this.thểLoạiToolStripMenuItem_Click);
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.sinhViênToolStripMenuItem.Text = "Sinh viên";
            this.sinhViênToolStripMenuItem.Click += new System.EventHandler(this.sinhViênToolStripMenuItem_Click);
            // 
            // thủThưToolStripMenuItem
            // 
            this.thủThưToolStripMenuItem.Name = "thủThưToolStripMenuItem";
            this.thủThưToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.thủThưToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.thủThưToolStripMenuItem.Text = "Thủ thư";
            this.thủThưToolStripMenuItem.Click += new System.EventHandler(this.thủThưToolStripMenuItem_Click);
            // 
            // phiếuMượnChiTiếtToolStripMenuItem
            // 
            this.phiếuMượnChiTiếtToolStripMenuItem.Name = "phiếuMượnChiTiếtToolStripMenuItem";
            this.phiếuMượnChiTiếtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.phiếuMượnChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.phiếuMượnChiTiếtToolStripMenuItem.Text = "Phiếu mượn";
            this.phiếuMượnChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.phiếuMượnToolStripMenuItem_Click);
            // 
            // làmMớiToolStripMenuItem
            // 
            this.làmMớiToolStripMenuItem.Name = "làmMớiToolStripMenuItem";
            this.làmMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.làmMớiToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.làmMớiToolStripMenuItem.Text = "Làm mới";
            this.làmMớiToolStripMenuItem.Click += new System.EventHandler(this.làmMớiToolStripMenuItem_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(651, 658);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(113, 51);
            this.back.TabIndex = 68;
            this.back.Text = "Quay lại";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(744, 54);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(84, 35);
            this.find.TabIndex = 67;
            this.find.Text = "Tìm kiếm";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // timKiem
            // 
            this.timKiem.Location = new System.Drawing.Point(527, 64);
            this.timKiem.Name = "timKiem";
            this.timKiem.Size = new System.Drawing.Size(201, 22);
            this.timKiem.TabIndex = 66;
            this.timKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // timKiemLabel
            // 
            this.timKiemLabel.AutoSize = true;
            this.timKiemLabel.Location = new System.Drawing.Point(442, 63);
            this.timKiemLabel.Name = "timKiemLabel";
            this.timKiemLabel.Size = new System.Drawing.Size(64, 17);
            this.timKiemLabel.TabIndex = 65;
            this.timKiemLabel.Text = "Tìm kiếm";
            // 
            // crystalReportPhieuMuonChiTiet
            // 
            this.crystalReportPhieuMuonChiTiet.ActiveViewIndex = -1;
            this.crystalReportPhieuMuonChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportPhieuMuonChiTiet.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportPhieuMuonChiTiet.DisplayStatusBar = false;
            this.crystalReportPhieuMuonChiTiet.DisplayToolbar = false;
            this.crystalReportPhieuMuonChiTiet.Location = new System.Drawing.Point(60, 40);
            this.crystalReportPhieuMuonChiTiet.Name = "crystalReportPhieuMuonChiTiet";
            this.crystalReportPhieuMuonChiTiet.Size = new System.Drawing.Size(1207, 538);
            this.crystalReportPhieuMuonChiTiet.TabIndex = 69;
            this.crystalReportPhieuMuonChiTiet.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // inforGroup
            // 
            this.inforGroup.Controls.Add(this.cancel);
            this.inforGroup.Controls.Add(this.sinhVien);
            this.inforGroup.Controls.Add(this.sach);
            this.inforGroup.Controls.Add(this.thuThu);
            this.inforGroup.Controls.Add(this.label6);
            this.inforGroup.Controls.Add(this.label5);
            this.inforGroup.Controls.Add(this.ngayMuon);
            this.inforGroup.Controls.Add(this.label4);
            this.inforGroup.Controls.Add(this.soLuong);
            this.inforGroup.Controls.Add(this.label3);
            this.inforGroup.Controls.Add(this.report);
            this.inforGroup.Controls.Add(this.addition);
            this.inforGroup.Controls.Add(this.delete);
            this.inforGroup.Controls.Add(this.label2);
            this.inforGroup.Controls.Add(this.soPhieuMuon);
            this.inforGroup.Controls.Add(this.label1);
            this.inforGroup.Controls.Add(this.update);
            this.inforGroup.Location = new System.Drawing.Point(240, 116);
            this.inforGroup.Name = "inforGroup";
            this.inforGroup.Size = new System.Drawing.Size(901, 266);
            this.inforGroup.TabIndex = 70;
            this.inforGroup.TabStop = false;
            this.inforGroup.Text = "Thông tin phiếu mượn chi tiết";
            // 
            // danhSachGroup
            // 
            this.danhSachGroup.Controls.Add(this.dataGridPhieuChiTiet);
            this.danhSachGroup.Location = new System.Drawing.Point(240, 388);
            this.danhSachGroup.Name = "danhSachGroup";
            this.danhSachGroup.Size = new System.Drawing.Size(900, 249);
            this.danhSachGroup.TabIndex = 71;
            this.danhSachGroup.TabStop = false;
            this.danhSachGroup.Text = "Bảng danh sách";
            // 
            // PhieuMuonChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 721);
            this.Controls.Add(this.crystalReportPhieuMuonChiTiet);
            this.Controls.Add(this.danhSachGroup);
            this.Controls.Add(this.inforGroup);
            this.Controls.Add(this.back);
            this.Controls.Add(this.find);
            this.Controls.Add(this.timKiem);
            this.Controls.Add(this.timKiemLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PhieuMuonChiTiet";
            this.Text = "PhieuMuonChiTiet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPhieuChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhieuMuonChiTietBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysachDataSet2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.inforGroup.ResumeLayout(false);
            this.inforGroup.PerformLayout();
            this.danhSachGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox soPhieuMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.DataGridView dataGridPhieuChiTiet;
        private System.Windows.Forms.TextBox soLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ngayMuon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox thuThu;
        private System.Windows.Forms.ComboBox sach;
        private System.Windows.Forms.ComboBox sinhVien;
        private System.Windows.Forms.Button cancel;
        private quanlysachDataSet2 quanlysachDataSet2;
        private System.Windows.Forms.BindingSource tblPhieuMuonChiTietBindingSource;
        private quanlysachDataSet2TableAdapters.tblPhieuMuonChiTietTableAdapter tblPhieuMuonChiTietTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soPhieuMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuThuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mụcLụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thểLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thủThưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuMượnChiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem làmMớiToolStripMenuItem;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TextBox timKiem;
        private System.Windows.Forms.Label timKiemLabel;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportPhieuMuonChiTiet;
        private System.Windows.Forms.GroupBox inforGroup;
        private System.Windows.Forms.GroupBox danhSachGroup;
    }
}