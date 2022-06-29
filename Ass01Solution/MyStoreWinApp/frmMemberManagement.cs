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
        IMemBerRepository memBerRepository = new MemBerRepository();
        public frmMemberManagement()
        {
            InitializeComponent();
            LoadMemberList();
        }
        void LoadMemberList()
        {
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
            var list = memBerRepository.DescendingSort().ToList();
            dgvDataView.DataSource = list;
            dgvDataView.Show();
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

        private void cbFilterByCity_SelectedValueChanged(object sender, EventArgs e)
        {
            cbFilterByCountry.DisplayMember = "city";
            ComboBox cb = sender as ComboBox;
            var result = memBerRepository.GetMemberByCity(cb.ToString());
            dgvDataView.DataSource = result;
            dgvDataView.Show();
        }

        private void cbFilterByCountry_SelectedValueChanged(object sender, EventArgs e)
        {
            cbFilterByCity.DisplayMember = "country";
            ComboBox cb = sender as ComboBox;
            var result = memBerRepository.GetMemberByCountry(cb.ToString());
            dgvDataView.DataSource = result;
            dgvDataView.Show();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            cbFilterByCity.DataSource = memBerRepository.GetCityList();
            cbFilterByCountry.DataSource = memBerRepository.GetCountryList();
        }
    }
}
