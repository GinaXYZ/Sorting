using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sorting.Models;

namespace Sorting.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Sorted = string.Empty;
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(IndexViewModel model)
        {
            string[] names = model.Names.Split(new char[] { ',', ' ', '\r', '\n' });

            if (model.SortOrder == "asc")
            {
                model.Sorted = string.Join(Environment.NewLine, names.OrderBy(n => n));
            }
            else
            {
                model.Sorted = string.Join(Environment.NewLine, names.OrderByDescending(n => n));
            }


            return View(model);
        }
    }
}
