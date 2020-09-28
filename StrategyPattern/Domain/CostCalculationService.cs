using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Code to demonstrate
    /// strategy pattern
    /// </summary>
    public class CostCalculationService
    {
        private readonly IShippingStrategy _shippingStrategy;

        public CostCalculationService(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public double CalculateShippingCost(Order order)
        {
            return _shippingStrategy.Calculate(order);
        }
    }
}
