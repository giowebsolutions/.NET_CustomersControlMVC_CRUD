using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomersControlMVC.Models;
using CustomersControlMVC.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomersControlMVC.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<CustomerModel> customersList = _customerRepository.FetchAll();
            return View(customersList);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            CustomerModel customer = _customerRepository.ListById(id);
            return View(customer);
        }


        [HttpPost]
        public IActionResult Create(CustomerModel customer)
        {
            _customerRepository.Add(customer);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(CustomerModel customer)
        {
            _customerRepository.Update(customer);
            return RedirectToAction("Index");
        }

        public IActionResult ConfirmDelete(int id) {
            CustomerModel customer = _customerRepository.ListById(id);
            return View(customer);    
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _customerRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}

