using FluentValidation.Results;
using MyCrmManager.Domain;
using MyCrmManager.Persistence;
using MyCrmManager.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCrmManager.WinFormUI
{
    public partial class FrmEmployeeRegister : Form
    {
        BindingList<string> errors = new BindingList<string>();
        public FrmEmployeeRegister()
        {
            InitializeComponent();
        }

        private void FrmEmployeeRegister_Load(object sender, EventArgs e)
        {
            GetUpdatedData();
            SetMyCustomDtFormat();
            grpError.Visible=btnEdit.Enabled=btnDelete.Enabled = false;
            lstError.DataSource = errors;
        }
        public void SetMyCustomDtFormat()
        {
            // Set the Format type and the CustomFormat string.
            dtBirthdate.Format = DateTimePickerFormat.Custom;
            dtBirthdate.CustomFormat = "dd/MM/yyyy";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            errors.Clear();
            grpError.Visible = false;
            DialogResult dr = MessageBox.Show("Are you sure you want to add the employee?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                RegisterEmployee();
            }
        }

        private void Clear()
        {
            foreach (var item in grpEmployee.Controls.OfType<TextBox>())
            {
                item.Text = string.Empty;
            }
            dtBirthdate.Value = DateTime.Today;
            mstPhone.Text = mstNationalId.Text = string.Empty;
            btnEdit.Enabled = btnDelete.Enabled = false;
            btnCreate.Enabled = true;
        }

        private ValidationResult CheckValidation(Employee emp)
        {
            EmployeeValidator validator = new EmployeeValidator();
            ValidationResult results = validator.Validate(emp);
            return results;
        }
        private void RegisterEmployee()
        {
            Employee emp = new Employee()
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Birthdate = dtBirthdate.Value,
                FirstName = txtFirstName.Text,
                Lastname = txtLastName.Text,
                IsActive = true,
                CreatedDate = DateTime.Now,
                NationalId = mstNationalId.Text,
                PhoneNumber = mstPhone.Text,
                CreatedBy = 1,
            };

            ValidationResult vr = CheckValidation(emp);

            if (vr.IsValid)
            {
                using (var unitOfWork = new UnitOfWork(new CrmContext()))
                {
                    unitOfWork.Employees.Add(emp);
                    int isSuccess = unitOfWork.Complete();
                    if (isSuccess > 0) 
                    {
                        MessageBox.Show("Employee has been successfully registered!");
                        Clear();
                        GetUpdatedData();
                    }
                    else
                    {
                        MessageBox.Show("Employee hasn't been registered!");
                    }
                }
            }
            else
            {
                grpError.Visible = true;
                foreach (ValidationFailure failure in vr.Errors)
                {
                    errors.Add(($"{ failure.PropertyName }: { failure.ErrorMessage}"));
                }
            }
        }
        private void UpdateEmployee()
        {
            int id = (int)btnEdit.Tag;
            using (var unitOfWork = new UnitOfWork(new CrmContext()))
            {
                Employee emp = unitOfWork.Employees.Find(e => e.Id == id).SingleOrDefault();
                emp.Email = txtEmail.Text;
                emp.Password = txtPassword.Text;
                emp.Birthdate = dtBirthdate.Value;
                emp.FirstName = txtFirstName.Text;
                emp.Lastname = txtLastName.Text;
                emp.IsActive = true;
                emp.NationalId = mstNationalId.Text;
                emp.PhoneNumber = mstPhone.Text;
                emp.ModifiedBy = 1;
                emp.ModifiedDate = DateTime.Now;

                ValidationResult vr = CheckValidation(emp);

                if (vr.IsValid)
                {
                    int isSuccess = unitOfWork.Complete();
                    if (isSuccess > 0)
                    {
                        MessageBox.Show("Employee has been successfully updated!");
                        GetUpdatedData();
                    }
                    else
                    {
                        MessageBox.Show("Employee hasn't been updated!");
                    }
                }
                else
                {
                    grpError.Visible = true;
                    foreach (ValidationFailure failure in vr.Errors)
                    {
                        errors.Add(($"{ failure.PropertyName }: { failure.ErrorMessage}"));
                    }
                }

            }
        }
        
        private void GetUpdatedData()
        {
            lstEmployee.Items.Clear();
            using (var unitOfWork = new UnitOfWork(new CrmContext()))
            {
                List<Employee> employees = unitOfWork.Employees.GetAll().ToList();
                if (employees!=null)
                {
                    foreach (var emp in employees)
                    {
                        lstEmployee.Items.Add(emp);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            errors.Clear();
            grpError.Visible = false;
            DialogResult dr = MessageBox.Show("Are you sure you want to edit selected employee?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                UpdateEmployee();
                Clear();
            }
        }

        private void lstEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmployee.SelectedItem == null)
            {
                btnDelete.Enabled = btnEdit.Enabled = false;
                btnCreate.Enabled = true;
            }
            else
            {
                btnCreate.Enabled = false;
                btnDelete.Enabled = btnEdit.Enabled = true;
                Employee selectedEmployee = lstEmployee.SelectedItem as Employee;
                txtEmail.Text = selectedEmployee.Email;
                txtPassword.Text = selectedEmployee.Password;
                txtFirstName.Text = selectedEmployee.FirstName;
                txtLastName.Text = selectedEmployee.Lastname;
                dtBirthdate.Value = selectedEmployee.Birthdate;
                mstPhone.Text = selectedEmployee.PhoneNumber;
                mstNationalId.Text = selectedEmployee.NationalId;

                btnEdit.Tag = btnDelete.Tag = selectedEmployee.Id;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            errors.Clear();
            grpError.Visible = false;
            DialogResult dr = MessageBox.Show("Are you sure you want to delete the employee?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                DeleteEmployee();
                Clear();
            }
        }

        private void DeleteEmployee()
        {
            int id = (int)btnDelete.Tag;
            using (var unitOfWork = new UnitOfWork(new CrmContext()))
            {
                Employee emp = unitOfWork.Employees.Find(e => e.Id == id).SingleOrDefault();
                unitOfWork.Employees.Remove(emp);
                int isSuccess = unitOfWork.Complete();
                if (isSuccess > 0)
                {
                    MessageBox.Show("Employee has been successfully deleted!");
                    GetUpdatedData();
                }
                else
                {
                    MessageBox.Show("Employee hasn't been delete!");
                }
            }
        }
    }
}
