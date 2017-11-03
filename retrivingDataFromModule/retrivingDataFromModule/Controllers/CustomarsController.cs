using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using retrivingDataFromModule.Models;
using retrivingDataFromModule.ViewModel;
namespace retrivingDataFromModule.Controllers
{
    public class CustomarsController : Controller
    {
        // GET: Customar
        public ActionResult Index()
        {
            Customar customar = new Customar()
            {
                
                Name="Basudev",
                city= "Lalitpur"

            };

            IndexCustomarViewModel viewModel = new IndexCustomarViewModel()
            {
                Name = customar.Name,
                city=customar.city
            };
            return View(viewModel);
        }
    }
}