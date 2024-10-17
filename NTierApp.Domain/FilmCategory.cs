using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.Domain
{
    public class FilmCategory : BaseClass
    {
        public string CategoryName { get; set; }

        // Bire sonsuz
        public ICollection<Film> Films { get; set; }
    }
}
