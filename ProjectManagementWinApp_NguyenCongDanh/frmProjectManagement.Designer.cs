namespace ProjectManagementWinApp_NguyenCongDanh
{
    partial class frmProjectManagement
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
            lbProjectID = new System.Windows.Forms.Label();
            lbEstimatedStartDate = new System.Windows.Forms.Label();
            lbProjectName = new System.Windows.Forms.Label();
            lbEstimatedEndDate = new System.Windows.Forms.Label();
            lbProjectDescription = new System.Windows.Forms.Label();
            lbProjectAddress = new System.Windows.Forms.Label();
            lbProjectCity = new System.Windows.Forms.Label();
            txtProjectID = new System.Windows.Forms.TextBox();
            txtProjectName = new System.Windows.Forms.TextBox();
            txtEstimatedStartDate = new System.Windows.Forms.MaskedTextBox();
            txtEstimatedEndDate = new System.Windows.Forms.MaskedTextBox();
            txtProjectDescription = new System.Windows.Forms.TextBox();
            txtProjectAddress = new System.Windows.Forms.TextBox();
            txtProjectCity = new System.Windows.Forms.TextBox();
            dgvProjectList = new System.Windows.Forms.DataGridView();
            btRead = new System.Windows.Forms.Button();
            btUpdate = new System.Windows.Forms.Button();
            btDelete = new System.Windows.Forms.Button();
            btCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvProjectList).BeginInit();
            SuspendLayout();
            // 
            // lbProjectID
            // 
            lbProjectID.AutoSize = true;
            lbProjectID.Location = new System.Drawing.Point(59, 32);
            lbProjectID.Name = "lbProjectID";
            lbProjectID.Size = new System.Drawing.Size(70, 20);
            lbProjectID.TabIndex = 0;
            lbProjectID.Text = "ProjectID";
            // 
            // lbEstimatedStartDate
            // 
            lbEstimatedStartDate.AutoSize = true;
            lbEstimatedStartDate.Location = new System.Drawing.Point(59, 118);
            lbEstimatedStartDate.Name = "lbEstimatedStartDate";
            lbEstimatedStartDate.Size = new System.Drawing.Size(138, 20);
            lbEstimatedStartDate.TabIndex = 1;
            lbEstimatedStartDate.Text = "EstimatedStartDate";
            // 
            // lbProjectName
            // 
            lbProjectName.AutoSize = true;
            lbProjectName.Location = new System.Drawing.Point(59, 73);
            lbProjectName.Name = "lbProjectName";
            lbProjectName.Size = new System.Drawing.Size(95, 20);
            lbProjectName.TabIndex = 2;
            lbProjectName.Text = "ProjectName";
            // 
            // lbEstimatedEndDate
            // 
            lbEstimatedEndDate.AutoSize = true;
            lbEstimatedEndDate.Location = new System.Drawing.Point(59, 160);
            lbEstimatedEndDate.Name = "lbEstimatedEndDate";
            lbEstimatedEndDate.Size = new System.Drawing.Size(132, 20);
            lbEstimatedEndDate.TabIndex = 3;
            lbEstimatedEndDate.Text = "EstimatedEndDate";
            // 
            // lbProjectDescription
            // 
            lbProjectDescription.AutoSize = true;
            lbProjectDescription.Location = new System.Drawing.Point(512, 32);
            lbProjectDescription.Name = "lbProjectDescription";
            lbProjectDescription.Size = new System.Drawing.Size(131, 20);
            lbProjectDescription.TabIndex = 4;
            lbProjectDescription.Text = "ProjectDescription";
            // 
            // lbProjectAddress
            // 
            lbProjectAddress.AutoSize = true;
            lbProjectAddress.Location = new System.Drawing.Point(512, 73);
            lbProjectAddress.Name = "lbProjectAddress";
            lbProjectAddress.Size = new System.Drawing.Size(108, 20);
            lbProjectAddress.TabIndex = 5;
            lbProjectAddress.Text = "ProjectAddress";
            // 
            // lbProjectCity
            // 
            lbProjectCity.AutoSize = true;
            lbProjectCity.Location = new System.Drawing.Point(512, 118);
            lbProjectCity.Name = "lbProjectCity";
            lbProjectCity.Size = new System.Drawing.Size(80, 20);
            lbProjectCity.TabIndex = 6;
            lbProjectCity.Text = "ProjectCity";
            // 
            // txtProjectID
            // 
            txtProjectID.Location = new System.Drawing.Point(218, 29);
            txtProjectID.Name = "txtProjectID";
            txtProjectID.Size = new System.Drawing.Size(234, 27);
            txtProjectID.TabIndex = 7;
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new System.Drawing.Point(218, 70);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new System.Drawing.Size(234, 27);
            txtProjectName.TabIndex = 8;
            // 
            // txtEstimatedStartDate
            // 
            txtEstimatedStartDate.Location = new System.Drawing.Point(218, 115);
            txtEstimatedStartDate.Mask = "00/00/0000";
            txtEstimatedStartDate.Name = "txtEstimatedStartDate";
            txtEstimatedStartDate.Size = new System.Drawing.Size(234, 27);
            txtEstimatedStartDate.TabIndex = 9;
            txtEstimatedStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtEstimatedEndDate
            // 
            txtEstimatedEndDate.Location = new System.Drawing.Point(218, 157);
            txtEstimatedEndDate.Mask = "00/00/0000";
            txtEstimatedEndDate.Name = "txtEstimatedEndDate";
            txtEstimatedEndDate.Size = new System.Drawing.Size(234, 27);
            txtEstimatedEndDate.TabIndex = 10;
            txtEstimatedEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtProjectDescription
            // 
            txtProjectDescription.Location = new System.Drawing.Point(660, 29);
            txtProjectDescription.Name = "txtProjectDescription";
            txtProjectDescription.Size = new System.Drawing.Size(234, 27);
            txtProjectDescription.TabIndex = 11;
            // 
            // txtProjectAddress
            // 
            txtProjectAddress.Location = new System.Drawing.Point(660, 67);
            txtProjectAddress.Name = "txtProjectAddress";
            txtProjectAddress.Size = new System.Drawing.Size(234, 27);
            txtProjectAddress.TabIndex = 12;
            // 
            // txtProjectCity
            // 
            txtProjectCity.Location = new System.Drawing.Point(660, 112);
            txtProjectCity.Name = "txtProjectCity";
            txtProjectCity.Size = new System.Drawing.Size(234, 27);
            txtProjectCity.TabIndex = 13;
            // 
            // dgvProjectList
            // 
            dgvProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjectList.Location = new System.Drawing.Point(59, 226);
            dgvProjectList.Name = "dgvProjectList";
            dgvProjectList.ReadOnly = true;
            dgvProjectList.RowHeadersWidth = 51;
            dgvProjectList.RowTemplate.Height = 29;
            dgvProjectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProjectList.Size = new System.Drawing.Size(707, 212);
            dgvProjectList.TabIndex = 28;
            // 
            // btRead
            // 
            btRead.Location = new System.Drawing.Point(800, 226);
            btRead.Name = "btRead";
            btRead.Size = new System.Drawing.Size(94, 29);
            btRead.TabIndex = 15;
            btRead.Text = "Read";
            btRead.UseVisualStyleBackColor = true;
            btRead.Click += btRead_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new System.Drawing.Point(800, 409);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new System.Drawing.Size(94, 29);
            btUpdate.TabIndex = 16;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new System.Drawing.Point(800, 345);
            btDelete.Name = "btDelete";
            btDelete.Size = new System.Drawing.Size(94, 29);
            btDelete.TabIndex = 17;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btCreate
            // 
            btCreate.Location = new System.Drawing.Point(800, 285);
            btCreate.Name = "btCreate";
            btCreate.Size = new System.Drawing.Size(94, 29);
            btCreate.TabIndex = 18;
            btCreate.Text = "Create";
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // frmProjectManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Aqua;
            ClientSize = new System.Drawing.Size(965, 468);
            Controls.Add(btCreate);
            Controls.Add(btDelete);
            Controls.Add(btUpdate);
            Controls.Add(btRead);
            Controls.Add(dgvProjectList);
            Controls.Add(txtProjectCity);
            Controls.Add(txtProjectAddress);
            Controls.Add(txtProjectDescription);
            Controls.Add(txtEstimatedEndDate);
            Controls.Add(txtEstimatedStartDate);
            Controls.Add(txtProjectName);
            Controls.Add(txtProjectID);
            Controls.Add(lbProjectCity);
            Controls.Add(lbProjectAddress);
            Controls.Add(lbProjectDescription);
            Controls.Add(lbEstimatedEndDate);
            Controls.Add(lbProjectName);
            Controls.Add(lbEstimatedStartDate);
            Controls.Add(lbProjectID);
            Name = "frmProjectManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Project Management";
            ((System.ComponentModel.ISupportInitialize)dgvProjectList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbProjectID;
        private System.Windows.Forms.Label lbEstimatedStartDate;
        private System.Windows.Forms.Label lbProjectName;
        private System.Windows.Forms.Label lbEstimatedEndDate;
        private System.Windows.Forms.Label lbProjectDescription;
        private System.Windows.Forms.Label lbProjectAddress;
        private System.Windows.Forms.Label lbProjectCity;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.MaskedTextBox txtEstimatedStartDate;
        private System.Windows.Forms.MaskedTextBox txtEstimatedEndDate;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.TextBox txtProjectAddress;
        private System.Windows.Forms.TextBox txtProjectCity;
        private System.Windows.Forms.DataGridView dgvProjectList;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btCreate;
    }
}