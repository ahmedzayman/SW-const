using Microsoft.EntityFrameworkCore;
using mhma_kan; 

public class AdventureWorks2022Context : DbContext
{
    public AdventureWorks2022Context(DbContextOptions<AdventureWorks2022Context> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}