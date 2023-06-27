 using System;
using CustomersControlMVC.Data;

namespace CustomersControlMVC.Models
{
	public class CustomerModel
	{
		public int Id { get; set; }

		public string? Name { get; set; }

		public string? Address { get; set; }

		public string? ContactNumber { get; set; }

        public string? Email2 { get; set; }

        public CustomerModel()
        {

        }

        public CustomerModel(int id, string? name, string? address, string? contactNumber, string? email2)
        {
            Id = id;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
            Email2 = email2;
        }
    }
}

