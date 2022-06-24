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
            MemBerRepository memBerRepository = new MemBerRepository();
            List<string> contryList = memBerRepository.GetCountryList().ToList();
            // remake properties
            var listContry = contryList.Select(s => new { value = s }).ToList();
            dgvDataView.DataSource = listContry;
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

        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void btnCreating_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreate frmCreate = new frmCreate();
            frmCreate.ShowDialog();
            this.Show();
        }

        private void btnModifying_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateMember frmUpdate = new frmUpdateMember();
            frmUpdate.ShowDialog();
            this.Show();
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {

        }
    }
}
