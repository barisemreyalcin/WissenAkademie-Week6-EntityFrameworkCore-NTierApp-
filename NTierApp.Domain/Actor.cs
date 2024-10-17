using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.Domain
{
    public class Actor : BaseClass
    {
        public string ActorName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Biography { get; set; }
    }
}
