using System;
using CustomersControlMVC.Data;
using CustomersControlMVC.Models;

namespace CustomersControlMVC.Repositories
{
	public class CustomerRepository : ICustomerRepository
	{
        private readonly DataBaseContext _context;

		public CustomerRepository(DataBaseContext context)
		{
            _context = context;
		}

        public CustomerModel Add(CustomerModel customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public bool Delete(int id)
        {
            CustomerModel customerDB = ListById(id);

            if (customerDB == null) throw new Exception("Error while deleting customer");

            _context.Customer.Remove(customerDB);
            _context.SaveChanges();

            return true;

        }

        public List<CustomerModel> FetchAll()
        {
            return _context.Customer.ToList();
        }

        public CustomerModel ListById(int id)
        {
            CustomerModel customer = _context.Customer.FirstOrDefault(e => e.Id == id);
            return customer;
        }

        public CustomerModel Update(CustomerModel customer)
        {
            CustomerModel customerDB = ListById(customer.Id);

            if (customerDB == null) throw new Exception("Error while updating customer details");

            customerDB.Id = customer.Id;
            customerDB.Name = customer.Name;
            customerDB.Address = customer.Address;
            customerDB.Email2 = customer.Email2;

            _context.Customer.Update(customerDB);
            _context.SaveChanges();

            return customerDB;
        }
    }
}

