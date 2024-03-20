using System.Net;
using Microsoft.EntityFrameworkCore;

namespace Deploy_Web_API_LP // Замените на ваше пространство имен
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=mysqlserver1966.database.windows.net;Database=mySampleDatabase;User=azureuser;Password=Raikurinne1L99!;"); // Замените на ваши реальные данные
        }

        // DbSet для каждой таблицы в вашей базе данных
        public DbSet<BuildVersion> BuildVersions { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductDescription> ProductDescriptions { get; set; }
        public DbSet<ProductModel> ProductModels { get; set; }
        public DbSet<ProductModelProductDescription> ProductModelProductDescriptions { get; set; }
        public DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public DbSet<vGetAllCategories> vGetAllCategories { get; set; }
        public DbSet<vProductModelCatalogDescription> vProductModelCatalogDescriptions { get; set; }
        public DbSet<uspLogErr> uspLogErrs { get; set; }
        public DbSet<uspPrintError> uspPrintErrors { get; set; }
        public DbSet<unfGetAllCategories> unfGetAllCategories { get; set; }
        public DbSet<unfGetCustomerInformation> unfGetCustomerInformations { get; set; }
        public DbSet<unfGetSalesOrderStatusText> unfGetSalesOrderStatusTexts { get; set; }
    }
}
