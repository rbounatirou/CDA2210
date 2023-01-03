using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huffman
{
    internal interface ICompressable
    {
        public abstract Dictionary<char, bool[]> MakeCompressDictionary();

        public abstract Dictionary<bool[], char> MakeUncompressDictionary();
    }
}
