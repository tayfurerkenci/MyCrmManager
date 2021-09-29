
namespace MyCrmManager.WinFormUI
{
    partial class FrmEmployeeRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.mstPhone = new System.Windows.Forms.MaskedTextBox();
            this.mstNationalId = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstEmployee = new System.Windows.Forms.ListBox();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.grpManage = new System.Windows.Forms.GroupBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.grpError = new System.Windows.Forms.GroupBox();
            this.lstError = new System.Windows.Forms.ListBox();
            this.grpEmployee.SuspendLayout();
            this.grpManage.SuspendLayout();
            this.grpError.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birth of Date";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 24);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.Location = new System.Drawing.Point(131, 183);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(200, 20);
            this.dtBirthdate.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(131, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(131, 110);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(131, 150);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 20);
            this.txtLastName.TabIndex = 9;
            // 
            // mstPhone
            // 
            this.mstPhone.Location = new System.Drawing.Point(131, 222);
            this.mstPhone.Mask = "0000000000";
            this.mstPhone.Name = "mstPhone";
            this.mstPhone.Size = new System.Drawing.Size(200, 20);
            this.mstPhone.TabIndex = 10;
            this.mstPhone.ValidatingType = typeof(int);
            // 
            // mstNationalId
            // 
            this.mstNationalId.Location = new System.Drawing.Point(131, 268);
            this.mstNationalId.Mask = "00000000000";
            this.mstNationalId.Name = "mstNationalId";
            this.mstNationalId.Size = new System.Drawing.Size(200, 20);
            this.mstNationalId.TabIndex = 11;
            this.mstNationalId.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "National Id Number";
            // 
            // lstEmployee
            // 
            this.lstEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEmployee.FormattingEnabled = true;
            this.lstEmployee.Location = new System.Drawing.Point(3, 16);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(329, 471);
            this.lstEmployee.TabIndex = 14;
            this.lstEmployee.SelectedIndexChanged += new System.EventHandler(this.lstEmployee_SelectedIndexChanged);
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.btnDelete);
            this.grpEmployee.Controls.Add(this.btnCancel);
            this.grpEmployee.Controls.Add(this.btnEdit);
            this.grpEmployee.Controls.Add(this.btnCreate);
            this.grpEmployee.Controls.Add(this.label7);
            this.grpEmployee.Controls.Add(this.label1);
            this.grpEmployee.Controls.Add(this.label2);
            this.grpEmployee.Controls.Add(this.label6);
            this.grpEmployee.Controls.Add(this.label3);
            this.grpEmployee.Controls.Add(this.mstNationalId);
            this.grpEmployee.Controls.Add(this.label4);
            this.grpEmployee.Controls.Add(this.mstPhone);
            this.grpEmployee.Controls.Add(this.label5);
            this.grpEmployee.Controls.Add(this.txtLastName);
            this.grpEmployee.Controls.Add(this.txtEmail);
            this.grpEmployee.Controls.Add(this.txtFirstName);
            this.grpEmployee.Controls.Add(this.dtBirthdate);
            this.grpEmployee.Controls.Add(this.txtPassword);
            this.grpEmployee.Location = new System.Drawing.Point(12, 12);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(357, 351);
            this.grpEmployee.TabIndex = 15;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Register an Employee";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(84, 303);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(28, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(163, 303);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(244, 303);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(87, 23);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Save";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // grpManage
            // 
            this.grpManage.Controls.Add(this.lstEmployee);
            this.grpManage.Location = new System.Drawing.Point(384, 12);
            this.grpManage.Name = "grpManage";
            this.grpManage.Size = new System.Drawing.Size(335, 490);
            this.grpManage.TabIndex = 16;
            this.grpManage.TabStop = false;
            this.grpManage.Text = "Manage Employees";
            // 
            // grpError
            // 
            this.grpError.Controls.Add(this.lstError);
            this.grpError.Location = new System.Drawing.Point(12, 370);
            this.grpError.Name = "grpError";
            this.grpError.Size = new System.Drawing.Size(357, 132);
            this.grpError.TabIndex = 17;
            this.grpError.TabStop = false;
            this.grpError.Text = "Errors";
            // 
            // lstError
            // 
            this.lstError.FormattingEnabled = true;
            this.lstError.Location = new System.Drawing.Point(7, 20);
            this.lstError.Name = "lstError";
            this.lstError.Size = new System.Drawing.Size(344, 108);
            this.lstError.TabIndex = 0;
            // 
            // FrmEmployeeRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 514);
            this.Controls.Add(this.grpError);
            this.Controls.Add(this.grpManage);
            this.Controls.Add(this.grpEmployee);
            this.Name = "FrmEmployeeRegister";
            this.Text = "FrmEmployeeRegister";
            this.Load += new System.EventHandler(this.FrmEmployeeRegister_Load);
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            this.grpManage.ResumeLayout(false);
            this.grpError.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtBirthdate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.MaskedTextBox mstPhone;
        private System.Windows.Forms.MaskedTextBox mstNationalId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstEmployee;
        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox grpManage;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.GroupBox grpError;
        private System.Windows.Forms.ListBox lstError;
        private System.Windows.Forms.Button btnDelete;
    }
}