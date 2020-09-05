using System;
using System.Collections.Generic;

namespace DelegateCompilerSample.Core
{
  public class Order
  {
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public virtual IEnumerable<OrderLine> OrderLines
    {
      get { return _lines; }
    }

    protected ICollection<OrderLine> _lines { get; private set; }
  }
}