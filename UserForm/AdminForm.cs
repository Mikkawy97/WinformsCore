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
    public partial class AdminForm : Form
    {
        private readonly IUnitofwork _unitofwork;
        public AdminForm()
        {
            InitializeComponent();
            _unitofwork = Program._unitofwork;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _unitofwork.AdminRepo.GetAllProducts();
            dataGridView2.DataSource = _unitofwork.AdminRepo.GetAllCategories();
            dataGridView3.DataSource = _unitofwork.AdminRepo.GetAllAdmins();
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView2.Columns["CategoryID"].Visible = false;
            dataGridView3.Columns["ID"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            _unitofwork.save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.EndEdit();
            _unitofwork.save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            dataGridView2.EndEdit();
            dataGridView3.EndEdit();
            _unitofwork.save();
        }

        private void vieworders_btn_Click(object sender, EventArgs e)
        {
            OrderList f = new OrderList();
            this.Hide();
           f.Show();
        }
    }
}
