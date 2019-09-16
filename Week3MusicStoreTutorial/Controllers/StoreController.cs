using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Week3MusicStoreTutorial.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Hello World from Store.Index()");
        }

        public IActionResult Browse(string genre)
        {
            genre = HttpUtility.HtmlEncode("Store.Browse, genre = " + genre);

            return Ok(genre);
            //return Ok("Result = " + (x * y));

        }
        public IActionResult Details(int id)
        {

            return Ok(id.ToString());
        }


    }
}