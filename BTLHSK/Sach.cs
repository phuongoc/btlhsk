using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTLHSK
{
    public partial class Sach : Form
    {
        public Sach()
        {
            InitializeComponent();
            comboxTheLoai();
            Sach_Load();
            delete.Enabled = false;
            update.Enabled = false;

            //report
            back.Visible = false;
            timKiemLabel.Visible = false;
            timKiem.Visible = false;
            find.Visible = false;
            sachReport.Visible = false;
        }

        public void comboxTheLoai()
        {
            SqlConnection connection = openSQL();
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "[dbo].[selectTheLoai]";
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                        theLoai.Items.Add(reader[0].ToString());
            }
            connection.Close();
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
            maSach.ResetText();
            tenSach.ResetText();
            soLuong.ResetText();
            theLoai.ResetText();
            addition.Enabled = true;
            delete.Enabled = false;
            update.Enabled = false;
            maSach.Enabled = true;
        }

        
        private void soLuong_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public Boolean check()
        {

            if (string.IsNullOrEmpty(maSach.Text) || string.IsNullOrEmpty(soLuong.Text)
               || string.IsNullOrEmpty(tenSach.Text) || string.IsNullOrEmpty(theLoai.Text))
            {
                return false;
            }
            if (Int32.Parse(soLuong.Text) < 0)
            {
                soLuong.Focus();
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
            sachReport.Visible = false;
            timKiemLabel.Visible = false;
            timKiem.Visible = false;
            find.Visible = false;
            groupInfor.Visible = true;
            danhSachGroup.Visible = true;
            controlGroup.Visible = true;
            //findBtn.Visible = true;
        }

        private void report_Click(object sender, EventArgs e)
        {
            back.Visible = true;
            sachReport.Visible = true;
            timKiemLabel.Visible = true;
            timKiem.Visible = true;
            find.Visible = true;
            //findBtn.Visible = false;
            filterCrystalReport("");
            timKiem.Focus();
        }
        private void addition_Click(object sender, EventArgs e)
        {
            string masach = maSach.Text;
            //if (masach.IndexOf("@") == -1)
            //{
            //    const string message = "khong co @";
            //    const string caption = "Sách";
            //    MessageBox.Show(message, caption, MessageBoxButtons.OK);
            //}
            if (Int32.Parse(soLuong.Text) > 1)
            {
                const string message = "Số lượng không được lớn hơn 1";
                const string caption = "Sách";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = openSQL();
                string queryTrung = "select * from tblSach where maSach = '" + maSach.Text + "';";
                SqlCommand cmdTrung = new SqlCommand(queryTrung, con);
                SqlDataReader readerTrung = cmdTrung.ExecuteReader();

                if (readerTrung.HasRows)
                {
                    const string message = "Mã sách trùng!";
                    const string caption = "Sách";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    maSach.Focus();
                    con.Close();
                }
                else
                {
                    readerTrung.Close();
                    if (!check())
                    {
                        const string message = "Vui lòng điền đúng và đầy đủ thông tin";
                        const string caption = "Sách";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK);
                        maSach.Focus();
                        con.Close();
                    }
                    else
                    {
                        using (SqlCommand command = con.CreateCommand())
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.CommandText = "[dbo].[createSach]";
                            command.Parameters.AddWithValue("@maSach", maSach.Text);
                            command.Parameters.AddWithValue("@tenSach", tenSach.Text);
                            command.Parameters.AddWithValue("@soLuong", soLuong.Text);
                            command.Parameters.AddWithValue("@theLoai", theLoai.Text);
                            command.ExecuteNonQuery();
                            con.Close();
                            const string message = "Thêm thành công";
                            const string caption = "Sách";
                            MessageBox.Show(message, caption, MessageBoxButtons.OK);
                        }
                        Sach_Load();
                        this.reset();
                    }
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
            const string captionEvent = "Sách";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, messageEvent, captionEvent, buttons);
            if (result == DialogResult.Yes)
            {
                SqlConnection con = openSQL();
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[deleteSach]";
                    command.Parameters.AddWithValue("@maSach", maSach.Text);
                    command.ExecuteNonQuery();
                    const string message = "Xoá thành công";
                    const string caption = "Sách";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    con.Close();
                }
                Sach_Load();
                this.reset();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (!check() == true)
            {
                const string message = "Vui lòng điền đúng và đầy đủ thông tin";
                const string caption = "Sách";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = openSQL();
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[updateSach]";
                    command.Parameters.AddWithValue("@maSach", maSach.Text);
                    command.Parameters.AddWithValue("@tenSach", tenSach.Text);
                    command.Parameters.AddWithValue("@soLuong", soLuong.Text);
                    command.Parameters.AddWithValue("@theLoai", theLoai.Text);
                    command.ExecuteNonQuery();
                    const string message = "Cập nhật thành công";
                    const string caption = "Sách";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }
                con.Close();
                Sach_Load();
                this.reset();
            }
        }
        private void tblSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maSach.Enabled = false;
            delete.Enabled = true;
            update.Enabled = true;
            addition.Enabled = false;
            DataGridView temp = (DataGridView)sender;
            if (temp.CurrentRow == null)
                return;
            maSach.Text = dataGridSach.CurrentRow.Cells[0].Value.ToString();
            tenSach.Text = dataGridSach.CurrentRow.Cells[1].Value.ToString();
            soLuong.Text = dataGridSach.CurrentRow.Cells[2].Value.ToString();
            theLoai.Text = dataGridSach.CurrentRow.Cells[3].Value.ToString();
        }

        private void Sach_Load()
        {
            this.tblSachTableAdapter.Fill(this.quanlysachDataSet2.tblSach);
        }

        private void PhiếuMượnChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuMuonChiTiet phieuMuonChiTiet = new PhieuMuonChiTiet();
            phieuMuonChiTiet.Show();
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
            IsMdiContainer = true;
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
            Sach_Load();
        }

        //report
        private void filterCrystalReport(string parameter)
        {
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load("C:\\Users\\dinhv\\Downloads\\BTLHSK\\BTLHSK\\CrystalReport1.rpt");
            quanlysachDataSet2 ds = new quanlysachDataSet2();
            SqlConnection con = openSQL();
            SqlDataAdapter sda = new SqlDataAdapter("[dbo].[reportSach]", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@check", parameter);
            DataSet st = new DataSet();
            sda.Fill(st, "tblSach");
            rptDoc.SetDataSource(st);
            sachReport.ReportSource = rptDoc;
            groupInfor.Visible = false;
            danhSachGroup.Visible = false;
            controlGroup.Visible = false;
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = openSQL();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("[dbo].[findSach]", connection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + maSach.Text + "%");
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridSach.DataSource = dataTable;
        }
    }
}
