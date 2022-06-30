using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        IMemBerRepository memBerRepository;
        public frmMemberManagement()
        {
            InitializeComponent();
            LoadMemberList();
        }
        void LoadMemberList()
        {
            memBerRepository = new MemBerRepository();
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
            memBerRepository = new MemBerRepository();
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
            memBerRepository = new MemBerRepository();
            var list = memBerRepository.GetMemberById(int.Parse(txtSearchById.Text)).ToArray();
            dgvDataView.DataSource = list;
            dgvDataView.Show();
            txtSearchById.Clear();
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            memBerRepository= new MemBerRepository();
            var list = memBerRepository.GetMemberByName(txtSearchByName.Text).ToArray();
            dgvDataView.DataSource = list;
            dgvDataView.Show();
            txtSearchByName.Clear();
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
            ComboBox cb = sender as ComboBox;
            var result = memBerRepository.GetMemberByCity(cb.SelectedValue.ToString()).ToArray();
            dgvDataView.DataSource = result;
            dgvDataView.Show();
        }

        private void cbFilterByCountry_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            var result = memBerRepository.GetMemberByCountry(cb.SelectedValue.ToString()).ToArray();
            dgvDataView.DataSource = result;
            dgvDataView.Show();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            cbFilterByCity.DataSource = memBerRepository.GetCityList().ToArray();
            cbFilterByCity.DisplayMember = "city";

            cbFilterByCountry.DataSource = memBerRepository.GetCountryList().ToArray();
            cbFilterByCountry.DisplayMember = "country";
        }

        private void txtSearchById_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(txtSearchById.Text,"\\d") ) 
            {
                if (memBerRepository.GetMemberById(int.Parse(txtSearchById.Text)).Count() == 0)
                {
                    e.Cancel = true;
                    ErrorSearchID.SetError(txtSearchById, "No member has this ID");
                    txtSearchById.Clear();
                }
                else 
                { 
                e.Cancel = false;
                ErrorSearchID.SetError(txtSearchById, "");
                }
            }
            else if (string.IsNullOrWhiteSpace(txtSearchById.Text))
            {
                e.Cancel = true;
                ErrorSearchID.SetError(txtSearchById, "ID should not be left blank ");
            }
            else
            {
                e.Cancel = true;
                ErrorSearchID.SetError(txtSearchById, "Input NUMBER to search member by ID");
                txtSearchById.Clear();
            }
        }

        private void txtSearchByName_Validating(object sender, CancelEventArgs e)
        {
            if (memBerRepository.GetMemberByName(txtSearchByName.Text).Count() == 0)
            {
                e.Cancel = true;
                ErrorSearchName.SetError(txtSearchByName, "No member has this NAME");
                txtSearchByName.Clear();
            }
            else if (string.IsNullOrWhiteSpace(txtSearchByName.Text))
            {
                e.Cancel = true;
                ErrorSearchName.SetError(txtSearchByName, "Name should not be left blank");
            }
            else
            {
                e.Cancel = false;
                ErrorSearchName.SetError(txtSearchByName, "");
            }
        }
    }
}
