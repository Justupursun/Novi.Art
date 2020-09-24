using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Novi.Art.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Novi.Art.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string CustomProperty { get; set; }

        [ViewData]
        public string Title { get; set; }

        [ViewData]
        public ArtModel Art { get; set; }



        public ViewResult Index()
        {

            //Art = new ArtModel()
            //{
            //    Id = 33,
            //    Title = "Nieuwe kunst",
            //    Artist = "Martijn"
            //};
             
            //CustomProperty = "Dit is een customproperty of the homecontroller property";
            //Title = "Home";

            //// Viewbags
            ////     Gets or sets Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary used by
            ////     Microsoft.AspNetCore.Mvc.ViewResult and Microsoft.AspNetCore.Mvc.Controller.ViewBag.

            //// 1:
            //dynamic data = new ExpandoObject();
            //data.Id = 1;
            //data.name = "Martijn";
            //ViewBag.Data = data;
            //// 2:
            //ViewBag.Type = new ArtModel()
            //{
            //    Id = 5, Artist = "Martijn"
            //};

            // ViewData:
            // Propery of ViewDataDictionary
            //     Gets or sets Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary used by
            //     Microsoft.AspNetCore.Mvc.ViewResult and Microsoft.AspNetCore.Mvc.Controller.ViewBag.
            // public class ViewDataDictionary : ICollection<KeyValuePair<string, object>>

            ViewData["property1"] = "Martijn Terstappen";


            return View();
        }
        public ViewResult AboutUs()
        {
            Title = "About us";

            return View();
        }
        public ViewResult ContactUs()
        {
            Title = "Contact us";

            return View();
        }
    }
}
