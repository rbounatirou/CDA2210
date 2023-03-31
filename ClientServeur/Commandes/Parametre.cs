using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communications
{
    public class Parametre
    {
        public string key { get; private set; }
        public string value { get; private set; }

        public Parametre(string k, string v)
        {
            key = k;
            value = v;
        }

        public Parametre(Parametre p) : this(p.key, p.value) { }
    }
}
