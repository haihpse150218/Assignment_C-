using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository;
using System.Text.RegularExpressions;

namespace MyStoreWinApp
{
    public partial class frmCreate : Form
    {
        public frmCreate()
        {
            InitializeComponent();
        }
        public IMemBerRepository MemberRepository = new MemBerRepository();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            MemberObject member;
            try
            {
                member = new MemberObject
                {
                    name = txtName.Text,
                    email = txtEmail.Text,
                    password = txtPassword.Text,
                    city = txtCity.Text,
                    country = txtCountry.Text
                };
                MemberRepository.CreateMember(member);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Create a new user.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                NameValidate.SetError(txtName, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                NameValidate.SetError(txtName, "");
            }
        }


        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                EmailValidate.SetError(txtEmail, "Email should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                EmailValidate.SetError(txtEmail, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                PasswordValidate.SetError(txtPassword, "Password should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                PasswordValidate.SetError(txtPassword, "");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)

        {

            Regex mRegxExpression;

            if (txtEmail.Text.Trim() != string.Empty)

            {
                string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (Regex.IsMatch(txtEmail.Text, pattern))
                {
                    EmailFormat.Clear();
                    btnCreate.Enabled = true;
                }
                else
                {
                    EmailFormat.SetError(this.txtEmail, "E-mail address format is not correct.");
                    btnCreate.Enabled = false;
                }
               

            }

        }
    }
}
