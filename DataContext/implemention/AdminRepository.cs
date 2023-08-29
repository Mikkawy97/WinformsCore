using DataContext.Context;
using Microsoft.EntityFrameworkCore;
using Model;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext.implemention
{
    public class AdminRepository : GenricRepository<Admin>, IAdminRepo
    {
        private readonly CompanyContext _companyContext;
        public User User { get; set; }  
        public AdminRepository(CompanyContext context) : base(context)
        {
            _companyContext = context;
        }

        public void AddCategory(Category c)
        {
            _companyContext.Categories.Add(c);
            _companyContext.SaveChanges();
        }
 


        public void AddProduct(Product product)
        {
            _companyContext.Products.Add(product);
            _companyContext.SaveChanges();
        }
        public BindingList<Category> GetAllCategories()
        {
            _companyContext.Categories.Load();
            return _companyContext.Categories.Local.ToBindingList();
        }
        public BindingList<Admin> GetAllAdmins()
        {
            _companyContext.Admins.Load();
            return _companyContext.Admins.Local.ToBindingList();
        }



        public BindingList<Product> GetAllProducts()
        {
            _companyContext.Products.Load();
            return _companyContext.Products.Local.ToBindingList();

        }
        public void AddOrder(Order order)
        {
            _companyContext.Orders.Add(order);
            _companyContext.SaveChanges();
        }
        public void AddOrderDetail(OrderDetails orderdetail)
        {
            _companyContext.OrderDetails.Add(orderdetail);
            _companyContext.SaveChanges ();
        }

        public BindingList<Order> GetAllOrders()
        {
            _companyContext.Orders.Load();
            return _companyContext.Orders.Local.ToBindingList();


        }
    }
}
