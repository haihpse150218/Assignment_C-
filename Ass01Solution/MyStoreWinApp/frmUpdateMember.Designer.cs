namespace MyStoreWinApp
{
    partial class frmUpdateMember
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseUpdate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateCountry = new System.Windows.Forms.TextBox();
            this.txtUpdateCity = new System.Windows.Forms.TextBox();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.txtUpdateID = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseUpdate);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtUpdateCountry);
            this.panel1.Controls.Add(this.txtUpdateCity);
            this.panel1.Controls.Add(this.txtUpdatePassword);
            this.panel1.Controls.Add(this.txtUpdateEmail);
            this.panel1.Controls.Add(this.txtUpdateName);
            this.panel1.Controls.Add(this.txtUpdateID);
            this.panel1.Controls.Add(this.lbCountry);
            this.panel1.Controls.Add(this.lbCity);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbId);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 360);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCloseUpdate
            // 
            this.btnCloseUpdate.Location = new System.Drawing.Point(279, 308);
            this.btnCloseUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseUpdate.Name = "btnCloseUpdate";
            this.btnCloseUpdate.Size = new System.Drawing.Size(86, 31);
            this.btnCloseUpdate.TabIndex = 13;
            this.btnCloseUpdate.Text = "Close";
            this.btnCloseUpdate.UseVisualStyleBackColor = true;
            this.btnCloseUpdate.Click += new System.EventHandler(this.btnCloseUpdate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.Location = new System.Drawing.Point(118, 308);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 31);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateCountry
            // 
            this.txtUpdateCountry.Location = new System.Drawing.Point(118, 247);
            this.txtUpdateCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdateCountry.Name = "txtUpdateCountry";
            this.txtUpdateCountry.Size = new System.Drawing.Size(246, 27);
            this.txtUpdateCountry.TabIndex = 11;
            // 
            // txtUpdateCity
            // 
            this.txtUpdateCity.Location = new System.Drawing.Point(118, 204);
            this.txtUpdateCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdateCity.Name = "txtUpdateCity";
            this.txtUpdateCity.Size = new System.Drawing.Size(246, 27);
            this.txtUpdateCity.TabIndex = 10;
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.Location = new System.Drawing.Point(118, 160);
            this.txtUpdatePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.Size = new System.Drawing.Size(246, 27);
            this.txtUpdatePassword.TabIndex = 9;
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(118, 112);
            this.txtUpdateEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(246, 27);
            this.txtUpdateEmail.TabIndex = 8;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(118, 57);
            this.txtUpdateName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(246, 27);
            this.txtUpdateName.TabIndex = 7;
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.Location = new System.Drawing.Point(118, 9);
            this.txtUpdateID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.ReadOnly = true;
            this.txtUpdateID.Size = new System.Drawing.Size(246, 27);
            this.txtUpdateID.TabIndex = 6;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(23, 257);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 5;
            this.lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(23, 204);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 4;
            this.lbCity.Text = "City";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(23, 160);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(23, 112);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(23, 61);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(23, 13);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(24, 20);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "ID";
            // 
            // frmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 389);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUpdateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Member";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUpdateCountry;
        private System.Windows.Forms.TextBox txtUpdateCity;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.TextBox txtUpdateID;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btnCloseUpdate;
        private System.Windows.Forms.Button btnUpdate;
    }
}