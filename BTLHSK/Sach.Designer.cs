namespace BTLHSK
{
    partial class Sach
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maSach = new System.Windows.Forms.TextBox();
            this.tenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.soLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.dataGridSach = new System.Windows.Forms.DataGridView();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlysachDataSet2 = new BTLHSK.quanlysachDataSet2();
            this.report = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.theLoai = new System.Windows.Forms.ComboBox();
            this.tblSachTableAdapter = new BTLHSK.quanlysachDataSet2TableAdapters.tblSachTableAdapter();
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
            this.tempReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupInfor = new System.Windows.Forms.GroupBox();
            this.controlGroup = new System.Windows.Forms.GroupBox();
            this.danhSachGroup = new System.Windows.Forms.GroupBox();
            this.sachReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysachDataSet2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupInfor.SuspendLayout();
            this.controlGroup.SuspendLayout();
            this.danhSachGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ControlLight;
            this.update.Location = new System.Drawing.Point(61, 231);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(88, 46);
            this.update.TabIndex = 0;
            this.update.Text = "Sửa";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sách";
            // 
            // maSach
            // 
            this.maSach.Location = new System.Drawing.Point(135, 33);
            this.maSach.Name = "maSach";
            this.maSach.Size = new System.Drawing.Size(206, 22);
            this.maSach.TabIndex = 2;
            // 
            // tenSach
            // 
            this.tenSach.Location = new System.Drawing.Point(135, 85);
            this.tenSach.Name = "tenSach";
            this.tenSach.Size = new System.Drawing.Size(206, 22);
            this.tenSach.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên sách";
            // 
            // soLuong
            // 
            this.soLuong.Location = new System.Drawing.Point(456, 33);
            this.soLuong.Name = "soLuong";
            this.soLuong.Size = new System.Drawing.Size(206, 22);
            this.soLuong.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã loại sách";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.delete.Location = new System.Drawing.Point(61, 154);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(88, 46);
            this.delete.TabIndex = 11;
            this.delete.Text = "Xoá";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // addition
            // 
            this.addition.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addition.Location = new System.Drawing.Point(61, 71);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(88, 46);
            this.addition.TabIndex = 12;
            this.addition.Text = "Thêm";
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // dataGridSach
            // 
            this.dataGridSach.AutoGenerateColumns = false;
            this.dataGridSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSachDataGridViewTextBoxColumn,
            this.tenSachDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.theLoaiDataGridViewTextBoxColumn});
            this.dataGridSach.DataSource = this.tblSachBindingSource;
            this.dataGridSach.Location = new System.Drawing.Point(46, 35);
            this.dataGridSach.Name = "dataGridSach";
            this.dataGridSach.RowHeadersWidth = 51;
            this.dataGridSach.RowTemplate.Height = 24;
            this.dataGridSach.Size = new System.Drawing.Size(611, 325);
            this.dataGridSach.TabIndex = 17;
            this.dataGridSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblSach_CellClick);
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            this.maSachDataGridViewTextBoxColumn.DataPropertyName = "maSach";
            this.maSachDataGridViewTextBoxColumn.HeaderText = "maSach";
            this.maSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            this.maSachDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenSachDataGridViewTextBoxColumn
            // 
            this.tenSachDataGridViewTextBoxColumn.DataPropertyName = "tenSach";
            this.tenSachDataGridViewTextBoxColumn.HeaderText = "tenSach";
            this.tenSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSachDataGridViewTextBoxColumn.Name = "tenSachDataGridViewTextBoxColumn";
            this.tenSachDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "soLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "soLuong";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // theLoaiDataGridViewTextBoxColumn
            // 
            this.theLoaiDataGridViewTextBoxColumn.DataPropertyName = "theLoai";
            this.theLoaiDataGridViewTextBoxColumn.HeaderText = "theLoai";
            this.theLoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.theLoaiDataGridViewTextBoxColumn.Name = "theLoaiDataGridViewTextBoxColumn";
            this.theLoaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblSachBindingSource
            // 
            this.tblSachBindingSource.DataMember = "tblSach";
            this.tblSachBindingSource.DataSource = this.quanlysachDataSet2;
            // 
            // quanlysachDataSet2
            // 
            this.quanlysachDataSet2.DataSetName = "quanlysachDataSet2";
            this.quanlysachDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report
            // 
            this.report.BackColor = System.Drawing.SystemColors.ControlLight;
            this.report.Location = new System.Drawing.Point(61, 384);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(88, 49);
            this.report.TabIndex = 19;
            this.report.Text = "Báo cáo";
            this.report.UseVisualStyleBackColor = false;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancel.Location = new System.Drawing.Point(61, 306);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(88, 46);
            this.cancel.TabIndex = 20;
            this.cancel.Text = "Huỷ";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // theLoai
            // 
            this.theLoai.FormattingEnabled = true;
            this.theLoai.Location = new System.Drawing.Point(456, 83);
            this.theLoai.Name = "theLoai";
            this.theLoai.Size = new System.Drawing.Size(206, 24);
            this.theLoai.TabIndex = 21;
            // 
            // tblSachTableAdapter
            // 
            this.tblSachTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mụcLụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1314, 28);
            this.menuStrip1.TabIndex = 32;
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
            this.sáchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.sáchToolStripMenuItem.Text = "Phiếu mượn chi tiết";
            this.sáchToolStripMenuItem.Click += new System.EventHandler(this.PhiếuMượnChiTiếtToolStripMenuItem_Click);
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
            this.phiếuMượnChiTiếtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.phiếuMượnChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.phiếuMượnChiTiếtToolStripMenuItem.Text = "Phiếu mượn";
            this.phiếuMượnChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.phiếuMượnToolStripMenuItem_Click);
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
            this.back.Location = new System.Drawing.Point(564, 630);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(113, 56);
            this.back.TabIndex = 64;
            this.back.Text = "Quay lại";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(718, 49);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(84, 35);
            this.find.TabIndex = 63;
            this.find.Text = "Tìm kiếm";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // timKiem
            // 
            this.timKiem.Location = new System.Drawing.Point(501, 59);
            this.timKiem.Name = "timKiem";
            this.timKiem.Size = new System.Drawing.Size(201, 22);
            this.timKiem.TabIndex = 62;
            this.timKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // timKiemLabel
            // 
            this.timKiemLabel.AutoSize = true;
            this.timKiemLabel.Location = new System.Drawing.Point(416, 58);
            this.timKiemLabel.Name = "timKiemLabel";
            this.timKiemLabel.Size = new System.Drawing.Size(64, 17);
            this.timKiemLabel.TabIndex = 61;
            this.timKiemLabel.Text = "Tìm kiếm";
            // 
            // tempReport
            // 
            this.tempReport.ActiveViewIndex = -1;
            this.tempReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.tempReport.DisplayStatusBar = false;
            this.tempReport.DisplayToolbar = false;
            this.tempReport.Location = new System.Drawing.Point(953, 17);
            this.tempReport.Name = "tempReport";
            this.tempReport.Size = new System.Drawing.Size(128, 503);
            this.tempReport.TabIndex = 66;
            this.tempReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupInfor
            // 
            this.groupInfor.Controls.Add(this.theLoai);
            this.groupInfor.Controls.Add(this.tempReport);
            this.groupInfor.Controls.Add(this.label4);
            this.groupInfor.Controls.Add(this.soLuong);
            this.groupInfor.Controls.Add(this.label3);
            this.groupInfor.Controls.Add(this.tenSach);
            this.groupInfor.Controls.Add(this.label2);
            this.groupInfor.Controls.Add(this.maSach);
            this.groupInfor.Controls.Add(this.label1);
            this.groupInfor.Location = new System.Drawing.Point(201, 104);
            this.groupInfor.Name = "groupInfor";
            this.groupInfor.Size = new System.Drawing.Size(693, 126);
            this.groupInfor.TabIndex = 67;
            this.groupInfor.TabStop = false;
            this.groupInfor.Text = "Thông tin sách";
            // 
            // controlGroup
            // 
            this.controlGroup.Controls.Add(this.cancel);
            this.controlGroup.Controls.Add(this.addition);
            this.controlGroup.Controls.Add(this.delete);
            this.controlGroup.Controls.Add(this.update);
            this.controlGroup.Controls.Add(this.report);
            this.controlGroup.Location = new System.Drawing.Point(919, 104);
            this.controlGroup.Name = "controlGroup";
            this.controlGroup.Size = new System.Drawing.Size(200, 511);
            this.controlGroup.TabIndex = 68;
            this.controlGroup.TabStop = false;
            this.controlGroup.Text = "Tác vụ";
            // 
            // danhSachGroup
            // 
            this.danhSachGroup.Controls.Add(this.dataGridSach);
            this.danhSachGroup.Location = new System.Drawing.Point(201, 236);
            this.danhSachGroup.Name = "danhSachGroup";
            this.danhSachGroup.Size = new System.Drawing.Size(693, 379);
            this.danhSachGroup.TabIndex = 69;
            this.danhSachGroup.TabStop = false;
            this.danhSachGroup.Text = "Bảng danh sách";
            // 
            // sachReport
            // 
            this.sachReport.ActiveViewIndex = -1;
            this.sachReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sachReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.sachReport.DisplayStatusBar = false;
            this.sachReport.DisplayToolbar = false;
            this.sachReport.Location = new System.Drawing.Point(72, 104);
            this.sachReport.Name = "sachReport";
            this.sachReport.Size = new System.Drawing.Size(1163, 525);
            this.sachReport.TabIndex = 70;
            this.sachReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 698);
            this.Controls.Add(this.sachReport);
            this.Controls.Add(this.controlGroup);
            this.Controls.Add(this.danhSachGroup);
            this.Controls.Add(this.groupInfor);
            this.Controls.Add(this.back);
            this.Controls.Add(this.find);
            this.Controls.Add(this.timKiem);
            this.Controls.Add(this.timKiemLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Sach";
            this.Text = "Sách";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysachDataSet2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupInfor.ResumeLayout(false);
            this.groupInfor.PerformLayout();
            this.controlGroup.ResumeLayout(false);
            this.danhSachGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maSach;
        private System.Windows.Forms.TextBox tenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox soLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.DataGridView dataGridSach;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox theLoai;
        private quanlysachDataSet2 quanlysachDataSet2;
        private quanlysachDataSet2TableAdapters.tblSachTableAdapter tblSachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblSachBindingSource;
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
        private CrystalReport1 crystalReport11;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer tempReport;
        private System.Windows.Forms.GroupBox groupInfor;
        private System.Windows.Forms.GroupBox controlGroup;
        private System.Windows.Forms.GroupBox danhSachGroup;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer sachReport;
    }
}

