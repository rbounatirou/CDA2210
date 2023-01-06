﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace huffman
{
    internal class Branch : Content, ICompressable
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




        public override List<bool[]> GetAllPath(out List<char> letters)
        {
            letters = new();
            List<char> previousLetter = new();
            List<bool[]> path = new();
            for (int i = 0; i < content.Count(); i++)
            {
                List<bool[]> path2 = content[i].GetAllPath(out previousLetter);
                if (previousLetter.Count() != null)
                    letters.AddRange(previousLetter);
                if (path2 != null)
                {
                    
                    for (int j = 0; j < path2.Count(); j++)
                    {
                        List<bool> pathTmp = new();
                        pathTmp.AddRange(path2[j]);
                        pathTmp.Insert(0, i == 0);
                        path.Add(pathTmp.ToArray());
                       
                    }
                }
                else
                {
                    path.Add(new bool[] { i == 0 });
                    
                }
            }
            return path;
        }

        public override List<bool[]> GetAllPath()
        {

            List<char> previousLetter = new();
            List<bool[]> path = new();
            for (int i = 0; i < content.Count(); i++)
            {
                List<bool[]> path2 = content[i].GetAllPath();

                if (path2 != null)
                {

                    for (int j = 0; j < path2.Count(); j++)
                    {
                        List<bool> pathTmp = new();
                        pathTmp.AddRange(path2[j]);
                        pathTmp.Insert(0, i == 0);
                        path.Add(pathTmp.ToArray());

                    }
                }
                else
                {
                    path.Add(new bool[] { i == 0 });

                }
            }
            return path;
        }

        public Dictionary<char, bool[]> MakeCompressDictionary()
        {
            List<char> chars = new();
            List<bool[]> path= GetAllPath(out chars);
            if (chars.Count() != path.Count())
                return null;
            Dictionary<char, bool[]> rt = new Dictionary<char, bool[]>();
            for (int i = 0; i < chars.Count(); i++)
            {
                rt.Add(chars[i], path[i]);
            }
            return rt;
        }

        public Dictionary<bool[], char> MakeUncompressDictionary()
        {
            List<char> chars = new();
            List<bool[]> path = GetAllPath(out chars);
            if (chars.Count() != path.Count())
                return null;
            Dictionary<bool[], char> rt = new Dictionary<bool[], char>();
            for (int i = 0; i < chars.Count(); i++)
            {
                rt.Add(path[i], chars[i]);
            }
            return rt;
        }
    }
}