using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BonjourASP.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<select name='lang'>" +
                "<option value='eng' selected='selected'>English</option>" +
                "<option value='frn'>French</option>" +
                "<option value='jap'>Japanese</option>" +
                "<option value='chn'>Chinese(Mand)</option>" +
                "<option value='spn'>Spanish</option>" +
                "</select>" +
                "<input type='submit' value='Greet me!'>" +
                "</form>";

            return Content(html, "text/html");
        }

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Greet(string greeting = "Hello", string name = "World", string lang = "eng")
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "World";
            }

            if (lang == "eng") {
                greeting = "Hello";
            }

            else if (lang == "frn")
            {
                greeting = "Bonjour";
            }

            else if (lang == "jap")
            {
                greeting = "Konnitiwa";
            }

            else if (lang == "chn")
            {
                greeting = "Nihao";
            }

            else if (lang == "spn")
            {
                greeting = "Ola";
            }

            return Content(string.Format("<h1><em>{0}</em>, {1}!</h1>", greeting, name),"text/html");
        }
    }
}
