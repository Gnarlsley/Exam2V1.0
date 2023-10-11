using Microsoft.EntityFrameworkCore;

namespace Exam2V1._0.Models
{
    public class ProductContext : DbContext //extends DbContext from EFC
    {

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; } //creating product


        //calling the OnModelCreating method and overriding it with new data. This fills the values in the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
                {
                modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        ProductId = 1,
                        Name = "Socket Head Cap Screws",
                        Quantity = 100,
                        Price = 18.25,
                        Description = "A wire can be passed through the bolt head to prevent loosening."
                    },

                    new Product
                    {
                        ProductId = 2,
                        Name = "Fiber Optic Cables",
                        Quantity = 10,
                        Price = 1100.11,
                        Description = "20 meters of cable capable of high-frequency signal transmission in wide bandwidths."
                    },
                    new Product
                    {
                        ProductId = 3,
                        Name = "Dip Switch",
                        Quantity = 5,
                        Price = 4.15,
                        Description = "Ideal for switching equipment settings; connects to PCB."
                    },

                    new Product
                    {
                        ProductId = 4,
                        Name = "Insulated Torque Wrench",
                        Quantity = 1,
                        Price = 386.28,
                        Description = "265mm and 735g"
                    }

                    //Blank Product Template
                    /*
                    new Product
                    {
                        ProductId = ,
                        Name = ",
                        Quantity = ,
                        Price = ,
                        Description = ""
                    }
                    */
                   );

            }
        }
    }
