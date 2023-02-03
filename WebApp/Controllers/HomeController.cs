using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            var dateNameInfo = new DateNameModel("Bondarev Ilya Valeryevich");
            return string.Format("Hello {0}, today is {1:d}",
                dateNameInfo.Name, dateNameInfo.CurrentDate);
        }

        public string Error()
        {
            return "Page not found";
        }
    }
}
