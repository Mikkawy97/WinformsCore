using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserForm
{
    public partial class OrderList : Form
    {
        private readonly IUnitofwork _unitofwork;
        public OrderList()
        {
            InitializeComponent();
            _unitofwork = Program._unitofwork;

        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            AdminForm f = new AdminForm();
            this.Hide();
            f.Show();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            OrderGridView.DataSource = _unitofwork.AdminRepo.GetAllOrders();
            OrderGridView.Columns["ID"].Visible = false;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            OrderGridView.EndEdit();
            _unitofwork.save();
        }
    }
}
