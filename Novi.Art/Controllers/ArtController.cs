using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Novi.Art.Controllers
{
    public class ArtController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public string GetAllArts()
        {
            return "All pieces of art";
        }

        public string GetArt(int id)
        {
            return $"Piece of Art with id = {id}";
        }

        public string SearchArt(string artName, string artistName)
        {
            // http://localhost:57536/art/searchart?artname=deschreeuw&artistname=Martijn
            return $"Found art with name = {artName} and artist {artistName}";
        }
    }
}
