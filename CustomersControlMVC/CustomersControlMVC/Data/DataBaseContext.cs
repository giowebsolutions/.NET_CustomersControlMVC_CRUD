using System;
using CustomersControlMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomersControlMVC.Data
{
	public class DataBaseContext : DbContext
	{
		public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
		{}

		public DbSet<CustomerModel> Customer { get; set; }
	}
}

