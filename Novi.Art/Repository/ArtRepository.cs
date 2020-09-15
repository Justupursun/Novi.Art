using Novi.Art.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novi.Art.Repository
{
    public class ArtRepository
    {
       
        public List<ArtModel> GetAllArt()
        {
            return Datasource();
        }

        public ArtModel GetArtById(int id)
        {
            return Datasource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<ArtModel> SearchArt(string title, string artist)
        {
            return Datasource().Where(x => x.Title.Contains(title) && x.Artist.Contains(artist)).ToList();
        }

        // Data declared ina private methode
        private List<ArtModel> Datasource()
        {
            return new List<ArtModel>()
            {
                new ArtModel(){Id=1, Title="Lovecouple", Artist="Martijn Terstappen", Description="This section will be used to display the short description of art-piece", Price=10.50M, Category="Painting", InStock=true, ImageUrl=""},
                new ArtModel(){Id=2, Title="Abstract", Artist="Jantje", Description="This section will be used to display the short description of art-piece", Price=10.50M, Category="Painting", InStock=false, ImageUrl=""},
                new ArtModel(){Id=3, Title="Eifeltower", Artist="Pietje", Description = "This section will be used to display the short description of art-piece", Price=10.50M, Category="sculptor ", InStock=false, ImageUrl=""},
                new ArtModel(){Id=4, Title="David", Artist="Klaasje", Description = "This section will be used to display the short description of art-piece", Price=10.50M, Category="sculptor ", InStock=true, ImageUrl=""},
            };
        }


    }
}
