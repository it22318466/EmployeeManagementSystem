using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;

namespace EmployeeManagementSystem
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        //SqlConnection con2 = new SqlConnection(@"");
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5N12DBC\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True;TrustServerCertificate=True");

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string fName = txtFName.Text;
                string lName = txtLName.Text;
                dateTimePicker1DOB.Format = DateTimePickerFormat.Custom;
                dateTimePicker1DOB.CustomFormat = "dd/MMM/yyyy";
                string gender;
                if (radioButton1Male.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string address = txtAdd.Text;
                string email = txtEmail.Text;
                int mobile = Convert.ToInt32(txtMobile.Text);
                int hPhone = Convert.ToInt32(txtHPhone.Text);
                string deptName = txtDepName.Text;
                string designation = txtDesi.Text;
                string empType = txtEmpType.Text;

                string InsertQuery = " INSERT INTO Employee VALUES (" + comboBox1EmpNo.Text + ",'" + fName + "', '" + lName + "', '" + dateTimePicker1DOB.Text + "', '" + gender + "', '" + address + "', '" + email + "', '" + mobile + "', '" + hPhone + "', '" + deptName + "', '" + designation + "', '" + empType + "')";
                con.Open();
                SqlCommand InsertCommand = new SqlCommand(InsertQuery, con);
                InsertCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show(msg);
            }
            finally
            { con.Close(); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLName.Clear();
            txtAdd.Clear();
            txtDepName.Clear();
            txtDesi.Clear();
            txtEmail.Clear();
            txtEmpType.Clear();
            txtHPhone.Clear();
            txtMobile.Clear();
            radioButton1Male.Checked = false;
            radioButton2Female.Checked = false;
            dateTimePicker1DOB.Format = DateTimePickerFormat.Custom;
            dateTimePicker1DOB.CustomFormat = "dd/MMM/yyyy";
            DateTime today = DateTime.Today;
            dateTimePicker1DOB.Text = today.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string empNo = comboBox1EmpNo.Text;
                string fName = txtFName.Text;
                string lName = txtLName.Text;
                dateTimePicker1DOB.Format = DateTimePickerFormat.Custom;
                dateTimePicker1DOB.CustomFormat = "dd/MMM/yyyy";
                string gender;
                if (radioButton1Male.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string address = txtAdd.Text;
                string email = txtEmail.Text;
                int mobile = Convert.ToInt32(txtMobile.Text);
                int hPhone = Convert.ToInt32(txtHPhone.Text);
                string deptName = txtDepName.Text;
                string designation = txtDesi.Text;
                string empType = txtEmpType.Text;

                string UpdateQuery = " UPDATE Employee SET FirstName = '" + fName + "', LastName = '" + lName + "', DOB = '" + dateTimePicker1DOB.Text + "', Gender = '" + gender + "', Address = '" + address + "', Email = '" + email + "', Mobile = '" + mobile + "', HomePhone = '" + hPhone + "', DeptName = '" + deptName + "', Designation = '" + designation + "', EmpType = '" + empType + "' WHERE EmpNo = " + empNo + " ";
                con.Open();
                SqlCommand UpdateCommand = new SqlCommand(UpdateQuery, con);
                UpdateCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee Details Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show(msg);
            }
            finally
            { con.Close(); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string empNo = comboBox1EmpNo.Text;
                    string DeleteQuery = " DELETE FROM Employee WHERE EmpNo = " + empNo + " ";
                    con.Open();
                    SqlCommand DeleteCommand = new SqlCommand(DeleteQuery, con);
                    DeleteCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Employee Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { con.Close(); }
        }

        private void linkLabel1LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void linkLabel2Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure you want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            comboBox1EmpNo.Items.Clear();
            comboBox1EmpNo.Items.Add("New Register");

            const string selectQuery = "SELECT EmpNo FROM Employee";

            try
            {
                con.Open();
                using (var cmd = new SqlCommand(selectQuery, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Use the named column to be explicit and avoid index issues
                        comboBox1EmpNo.Items.Add(reader["EmpNo"]?.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }

            //con.Open();
            //string select_query = " SELECT * FROM Employee ";
            //SqlCommand cmd_select = new SqlCommand(select_query, con);
            //SqlDataReader reader = cmd_select.ExecuteReader();
            //comboBox1EmpNo.Items.Add("New Register");
            //while (reader.Read())
            //{
            //    comboBox1EmpNo.Items.Add(reader[0].ToString());
            //}
            //con.Close();
        }
    }
}
