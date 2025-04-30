using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using UpWork.Infrastructure.Data;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

        // 👇 Use your actual local/dev connection string here
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=UpWorkDb;Trusted_Connection=True;");

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}
