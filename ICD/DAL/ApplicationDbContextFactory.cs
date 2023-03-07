using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DAL;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseSqlite("Data Source=test.db");

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}
// public class ApplicationDbContextFactory: IDesignTimeDbContextFactory<ApplicationDbContext>
// {
//     private IDesignTimeDbContextFactory<ApplicationDbContext>? _designTimeDbContextFactoryImplementation;
//
//     public ApplicationDbContextFactory(IDesignTimeDbContextFactory<ApplicationDbContext>? designTimeDbContextFactoryImplementation)
//     {
//         _designTimeDbContextFactoryImplementation = designTimeDbContextFactoryImplementation;
//         var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
//         optionsBuilder.UseSqlite("Data Source=design.db");
//
//         ApplicationDbContext applicationDbContext = new ApplicationDbContext(optionsBuilder.Options);
//         if (applicationDbContext == null) throw new ArgumentNullException(nameof(applicationDbContext));
//     }
//
//     public ApplicationDbContext CreateDbContext(string[] args)
//     {
//         return _designTimeDbContextFactoryImplementation!.CreateDbContext(args);
//     }
// }