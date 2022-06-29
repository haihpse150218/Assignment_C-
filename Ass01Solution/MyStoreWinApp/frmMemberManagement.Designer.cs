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
            this.lbSearchByName = new System.Windows.Forms.TextBox();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.lbSearchById = new System.Windows.Forms.TextBox();
            this.lbFilterByCountry = new System.Windows.Forms.Label();
            this.lbFilterByCity = new System.Windows.Forms.Label();
            this.cbFilterByCountry = new System.Windows.Forms.ComboBox();
            this.cbFilterByCity = new System.Windows.Forms.ComboBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDataView);
            this.panel1.Location = new System.Drawing.Point(136, 132);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 293);
            this.panel1.TabIndex = 2;
            // 
            // dgvDataView
            // 
            this.dgvDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataView.Location = new System.Drawing.Point(3, 4);
            this.dgvDataView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDataView.Name = "dgvDataView";
            this.dgvDataView.RowHeadersWidth = 51;
            this.dgvDataView.RowTemplate.Height = 25;
            this.dgvDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataView.Size = new System.Drawing.Size(623, 285);
            this.dgvDataView.TabIndex = 1;
            this.dgvDataView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataView_CellContentDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSort);
            this.panel2.Controls.Add(this.btnRemoving);
            this.panel2.Controls.Add(this.btnModifying);
            this.panel2.Controls.Add(this.btnViewing);
            this.panel2.Controls.Add(this.btnCreating);
            this.panel2.Location = new System.Drawing.Point(32, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 389);
            this.panel2.TabIndex = 3;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(3, 85);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(86, 53);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sorting";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnRemoving
            // 
            this.btnRemoving.Location = new System.Drawing.Point(3, 317);
            this.btnRemoving.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoving.Name = "btnRemoving";
            this.btnRemoving.Size = new System.Drawing.Size(86, 53);
            this.btnRemoving.TabIndex = 3;
            this.btnRemoving.Text = "Removing";
            this.btnRemoving.UseVisualStyleBackColor = true;
            this.btnRemoving.Click += new System.EventHandler(this.btnRemoving_Click);
            // 
            // btnModifying
            // 
            this.btnModifying.Location = new System.Drawing.Point(3, 240);
            this.btnModifying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModifying.Name = "btnModifying";
            this.btnModifying.Size = new System.Drawing.Size(86, 53);
            this.btnModifying.TabIndex = 2;
            this.btnModifying.Text = "Modifying";
            this.btnModifying.UseVisualStyleBackColor = true;
            this.btnModifying.Click += new System.EventHandler(this.btnModifying_Click);
            // 
            // btnViewing
            // 
            this.btnViewing.Location = new System.Drawing.Point(3, 8);
            this.btnViewing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewing.Name = "btnViewing";
            this.btnViewing.Size = new System.Drawing.Size(86, 53);
            this.btnViewing.TabIndex = 1;
            this.btnViewing.Text = "Viewing";
            this.btnViewing.UseVisualStyleBackColor = true;
            this.btnViewing.Click += new System.EventHandler(this.btnViewing_Click);
            // 
            // btnCreating
            // 
            this.btnCreating.Location = new System.Drawing.Point(3, 163);
            this.btnCreating.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreating.Name = "btnCreating";
            this.btnCreating.Size = new System.Drawing.Size(86, 53);
            this.btnCreating.TabIndex = 0;
            this.btnCreating.Text = "Creating";
            this.btnCreating.UseVisualStyleBackColor = true;
            this.btnCreating.Click += new System.EventHandler(this.btnCreating_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearchByName);
            this.panel3.Controls.Add(this.lbSearchByName);
            this.panel3.Controls.Add(this.btnSearchById);
            this.panel3.Controls.Add(this.lbSearchById);
            this.panel3.Controls.Add(this.lbFilterByCountry);
            this.panel3.Controls.Add(this.lbFilterByCity);
            this.panel3.Controls.Add(this.cbFilterByCountry);
            this.panel3.Controls.Add(this.cbFilterByCity);
            this.panel3.Location = new System.Drawing.Point(136, 36);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 88);
            this.panel3.TabIndex = 4;
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(509, 47);
            this.btnSearchByName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(118, 31);
            this.btnSearchByName.TabIndex = 7;
            this.btnSearchByName.Text = "Search By Name";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // lbSearchByName
            // 
            this.lbSearchByName.Location = new System.Drawing.Point(301, 48);
            this.lbSearchByName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbSearchByName.Name = "lbSearchByName";
            this.lbSearchByName.Size = new System.Drawing.Size(201, 27);
            this.lbSearchByName.TabIndex = 6;
            // 
            // btnSearchById
            // 
            this.btnSearchById.Location = new System.Drawing.Point(509, 8);
            this.btnSearchById.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(118, 31);
            this.btnSearchById.TabIndex = 5;
            this.btnSearchById.Text = "Search By ID";
            this.btnSearchById.UseVisualStyleBackColor = true;
            this.btnSearchById.Click += new System.EventHandler(this.btnSearchById_Click);
            // 
            // lbSearchById
            // 
            this.lbSearchById.Location = new System.Drawing.Point(301, 9);
            this.lbSearchById.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbSearchById.Name = "lbSearchById";
            this.lbSearchById.Size = new System.Drawing.Size(201, 27);
            this.lbSearchById.TabIndex = 4;
            // 
            // lbFilterByCountry
            // 
            this.lbFilterByCountry.AutoSize = true;
            this.lbFilterByCountry.Location = new System.Drawing.Point(3, 57);
            this.lbFilterByCountry.Name = "lbFilterByCountry";
            this.lbFilterByCountry.Size = new System.Drawing.Size(117, 20);
            this.lbFilterByCountry.TabIndex = 3;
            this.lbFilterByCountry.Text = "Filter By Country";
            // 
            // lbFilterByCity
            // 
            this.lbFilterByCity.AutoSize = true;
            this.lbFilterByCity.Location = new System.Drawing.Point(3, 8);
            this.lbFilterByCity.Name = "lbFilterByCity";
            this.lbFilterByCity.Size = new System.Drawing.Size(91, 20);
            this.lbFilterByCity.TabIndex = 2;
            this.lbFilterByCity.Text = "Filter By City";
            // 
            // cbFilterByCountry
            // 
            this.cbFilterByCountry.FormattingEnabled = true;
            this.cbFilterByCountry.Location = new System.Drawing.Point(119, 47);
            this.cbFilterByCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFilterByCountry.Name = "cbFilterByCountry";
            this.cbFilterByCountry.Size = new System.Drawing.Size(138, 28);
            this.cbFilterByCountry.TabIndex = 1;
            // 
            // cbFilterByCity
            // 
            this.cbFilterByCity.FormattingEnabled = true;
            this.cbFilterByCity.Location = new System.Drawing.Point(119, 8);
            this.cbFilterByCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFilterByCity.Name = "cbFilterByCity";
            this.cbFilterByCity.Size = new System.Drawing.Size(138, 28);
            this.cbFilterByCity.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(677, 5);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(86, 31);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 459);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMemberManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
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
        private System.Windows.Forms.TextBox lbSearchById;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.TextBox lbSearchByName;
        private System.Windows.Forms.Button btnLogOut;
    }
}