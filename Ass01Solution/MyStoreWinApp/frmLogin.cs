using BusinessObject;
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
            if(MessageBox.Show("Are you sure to exit?","Exit Confirm", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MemberObject memberObject = null;

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            memberObject = LoginAsUser(email, password);
            if (LoginAsAdmin(email, password))
            {
                frmMemberManagement formManagerMember = new frmMemberManagement();
                this.Hide();
                formManagerMember.ShowDialog();
                this.Show();
            }
           
            else if(memberObject!=null)
            {
                
                frmUser formUser = new frmUser(memberObject);
                this.Hide();
                formUser.ShowDialog();
                this.Show();
            }
            
           
        }
        

        bool LoginAsAdmin(string email, string password)
        {
            
            bool flag = false;
            IMemBerRepository memBerRepository = new MemBerRepository();
            flag = memBerRepository.LoginAsAdmin(email, password);
            return flag;
        }

        MemberObject LoginAsUser(string email, string password)
        {
            string msg = null;
            MemberObject memberObject = null;
            IMemBerRepository memBerRepository = new MemBerRepository();
            memberObject = memBerRepository.LoginAsUser(email, password,out msg);
            if(msg!=null)
            {
                MessageBox.Show(msg);
            }
            return memberObject;
        }
    }
}
