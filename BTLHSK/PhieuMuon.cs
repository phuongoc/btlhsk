using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTLHSK
{
    public partial class PhieuMuon : Form
    {
        string phieuMuonChiTiet = "";
        public PhieuMuon()
        {
            InitializeComponent();
            PhieuMuon_Load();
            //report
            back.Visible = false;
            crystalReportPhieuMuon.Visible = false;
            daTra.Visible = false;
            chuaTra.Visible = false;
            datagridview();
            //datagridview();
        }


        //report
        private void filterCrystalReport(int parameter)
        {
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load("C:\\Users\\dinhv\\Downloads\\BTLHSK\\BTLHSK\\phieuMuonReport.rpt");
            SqlConnection con = openSQL();
            SqlDataAdapter sda = new SqlDataAdapter("[dbo].[reportPhieuMuon]", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@check", parameter);
            DataSet st = new DataSet();
            sda.Fill(st, "tblPhieuMuon");
            rptDoc.SetDataSource(st);
            crystalReportPhieuMuon.ReportSource = rptDoc;
        }


        //event click

        private void back_Click(object sender, EventArgs e)
        {
            back.Visible = false;
            crystalReportPhieuMuon.Visible = false;
            daTra.Visible = false;
            chuaTra.Visible = false;
        }

        private void report_Click(object sender, EventArgs e)
        {
            back.Visible = true;
            crystalReportPhieuMuon.Visible = true;
            daTra.Visible = true;
            chuaTra.Visible = true;
            filterCrystalReport(0);
        }

        private void daTra_CheckedChanged(object sender, EventArgs e)
        {
            filterCrystalReport(1);
        }

        private void chuaTra_CheckedChanged(object sender, EventArgs e)
        {
            filterCrystalReport(2);
        }
        private void PhieuMuon_Load()
        {
            this.tblPhieuMuonTableAdapter.Fill(this.quanlysachDataSet2.tblPhieuMuon);
            //datagridview();
        }

        private void traSach_Click(object sender, EventArgs e)
        {
            if (phieuMuonChiTiet == "")
            {
                const string message = "Vui lòng chọn phiếu cần cập nhật!";
                const string caption = "Phiếu mượn";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = openSQL();
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "[dbo].[updatePhieuMuon]";
                command.Parameters.AddWithValue("@phieuMuonChiTiet", phieuMuonChiTiet);
                command.ExecuteNonQuery();

                const string message = "Trả sách thành công!";
                const string caption = "Phiếu mượn";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
                con.Close();
                PhieuMuon_Load();
            }
        }
        public SqlConnection openSQL()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }
        private void tblPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView temp = (DataGridView)sender;
            if (temp.CurrentRow == null)
                return;
            phieuMuonChiTiet = dataGridPhieuMuon.CurrentRow.Cells[0].Value.ToString();
        }

        private void datagridview()
        {
            SqlConnection connection = openSQL();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("[dbo].[changeName]", connection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridPhieuMuon.DataSource = dataTable;
            connection.Close();
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
            IsMdiContainer = true;
            phieuMuonChiTiet.Show();
            this.Hide();
        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuMuon_Load();
        }

      
    }
}
