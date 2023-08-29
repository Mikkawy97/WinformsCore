
using DataContext.Context;
using DataContext.implemention;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Model;
using RepositoryLayer;

namespace UserForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        private static IServiceProvider? ServiceProvider { get; set; }
        public static IUnitofwork? _unitofwork { get; set; }    
        [STAThread]
      
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var host = CreateHostBuilder().Build();
            //ServiceProvider = host.Services;


            //Application.Run(ServiceProvider.GetRequiredService<Form1>());
            var host = Host.CreateDefaultBuilder().ConfigureServices((hostcontext, services) =>
            {
                services.GetServices();
                ServiceProvider = services.BuildServiceProvider();

            }).Build();
            using IServiceScope scope = ServiceProvider.CreateScope();
            _unitofwork = scope.ServiceProvider.GetRequiredService<IUnitofwork>();
            //Category c1=new Category() { Name="Drinks" };
            //Product p1 = new Product() { NameAr = "Pepsi", NameEn = "Pepsi", Category = c1, StockQuantity = 15, UnitPrice = 10 };
            //_unitofwork.AdminRepo.AddCategory(c1);
            //_unitofwork.AdminRepo.AddProduct(p1);


            //OrderDetails o1 = new OrderDetails { OrderID = 2, ProductID = 5, UnitPrice = 10 };
            //_unitofwork.AdminRepo.AddOrderDetail(o1);

            //Order o1 = new Order { CreateDate=DateTime.Now,CustomerID=10,Status=Status.pending,TotalPrice=10};
            //_unitofwork.AdminRepo.AddOrder(o1);


            Application.Run(new Form1());
        }
        //public static IServiceProvider ServiceProvider { get; private set; }
       //public static IHostBuilder CreateHostBuilder()
       // {
       //     return Host.CreateDefaultBuilder()
       //         .ConfigureServices((context, services) => {
       //             services.AddDbContext<CompanyContext>(options => options.UseSqlServer("server=.;database=FinalProjectDB;trusted_connection=true;TrustServerCertificate=True;"));
       //             services.AddTransient<IUnitofwork, UnitofWork>();
       //             services.AddTransient<Form1>();
       //         });
       // }
    }
}