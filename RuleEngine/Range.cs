using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuleEngine
{
  public class Range
  {
    private decimal _min;
    private decimal _max;

    public Range(decimal min, decimal max)
    {      
      _min = min;
      _max = max;
    }

    public bool IsInRange(int value)
    {
      return value >= _min && value <= _max;
    }
  }
}
