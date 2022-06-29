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
using BusinessObject;
namespace MyStoreWinApp
{
    public partial class frmUser : Form
    {
        MemberObject member;
        public frmUser()
        {
            InitializeComponent();
        }

        public frmUser(MemberObject memberObject)
        {
            InitializeComponent();
            member = memberObject;
            frmUser_Load();
        }

        private void bthLogOut_Click(object sender, EventArgs e)
        {
            var a = sender.GetType();
            this.Close();
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            var b = sender.GetType();
            if (MessageBox.Show("Are you sure to Logout?", "Logout Confirm", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        
        private void frmUser_Load()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.Clear();
            List<MemberObject> source = new List<MemberObject>();
            bindingSource.Add(member);
            IMemBerRepository memBerRepository = new MemBerRepository();
            dgvUser.DataSource = bindingSource;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            frmUpdateUser formUpdateUser = new frmUpdateUser(member);
            this.Hide();
            formUpdateUser.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
