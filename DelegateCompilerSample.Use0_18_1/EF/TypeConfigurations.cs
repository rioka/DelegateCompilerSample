using System.Data.Entity.ModelConfiguration;
using DelegateCompilerSample.Core;

namespace DelegateCompilerSample.EF
{
  internal class OrderConfiguration : EntityTypeConfiguration<Order>
  {
    public OrderConfiguration()
    {
      this.HasMany(o => o.OrderLines)
        .WithRequired()
        .Map(cfg => cfg.MapKey($"{nameof(Order)}{nameof(Order.Id)}"));
    }
  }

  internal class OrderLineConfiguration : EntityTypeConfiguration<OrderLine>
  {
    public OrderLineConfiguration()
    {
      Property(l => l.Product)
        .IsRequired()
        .HasMaxLength(50);
    }
  }
}
