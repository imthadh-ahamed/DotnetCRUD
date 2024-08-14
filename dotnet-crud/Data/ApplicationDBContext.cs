using dotnet_crud.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_crud.Data
{
    // This class will be used to interact with the database
    public class ApplicationDBContext:DbContext
    {
        // This constructor will be used to inject the options to the base class
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }

        // This DbSet will be used to interact with the Brand table
        public DbSet<Brand> Brand { get; set; }
    }
}
