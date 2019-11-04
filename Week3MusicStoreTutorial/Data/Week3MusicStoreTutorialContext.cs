using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Week3MusicStoreTutorial.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Week3_MusicStoreTutorial.Models
{
    public class Week3MusicStoreTutorialContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    { 
        public Week3MusicStoreTutorialContext (DbContextOptions<Week3MusicStoreTutorialContext> options)
            : base(options)
        {
        }

        public DbSet<Week3MusicStoreTutorial.Models.Genre> Genre { get; set; }

        public DbSet<Week3_MusicStoreTutorial.Models.Album> Album { get; set; }

        public DbSet<Week3MusicStoreTutorial.Models.Song> Song { get; set; }
    }
}
