using RailwayReservationLibrary.DataAccess;
using RailwayReservationLibrary.Entities;
using RailwayReservationLibrary.Logic;
using System.Data;
using System.Data.SqlClient;

namespace RailwayReservationUI
{
    public partial class Dashboard : Form
    {
        EmployeeDataLogic employeeLogic = new EmployeeDataLogic();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string searchQuery = "Select Id,FirstName, LastName, CNIC, DateOfBirth, City, Email, ContactNumber, Designation, Department from Employees";

            pnlEmployee.Visible = false;
            txtSearchText.Enabled = false;
            btnSave.Enabled = false;
            lblResetForm.Enabled = false;

            FillGridViewWithEmployeeData(searchQuery);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pnlEmployee.Visible = true;
            pnllEmployeeToolbar.Visible = true;
            pnlEmployeeForm.Enabled = false;
        }

        private void btnEmployeeClose_Click(object sender, EventArgs e)
        {
            pnlEmployeeFormMain.Visible = false;
            pnlEmployeeGridViewAndSearch.Visible = false;
            pnllEmployeeToolbar.Visible = false;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            txtDateOfBirth.Text = dateTimePicker.Value.ToString("dd-MM-yyyy");
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            txtGender.Text = "Male";
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            txtGender.Text = "Female";
        }

        private void chkbSetPassword_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkbSetPassword.Checked)
            {
                txtPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
                txtPassword.Focus();
            }
            else
            {
                txtPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;
            }
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            pnlEmployeeFormMain.Visible = true;
            pnlEmployeeGridViewAndSearch.Visible = true;
            pnllEmployeeToolbar.Visible = true;
            pnlEmployeeForm.Enabled = true;
            btnSave.Enabled = true;
            lblResetForm.Enabled = true;
            txtFirstName.Focus();
        }

        private void lblResetForm_Click(object sender, EventArgs e)
        {
            ResetFormFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Save the new employee in the database
                if (btnSave.Text == "Save Employee Data")
                {
                    Employee emp = new Employee
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        CNIC = txtCNIC.Text,
                        DOB = DateTime.Parse(txtDateOfBirth.Text),
                        Gender = txtGender.Text,
                        Address = txtAddress.Text,
                        PostalCode = txtPostalCode.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text,
                        Email = txtEmail.Text,
                        Contact = txtContactNumbers.Text,
                        Designation = Convert.ToString(cmbDesignation.SelectedItem),
                        Department = Convert.ToString(cmbDepartment.SelectedItem),
                        Password = txtPassword.Text
                    };

                    int result = employeeLogic.CreateEmployee(emp);

                    if (result > 0)
                    {
                        MessageBox.Show("Data Saved Successfully");
                        ResetFormFields();
                    }
                    else
                    {
                        MessageBox.Show("Problem in saving data");
                    }
                }

                //update the existing employee details
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employee Form: Problem in saving data \n" + ex.Message);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string searchQuery = "Select Id,FirstName, LastName, CNIC, DateOfBirth, City, Email, ContactNumber, Designation, Department from Employees Where CNIC = @CNIC";
            FillGridViewWithEmployeeData(searchQuery, "CNIC", txtSearchText.Text);
        }

        private void btnEmployeeSearch_Click(object sender, EventArgs e)
        {
            txtSearchText.Enabled = true;
            txtSearchText.Focus();
        }

        private void dataGridViewEmployee_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count > 0)
            {
                pnlEmployeeFormMain.Enabled = true;
                pnlEmployeeForm.Enabled = true;
                btnSave.Enabled = true;
                lblResetForm.Enabled = true;

                btnSave.Text = "Edit Employee Data";

                txtFirstName.Text = dataGridViewEmployee.SelectedRows[0].Cells[1].Value.ToString();
                txtLastName.Text = dataGridViewEmployee.SelectedRows[0].Cells[2].Value.ToString();
                txtCNIC.Text = dataGridViewEmployee.SelectedRows[0].Cells[3].Value.ToString();
            }
        }


        //Private method to reset the employee data form.
        private void ResetFormFields()
        {
            txtAddress.Text = "";
            txtCity.Text = "";
            txtCNIC.Text = "";
            txtConfirmPassword.Text = "";
            txtContactNumbers.Text = "";
            txtCountry.Text = "";
            txtDateOfBirth.Text = "";
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtGender.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            txtPostalCode.Text = "";
            chkbSetPassword.Checked = false;
            cmbDepartment.SelectedIndex = 0;
            cmbDesignation.SelectedIndex = 0;
        }

        //Private method fill the GridView with the employees data
        private void FillGridViewWithEmployeeData(string sqlQuery)
        {
            try
            {
                using (SqlConnection connection = ApplicationDbContext.ConnectToDB())
                {
                    using (DataTable dataTable = new DataTable("Employees"))
                    {
                        using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                        {
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                            dataAdapter.Fill(dataTable);
                            dataGridViewEmployee.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem while loading data in the GridView\n" + ex.Message);
            }

        }

        private void FillGridViewWithEmployeeData(string sqlQuery, string parameterName, object value)
        {
            try
            {
                using (SqlConnection connection = ApplicationDbContext.ConnectToDB())
                {
                    using (DataTable dataTable = new DataTable("Employees"))
                    {
                        using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                        {
                            cmd.Parameters.AddWithValue(parameterName, value);
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                            dataAdapter.Fill(dataTable);
                            dataGridViewEmployee.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem while loading searched data in the GridView\n" + ex.Message);
            }

        }

        private void dataGridViewEmployee_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        
    }
}