using Model;
using RepositoryLayer;

namespace UserForm
{
    public partial class Form1 : Form
    {
        private readonly IUnitofwork _unitofwork;
        public Form1()
        {
            InitializeComponent();
            _unitofwork = Program._unitofwork;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            User flag = _unitofwork.UserRepo.Login(name, password);
            if (flag!=null)
            {
                if (flag.DiscriminatorValue == "Admin")
                {
                    AdminForm f = new AdminForm();
                    f.Show();

                }
                else
                {
                    CustomerForm c = new CustomerForm();
                    c.Show();   
                }
                _unitofwork.AdminRepo.User = flag;  
                this.Hide();
           

            }
            else
            {
                MessageBox.Show("Invaild User Name or Password");
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}