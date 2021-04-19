namespace BTLHSK
{
    partial class SinhVien
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
            this.maSinhVien = new System.Windows.Forms.TextBox();
            this.hoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.dataGridSinhVien = new System.Windows.Forms.DataGridView();
            this.maSinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlysachDataSet2 = new BTLHSK.quanlysachDataSet2();
            this.diaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nam = new System.Windows.Forms.RadioButton();
            this.nu = new System.Windows.Forms.RadioButton();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.report = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.tblSinhVienTableAdapter = new BTLHSK.quanlysachDataSet2TableAdapters.tblSinhVienTableAdapter();
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
            this.inforGroup = new System.Windows.Forms.GroupBox();
            this.controlGroup = new System.Windows.Forms.GroupBox();
            this.listGroup = new System.Windows.Forms.GroupBox();
            this.sinhVienReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysachDataSet2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.inforGroup.SuspendLayout();
            this.controlGroup.SuspendLayout();
            this.listGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(26, 172);
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
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên";
            // 
            // maSinhVien
            // 
            this.maSinhVien.Location = new System.Drawing.Point(112, 47);
            this.maSinhVien.Name = "maSinhVien";
            this.maSinhVien.Size = new System.Drawing.Size(206, 22);
            this.maSinhVien.TabIndex = 2;
            // 
            // hoTen
            // 
            this.hoTen.Location = new System.Drawing.Point(112, 207);
            this.hoTen.Name = "hoTen";
            this.hoTen.Size = new System.Drawing.Size(206, 22);
            this.hoTen.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ tên";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(26, 105);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 46);
            this.delete.TabIndex = 11;
            this.delete.Text = "Xoá";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(26, 40);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 46);
            this.addition.TabIndex = 12;
            this.addition.Text = "Thêm";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // dataGridSinhVien
            // 
            this.dataGridSinhVien.AutoGenerateColumns = false;
            this.dataGridSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSinhVienDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.lopDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn});
            this.dataGridSinhVien.DataSource = this.tblSinhVienBindingSource;
            this.dataGridSinhVien.Location = new System.Drawing.Point(29, 40);
            this.dataGridSinhVien.Name = "dataGridSinhVien";
            this.dataGridSinhVien.RowHeadersWidth = 51;
            this.dataGridSinhVien.RowTemplate.Height = 24;
            this.dataGridSinhVien.Size = new System.Drawing.Size(866, 297);
            this.dataGridSinhVien.TabIndex = 17;
            this.dataGridSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblSinhVien_CellClick);
            // 
            // maSinhVienDataGridViewTextBoxColumn
            // 
            this.maSinhVienDataGridViewTextBoxColumn.DataPropertyName = "maSinhVien";
            this.maSinhVienDataGridViewTextBoxColumn.HeaderText = "maSinhVien";
            this.maSinhVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSinhVienDataGridViewTextBoxColumn.Name = "maSinhVienDataGridViewTextBoxColumn";
            this.maSinhVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "hoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "hoTen";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.Width = 125;
            // 
            // lopDataGridViewTextBoxColumn
            // 
            this.lopDataGridViewTextBoxColumn.DataPropertyName = "lop";
            this.lopDataGridViewTextBoxColumn.HeaderText = "lop";
            this.lopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lopDataGridViewTextBoxColumn.Name = "lopDataGridViewTextBoxColumn";
            this.lopDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "diaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "diaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "gioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "gioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "ngaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "ngaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblSinhVienBindingSource
            // 
            this.tblSinhVienBindingSource.DataMember = "tblSinhVien";
            this.tblSinhVienBindingSource.DataSource = this.quanlysachDataSet2;
            // 
            // quanlysachDataSet2
            // 
            this.quanlysachDataSet2.DataSetName = "quanlysachDataSet2";
            this.quanlysachDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diaChi
            // 
            this.diaChi.Location = new System.Drawing.Point(112, 257);
            this.diaChi.Name = "diaChi";
            this.diaChi.Size = new System.Drawing.Size(206, 22);
            this.diaChi.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Địa chỉ";
            // 
            // lop
            // 
            this.lop.Location = new System.Drawing.Point(112, 97);
            this.lop.Name = "lop";
            this.lop.Size = new System.Drawing.Size(206, 22);
            this.lop.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ngày sinh";
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Checked = true;
            this.nam.Location = new System.Drawing.Point(112, 310);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(58, 21);
            this.nam.TabIndex = 25;
            this.nam.TabStop = true;
            this.nam.Text = "Nam";
            this.nam.UseVisualStyleBackColor = true;
            // 
            // nu
            // 
            this.nu.AutoSize = true;
            this.nu.Location = new System.Drawing.Point(197, 310);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(47, 21);
            this.nu.TabIndex = 26;
            this.nu.TabStop = true;
            this.nu.Text = "Nữ";
            this.nu.UseVisualStyleBackColor = true;
            // 
            // dob
            // 
            this.dob.CustomFormat = "dd/MM/yyyy";
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob.Location = new System.Drawing.Point(112, 149);
            this.dob.MaxDate = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            this.dob.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 22);
            this.dob.TabIndex = 27;
            this.dob.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(26, 232);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(75, 46);
            this.report.TabIndex = 28;
            this.report.Text = "Báo cáo";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(26, 291);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 46);
            this.cancel.TabIndex = 29;
            this.cancel.Text = "Huỷ";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // tblSinhVienTableAdapter
            // 
            this.tblSinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mụcLụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1574, 28);
            this.menuStrip1.TabIndex = 30;
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
            this.sinhViênToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.sinhViênToolStripMenuItem.Text = "Phiếu mượn";
            this.sinhViênToolStripMenuItem.Click += new System.EventHandler(this.phiếuMượnToolStripMenuItem_Click);
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
            // back
            // 
            this.back.Location = new System.Drawing.Point(755, 622);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(113, 54);
            this.back.TabIndex = 56;
            this.back.Text = "Quay lại";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(755, 30);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(84, 35);
            this.find.TabIndex = 55;
            this.find.Text = "Tìm kiếm";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // timKiem
            // 
            this.timKiem.Location = new System.Drawing.Point(538, 40);
            this.timKiem.Name = "timKiem";
            this.timKiem.Size = new System.Drawing.Size(201, 22);
            this.timKiem.TabIndex = 54;
            this.timKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // timKiemLabel
            // 
            this.timKiemLabel.AutoSize = true;
            this.timKiemLabel.Location = new System.Drawing.Point(453, 39);
            this.timKiemLabel.Name = "timKiemLabel";
            this.timKiemLabel.Size = new System.Drawing.Size(64, 17);
            this.timKiemLabel.TabIndex = 53;
            this.timKiemLabel.Text = "Tìm kiếm";
            // 
            // inforGroup
            // 
            this.inforGroup.Controls.Add(this.dob);
            this.inforGroup.Controls.Add(this.nu);
            this.inforGroup.Controls.Add(this.nam);
            this.inforGroup.Controls.Add(this.label5);
            this.inforGroup.Controls.Add(this.label6);
            this.inforGroup.Controls.Add(this.diaChi);
            this.inforGroup.Controls.Add(this.label3);
            this.inforGroup.Controls.Add(this.lop);
            this.inforGroup.Controls.Add(this.label4);
            this.inforGroup.Controls.Add(this.hoTen);
            this.inforGroup.Controls.Add(this.label2);
            this.inforGroup.Controls.Add(this.maSinhVien);
            this.inforGroup.Controls.Add(this.label1);
            this.inforGroup.Location = new System.Drawing.Point(78, 164);
            this.inforGroup.Name = "inforGroup";
            this.inforGroup.Size = new System.Drawing.Size(344, 359);
            this.inforGroup.TabIndex = 58;
            this.inforGroup.TabStop = false;
            this.inforGroup.Text = "Thông tin sinh viên";
            // 
            // controlGroup
            // 
            this.controlGroup.Controls.Add(this.cancel);
            this.controlGroup.Controls.Add(this.report);
            this.controlGroup.Controls.Add(this.addition);
            this.controlGroup.Controls.Add(this.delete);
            this.controlGroup.Controls.Add(this.update);
            this.controlGroup.Location = new System.Drawing.Point(439, 164);
            this.controlGroup.Name = "controlGroup";
            this.controlGroup.Size = new System.Drawing.Size(132, 359);
            this.controlGroup.TabIndex = 59;
            this.controlGroup.TabStop = false;
            this.controlGroup.Text = "Tác vụ";
            // 
            // listGroup
            // 
            this.listGroup.Controls.Add(this.dataGridSinhVien);
            this.listGroup.Location = new System.Drawing.Point(594, 164);
            this.listGroup.Name = "listGroup";
            this.listGroup.Size = new System.Drawing.Size(917, 358);
            this.listGroup.TabIndex = 60;
            this.listGroup.TabStop = false;
            this.listGroup.Text = "Bảng danh sách";
            // 
            // sinhVienReport
            // 
            this.sinhVienReport.ActiveViewIndex = -1;
            this.sinhVienReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sinhVienReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.sinhVienReport.DisplayStatusBar = false;
            this.sinhVienReport.DisplayToolbar = false;
            this.sinhVienReport.Location = new System.Drawing.Point(46, 94);
            this.sinhVienReport.Name = "sinhVienReport";
            this.sinhVienReport.Size = new System.Drawing.Size(1484, 498);
            this.sinhVienReport.TabIndex = 61;
            this.sinhVienReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 724);
            this.Controls.Add(this.sinhVienReport);
            this.Controls.Add(this.back);
            this.Controls.Add(this.find);
            this.Controls.Add(this.timKiem);
            this.Controls.Add(this.timKiemLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.inforGroup);
            this.Controls.Add(this.controlGroup);
            this.Controls.Add(this.listGroup);
            this.Name = "SinhVien";
            this.Text = "SinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysachDataSet2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.inforGroup.ResumeLayout(false);
            this.inforGroup.PerformLayout();
            this.controlGroup.ResumeLayout(false);
            this.listGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maSinhVien;
        private System.Windows.Forms.TextBox hoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.DataGridView dataGridSinhVien;
        private System.Windows.Forms.TextBox diaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.RadioButton nu;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button cancel;
        private quanlysachDataSet2 quanlysachDataSet2;
        private System.Windows.Forms.BindingSource tblSinhVienBindingSource;
        private quanlysachDataSet2TableAdapters.tblSinhVienTableAdapter tblSinhVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.GroupBox inforGroup;
        private System.Windows.Forms.GroupBox controlGroup;
        private System.Windows.Forms.GroupBox listGroup;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer sinhVienReport;
    }
}