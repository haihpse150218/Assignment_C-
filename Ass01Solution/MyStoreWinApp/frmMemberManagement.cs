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
            dgvDataView.DataSource = memBerRepository.ReadAll();
            dgvDataView.AutoResizeColumns();
            dgvDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgvDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
