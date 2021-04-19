using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTLHSK
{
    public partial class ThuThu : Form
    {
        public ThuThu()
        {
            InitializeComponent();
            ThuThu_Load();
            back.Visible = false;
            crystalReportThuThu.Visible = false;
            timKiemLabel.Visible = false;
            timKiem.Visible = false;
            find.Visible = false;
            delete.Enabled = false;
            update.Enabled = false;
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
            maThuThu.ResetText();
            hoTen.ResetText();
            diaChi.ResetText();
            dob.ResetText();
            email.ResetText();
            nam.Checked = true;
            addition.Enabled = true;
            delete.Enabled = false;
            update.Enabled = false;
            maThuThu.Enabled = true;
        }

        public Boolean check()
        {
         
            if (string.IsNullOrEmpty(maThuThu.Text) || string.IsNullOrEmpty(hoTen.Text)
                || string.IsNullOrEmpty(dob.Text) || string.IsNullOrEmpty(email.Text)
                || string.IsNullOrEmpty(diaChi.Text))
                return false;
            return true;
        }

        //event click
        private void back_Click(object sender, EventArgs e)
        {
            back.Visible = false;
            crystalReportThuThu.Visible = false;
            timKiemLabel.Visible = false;
            timKiem.Visible = false;
            find.Visible = false;
        }

        private void report_Click(object sender, EventArgs e)
        {
            back.Visible = true;
            crystalReportThuThu.Visible = true;
            timKiemLabel.Visible = true;
            timKiem.Visible = true;
            find.Visible = true;
            filterCrystalReport("");
            timKiem.Focus();
        }
        private void addition_Click(object sender, EventArgs e)
        {
            SqlConnection con = openSQL();
            string queryTrung = "select * from tblThuThu where maThuThu = '" + maThuThu.Text + "';";

            SqlCommand cmdTrung = new SqlCommand(queryTrung, con);
            SqlDataReader readerTrung = cmdTrung.ExecuteReader();
            if (readerTrung.HasRows)
            {
                const string message = "Mã thủ thư trùng!";
                const string caption = "Thủ thư";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
                maThuThu.Focus();
                con.Close();
            }
            else
            {
                readerTrung.Close();
                if (!check())
                {
                    const string message = "Vui lòng điền đầy đủ và đúng thông tin";
                    const string caption = "Thủ Thư";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    maThuThu.Focus();
                    con.Close();
                }
                else
                {
                    using (SqlCommand command = con.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "[dbo].[createThuThu]";
                        command.Parameters.AddWithValue("@maThuThu", maThuThu.Text);
                        command.Parameters.AddWithValue("@hoTen", hoTen.Text);
                        command.Parameters.AddWithValue("@diaChi", diaChi.Text);
                        command.Parameters.AddWithValue("@email", email.Text);
                        command.Parameters.AddWithValue("@ngaySinh", DateTime.ParseExact(dob.Text, "dd/MM/yyyy", null)); 
                        if (nam.Checked)
                            command.Parameters.AddWithValue("@gioiTinh", "Nam");
                        else
                            command.Parameters.AddWithValue("@gioiTinh", "Nữ");
                        command.ExecuteNonQuery();
                        const string message = "Thêm thành công";
                        const string caption = "Thủ thư";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    }
                    con.Close();
                    ThuThu_Load();
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
            const string captionEvent = "Thủ thư";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, messageEvent, captionEvent, buttons);
            if (result == DialogResult.Yes)
            {
                SqlConnection con = openSQL();
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[deleteThuThu]";
                    command.Parameters.AddWithValue("@maThuThu", maThuThu.Text);
                    command.ExecuteNonQuery();

                    const string message = "Xoá thành công";
                    const string caption = "Thủ thư";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }
                con.Close();
                ThuThu_Load();
                this.reset();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                const string message = "Vui lòng điền đầy đủ thông tin";
                const string caption = "Thủ Thư";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = openSQL();
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[updateThuThu]";
                    command.Parameters.AddWithValue("@maThuThu", maThuThu.Text);
                    command.Parameters.AddWithValue("@hoTen", hoTen.Text);
                    command.Parameters.AddWithValue("@email", email.Text);
                    command.Parameters.AddWithValue("@diaChi", diaChi.Text);
                    if (nam.Checked)
                        command.Parameters.AddWithValue("@gioiTinh", "Nam");
                    else
                        command.Parameters.AddWithValue("@gioiTinh", "Nữ");
                    command.Parameters.AddWithValue("@ngaySinh", DateTime.Parse(dob.Text));
                    command.ExecuteNonQuery();
                    const string message = "Cập nhật thành công";
                    const string caption = "Thủ thư";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }
                con.Close();
                ThuThu_Load();
                this.reset();
            }
        }

        private void tblThuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maThuThu.Enabled = false;
            delete.Enabled = true;
            update.Enabled = true;
            addition.Enabled = false;
            DataGridView temp = (DataGridView)sender;
            if (temp.CurrentRow == null)
                return;
            maThuThu.Text = dataGridThuThu.CurrentRow.Cells[0].Value.ToString();
            hoTen.Text = dataGridThuThu.CurrentRow.Cells[1].Value.ToString();
            email.Text = dataGridThuThu.CurrentRow.Cells[2].Value.ToString();
            diaChi.Text = dataGridThuThu.CurrentRow.Cells[3].Value.ToString();
            if (dataGridThuThu.CurrentRow.Cells[4].Value.ToString() == "Nam")
                nam.Checked = true;
            else
                nu.Checked = true;
            dob.Text = dataGridThuThu.CurrentRow.Cells[5].Value.ToString();
        }

        //griddata fill
        private void ThuThu_Load()
        {
            this.tblThuThuTableAdapter.Fill(this.quanlysachDataSet2.tblThuThu);
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
        private void find_Click(object sender, EventArgs e)
        {
            string parameter = "%" +timKiem.Text + "%";
            filterCrystalReport(parameter);
        }


        //mdi
        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            //sach.MdiParent = this;
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

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
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
            ThuThu_Load();
        }

        //report
        private void filterCrystalReport(string parameter)
        {
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load("C:\\Users\\dinhv\\Downloads\\BTLHSK\\BTLHSK\\thuThuReport.rpt");
            quanlysachDataSet2 ds = new quanlysachDataSet2();
            SqlConnection con = openSQL();
            SqlDataAdapter sda = new SqlDataAdapter("[dbo].[reportThuThu]", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@check", parameter);
            DataSet st = new DataSet();
            sda.Fill(st, "tblThuThu");
            rptDoc.SetDataSource(st);
            crystalReportThuThu.ReportSource = rptDoc;
        }
    }
}
