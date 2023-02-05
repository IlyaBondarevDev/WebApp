using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class Lab1Controller : Controller
    {
        public string Index(int number)
        {
            var name = "Bondarev Ilya Valeryevich";
            return string.Format("Hello, {0}, today is {1:dd.MM.yyyy}", name, DateTime.Now);
        }
    }
}
