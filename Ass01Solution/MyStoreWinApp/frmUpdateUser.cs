using BusinessObject;
using DataAccess.Repository;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmUpdateUser : Form
    {
        BindingSource source;
        MemberObject member;
        public frmUpdateUser()
        {
            InitializeComponent();
        }

        public frmUpdateUser(MemberObject memberObject)
        {
            InitializeComponent();
            member = memberObject;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                int id = Convert.ToInt32(txtID.Text);
                string name = txtName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();
                string city = txtCity.Text.Trim();
                string country = txtCountry.Text.Trim();
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);

                if (email == null || !match.Success)
                {
                    MessageBox.Show("Email is invalid");
                }
                if (password == null)
                {
                    MessageBox.Show("Password is required!");
                }
                else
                {
                    IMemBerRepository memBerRepository = new MemBerRepository();
                    try
                    {
                        memBerRepository.UpdateInfo(id, name, email, password, city, country);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Update have Error!!!: \n" + ex.Message);
                    }
                    MessageBox.Show("Update Success!");
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var a = sender.GetType();
            this.Close();
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            source = new BindingSource();
            source.DataSource = member;
            txtID.DataBindings.Add("Text", source, "ID");
            txtName.DataBindings.Add("Text", member, "Name");
            txtEmail.DataBindings.Add("Text", member, "Email");
            txtPassword.DataBindings.Add("Text", member, "Password");
            txtCity.DataBindings.Add("Text", member, "City");
            txtCountry.DataBindings.Add("Text", member, "Country");
        }

        private void frmUpdateUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            var b = sender.GetType();
            if (MessageBox.Show("Are you sure to Cancel?", "Cancel Confirm", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
