using System;
using System.Collections.Generic;
using Domain;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public IList<Customer> GetCustomers()
        {
            return new List<Customer>();
        }
    }
}
