using KoreMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace KoreMvc.Controllers
{
    public class SampleController : Controller
    {
        //public string hello()
        //{
        //    return "Happy Valentine's Day";
        //}

        //public string hello(string name)
        //{
        //    return "Happy Valentine's Day dear " + name;
        //}

        //public string hello(string name, int no)
        //{
        //    return "Happy Valentine's Day dear " + name + "And you are the " + no + " Visitor";
        //}

        public IActionResult Index(string name,int no)
        {
            ViewData["name"] = name;
            ViewData["number"] = no;
            return View();
        }
        public IActionResult GetCustomer() {
            Customer cust = new Customer()
            { CustomerId = 123, CustomerName = "Joy", Gender = "Male", City = "Chennai",Region="India" };
            return View("CustomerDisplay", cust);

        }
        public IActionResult newcustomer()
        {
            return View();
        }
        public IActionResult submitcustomer(Customer customer)
        {
            return View("CustomerDisplay", customer);
        }

    }
}
