using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTLHSK
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            check();
        }

        public SqlConnection openSQL()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        private void loginBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                check();
            }
        }

        public void check()
        {
            SqlConnection connect = openSQL();
            string queryThuThu = "select * from tblThuThu where maThuThu = '" + taiKhoan.Text + "'and email = '" + matKhau.Text + "';";

            SqlCommand cmdThuThu = new SqlCommand(queryThuThu, connect);
            SqlDataReader readerThuThu = cmdThuThu.ExecuteReader();

            if (readerThuThu.HasRows)
            {
                PhieuMuonChiTiet phieuMuonChiTiet = new PhieuMuonChiTiet();
                phieuMuonChiTiet.Show();
                this.Hide();
            }
            else
            {
                const string message = "Tài khoản hoặc mật khẩu sai!";
                const string caption = "Đăng nhập";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
                taiKhoan.Focus();
            }
            connect.Close();
        }
    }
}
