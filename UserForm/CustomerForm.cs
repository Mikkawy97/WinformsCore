using Model;
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
    public partial class CustomerForm : Form
    {
        private readonly IUnitofwork _unitofwork;
        public CustomerForm()
        {
            InitializeComponent();
            _unitofwork = Program._unitofwork;

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            ProductsgridView.DataSource = _unitofwork.AdminRepo.GetAllProducts();
            ProductsgridView.ReadOnly = true;
            ProductsgridView.Columns["ID"].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = _unitofwork.AdminRepo.GetAllProducts().Where(p => p.NameEn.Contains(search_txt.Text));

            ProductsgridView.DataSource = bs;
        }

        private void plOrderBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ProductsgridView.Rows.GetRowCount(DataGridViewElementStates.Selected); i++)
            {
                Order o1 = new Order() { CreateDate = DateTime.Now, CustomerID = _unitofwork.AdminRepo.User.ID, Status = Status.pending, TotalPrice = 0 };
                _unitofwork.AdminRepo.AddOrder(o1);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderList orderList = new OrderList();
            this.Hide();
            orderList.Show();

        }
    }
}
