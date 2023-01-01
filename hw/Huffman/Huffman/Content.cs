using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huffman
{
    internal interface Content
    {
        public abstract uint GetWeight();
        public abstract string ToHTML();
    }
}
