using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huffman
{
    internal class Letter : Content
    {
        private char hisChar;
        private uint hisWeight;
        public uint HisWeight { get => hisWeight; }
        public char HisChar { get => hisChar; }

        public Letter(char hisChar, uint hisWeight)
        {
            this.hisChar = hisChar;
            this.hisWeight = hisWeight;
        }

        public override uint GetWeight()
        {
            return hisWeight;
        }


        public override string ToString()
        {
            return String.Format("{0}({1})", hisChar, hisWeight);
        }

        public override string ToHTML()
        {
            return String.Format("<li>{0}</li>", ToString());
        }

        public override bool Equals(object o)
        {
            if (o is Letter)
            {
                Letter l = o as Letter;
                return (l.hisChar == this.hisChar && l.hisWeight == this.hisWeight);
            }
            return false;

        }
    }
}
