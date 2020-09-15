using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novi.Art.Models
{
    public class ArtModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Artist { get; set; }

        public string Description { get; set; }
        
        public decimal Price { get; set; }
        
        public string ImageUrl { get; set; }

        public bool InStock { get; set; }

        //public string HireFrom { get; set; }

        //public string HireTill { get; set; }
 
        public string Category { get; set; }

        //public int StudentId { get; set; }
        //public Student student { get; set; }



    }
}
