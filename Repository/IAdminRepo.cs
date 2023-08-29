using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public interface IAdminRepo : IGenricRepo<Admin>

    {
        public User User { get; set; }
        public BindingList<Product> GetAllProducts();

        public void AddCategory(Category c);

        public void AddProduct(Product product);

        public void AddOrder(Order order);
        public void AddOrderDetail(OrderDetails orderdetail);

        public BindingList<Admin> GetAllAdmins();

        public BindingList<Category> GetAllCategories();

        public BindingList<Order> GetAllOrders();
    }
}
