using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
