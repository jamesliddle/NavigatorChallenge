using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NavigatorChallenge.Models;
using Newtonsoft.Json;

namespace NavigatorChallenge.Controllers
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

        public IActionResult OrderDisplay()
        {
            ViewData["Message"] = "Your order display page.";

            string storedResults1 = TempData["orderList"].ToString();
            string storedResults2 = TempData["totalLineItemsList"].ToString();
            string storedResults3 = TempData["totalAmountList"].ToString();

            List<Models.TestOrder.Orders> orderList = JsonConvert.DeserializeObject<List<Models.TestOrder.Orders>>(storedResults1);
            List<int> totalLineItemsList = JsonConvert.DeserializeObject<List<int>>(storedResults2);
            List<decimal> totalAmountList = JsonConvert.DeserializeObject<List<decimal>>(storedResults3);

            ViewData["totalLineItemsList"] = totalLineItemsList;
            ViewData["totalAmountList"] = totalAmountList;

            return View(orderList);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
