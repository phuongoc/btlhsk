namespace BTLHSK
{
    partial class ThuThu
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
            this.tblPhieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlysachDataSet2 = new BTLHSK.quanlysachDataSet2();
            this.report = new System.Windows.Forms.Button();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.nu = new System.Windows.Forms.RadioButton();
            this.nam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.diaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridThuThu = new System.Windows.Forms.DataGridView();
            this.maThuThuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblThuThuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addition = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.hoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maThuThu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.tblThuThuTableAdapter = new BTLHSK.quanlysachDataSet2TableAdapters.tblThuThuTableAdapter();
            this.tblPhieuMuonTableAdapter = new BTLHSK.quanlysachDataSet2TableAdapters.tblPhieuMuonTableAdapter();
            this.timKiemLabel = new System.Windows.Forms.Label();
            this.timKiem = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.crystalReportThuThu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mụcLụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thủThưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuMượnChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.làmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhieuMuonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysachDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThuThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblThuThuBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.report.Location = new System.Drawing.Point(786, 268);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(75, 46);
            this.report.TabIndex = 46;
            this.report.Text = "Báo cáo";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // dob
            // 
            this.dob.CustomFormat = "dd/MM/yyyy";
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob.Location = new System.Drawing.Point(469, 217);
            this.dob.MaxDate = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            this.dob.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 22);
            this.dob.TabIndex = 45;
            this.dob.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // nu
            // 
            this.nu.AutoSize = true;
            this.nu.Location = new System.Drawing.Point(897, 218);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(47, 21);
            this.nu.TabIndex = 44;
            this.nu.TabStop = true;
            this.nu.Text = "Nữ";
            this.nu.UseVisualStyleBackColor = true;
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Checked = true;
            this.nam.Location = new System.Drawing.Point(812, 218);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(58, 21);
            this.nam.TabIndex = 43;
            this.nam.TabStop = true;
            this.nam.Text = "Nam";
            this.nam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(720, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Ngày sinh";
            // 
            // diaChi
            // 
            this.diaChi.Location = new System.Drawing.Point(812, 165);
            this.diaChi.Name = "diaChi";
            this.diaChi.Size = new System.Drawing.Size(206, 22);
            this.diaChi.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(720, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Địa chỉ";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(469, 165);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(206, 22);
            this.email.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Email";
            // 
            // dataGridThuThu
            // 
            this.dataGridThuThu.AutoGenerateColumns = false;
            this.dataGridThuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridThuThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThuThuDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn});
            this.dataGridThuThu.DataSource = this.tblThuThuBindingSource1;
            this.dataGridThuThu.Location = new System.Drawing.Point(251, 341);
            this.dataGridThuThu.Name = "dataGridThuThu";
            this.dataGridThuThu.RowTemplate.Height = 24;
            this.dataGridThuThu.Size = new System.Drawing.Size(901, 216);
            this.dataGridThuThu.TabIndex = 36;
            this.dataGridThuThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblThuThu_CellClick);
            // 
            // maThuThuDataGridViewTextBoxColumn
            // 
            this.maThuThuDataGridViewTextBoxColumn.DataPropertyName = "maThuThu";
            this.maThuThuDataGridViewTextBoxColumn.HeaderText = "maThuThu";
            this.maThuThuDataGridViewTextBoxColumn.Name = "maThuThuDataGridViewTextBoxColumn";
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "hoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "hoTen";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "diaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "diaChi";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "gioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "gioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "ngaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "ngaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // tblThuThuBindingSource1
            // 
            this.tblThuThuBindingSource1.DataMember = "tblThuThu";
            this.tblThuThuBindingSource1.DataSource = this.quanlysachDataSet2;
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(430, 268);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 46);
            this.addition.TabIndex = 35;
            this.addition.Text = "Thêm";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(546, 268);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 46);
            this.delete.TabIndex = 34;
            this.delete.Text = "Xoá";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // hoTen
            // 
            this.hoTen.Location = new System.Drawing.Point(812, 115);
            this.hoTen.Name = "hoTen";
            this.hoTen.Size = new System.Drawing.Size(206, 22);
            this.hoTen.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Họ tên";
            // 
            // maThuThu
            // 
            this.maThuThu.Location = new System.Drawing.Point(469, 115);
            this.maThuThu.Name = "maThuThu";
            this.maThuThu.Size = new System.Drawing.Size(206, 22);
            this.maThuThu.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã thủ thư";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(671, 268);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 46);
            this.update.TabIndex = 29;
            this.update.Text = "Sửa";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(915, 268);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 46);
            this.cancel.TabIndex = 47;
            this.cancel.Text = "Huỷ";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // tblThuThuTableAdapter
            // 
            this.tblThuThuTableAdapter.ClearBeforeFill = true;
            // 
            // tblPhieuMuonTableAdapter
            // 
            this.tblPhieuMuonTableAdapter.ClearBeforeFill = true;
            // 
            // timKiemLabel
            // 
            this.timKiemLabel.AutoSize = true;
            this.timKiemLabel.Location = new System.Drawing.Point(484, 66);
            this.timKiemLabel.Name = "timKiemLabel";
            this.timKiemLabel.Size = new System.Drawing.Size(64, 17);
            this.timKiemLabel.TabIndex = 49;
            this.timKiemLabel.Text = "Tìm kiếm";
            // 
            // timKiem
            // 
            this.timKiem.Location = new System.Drawing.Point(569, 67);
            this.timKiem.Name = "timKiem";
            this.timKiem.Size = new System.Drawing.Size(201, 22);
            this.timKiem.TabIndex = 50;
            this.timKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(786, 57);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(84, 35);
            this.find.TabIndex = 51;
            this.find.Text = "Tìm kiếm";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(671, 573);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(118, 55);
            this.back.TabIndex = 52;
            this.back.Text = "Quay lại";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // crystalReportThuThu
            // 
            this.crystalReportThuThu.ActiveViewIndex = -1;
            this.crystalReportThuThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportThuThu.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportThuThu.Location = new System.Drawing.Point(63, 115);
            this.crystalReportThuThu.Name = "crystalReportThuThu";
            this.crystalReportThuThu.Size = new System.Drawing.Size(1214, 442);
            this.crystalReportThuThu.TabIndex = 48;
            this.crystalReportThuThu.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mụcLụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1305, 28);
            this.menuStrip1.TabIndex = 53;
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
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.sáchToolStripMenuItem.Text = "Sách";
            this.sáchToolStripMenuItem.Click += new System.EventHandler(this.sáchToolStripMenuItem_Click);
            // 
            // thểLoạiToolStripMenuItem
            // 
            this.thểLoạiToolStripMenuItem.Name = "thểLoạiToolStripMenuItem";
            this.thểLoạiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.thểLoạiToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.thểLoạiToolStripMenuItem.Text = "Thể loại";
            this.thểLoạiToolStripMenuItem.Click += new System.EventHandler(this.thểLoạiToolStripMenuItem_Click);
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.sinhViênToolStripMenuItem.Text = "Sinh viên";
            this.sinhViênToolStripMenuItem.Click += new System.EventHandler(this.sinhViênToolStripMenuItem_Click);
            // 
            // thủThưToolStripMenuItem
            // 
            this.thủThưToolStripMenuItem.Name = "thủThưToolStripMenuItem";
            this.thủThưToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.thủThưToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.thủThưToolStripMenuItem.Text = "Phiếu mượn";
            this.thủThưToolStripMenuItem.Click += new System.EventHandler(this.phiếuMượnToolStripMenuItem_Click);
            // 
            // phiếuMượnChiTiếtToolStripMenuItem
            // 
            this.phiếuMượnChiTiếtToolStripMenuItem.Name = "phiếuMượnChiTiếtToolStripMenuItem";
            this.phiếuMượnChiTiếtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.phiếuMượnChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.phiếuMượnChiTiếtToolStripMenuItem.Text = "Phiếu mượn chi tiết";
            this.phiếuMượnChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.phiếuMượnChiTiếtToolStripMenuItem_Click);
            // 
            // làmMớiToolStripMenuItem
            // 
            this.làmMớiToolStripMenuItem.Name = "làmMớiToolStripMenuItem";
            this.làmMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.làmMớiToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.làmMớiToolStripMenuItem.Text = "Làm mới";
            this.làmMớiToolStripMenuItem.Click += new System.EventHandler(this.làmMớiToolStripMenuItem_Click);
            // 
            // ThuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 640);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.crystalReportThuThu);
            this.Controls.Add(this.back);
            this.Controls.Add(this.find);
            this.Controls.Add(this.timKiem);
            this.Controls.Add(this.timKiemLabel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.report);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.nu);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.diaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridThuThu);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.hoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maThuThu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Name = "ThuThu";
            this.Text = "ThuThu";
            ((System.ComponentModel.ISupportInitialize)(this.tblPhieuMuonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysachDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThuThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblThuThuBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button report;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.RadioButton nu;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox diaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridThuThu;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox hoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maThuThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button cancel;
        private quanlysachDataSet2 quanlysachDataSet2;
        private System.Windows.Forms.BindingSource tblThuThuBindingSource1;
        private quanlysachDataSet2TableAdapters.tblThuThuTableAdapter tblThuThuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuThuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblPhieuMuonBindingSource;
        private quanlysachDataSet2TableAdapters.tblPhieuMuonTableAdapter tblPhieuMuonTableAdapter;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportThuThu;
        private System.Windows.Forms.Label timKiemLabel;
        private System.Windows.Forms.TextBox timKiem;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mụcLụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thểLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thủThưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuMượnChiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem làmMớiToolStripMenuItem;
    }
}