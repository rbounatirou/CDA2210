using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huffman
{
    internal abstract class Content
    {
        protected Content hisParent;
        public abstract uint GetWeight();
        public abstract string ToHTML();

        public bool setParent(Content parent)
        {
            if (hisParent == null)
            {
                hisParent = parent;
                return true;
            }
            return false;
                
        }

        public abstract bool Equals(object o);
        public Content[] getParents()
        {
            List<Content> parents = new();
            if (hisParent != null)
            {
                parents.AddRange(hisParent.getParents());
                parents.Add(hisParent);
            }            
            return parents.ToArray();
        }

        public virtual Content left()
        {
            return null;
        }

        public virtual Content right()
        {
            return null;
        }



        public abstract List<bool[]> GetAllPath(out List<char> letters);
        public abstract List<bool[]> GetAllPath();
    }
}
