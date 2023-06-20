using allari_project.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace allari_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult PlantsTable()
        {
            _logger.LogInformation("Loading Plants Table");
            List<Plant> plants = new List<Plant>();

            using (StreamReader r = new StreamReader("wwwroot/data/plants.json"))
            {
                string json = r.ReadToEnd();
                plants = JsonConvert.DeserializeObject<List<Plant>>(json) ?? new List<Plant>();
                
            }

            return PartialView("_PlantsTable", plants);
        }
    }
}