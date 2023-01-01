using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace huffman
{
    internal class Branch : Content
    {
        private List<Content> content;
       


        public Branch(Content a)
        {

            content = new List<Content>(){ a };
            
        }

        public Branch(Content a, Content b) { 

            content = new List<Content>(){ a, b };
            
        }

        public Content[] GetChildren()
        {
            return content.ToArray();
        }

        public bool AddContent(Content a)
        {
            if (content.Count() < 2)
            {
                content.Insert(((content.Count() == 0 || a.GetWeight() > content[0].GetWeight()) ?  0:1),a);                
                return true;
            }
            return false;
        }

        public uint GetWeight()
        {
            uint sommeWeight = 0;
            for (int i = 0; i < content.Count(); i++)
                sommeWeight += content[i].GetWeight();
            return sommeWeight;
        }

        public override string ToString()
        {
            string str = "{";
            for (int i = 0; i < content.Count(); i++)
                str += content[i] + (i + 1 < content.Count() ? "," : ""); 
            str += "}(" + GetWeight() + ")";
            return str;
        }

        public string ToHTML()
        {
            string str = "<li>\n\t<font color=\"#ff0000\">total(" + GetWeight() + ")</font>" +
                "\n";
            str += "\n\t<ul>";
            for (int i = 0; i < content.Count(); i++)
            {
                str += "\n\t" + content[i].ToHTML();
            }
            str += "\n\t</ul>";
            str += "\n</li>";

            return str;
        }
    }
}
