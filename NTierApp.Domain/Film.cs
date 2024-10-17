using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.Domain
{
    public class Film : BaseClass
    {
        public string FilmName { get; set; }
        public DateTime LastReleaseDate { get; set; }
        public int WatchingNumber { get; set; }
        public int CategoryID { get; set; }
        public FilmCategory FilmCategory { get; set; } // FK olacak sınıf
        public int FilmDetailID { get; set; }
        public FilmDetail FilmDetail { get; set; } 
        public ICollection<ActorFilm> FilmActors { get; set; }
    }
}
