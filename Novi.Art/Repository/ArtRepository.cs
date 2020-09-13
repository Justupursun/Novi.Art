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
                new ArtModel(){Id=1, Title="Lovecouple", Artist="Martijn Terstappen"},
                new ArtModel(){Id=2, Title="Abstract", Artist="Jantje"},
                new ArtModel(){Id=3, Title="Eifeltower", Artist="Pietje"},
                new ArtModel(){Id=4, Title="David", Artist="Klaasje"},
            };
        }


    }
}
