using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLHSK
{
    static class Program
    {
        static void Main()
        {
	    // Chuc ban khong vao Tuan senpai :D
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PhieuMuonChiTiet());
        }
    }
}
