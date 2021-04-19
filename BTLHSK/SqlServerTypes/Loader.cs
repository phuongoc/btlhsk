using System;
using System.IO;
using System.Runtime.InteropServices;

namespace SqlServerTypes
{
    /// <summary>
    /// Utility methods related to CLR Types for SQL Server 
    /// </summary>
    public class Utilities
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr LoadLibrary(string libname);

        /// <summary>
        /// Loads the required native assemblies for the current architecture (x86 or x64)
        /// </summary>
        /// <param name="rootApplicationPath">
        /// Root path of the current application. Use Server.MapPath(".") for ASP.NET applications
        /// and AppDomain.CurrentDomain.BaseDirectory for desktop applications.
        /// </param>
        public static void LoadNativeAssemblies(string rootApplicationPath)
        {
            var nativeBinaryPath = IntPtr.Size > 4
                ? Path.Combine(rootApplicationPath, @"SqlServerTypes\x64\")
                : Path.Combine(rootApplicationPath, @"SqlServerTypes\x86\");

            LoadNativeAssembly(nativeBinaryPath, "msvcr120.dll");
            LoadNativeAssembly(nativeBinaryPath, "SqlServerSpatial140.dll");
        }

        private static void LoadNativeAssembly(string nativeBinaryPath, string assemblyName)
        {
            var path = Path.Combine(nativeBinaryPath, assemblyName);
            var ptr = LoadLibrary(path);
            if (ptr == IntPtr.Zero)
            {
                throw new Exception(string.Format(
                    "Error loading {0} (ErrorCode: {1})",
                    assemblyName,
                    Marshal.GetLastWin32Error()));
            }
        }
    }
}

//string constring = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
//using (SqlConnection con = new SqlConnection(constring))
//{
//    using (SqlCommand cmd = new SqlCommand("SELECT Name, City FROM Persons", con))
//    {
//        cmd.CommandType = CommandType.Text;
//        con.Open();
//        SqlDataReader dr = cmd.ExecuteReader();
//        while (dr.Read())
//        {
//            string name = dr["Name"].ToString();
//string city = dr["City"].ToString();
//Response.Write("Name: " + name);
//            Response.Write("City: " + city);
//        }
//        con.Close();
//    }
//}

//     if(serverName.Text.Length == 0)
//    {
//        // Initializes the variables to pass to the MessageBox.Show method.
//        string message = "You did not enter a server name. Cancel this operation?";
//string caption = "No Server Name Specified";
//MessageBoxButtons buttons = MessageBoxButtons.YesNo;
//DialogResult result;
//// Displays the MessageBox.
//result = MessageBox.Show(this, message, caption, buttons);
//        if(result == DialogResult.Yes)
//        {
//    // Closes the parent form.
//    this.Close();
//}
//}