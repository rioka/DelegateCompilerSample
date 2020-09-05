using System.Data.Entity;
using System.Reflection;
using DelegateCompilerSample.Core;

namespace DelegateCompilerSample.EF
{
  internal class Context : DbContext
  {
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
    }
  }
}
