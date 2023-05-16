using ApiBank.Models;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace ApiBank.WebApp.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NamedView()
        {
            return View("MaView");
        }

        public IActionResult DataView()
        {
            ViewBag.title = "How dare you?";
            ViewBag.desc = "You've stollen my dream with your empty words";
            return View();
        }

        public IActionResult ModelView()
        {
            BankTransaction transaction = new()
            {
                Id = 1,
                TransactionDate = DateTime.Now,
                TransactionFrom = "99999999999",
                TransactionTo = "88888888888",
                TransactionAmount = Convert.ToDecimal(125.10)
            };
            return View(transaction);
        }


    }
}
