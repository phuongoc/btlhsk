using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTLHSK
{
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
            SinhVien_Load();
            delete.Enabled = false;
            update.Enabled = false;
            //report
            back.Visible = false;
            sinhVienReport.Visible = false;
            timKiemLabel.Visible = false;
            timKiem.Visible = false;
            find.Visible = false;
        }

        public SqlConnection openSQL()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        private void reset()
        {
            maSinhVien.ResetText();
            hoTen.ResetText();
            diaChi.ResetText();
            dob.ResetText();
            nam.Checked = true;
            lop.ResetText();

            addition.Enabled = true;
            delete.Enabled = false;
            update.Enabled = false;
            maSinhVien.Enabled = true;
        }

        public Boolean check()
        {
           
            if (string.IsNullOrEmpty(maSinhVien.Text) || string.IsNullOrEmpty(hoTen.Text)
                   || string.IsNullOrEmpty(diaChi.Text) || string.IsNullOrEmpty(dob.Text) || string.IsNullOrEmpty(lop.Text))
                return false;
            return true;
        }

        //event click
        private void addition_Click(object sender, EventArgs e)
        {
            SqlConnection con = openSQL();
            string queryTrung = "select * from tblSinhVien where maSinhVien = '" + maSinhVien.Text + "';";

            SqlCommand cmdTrung = new SqlCommand(queryTrung, con);
            SqlDataReader readerTrung = cmdTrung.ExecuteReader();
            if (readerTrung.HasRows)
            {
                const string message = "Mã sinh viên trùng!";
                const string caption = "Sinh viên";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
                maSinhVien.Focus();
                con.Close();
            }
            else
            {
                readerTrung.Close();
                if (!check())
                {
                    const string message = "Vui lòng điền đầy đủ thông tin";
                    const string caption = "Sinh viên";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    maSinhVien.Focus();
                    con.Close();
                }
                else
                {
                    using (SqlCommand command = con.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "[dbo].[createSinhVien]";
                        command.Parameters.AddWithValue("@maSinhVien", maSinhVien.Text);
                        command.Parameters.AddWithValue("@hoTen", hoTen.Text);
                        command.Parameters.AddWithValue("@diaChi", diaChi.Text);
                        command.Parameters.AddWithValue("@lop", lop.Text);
                        command.Parameters.AddWithValue("@ngaySinh", DateTime.ParseExact(dob.Text, "dd/MM/yyyy", null));
                        if (nam.Checked)
                            command.Parameters.AddWithValue("@gioiTinh", "Nam");
                        else
                            command.Parameters.AddWithValue("@gioiTinh", "Nữ");

                        command.ExecuteNonQuery();
                        const string message = "Thêm thành công";
                        const string caption = "Sinh viên";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    }
                    con.Close();
                    SinhVien_Load();
                    this.reset();
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.reset();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            const string messageEvent = "Bạn có muốn xóa ?";
            const string captionEvent = "Sinh viên";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, messageEvent, captionEvent, buttons);
            if (result == DialogResult.Yes)
            {
                SqlConnection con = openSQL();
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[deleteSinhVien]";
                    command.Parameters.AddWithValue("@maSinhVien", maSinhVien.Text);
                    command.ExecuteNonQuery();

                    const string message = "Xoá thành công";
                    const string caption = "Sinh viên";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }
                con.Close();
                SinhVien_Load();
                this.reset();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                const string message = "Vui lòng điền đầy đủ thông tin";
                const string caption = "Sinh viên";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else
            {

                SqlConnection con = openSQL();
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[updateSinhVien]";
                    command.Parameters.AddWithValue("@maSinhVien", maSinhVien.Text);
                    command.Parameters.AddWithValue("@hoTen", hoTen.Text);
                    command.Parameters.AddWithValue("@diaChi", diaChi.Text);
                    command.Parameters.AddWithValue("@lop", lop.Text);
                    command.Parameters.AddWithValue("@ngaySinh", DateTime.Parse(dob.Text));
                    if (nam.Checked)
                        command.Parameters.AddWithValue("@gioiTinh", "Nam");
                    else
                        command.Parameters.AddWithValue("@gioiTinh", "Nữ");
                    command.ExecuteNonQuery();

                    const string message = "Cập nhật thành công";
                    const string caption = "Sinh viên";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }
                con.Close();
                SinhVien_Load();
                this.reset();
            }

        }

        private void find_Click(object sender, EventArgs e)
        {
            string parameter = "%" + timKiem.Text + "%";
            filterCrystalReport(parameter);
        }
        private void back_Click(object sender, EventArgs e)
        {
            back.Visible = false;
            sinhVienReport.Visible = false;
            timKiemLabel.Visible = false;
            timKiem.Visible = false;
            find.Visible = false;
            inforGroup.Visible = true;
            controlGroup.Visible = true;
        }

        private void report_Click(object sender, EventArgs e)
        {
            back.Visible = true;
            sinhVienReport.Visible = true;
            timKiemLabel.Visible = true;
            timKiem.Visible = true;
            find.Visible = true;
            filterCrystalReport("");
            timKiem.Focus();
            inforGroup.Visible = false;
            controlGroup.Visible = false;

        }


        private void tblSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maSinhVien.Enabled = false;
            delete.Enabled = true;
            update.Enabled = true;
            addition.Enabled = false;
            DataGridView temp = (DataGridView)sender;
            if (temp.CurrentRow == null)
                return;
            maSinhVien.Text = dataGridSinhVien.CurrentRow.Cells[0].Value.ToString();
            hoTen.Text = dataGridSinhVien.CurrentRow.Cells[1].Value.ToString();
            lop.Text = dataGridSinhVien.CurrentRow.Cells[2].Value.ToString();
            diaChi.Text = dataGridSinhVien.CurrentRow.Cells[3].Value.ToString();
            if (dataGridSinhVien.CurrentRow.Cells[4].Value.ToString() == "Nam")
                nam.Checked = true;
            else
                nu.Checked = true;
            dob.Text = dataGridSinhVien.CurrentRow.Cells[5].Value.ToString();
        }

        //event enter
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                string parameter = "%" + timKiem.Text + "%";
                filterCrystalReport(parameter);
            }
        }
      
        //griddata fill
        private void SinhVien_Load()
        {
            this.tblSinhVienTableAdapter.Fill(this.quanlysachDataSet2.tblSinhVien);
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.Show();
            this.Hide();

        }


        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheLoai theLoai = new TheLoai();
            theLoai.Show();
            this.Hide();

        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuMuon phieuMuon = new PhieuMuon();
            phieuMuon.Show();
            this.Hide();

        }

        private void thủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThuThu thuThu = new ThuThu();
            thuThu.Show();
            this.Hide();

        }

        private void phiếuMượnChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuMuonChiTiet phieuMuonChiTiet = new PhieuMuonChiTiet();
            phieuMuonChiTiet.Show();
            this.Hide();

        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVien_Load();
        }

        private void filterCrystalReport(string parameter)
        {
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load("C:\\Users\\dinhv\\Downloads\\BTLHSK\\BTLHSK\\sinhVienReport.rpt");
            quanlysachDataSet2 ds = new quanlysachDataSet2();
            SqlConnection con = openSQL();
            SqlDataAdapter sda = new SqlDataAdapter("[dbo].[reportSinhVien]", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@check", parameter);
            DataSet st = new DataSet();
            sda.Fill(st, "tblSinhVien");
            rptDoc.SetDataSource(st);
            sinhVienReport.ReportSource = rptDoc;
        }
    }
}
