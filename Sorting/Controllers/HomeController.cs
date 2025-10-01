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
            model.Sorted = new List<string> { "asc", "desc" };
            return View(model);
        }
        [HttpPost]

        public IActionResult Index(IndexViewModel model)
        {
            string[] names = model.Names.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> nameList = names.ToList();

            model.Sorted = model.SortOrder == "asc" ?
            nameList.OrderBy(n => n).ToList() :
            nameList.OrderByDescending(n => n).ToList();
            return View(model);
        }
    }
}
