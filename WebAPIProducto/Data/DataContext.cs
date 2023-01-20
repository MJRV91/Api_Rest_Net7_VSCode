
using Microsoft.EntityFrameworkCore;

namespace WebAPIProducto.Models.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
            
        }
         public DbSet<Producto> Productos { get; set; }
    }
}