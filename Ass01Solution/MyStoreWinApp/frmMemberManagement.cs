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
    public partial class frmMemberManagement : Form
    {
        MemberObject member;
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
            
            cbFilterByCity.Text = "Select City";
            cbFilterByCountry.Text = "Select Country";
        }
        void LoadCity()
        {
            IMemBerRepository memBerRepository = new MemBerRepository();
            BindingList<string> list = new BindingList<string>(memBerRepository.GetCityList().ToList());
            cbFilterByCity.DataSource = list;
        }
        void LoadCountry()
        {
            IMemBerRepository memBerRepository = new MemBerRepository();
            BindingList<string> list = new BindingList<string>(memBerRepository.GetCountryList().ToList());
            cbFilterByCountry.DataSource = list;
        }
        private void dgvDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnRemoving_Click(object sender, EventArgs e)
        {
            member = dgvDataView.CurrentRow.DataBoundItem as MemberObject;
            int id = member.id;
            if (MessageBox.Show("Are you sure to remove this member?", "Remove Confirm", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                IMemBerRepository memBerRepository = new MemBerRepository();
                memBerRepository.RemoveMember(id);
                LoadMemberList();
            }    
        }

        private void btnViewing_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void SortDes()
        {
            
            IMemBerRepository memBerRepository = new MemBerRepository();
            List<MemberObject> list = memBerRepository.DescendingSort().ToList();
            BindingList<MemberObject> source = new BindingList<MemberObject>(list);
            
            dgvDataView.DataSource = source;
            dgvDataView.AutoResizeColumns();
            dgvDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            SortDes();
        }

        private void btnCreating_Click(object sender, EventArgs e)
        {
            frmCreate frmCreate = new frmCreate();
            frmCreate.ShowDialog();
            LoadMemberList();
            
        }

        private void btnModifying_Click(object sender, EventArgs e)
        {
            member = dgvDataView.CurrentRow.DataBoundItem as MemberObject;
            frmUpdateMember frmUpdate = new frmUpdateMember(member);
            frmUpdate.ShowDialog();
            LoadMemberList();
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            string idNumeric = txtSearchById.Text;
            int idNumber;
            IMemBerRepository memBerRepository = new MemBerRepository();
            List<MemberObject> list = new List<MemberObject>();
            if (int.TryParse(idNumeric, out idNumber))
            {
                int size = memBerRepository.ReadAll().Count();
                List<int> listSize = new List<int>();
                for(int i = 1; i <= size; i*=10)
                {
                    listSize.Add(i);
                }
                foreach (MemberObject mem in memBerRepository.ReadAll())
                {
                    for(int i = 0; i < listSize.Count; i++)
                    {
                        var a = Math.Floor(new decimal(mem.id) / new decimal(listSize[i]));
                        if (a == idNumber)
                        {
                            list.Add(mem);
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter integer id!");
            }
            if(list.Count > 0)
            {
                BindingList<MemberObject> source = new BindingList<MemberObject>(list);
                dgvDataView.DataSource = source;
                dgvDataView.AutoResizeColumns();
                dgvDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                IList<String> listNoResult = new List<String>();
                listNoResult.Add("No result");
                dgvDataView.DataSource = listNoResult.Select(x => new { Value = x }).ToList();
            }
            

        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            IMemBerRepository memBerRepository = new MemBerRepository();
            List<MemberObject> list = new List<MemberObject>();
            string name = txtSearchByName.Text;
            list = memBerRepository.GetMemberByName(name).ToList();
            if (list.Count > 0)
            {
                BindingList<MemberObject> source = new BindingList<MemberObject>(list);
                dgvDataView.DataSource = source;
                dgvDataView.AutoResizeColumns();
                dgvDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {

                IList<String> listNoResult = new List<String>();
                listNoResult.Add("No result");
                dgvDataView.DataSource = listNoResult.Select(x => new { Value = x }).ToList();
            }
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
        void LoadByCity(string city)
        {
            IMemBerRepository memBerRepository = new MemBerRepository();
            List<MemberObject> list = memBerRepository.SortByCity(city).ToList();
            BindingList<MemberObject> source = new BindingList<MemberObject>(list);
            dgvDataView.DataSource = source;
            dgvDataView.AutoResizeColumns();
            dgvDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        void LoadByCountry(string country)
        {
            IMemBerRepository memBerRepository = new MemBerRepository();
            List<MemberObject> list = memBerRepository.SortByCountry(country).ToList();
            BindingList<MemberObject> source = new BindingList<MemberObject>(list);
            dgvDataView.DataSource = source;
            dgvDataView.AutoResizeColumns();
            dgvDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void cbFilterByCity_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadCity();
           
            string city = cbFilterByCity.SelectedItem.ToString();
            LoadByCity(city);
        }

        private void cbFilterByCity_Click(object sender, EventArgs e)
        {
            LoadCity();
        }

        private void cbFilterByCountry_Click(object sender, EventArgs e)
        {
            LoadCountry();
        }

        private void cbFilterByCountry_SelectedValueChanged(object sender, EventArgs e)
        {
            string country = cbFilterByCountry.SelectedItem.ToString();
            LoadByCountry(country);
        }
    }
}
