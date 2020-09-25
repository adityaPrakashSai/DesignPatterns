using System;
using System.Collections.Generic;
using Domain;

namespace Service
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICacheStorage _cacheStorage;

        public CustomerService(ICustomerRepository customerRepository, ICacheStorage cacheStorage)
        {
            this._customerRepository = customerRepository;
            this._cacheStorage = cacheStorage;
        }

        public IList<Customer> GetAllCustomers()
        {
            string storageKey = "GetAllCustomers";
            IList<Customer> customers = _cacheStorage.Retrieve<List<Customer>>(storageKey);
            if (customers == null)
            {
                customers = _customerRepository.GetCustomers();
                _cacheStorage.Store(storageKey, customers);
            }

            return customers;
        }
    }
}
