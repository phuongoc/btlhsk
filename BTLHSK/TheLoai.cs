using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTLHSK
{
    public partial class TheLoai : Form
    {
        public TheLoai()
        {
            InitializeComponent();
            TheLoai_Load();
            delete.Enabled = false;
            update.Enabled = false;
            //report
            back.Visible = false;
            crystalReportTheLoai.Visible = false;
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
            maLoaiSach.ResetText();
            tenLoaiSach.ResetText();
            addition.Enabled = true;
            delete.Enabled = false;
            update.Enabled = false;
            maLoaiSach.Enabled = true;
        }

        public Boolean check()
        {

            if (string.IsNullOrEmpty(maLoaiSach.Text) || string.IsNullOrEmpty(tenLoaiSach.Text))
                return false;
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
        private void finda_Click(object sender, EventArgs e)
        {
            String a = find.Text;
            String b = findb.Text;
            SqlConnection con = openSQL();
                    using (SqlCommand command = con.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "[dbo].[createTheLoai]";
                        command.Parameters.AddWithValue("@maLoaiSach", maLoaiSach.Text);
                        command.Parameters.AddWithValue("@tenLoaiSach", @tenLoaiSach.Text);
                        command.ExecuteNonQuery();
                        const string message = "Thêm thành công";
                        const string caption = "Thể loại";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK);
                        con.Close();
                        TheLoai_Load();
                    }
            this.tblTheLoaiTableAdapter.Fill(this.quanlysachDataSet2.tblTheLoai);
        }
        private void find_Click(object sender, EventArgs e)
        {
            string parameter = "%" + timKiem.Text + "%";
            filterCrystalReport(parameter);
        }
        private void back_Click(object sender, EventArgs e)
        {
            back.Visible = false;
            crystalReportTheLoai.Visible = false;
            timKiemLabel.Visible = false;
            timKiem.Visible = false;
            find.Visible = false;
        }

        private void report_Click(object sender, EventArgs e)
        {
            back.Visible = true;
            crystalReportTheLoai.Visible = true;
            timKiemLabel.Visible = true;
            timKiem.Visible = true;
            find.Visible = true;
            filterCrystalReport("");
            timKiem.Focus();
        }
        private void addition_Click(object sender, EventArgs e)
        {
            SqlConnection con = openSQL();
            string queryTrung = "select * from tblTheLoai where maLoaiSach = '" + maLoaiSach.Text + "';";

            SqlCommand cmdTrung = new SqlCommand(queryTrung, con);
            SqlDataReader readerTrung = cmdTrung.ExecuteReader();
            if (readerTrung.HasRows)
            {
                const string message = "Mã loại sách trùng!";
                const string caption = "Thể loai";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
                maLoaiSach.Focus();
                con.Close();
            }
            else
            {
                readerTrung.Close();
                if (!check())
                {
                    const string message = "Vui lòng điền đầy đủ thông tin";
                    const string caption = "Thể loại";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }
                else
                {
                    using (SqlCommand command = con.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "[dbo].[createTheLoai]";
                        command.Parameters.AddWithValue("@maLoaiSach", maLoaiSach.Text);
                        command.Parameters.AddWithValue("@tenLoaiSach", @tenLoaiSach.Text);
                        command.ExecuteNonQuery();
                        const string message = "Thêm thành công";
                        const string caption = "Thể loại";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK);
                        con.Close();
                        TheLoai_Load();
                    }
                    this.reset();
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            const string messageEvent = "Bạn có muốn xóa ?";
            const string captionEvent = "Thể loại";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, messageEvent, captionEvent, buttons);
            if (result == DialogResult.Yes)
            {
                SqlConnection con = openSQL();
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[deleteTheLoai]";
                    command.Parameters.AddWithValue("@maLoaiSach", maLoaiSach.Text);
                    command.ExecuteNonQuery();
                    const string message = "Xoá thành công";
                    const string caption = "Thể loại";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    con.Close();
                    TheLoai_Load();
                }
                this.reset();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                const string message = "Vui lòng điền đầy đủ thông tin";
                const string caption = "Thể loại";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = openSQL();
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[updateTheLoai]";
                    command.Parameters.AddWithValue("@maLoaiSach", maLoaiSach.Text);
                    command.Parameters.AddWithValue("@tenLoaiSach", tenLoaiSach.Text);
                    command.ExecuteNonQuery();

                    const string message = "Cập nhật thành công";
                    const string caption = "Thể loại";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }
                con.Close();
                TheLoai_Load();
                this.reset();
            }
        }
        private void tblTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maLoaiSach.Enabled = false;
            delete.Enabled = true;
            update.Enabled = true;
            addition.Enabled = false;
            DataGridView temp = (DataGridView)sender;
            if (temp.CurrentRow == null)
                return;
            maLoaiSach.Text = dataGridTheLoai.CurrentRow.Cells[0].Value.ToString();
            tenLoaiSach.Text = dataGridTheLoai.CurrentRow.Cells[1].Value.ToString();
        }

        private void TheLoai_Load()
        {
            this.tblTheLoaiTableAdapter.Fill(this.quanlysachDataSet2.tblTheLoai);
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.Show();
            this.Hide();

        }


        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuMuon phieuMuon = new PhieuMuon();
            phieuMuon.Show();
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

        private void phiếuMượnChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuMuonChiTiet phieuMuonChiTiet = new PhieuMuonChiTiet();
            phieuMuonChiTiet.Show();
            this.Hide();

        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheLoai_Load();

        }

        private void filterCrystalReport(string parameter)
        {
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load("C:\\Users\\dinhv\\Downloads\\BTLHSK\\BTLHSK\\theLoaiReport.rpt");
            quanlysachDataSet2 ds = new quanlysachDataSet2();
            SqlConnection con = openSQL();
            SqlDataAdapter sda = new SqlDataAdapter("[dbo].[reportTheLoai]", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@check", parameter);
            DataSet st = new DataSet();
            sda.Fill(st, "tblTheLoai");
            rptDoc.SetDataSource(st);
            crystalReportTheLoai.ReportSource = rptDoc;
        }

    }
}
