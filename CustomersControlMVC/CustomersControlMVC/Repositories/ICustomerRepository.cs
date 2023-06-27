using System;
using CustomersControlMVC.Models;

namespace CustomersControlMVC.Repositories
{
	public interface ICustomerRepository
	{
		CustomerModel Add(CustomerModel customer);

		List<CustomerModel> FetchAll();

		CustomerModel ListById(int id);

		CustomerModel Update(CustomerModel customer);

		bool Delete(int id);
	}
}

