using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace huffman
{
    internal class HuffmanMessage
    {
        private bool[] message;

        private Dictionary<bool[], char> table;

        private int size;

        [JsonPropertyName("message")]

        public string Message { get => MessageToString(); }



        //public Dictionary<List<bool>, char> Table { get => MakeTreeWithList(); }
        [JsonPropertyName("table")]
        public Dictionary<string, char> Table { get => MakeDifferentTree(); }

        private Dictionary<List<bool>, char> MakeTreeWithList()
        {
            Dictionary<List<bool>, char>  rt= new Dictionary<List<bool>, char>();

            for (int i = 0; i < table.Count(); i++)
            {
                rt.Add(table.Keys.ElementAt(i).ToList(), table.Values.ElementAt(i));
            }
            return rt;
        }

        [JsonPropertyName("size")]
        public int Size { get => size; }
        public HuffmanMessage(bool[] message, Dictionary<bool[], char> table)
        {
            this.message = message;
            this.table = table;
            this.size = message.Length;
        }

        [JsonConstructor]
        public HuffmanMessage(int size ,string message, Dictionary<string, char> table)
        {
 
            this.size = size;
            this.table = MakeDifferentTree(table);
            this.message = MessageToBoolTable(message);
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

        private Dictionary<string, char> MakeDifferentTree()
        {

            Dictionary<string, char> rt = new Dictionary<string, char>();
            for (int i = 0; i < table.Count(); i++)
            {
                rt.Add(ConvertBoolTableToString(table.Keys.ElementAt(i)), table.Values.ElementAt(i));
            }

            return rt;
        }

        private string ConvertBoolTableToString(bool[] tab)
        {
            string str = "";
            foreach (bool b in tab)
                str += (b ? "1" : "0");
            return str;
        }

        private bool[] ConvertStringToBoolTable(string s)
        {
            List<bool> rt = new();
            foreach (char c in s)
            {
                if (c == '0' || c=='1')
                {
                    rt.Add(c == '1');
                } else
                {
                    throw new Exception("Erreur");
                }
            }
            return rt.ToArray();
        }

        private Dictionary<bool[], char> MakeDifferentTree(Dictionary<string, char> d)
        {
            Dictionary<bool[], char> rt = new Dictionary<bool[], char>();
            for(int i = 0; i < d.Count(); i++)
            {
                rt.Add(ConvertStringToBoolTable(d.Keys.ElementAt(i)), d.Values.ElementAt(i));
            }
            return rt;
        }

        private string MessageToString()
        {
            int BitsToAdd = (8 - message.Length%8) % 8;
            List<bool> messageBool = new();
            List<byte> byteActuel = new();
            string str = "";
            messageBool.AddRange(message);
            for (int i = 0; i < BitsToAdd; i++)
                messageBool.Add(false);

            for (int i = 0; i < messageBool.Count(); i+= 8)
            {
                bool[] currentBits = messageBool.GetRange(i, 8).ToArray();
                byteActuel.Add(BoolTableToByte(currentBits));
            }

            return System.Text.Encoding.Unicode.GetString(byteActuel.ToArray());
        }

        private bool[] MessageToBoolTable(string message)
        {
            byte[] byteMessage = Encoding.Unicode.GetBytes(message);
            List<bool> bools = new();
            for (int i = 0; i < byteMessage.Length; i++)
            {
                bools.AddRange(ByteToBoolArray(byteMessage[i]));
            }
            return bools.GetRange(0, size).ToArray();
        }

        private bool[] ByteToBoolArray(byte b)
        {
            bool[] rt = new bool[8];
            for (int i = 0; i < 8; i++)
            {
                rt[i] = (b & (1 << (7-i))) != 0;
            }
            return rt;
        }

        private byte BoolTableToByte(bool[] b)
        {

            if (b.Length != 8)
                throw new Exception("err");
            byte val = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i])
                    val += (byte)(1 << (7 - i));//(byte)Math.Pow(2, 7-i);
            }
            return val;
        }


    }
}
