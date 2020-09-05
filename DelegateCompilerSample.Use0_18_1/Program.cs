using System;
using System.Linq;
using DelegateCompilerSample.EF;

namespace DelegateCompilerSample.Use0_18_1
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var ctx = new Context())
      {
        var orders = ctx.Orders.ToList();
        Console.WriteLine($"{orders.Count} order(s) found");
      }
    }
  }
}
