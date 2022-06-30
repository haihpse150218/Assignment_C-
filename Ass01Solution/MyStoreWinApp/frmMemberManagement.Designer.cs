namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            this.cbFilterByCity = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDataView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnRemoving = new System.Windows.Forms.Button();
            this.btnModifying = new System.Windows.Forms.Button();
            this.btnViewing = new System.Windows.Forms.Button();
            this.btnCreating = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.txtSearchById = new System.Windows.Forms.TextBox();
            this.lbFilterByCountry = new System.Windows.Forms.Label();
            this.lbFilterByCity = new System.Windows.Forms.Label();
            this.cbFilterByCountry = new System.Windows.Forms.ComboBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFilterByCity
            // 
            this.cbFilterByCity.DisplayMember = "Select City";
            this.cbFilterByCity.FormattingEnabled = true;
            this.cbFilterByCity.Location = new System.Drawing.Point(104, 6);
            this.cbFilterByCity.Name = "cbFilterByCity";
            this.cbFilterByCity.Size = new System.Drawing.Size(121, 23);
            this.cbFilterByCity.Sorted = true;
            this.cbFilterByCity.TabIndex = 0;
            this.cbFilterByCity.Text = "Select City";
            this.cbFilterByCity.SelectedValueChanged += new System.EventHandler(this.cbFilterByCity_SelectedValueChanged);
            this.cbFilterByCity.Click += new System.EventHandler(this.cbFilterByCity_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDataView);
            this.panel1.Location = new System.Drawing.Point(119, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 220);
            this.panel1.TabIndex = 2;
            // 
            // dgvDataView
            // 
            this.dgvDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataView.Location = new System.Drawing.Point(3, 3);
            this.dgvDataView.Name = "dgvDataView";
            this.dgvDataView.RowHeadersWidth = 51;
            this.dgvDataView.RowTemplate.Height = 25;
            this.dgvDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataView.Size = new System.Drawing.Size(545, 214);
            this.dgvDataView.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSort);
            this.panel2.Controls.Add(this.btnRemoving);
            this.panel2.Controls.Add(this.btnModifying);
            this.panel2.Controls.Add(this.btnViewing);
            this.panel2.Controls.Add(this.btnCreating);
            this.panel2.Location = new System.Drawing.Point(28, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 292);
            this.panel2.TabIndex = 3;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(3, 64);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 40);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sorting";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnRemoving
            // 
            this.btnRemoving.Location = new System.Drawing.Point(3, 238);
            this.btnRemoving.Name = "btnRemoving";
            this.btnRemoving.Size = new System.Drawing.Size(75, 40);
            this.btnRemoving.TabIndex = 3;
            this.btnRemoving.Text = "Removing";
            this.btnRemoving.UseVisualStyleBackColor = true;
            this.btnRemoving.Click += new System.EventHandler(this.btnRemoving_Click);
            // 
            // btnModifying
            // 
            this.btnModifying.Location = new System.Drawing.Point(3, 180);
            this.btnModifying.Name = "btnModifying";
            this.btnModifying.Size = new System.Drawing.Size(75, 40);
            this.btnModifying.TabIndex = 2;
            this.btnModifying.Text = "Modifying";
            this.btnModifying.UseVisualStyleBackColor = true;
            this.btnModifying.Click += new System.EventHandler(this.btnModifying_Click);
            // 
            // btnViewing
            // 
            this.btnViewing.Location = new System.Drawing.Point(3, 6);
            this.btnViewing.Name = "btnViewing";
            this.btnViewing.Size = new System.Drawing.Size(75, 40);
            this.btnViewing.TabIndex = 1;
            this.btnViewing.Text = "Viewing";
            this.btnViewing.UseVisualStyleBackColor = true;
            this.btnViewing.Click += new System.EventHandler(this.btnViewing_Click);
            // 
            // btnCreating
            // 
            this.btnCreating.Location = new System.Drawing.Point(3, 122);
            this.btnCreating.Name = "btnCreating";
            this.btnCreating.Size = new System.Drawing.Size(75, 40);
            this.btnCreating.TabIndex = 0;
            this.btnCreating.Text = "Creating";
            this.btnCreating.UseVisualStyleBackColor = true;
            this.btnCreating.Click += new System.EventHandler(this.btnCreating_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearchByName);
            this.panel3.Controls.Add(this.txtSearchByName);
            this.panel3.Controls.Add(this.btnSearchById);
            this.panel3.Controls.Add(this.txtSearchById);
            this.panel3.Controls.Add(this.lbFilterByCountry);
            this.panel3.Controls.Add(this.lbFilterByCity);
            this.panel3.Controls.Add(this.cbFilterByCountry);
            this.panel3.Controls.Add(this.cbFilterByCity);
            this.panel3.Location = new System.Drawing.Point(119, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(551, 66);
            this.panel3.TabIndex = 4;
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(445, 35);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(103, 23);
            this.btnSearchByName.TabIndex = 7;
            this.btnSearchByName.Text = "Search By Name";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(263, 36);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(176, 23);
            this.txtSearchByName.TabIndex = 6;
            // 
            // btnSearchById
            // 
            this.btnSearchById.Location = new System.Drawing.Point(445, 6);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(103, 23);
            this.btnSearchById.TabIndex = 5;
            this.btnSearchById.Text = "Search By ID";
            this.btnSearchById.UseVisualStyleBackColor = true;
            this.btnSearchById.Click += new System.EventHandler(this.btnSearchById_Click);
            // 
            // txtSearchById
            // 
            this.txtSearchById.Location = new System.Drawing.Point(263, 7);
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Size = new System.Drawing.Size(176, 23);
            this.txtSearchById.TabIndex = 4;
            // 
            // lbFilterByCountry
            // 
            this.lbFilterByCountry.AutoSize = true;
            this.lbFilterByCountry.Location = new System.Drawing.Point(3, 43);
            this.lbFilterByCountry.Name = "lbFilterByCountry";
            this.lbFilterByCountry.Size = new System.Drawing.Size(95, 15);
            this.lbFilterByCountry.TabIndex = 3;
            this.lbFilterByCountry.Text = "Filter By Country";
            // 
            // lbFilterByCity
            // 
            this.lbFilterByCity.AutoSize = true;
            this.lbFilterByCity.Location = new System.Drawing.Point(3, 6);
            this.lbFilterByCity.Name = "lbFilterByCity";
            this.lbFilterByCity.Size = new System.Drawing.Size(73, 15);
            this.lbFilterByCity.TabIndex = 2;
            this.lbFilterByCity.Text = "Filter By City";
            // 
            // cbFilterByCountry
            // 
            this.cbFilterByCountry.DisplayMember = "Select Contry";
            this.cbFilterByCountry.FormattingEnabled = true;
            this.cbFilterByCountry.Location = new System.Drawing.Point(104, 35);
            this.cbFilterByCountry.Name = "cbFilterByCountry";
            this.cbFilterByCountry.Size = new System.Drawing.Size(121, 23);
            this.cbFilterByCountry.TabIndex = 2;
            this.cbFilterByCountry.Text = "Select Country";
            this.cbFilterByCountry.SelectedValueChanged += new System.EventHandler(this.cbFilterByCountry_SelectedValueChanged);
            this.cbFilterByCountry.Click += new System.EventHandler(this.cbFilterByCountry_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(592, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 344);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMemberManagement_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDataView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemoving;
        private System.Windows.Forms.Button btnModifying;
        private System.Windows.Forms.Button btnViewing;
        private System.Windows.Forms.Button btnCreating;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbFilterByCountry;
        private System.Windows.Forms.Label lbFilterByCity;
        private System.Windows.Forms.ComboBox cbFilterByCountry;
        private System.Windows.Forms.ComboBox cbFilterByCity;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.TextBox txtSearchById;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Button btnLogOut;
    }
}