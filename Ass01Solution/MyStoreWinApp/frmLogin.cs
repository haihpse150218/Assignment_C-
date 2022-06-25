using DataAccess.Repository;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you sur to exit?","Exit Confirm", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (Login(email, password))
            {
                frmMemberManagement formManagerMember = new frmMemberManagement();
                this.Hide();
                formManagerMember.ShowDialog();
                this.Show();
            }
           
        }
        bool Login(string email, string password)
        {
            bool flag = false;
            string msg = null;
            IMemBerRepository memBerRepository = new MemBerRepository();
           flag =  memBerRepository.Login(email, password, out msg);
            if (msg != null)
            {
                MessageBox.Show(msg);
            }
            return flag;
        }
    }
}
