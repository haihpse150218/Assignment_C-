using BusinessObject;
using DataAccess.Repository;
using System;
using System.Text.RegularExpressions;
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
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if(match.Success && email.Length !=0 && password.Length !=0)
            {
                memberObject = LoginAsUser(email, password);
                if (LoginAsAdmin(email, password))
                {
                    frmMemberManagement formManagerMember = new frmMemberManagement();
                    this.Hide();
                    formManagerMember.ShowDialog();
                    this.Show();
                }

                else if (memberObject != null)
                {

                    frmUser formUser = new frmUser(memberObject);
                    this.Hide();
                    formUser.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password!");
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
