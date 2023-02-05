using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var dateNameInfo = new UserModel("Bondarev Ilya Valeryevich", 21);
            return View(dateNameInfo);
        }

        [HttpGet]
        public JsonResult Get()
        {
            return Json(new
            {
                name = "Bondarev Ilya Valeryevich",
                value = BigInteger.Parse("876846846847668768768768768").ToString(),
            });
        }
    }
}
