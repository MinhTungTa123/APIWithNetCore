using Microsoft.EntityFrameworkCore;
using pjModels;
namespace pjDataAccess
{
    public class KitchenContext:DbContext

    {
        public KitchenContext()
        {

        }
        public KitchenContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Writer> Writers { get; set; }

      
       
      
    }
}
