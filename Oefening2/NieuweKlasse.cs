using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class NieuweKlasse
    {
        public String testObject { get; set; }
        public NieuweKlasse(string testObject)
        {
            this.testObject = testObject;

        }

        public override string ToString()
        {
            return this.testObject;
        }
    }
}
