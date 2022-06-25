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
    public partial class frmMemberManagement : Form
    {
        public frmMemberManagement()
        {
            InitializeComponent();
            LoadMemberList();
        }
        void LoadMemberList()
        {
            IMemBerRepository memBerRepository = new MemBerRepository();
            dgvDataView.DataSource = memBerRepository.ReadAll(); 
            dgvDataView.AutoResizeColumns();
            dgvDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgvDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnRemoving_Click(object sender, EventArgs e)
        {

        }

        private void btnViewing_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void btnCreating_Click(object sender, EventArgs e)
        {
            frmCreate frmCreate = new frmCreate();
            frmCreate.ShowDialog();
            
        }

        private void btnModifying_Click(object sender, EventArgs e)
        {  
            frmUpdateMember frmUpdate = new frmUpdateMember();
            frmUpdate.ShowDialog();
            
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var a = sender.GetType();
            this.Close();
        }

        private void frmMemberManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            var b = sender.GetType();
            if (MessageBox.Show("Are you sure to Logout?", "Logout Confirm", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
