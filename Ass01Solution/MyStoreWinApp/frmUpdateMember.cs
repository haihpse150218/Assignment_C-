using System;
using DataAccess.Repository;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using BusinessObject;

namespace MyStoreWinApp
{
    public partial class frmUpdateMember : Form
    {
        public frmUpdateMember(BusinessObject.MemberObject mem)
        {
            MemberObject? memberObject = mem;
            InitializeComponent();
            if (memberObject != null)
            {
                txtUpdateID.Text = memberObject.id.ToString();
                txtUpdateName.Text = memberObject.name;
                txtUpdateEmail.Text = memberObject.email;
                txtUpdatePassword.Text = memberObject.password;
                txtUpdateCity.Text = memberObject.city;
                txtUpdateCountry.Text = memberObject.country;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtUpdateID.Text);
            string name = txtUpdateName.Text.Trim();
            string email = txtUpdateEmail.Text.Trim();
            string password = txtUpdatePassword.Text.Trim();
            string city = txtUpdateCity.Text.Trim();
            string country = txtUpdateCountry.Text.Trim();
            
            if (email == null && password == null)
            {
                MessageBox.Show("Email, password is required!");
            }
            else
            {
                IMemBerRepository memBerRepository = new MemBerRepository();
                memBerRepository.UpdateInfo(id, name, email, password, city, country);
            }
            
        }

        private void btnCloseUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
