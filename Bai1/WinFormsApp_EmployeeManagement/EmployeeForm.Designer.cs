
namespace WinFormsApp_EmployeeManagement
{
    partial class EmployeeForm
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
            LbEmployeeID = new System.Windows.Forms.Label();
            LbEmployeeName = new System.Windows.Forms.Label();
            LbYearOfBirth = new System.Windows.Forms.Label();
            LbDepartmentName = new System.Windows.Forms.Label();
            LbJobTitle = new System.Windows.Forms.Label();
            TxtEmployeeId = new System.Windows.Forms.TextBox();
            txtEmployeeName = new System.Windows.Forms.TextBox();
            TxtDepartmentName = new System.Windows.Forms.TextBox();
            CbbJobTitle = new System.Windows.Forms.ComboBox();
            BtnAction = new System.Windows.Forms.Button();
            BtnCancel = new System.Windows.Forms.Button();
            TxtYearOfBirth = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // LbEmployeeID
            // 
            LbEmployeeID.AutoSize = true;
            LbEmployeeID.Location = new System.Drawing.Point(163, 81);
            LbEmployeeID.Name = "LbEmployeeID";
            LbEmployeeID.Size = new System.Drawing.Size(124, 24);
            LbEmployeeID.TabIndex = 0;
            LbEmployeeID.Text = "Employee ID: ";
            // 
            // LbEmployeeName
            // 
            LbEmployeeName.AutoSize = true;
            LbEmployeeName.Location = new System.Drawing.Point(163, 150);
            LbEmployeeName.Name = "LbEmployeeName";
            LbEmployeeName.Size = new System.Drawing.Size(154, 24);
            LbEmployeeName.TabIndex = 1;
            LbEmployeeName.Text = "Employee name: ";
            // 
            // LbYearOfBirth
            // 
            LbYearOfBirth.AutoSize = true;
            LbYearOfBirth.Location = new System.Drawing.Point(163, 222);
            LbYearOfBirth.Name = "LbYearOfBirth";
            LbYearOfBirth.Size = new System.Drawing.Size(119, 24);
            LbYearOfBirth.TabIndex = 2;
            LbYearOfBirth.Text = "Year of Birth:";
            // 
            // LbDepartmentName
            // 
            LbDepartmentName.AutoSize = true;
            LbDepartmentName.Location = new System.Drawing.Point(163, 296);
            LbDepartmentName.Name = "LbDepartmentName";
            LbDepartmentName.Size = new System.Drawing.Size(170, 24);
            LbDepartmentName.TabIndex = 3;
            LbDepartmentName.Text = "Department Name:";
            // 
            // LbJobTitle
            // 
            LbJobTitle.AutoSize = true;
            LbJobTitle.Location = new System.Drawing.Point(163, 356);
            LbJobTitle.Name = "LbJobTitle";
            LbJobTitle.Size = new System.Drawing.Size(85, 24);
            LbJobTitle.TabIndex = 4;
            LbJobTitle.Text = "Job Title:";
            // 
            // TxtEmployeeId
            // 
            TxtEmployeeId.Location = new System.Drawing.Point(383, 73);
            TxtEmployeeId.Name = "TxtEmployeeId";
            TxtEmployeeId.Size = new System.Drawing.Size(319, 32);
            TxtEmployeeId.TabIndex = 5;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new System.Drawing.Point(383, 142);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new System.Drawing.Size(319, 32);
            txtEmployeeName.TabIndex = 6;
            // 
            // TxtDepartmentName
            // 
            TxtDepartmentName.Location = new System.Drawing.Point(383, 288);
            TxtDepartmentName.Name = "TxtDepartmentName";
            TxtDepartmentName.Size = new System.Drawing.Size(319, 32);
            TxtDepartmentName.TabIndex = 8;
            // 
            // CbbJobTitle
            // 
            CbbJobTitle.FormattingEnabled = true;
            CbbJobTitle.Location = new System.Drawing.Point(383, 348);
            CbbJobTitle.Name = "CbbJobTitle";
            CbbJobTitle.Size = new System.Drawing.Size(319, 32);
            CbbJobTitle.TabIndex = 9;
            // 
            // BtnAction
            // 
            BtnAction.Location = new System.Drawing.Point(578, 456);
            BtnAction.Name = "BtnAction";
            BtnAction.Size = new System.Drawing.Size(124, 45);
            BtnAction.TabIndex = 10;
            BtnAction.Text = "button1";
            BtnAction.UseVisualStyleBackColor = true;
            BtnAction.Click += BtnAction_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new System.Drawing.Point(322, 456);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new System.Drawing.Size(124, 45);
            BtnCancel.TabIndex = 11;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // TxtYearOfBirth
            // 
            TxtYearOfBirth.Location = new System.Drawing.Point(383, 214);
            TxtYearOfBirth.Name = "TxtYearOfBirth";
            TxtYearOfBirth.Size = new System.Drawing.Size(319, 32);
            TxtYearOfBirth.TabIndex = 7;
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1000, 540);
            Controls.Add(BtnCancel);
            Controls.Add(BtnAction);
            Controls.Add(CbbJobTitle);
            Controls.Add(TxtDepartmentName);
            Controls.Add(TxtYearOfBirth);
            Controls.Add(txtEmployeeName);
            Controls.Add(TxtEmployeeId);
            Controls.Add(LbJobTitle);
            Controls.Add(LbDepartmentName);
            Controls.Add(LbYearOfBirth);
            Controls.Add(LbEmployeeName);
            Controls.Add(LbEmployeeID);
            Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "FrmEmployee";
            Text = "FrmEmployee";
            Load += FrmEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label LbEmployeeID;
        private System.Windows.Forms.Label LbEmployeeName;
        private System.Windows.Forms.Label LbYearOfBirth;
        private System.Windows.Forms.Label LbDepartmentName;
        private System.Windows.Forms.Label LbJobTitle;
        private System.Windows.Forms.TextBox TxtEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox TxtDepartmentName;
        private System.Windows.Forms.ComboBox CbbJobTitle;
        private System.Windows.Forms.Button BtnAction;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtYearOfBirth;
    }
}