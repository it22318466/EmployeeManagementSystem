using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5N12DBC\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True;TrustServerCertificate=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string uname = txtUName.Text;
                string pass = txtPWD.Text;

                string select_query = " SELECT * FROM Login WHERE Username = '" + uname + "' AND Password = '" + pass + "' ";
                SqlCommand cmd_login = new SqlCommand(select_query, con);
                SqlDataReader reader = cmd_login.ExecuteReader();
                if (reader.HasRows)
                {
                    frmMainMenu mm = new frmMainMenu();
                    mm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Invalid Credentials!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { con.Close(); }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUName.Clear();
            txtPWD.Clear();
        }
    }
}
