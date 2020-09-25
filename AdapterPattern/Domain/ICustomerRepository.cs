using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface ICustomerRepository
    {
        IList<Customer> GetCustomers();
    }
}
