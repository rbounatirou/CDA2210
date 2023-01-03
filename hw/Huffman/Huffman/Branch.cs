﻿using System;
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
            a.setParent(this);
            
        }

        public Branch(Content a, Content b) { 

            content = new List<Content>(){ a, b };
            a.setParent(this);
            b.setParent(this);
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

        public override uint GetWeight()
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

        public override string ToHTML()
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

        public T[] GetElementByType<T>() where T: Content
        {
            List<T> type = new();
            foreach (Branch b in content.OfType<Branch>())
                type.AddRange(b.GetElementByType<T>());
            foreach (T t in content.OfType<T>())
                type.Add(t);
            return type.ToArray();
        }

        public override bool Equals(object o)
        {
            if (o is Branch)
            {
                Branch b = o as Branch;
                if (b.content.Count() == this.content.Count())
                {
                    bool areEquals = true;
                    int i = 0;
                    while (i<b.content.Count() && areEquals)
                    {
                        areEquals = this.content[i].Equals(b.content[i]);
                        i++;
                    }
                    return areEquals;
                }
                return false;
            }
            return false;
        }
    }
}
