using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace huffman
{
    internal class HuffmanMessage
    {
        private bool[] message;

        private Dictionary<bool[], char> table;

        [JsonPropertyName("message")]
        public bool[] Message { get => message; }

        public HuffmanMessage(bool[] message, Dictionary<bool[], char> table)
        {
            this.message = message;
            this.table = table;
        }

        public override string ToString()
        {
            string str = "";
            foreach (bool c in message)
                str += c ? "1" : "0";
            return str;
        }

        private char? SearchForChar(bool[] arg)
        {
            bool found = false;
            char? foundChar = null;
            List<bool[]> keys = new();
            foreach (bool[] b in table.Keys)
                keys.Add(b);
            int i = 0;
            while (i< keys.Count() && foundChar == null)
            {
                if (areEquals(keys[i],arg))
                    foundChar = table[keys[i]];
                i++;
            }
            return foundChar;
        }

       private bool areEquals(bool[] b1, bool[] b2)
        {
            if (b1.Length != b2.Length)
                return false;
            int i=0;
            bool isSame = true;
            while (i < b1.Length && isSame)
            {
                isSame = b1[i] == b2[i];
                i++;
            }
            return isSame;
        }

        public string Decompress()
        {
            string str="";
            int i;
            i = 0;
            List<bool> messageKey = new();
            while(i< message.Length)
            {
                messageKey.Add(message[i]);
                char? tmpChar = SearchForChar(messageKey.ToArray());
                if ( tmpChar != null)
                {
                    str += tmpChar;
                    messageKey.Clear();
                }
               
                i++;
            }
            return str;
        }

    }
}
