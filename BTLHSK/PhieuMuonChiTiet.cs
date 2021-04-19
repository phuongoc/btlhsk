using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTLHSK
{
    public partial class PhieuMuonChiTiet : Form
    {
        public PhieuMuonChiTiet()
        {
            InitializeComponent();
            PhieuMuonChiTiet_Load();
            comboBox("[dbo].[selectSach]", sach);
            comboBox("[dbo].[selectThuThu]", thuThu);
            comboBox("[dbo].[selectSinhVien]", sinhVien);
            delete.Enabled = false;
            update.Enabled = false;

            //report
            back.Visible = false;
            crystalReportPhieuMuonChiTiet.Visible = false;
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
            soPhieuMuon.ResetText();
            sach.ResetText();
            sinhVien.ResetText();
            thuThu.ResetText();
            ngayMuon.ResetText();
            soLuong.ResetText();

            addition.Enabled = true;
            delete.Enabled = false;
            update.Enabled = false;
            soPhieuMuon.Enabled = true;
        }

        public Boolean check()
        {
            SqlConnection connect = openSQL();
            string queryThuThu = "select * from tblThuThu where maThuThu = '" + thuThu.Text + "';";
            string querySach = "select * from tblSach where maSach = '" + sach.Text + "';";
            string querySinhVien = "select * from tblSinhVien where maSinhVien = '" + sinhVien.Text + "';";
            string querySoLuongSach = "select soLuong from tblSach where maSach = '" + sach.Text + "';";

            SqlCommand cmdThuThu = new SqlCommand(queryThuThu, connect);
            SqlCommand cmdSach = new SqlCommand(querySach, connect);
            SqlCommand cmdSinhVien = new SqlCommand(querySinhVien, connect);
            SqlCommand cmdSoLuongSach = new SqlCommand(querySoLuongSach, connect);
            SqlDataReader readerSoLuongSach = cmdSoLuongSach.ExecuteReader();


            if (readerSoLuongSach.HasRows)
            {
                while (readerSoLuongSach.Read())
                {
                    Int32 soLuongSach = (Int32)readerSoLuongSach["soLuong"];
                    if (Int32.Parse(soLuong.Text) > soLuongSach)
                    {
                        soLuong.Focus();
                        const string message = "Số lượng sách không đủ!";
                        const string caption = "Phiếu mượn chi tiết";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            readerSoLuongSach.Close();
            SqlDataReader readerThuThu = cmdThuThu.ExecuteReader();

            if (!readerThuThu.HasRows)
            {
                thuThu.Focus();
                return false;
            }
            readerThuThu.Close();
            SqlDataReader readerSach = cmdSach.ExecuteReader();
            if (!readerSach.HasRows)
            {
                sach.Focus();
                return false;
            }
            readerSach.Close();
            SqlDataReader readerSinhVien = cmdSinhVien.ExecuteReader();
            if (!readerSinhVien.HasRows)
            {
                sinhVien.Focus();
                return false;
            }
            readerSinhVien.Close();
            connect.Close();
            if (Int32.Parse(soLuong.Text) < 0)
            {
                soLuong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(soPhieuMuon.Text) || string.IsNullOrEmpty(sach.Text)
                || string.IsNullOrEmpty(sinhVien.Text) || string.IsNullOrEmpty(thuThu.Text) || string.IsNullOrEmpty(soLuong.Text))
            {
                return false;
            }
            return true;
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
        //event click

        private void find_Click(object sender, EventArgs e)
        {
            string parameter = "%" + timKiem.Text + "%";
            filterCrystalReport(parameter);
        }
        private void back_Click(object sender, EventArgs e)
        {
            back.Visible = false;
            crystalReportPhieuMuonChiTiet.Visible = false;
            timKiemLabel.Visible = false;
            timKiem.Visible = false;
            find.Visible = false;
            inforGroup.Visible = true;
            danhSachGroup.Visible = true;
        }

        private void report_Click(object sender, EventArgs e)
        {
            back.Visible = true;
            crystalReportPhieuMuonChiTiet.Visible = true;
            timKiemLabel.Visible = true;
            timKiem.Visible = true;
            find.Visible = true;
            filterCrystalReport("");
            timKiem.Focus();
            inforGroup.Visible = false;
            danhSachGroup.Visible = false;
            timKiemLabel.Visible = false;
            timKiem.Visible = false;
            find.Visible = false;

        }

        private void soLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '1' || soLuong.Text.Length > 0 || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' ||
                (e.KeyChar == '.' && (soLuong.Text.Length == 0 || soLuong.Text.IndexOf('.') != -1))))
            {
                e.Handled = true;
            }
        }
        private void addition_Click(object sender, EventArgs e)
        {
            SqlConnection con = openSQL();

            string queryTrung = "select * from tblPhieuMuonChiTiet where soPhieuMuon = '" + soPhieuMuon.Text + "';";
            SqlCommand cmdTrung = new SqlCommand(queryTrung, con);
            SqlDataReader readerTrung = cmdTrung.ExecuteReader();
            if (readerTrung.HasRows)
            {
                const string message = "Số phiếu mượn trùng!";
                const string caption = "Phiếu mượn chi tiết";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
                soPhieuMuon.Focus();
                con.Close();
            }
            else
            {
                readerTrung.Close();
                if (!check())
                {
                    const string message = "Vui lòng điền đúng và đầy đủ thông tin";
                    const string caption = "Phiếu mượn chi tiết";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }
                else
                {
                    using (SqlCommand command = con.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "[dbo].[createPhieuMuonChiTiet]";
                        command.Parameters.AddWithValue("@soPhieuMuon", soPhieuMuon.Text);
                        command.Parameters.AddWithValue("@sach", sach.Text);
                        command.Parameters.AddWithValue("@soLuong", soLuong.Text);
                        command.Parameters.AddWithValue("@thuThu", thuThu.Text);
                        command.Parameters.AddWithValue("@sinhVien", sinhVien.Text);
                        command.Parameters.AddWithValue("@ngayMuon", DateTime.ParseExact(ngayMuon.Text, "dd/MM/yyyy", null));
                        command.ExecuteNonQuery();
                        const string message = "Thêm thành công";
                        const string caption = "Phiếu mượn chi tiết";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK);
                        con.Close();
                        PhieuMuonChiTiet_Load();
                    }
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
            const string captionEvent = "Phiếu mượn chi tiết";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, messageEvent, captionEvent, buttons);
            if (result == DialogResult.Yes)
            {
                SqlConnection con = openSQL();
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[deletePhieuMuonChiTiet]";
                    command.Parameters.AddWithValue("@soPhieuMuon", soPhieuMuon.Text);
                    command.ExecuteNonQuery();

                    const string message = "Xoá thành công";
                    const string caption = "Phiếu mượn chi tiết";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    con.Close();
                    PhieuMuonChiTiet_Load();
                }
                this.reset();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                const string message = "Vui lòng điền đúng và đầy đủ thông tin";
                const string caption = "Phiếu mượn chi tiết";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = openSQL();
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[updatePhieuMuonChiTiet]";
                    command.Parameters.AddWithValue("@soPhieuMuon", soPhieuMuon.Text);
                    command.Parameters.AddWithValue("@sach", sach.Text);
                    command.Parameters.AddWithValue("@soLuong", soLuong.Text);
                    command.Parameters.AddWithValue("@thuThu", thuThu.Text);
                    command.Parameters.AddWithValue("@sinhVien", sinhVien.Text);
                    command.Parameters.AddWithValue("@ngayMuon", DateTime.Parse(ngayMuon.Text));

                    command.ExecuteNonQuery();

                    const string message = "Cập nhật thành công";
                    const string caption = "Phiếu mượn chi tiết ";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }
                PhieuMuonChiTiet_Load();
                con.Close();
                this.reset();
            }

        }
        private void tblSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            soPhieuMuon.Enabled = false;
            delete.Enabled = true;
            update.Enabled = true;
            addition.Enabled = false;
            DataGridView temp = (DataGridView)sender;
            if (temp.CurrentRow == null)
                return;
            soPhieuMuon.Text = dataGridPhieuChiTiet.CurrentRow.Cells[0].Value.ToString();
            sach.Text = dataGridPhieuChiTiet.CurrentRow.Cells[1].Value.ToString();
            sinhVien.Text = dataGridPhieuChiTiet.CurrentRow.Cells[2].Value.ToString();
            thuThu.Text = dataGridPhieuChiTiet.CurrentRow.Cells[3].Value.ToString();
            soLuong.Text = dataGridPhieuChiTiet.CurrentRow.Cells[4].Value.ToString();
            ngayMuon.Text = dataGridPhieuChiTiet.CurrentRow.Cells[5].Value.ToString();
        }

        private void PhieuMuonChiTiet_Load()
        {
            this.tblPhieuMuonChiTietTableAdapter.Fill(this.quanlysachDataSet2.tblPhieuMuonChiTiet);
        }

        public void comboBox(string s, ComboBox cb)
        {
            SqlConnection connection = openSQL();
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = s;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                        cb.Items.Add(reader[0].ToString());
            }
            connection.Close();
        }

        //private void soLuong_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' ||
        //        (e.KeyChar == '.' && (soLuong.Text.Length == 0 || soLuong.Text.IndexOf('.') != -1))))
        //    {
        //        e.Handled = true;
        //    }
        //}

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

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.Show();
            this.Hide();

        }

        private void thủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThuThu thuThu = new ThuThu();
            thuThu.Show();
            this.Hide();

        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuMuon phieuMuon = new PhieuMuon();
            phieuMuon.Show();
            this.Hide();

        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuMuonChiTiet_Load();
        }

        //report
        private void filterCrystalReport(string parameter)
        {
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load("C:\\Users\\dinhv\\Downloads\\BTLHSK\\BTLHSK\\phieuMuonChiTietReport.rpt");
            quanlysachDataSet2 ds = new quanlysachDataSet2();
            SqlConnection con = openSQL();
            SqlDataAdapter sda = new SqlDataAdapter("[dbo].[reportPhieuMuonChiTiet]", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@check", parameter);
            DataSet st = new DataSet();
            sda.Fill(st, "tblPhieuMuonChiTiet");
            rptDoc.SetDataSource(st);
            crystalReportPhieuMuonChiTiet.ReportSource = rptDoc;
        }

    }
}
