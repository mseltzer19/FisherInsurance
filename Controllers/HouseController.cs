using System;
using FisherInsurance.Models;
using Microsoft.AspNetCore.Mvc;
public class HouseController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Quote()
    {
        Quote quote = new Quote 
 { 
            Id = 345, 
            Product = "Home Insurance", 
            ExpireDate = DateTime.Now.AddDays(45), 
            Price = 45.00M 
        }; 
 
        return View(quote);
    }
}
