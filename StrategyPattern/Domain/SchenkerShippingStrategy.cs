using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class SchenkerShippingStrategy : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 3.00d;
        }
    }
}
