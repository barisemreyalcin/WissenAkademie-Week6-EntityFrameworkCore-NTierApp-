using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.Domain
{
    public class FilmDetail : BaseClass
    {
        public string FilmPlot {  get; set; }
        // FK
        public int FilmID{  get; set; }
        // FK
        public Film Film {  get; set; }

    }
}
