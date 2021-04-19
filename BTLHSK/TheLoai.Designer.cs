namespace BTLHSK
{
    partial class TheLoai
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
            this.maLoaiSach = new System.Windows.Forms.TextBox();
            this.tenLoaiSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.dataGridTheLoai = new System.Windows.Forms.DataGridView();
            this.maLoaiSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTheLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlysachDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlysachDataSet2 = new BTLHSK.quanlysachDataSet2();
            this.report = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.tblTheLoaiTableAdapter = new BTLHSK.quanlysachDataSet2TableAdapters.tblTheLoaiTableAdapter();
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
            this.crystalReportTheLoai = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.controlGroup = new System.Windows.Forms.GroupBox();
            this.inforGroup = new System.Windows.Forms.GroupBox();
            this.listGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTheLoaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysachDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysachDataSet2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.controlGroup.SuspendLayout();
            this.inforGroup.SuspendLayout();
            this.listGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(34, 140);
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
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã loại sách";
            // 
            // maLoaiSach
            // 
            this.maLoaiSach.Location = new System.Drawing.Point(121, 49);
            this.maLoaiSach.Name = "maLoaiSach";
            this.maLoaiSach.Size = new System.Drawing.Size(206, 22);
            this.maLoaiSach.TabIndex = 2;
            // 
            // tenLoaiSach
            // 
            this.tenLoaiSach.Location = new System.Drawing.Point(462, 49);
            this.tenLoaiSach.Name = "tenLoaiSach";
            this.tenLoaiSach.Size = new System.Drawing.Size(206, 22);
            this.tenLoaiSach.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên loại sách";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(34, 204);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 46);
            this.delete.TabIndex = 11;
            this.delete.Text = "Xoá";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(34, 68);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 46);
            this.addition.TabIndex = 12;
            this.addition.Text = "Thêm";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // dataGridTheLoai
            // 
            this.dataGridTheLoai.AutoGenerateColumns = false;
            this.dataGridTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiSachDataGridViewTextBoxColumn,
            this.tenLoaiSachDataGridViewTextBoxColumn});
            this.dataGridTheLoai.DataSource = this.tblTheLoaiBindingSource;
            this.dataGridTheLoai.Location = new System.Drawing.Point(106, 59);
            this.dataGridTheLoai.Name = "dataGridTheLoai";
            this.dataGridTheLoai.RowHeadersWidth = 51;
            this.dataGridTheLoai.RowTemplate.Height = 24;
            this.dataGridTheLoai.Size = new System.Drawing.Size(525, 206);
            this.dataGridTheLoai.TabIndex = 17;
            this.dataGridTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblTheLoai_CellClick);
            // 
            // maLoaiSachDataGridViewTextBoxColumn
            // 
            this.maLoaiSachDataGridViewTextBoxColumn.DataPropertyName = "maLoaiSach";
            this.maLoaiSachDataGridViewTextBoxColumn.HeaderText = "maLoaiSach";
            this.maLoaiSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLoaiSachDataGridViewTextBoxColumn.Name = "maLoaiSachDataGridViewTextBoxColumn";
            this.maLoaiSachDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenLoaiSachDataGridViewTextBoxColumn
            // 
            this.tenLoaiSachDataGridViewTextBoxColumn.DataPropertyName = "tenLoaiSach";
            this.tenLoaiSachDataGridViewTextBoxColumn.HeaderText = "tenLoaiSach";
            this.tenLoaiSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLoaiSachDataGridViewTextBoxColumn.Name = "tenLoaiSachDataGridViewTextBoxColumn";
            this.tenLoaiSachDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblTheLoaiBindingSource
            // 
            this.tblTheLoaiBindingSource.DataMember = "tblTheLoai";
            this.tblTheLoaiBindingSource.DataSource = this.quanlysachDataSet2BindingSource;
            // 
            // quanlysachDataSet2BindingSource
            // 
            this.quanlysachDataSet2BindingSource.DataSource = this.quanlysachDataSet2;
            this.quanlysachDataSet2BindingSource.Position = 0;
            // 
            // quanlysachDataSet2
            // 
            this.quanlysachDataSet2.DataSetName = "quanlysachDataSet2";
            this.quanlysachDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(34, 343);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(75, 46);
            this.report.TabIndex = 19;
            this.report.Text = "Báo cáo";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(34, 272);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 46);
            this.cancel.TabIndex = 21;
            this.cancel.Text = "Huỷ";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // tblTheLoaiTableAdapter
            // 
            this.tblTheLoaiTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mụcLụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 28);
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
            this.thểLoạiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.thểLoạiToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.thểLoạiToolStripMenuItem.Text = "Sinh viên";
            this.thểLoạiToolStripMenuItem.Click += new System.EventHandler(this.sinhViênToolStripMenuItem_Click);
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
            this.back.Location = new System.Drawing.Point(513, 592);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(112, 54);
            this.back.TabIndex = 60;
            this.back.Text = "Quay lại";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(708, 50);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(84, 35);
            this.find.TabIndex = 59;
            this.find.Text = "Tìm kiếm";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // timKiem
            // 
            this.timKiem.Location = new System.Drawing.Point(491, 60);
            this.timKiem.Name = "timKiem";
            this.timKiem.Size = new System.Drawing.Size(201, 22);
            this.timKiem.TabIndex = 58;
            this.timKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // timKiemLabel
            // 
            this.timKiemLabel.AutoSize = true;
            this.timKiemLabel.Location = new System.Drawing.Point(406, 59);
            this.timKiemLabel.Name = "timKiemLabel";
            this.timKiemLabel.Size = new System.Drawing.Size(64, 17);
            this.timKiemLabel.TabIndex = 57;
            this.timKiemLabel.Text = "Tìm kiếm";
            // 
            // crystalReportTheLoai
            // 
            this.crystalReportTheLoai.ActiveViewIndex = -1;
            this.crystalReportTheLoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportTheLoai.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportTheLoai.DisplayStatusBar = false;
            this.crystalReportTheLoai.DisplayToolbar = false;
            this.crystalReportTheLoai.Location = new System.Drawing.Point(60, 115);
            this.crystalReportTheLoai.Name = "crystalReportTheLoai";
            this.crystalReportTheLoai.Size = new System.Drawing.Size(1092, 452);
            this.crystalReportTheLoai.TabIndex = 61;
            this.crystalReportTheLoai.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // controlGroup
            // 
            this.controlGroup.Controls.Add(this.cancel);
            this.controlGroup.Controls.Add(this.report);
            this.controlGroup.Controls.Add(this.addition);
            this.controlGroup.Controls.Add(this.delete);
            this.controlGroup.Controls.Add(this.update);
            this.controlGroup.Location = new System.Drawing.Point(884, 141);
            this.controlGroup.Name = "controlGroup";
            this.controlGroup.Size = new System.Drawing.Size(140, 417);
            this.controlGroup.TabIndex = 62;
            this.controlGroup.TabStop = false;
            this.controlGroup.Text = "Tác vụ";
            // 
            // inforGroup
            // 
            this.inforGroup.Controls.Add(this.tenLoaiSach);
            this.inforGroup.Controls.Add(this.label2);
            this.inforGroup.Controls.Add(this.maLoaiSach);
            this.inforGroup.Controls.Add(this.label1);
            this.inforGroup.Location = new System.Drawing.Point(162, 138);
            this.inforGroup.Name = "inforGroup";
            this.inforGroup.Size = new System.Drawing.Size(694, 96);
            this.inforGroup.TabIndex = 63;
            this.inforGroup.TabStop = false;
            this.inforGroup.Text = "Thông tin thể loại";
            // 
            // listGroup
            // 
            this.listGroup.Controls.Add(this.dataGridTheLoai);
            this.listGroup.Location = new System.Drawing.Point(161, 255);
            this.listGroup.Name = "listGroup";
            this.listGroup.Size = new System.Drawing.Size(694, 302);
            this.listGroup.TabIndex = 64;
            this.listGroup.TabStop = false;
            this.listGroup.Text = "Bảng danh sách";
            // 
            // TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.crystalReportTheLoai);
            this.Controls.Add(this.listGroup);
            this.Controls.Add(this.inforGroup);
            this.Controls.Add(this.controlGroup);
            this.Controls.Add(this.back);
            this.Controls.Add(this.find);
            this.Controls.Add(this.timKiem);
            this.Controls.Add(this.timKiemLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TheLoai";
            this.Text = "TheLoai";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTheLoaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysachDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysachDataSet2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.controlGroup.ResumeLayout(false);
            this.inforGroup.ResumeLayout(false);
            this.inforGroup.PerformLayout();
            this.listGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maLoaiSach;
        private System.Windows.Forms.TextBox tenLoaiSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.DataGridView dataGridTheLoai;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.BindingSource quanlysachDataSet2BindingSource;
        private quanlysachDataSet2 quanlysachDataSet2;
        private System.Windows.Forms.BindingSource tblTheLoaiBindingSource;
        private quanlysachDataSet2TableAdapters.tblTheLoaiTableAdapter tblTheLoaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiSachDataGridViewTextBoxColumn;
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
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportTheLoai;
        private System.Windows.Forms.GroupBox controlGroup;
        private System.Windows.Forms.GroupBox inforGroup;
        private System.Windows.Forms.GroupBox listGroup;
    }
}