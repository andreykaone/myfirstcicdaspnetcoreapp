using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloThere.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace HelloThere.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public async Task<IActionResult> Games()
        {
            ViewData["Message"] = "Your game page.";
            string data = "";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("http://worldclockapi.com/api/json/est/now");
                    response.EnsureSuccessStatusCode();
                    data = await response.Content.ReadAsStringAsync();
                }
                catch (HttpRequestException e)
                { //ignore
                }

                //var model = JsonConvert.DeserializeObject<Model>(data);
                ViewData["CurrentTime"] = JsonConvert.DeserializeObject<Model>(data);

                //ViewData["CurrentTime"] = model;



                return View("Games");
            }
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
    }
}
