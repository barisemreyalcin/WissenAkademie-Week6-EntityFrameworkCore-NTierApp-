using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.Domain
{
    public class ActorFilm : BaseClass
    {
        public int WorkingDays { get; set; }
        public int ActorID { get; set; }
        public Actor Actor { get; set; }
        public int FilmID { get; set; }
        public Film Film { get; set; }
    }
}
