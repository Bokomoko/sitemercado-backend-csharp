using Microsoft.EntityFrameworkCore;
using prod_store_cs.Models;

namespace prod_store_cs.Data {
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) 
    : base(options){}

    public DbSet<Product> Products {get;set;}

    public DbSet<Category> Categories {get;set;}

  }
}