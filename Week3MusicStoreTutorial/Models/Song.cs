using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Week3_MusicStoreTutorial.Models;

namespace Week3MusicStoreTutorial.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }
        [ForeignKey("Album")]
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public string ArtistName { get; set; }
        public string Featuring { get; set; }
        public int RunTimeSeconds { get; set; }
        public Album Album { get; set; }
    }
}
