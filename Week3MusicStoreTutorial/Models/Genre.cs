using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week3_MusicStoreTutorial.Models;

namespace Week3MusicStoreTutorial.Models
{
    public class Genre
    {
        public int GenreId { get; set; }

        public string Name { get; set; }
        public ICollection<Album> Albums{ get; set;}
    }
}
