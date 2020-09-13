using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Novi.Art.Models;
using Novi.Art.Repository;

namespace Novi.Art.Controllers
{

    public class ArtController : Controller
    {
        private readonly ArtRepository _artRepository = null;

      // Constructor
        public ArtController()
        {
            _artRepository = new ArtRepository();
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public List<ArtModel> GetAllArts()
        {
            //   return "All pieces of art";
            return _artRepository.GetAllArt();
        }

        public ArtModel GetArt(int id)
        {
            return _artRepository.GetArtById(id);
        }

        public List<ArtModel> SearchArt(string artName, string artistName)
        {
            // http://localhost:57536/art/searchart?artname=deschreeuw&artistname=Martijn
            //return $"Found art with name = {artName} and artist {artistName}";
            return _artRepository.SearchArt(artName, artistName);
        }
    }
}
