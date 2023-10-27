
namespace WinFormsApp_EmployeeManagement
{
    partial class ManagementForm
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
            PnControls = new System.Windows.Forms.Panel();
            BtnSearch = new System.Windows.Forms.Button();
            TxtSearchValue = new System.Windows.Forms.TextBox();
            BtnDelete = new System.Windows.Forms.Button();
            BtnUpdate = new System.Windows.Forms.Button();
            BtnInsert = new System.Windows.Forms.Button();
            DgvEmployeeList = new System.Windows.Forms.DataGridView();
            PnControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvEmployeeList).BeginInit();
            SuspendLayout();
            // 
            // PnControls
            // 
            PnControls.Controls.Add(BtnSearch);
            PnControls.Controls.Add(TxtSearchValue);
            PnControls.Controls.Add(BtnDelete);
            PnControls.Controls.Add(BtnUpdate);
            PnControls.Controls.Add(BtnInsert);
            PnControls.Dock = System.Windows.Forms.DockStyle.Top;
            PnControls.Location = new System.Drawing.Point(0, 0);
            PnControls.Name = "PnControls";
            PnControls.Size = new System.Drawing.Size(1000, 171);
            PnControls.TabIndex = 0;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new System.Drawing.Point(476, 12);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new System.Drawing.Size(94, 32);
            BtnSearch.TabIndex = 4;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // TxtSearchValue
            // 
            TxtSearchValue.Location = new System.Drawing.Point(101, 12);
            TxtSearchValue.Name = "TxtSearchValue";
            TxtSearchValue.Size = new System.Drawing.Size(342, 27);
            TxtSearchValue.TabIndex = 3;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new System.Drawing.Point(767, 87);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new System.Drawing.Size(127, 42);
            BtnDelete.TabIndex = 2;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new System.Drawing.Point(443, 87);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new System.Drawing.Size(127, 42);
            BtnUpdate.TabIndex = 1;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnInsert
            // 
            BtnInsert.Location = new System.Drawing.Point(101, 87);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new System.Drawing.Size(127, 42);
            BtnInsert.TabIndex = 0;
            BtnInsert.Text = "Insert";
            BtnInsert.UseVisualStyleBackColor = true;
            BtnInsert.Click += BtnInsert_Click;
            // 
            // DgvEmployeeList
            // 
            DgvEmployeeList.AllowUserToAddRows = false;
            DgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            DgvEmployeeList.Location = new System.Drawing.Point(0, 171);
            DgvEmployeeList.Name = "DgvEmployeeList";
            DgvEmployeeList.ReadOnly = true;
            DgvEmployeeList.RowHeadersWidth = 51;
            DgvEmployeeList.RowTemplate.Height = 29;
            DgvEmployeeList.Size = new System.Drawing.Size(1000, 369);
            DgvEmployeeList.TabIndex = 1;
            DgvEmployeeList.CellFormatting += DgvEmployeeList_CellFormatting;
            // 
            // ManagementForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1000, 540);
            Controls.Add(DgvEmployeeList);
            Controls.Add(PnControls);
            Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "ManagementForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Management";
            Load += FrmManagement_Load;
            PnControls.ResumeLayout(false);
            PnControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvEmployeeList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PnControls;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.DataGridView DgvEmployeeList;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearchValue;
    }
}