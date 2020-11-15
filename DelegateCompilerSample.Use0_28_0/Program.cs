using System;
using System.Linq;
using DelegateCompilerSample.EF;

namespace DelegateCompilerSample.Use0_28_0
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var ctx = new Context())
      {
        Console.WriteLine(ctx.Database.Connection.ConnectionString);

        var orders = ctx.Orders.ToList();
        Console.WriteLine($"{orders.Count} order(s) found");

        foreach (var order in orders)
        {
          Console.WriteLine($"{order.Id}");

          foreach (var line in order.OrderLines)
          {
            Console.WriteLine($"\t{line.Id} {line.Product} {line.Qty}");
          }
        }
      }
    }
  }
}
