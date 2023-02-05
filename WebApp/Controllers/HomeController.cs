using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            var welcomeMessage = "The path to laboratory work: /lab<number>\nexample: /lab1";
            return welcomeMessage;
        }        
    }
}
