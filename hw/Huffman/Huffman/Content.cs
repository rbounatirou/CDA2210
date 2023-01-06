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

        public bool setParent(Content parent)
        {
            if (hisParent == null)
            {
                hisParent = parent;
                return true;
            }
            return false;
                
        }
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

        public abstract List<bool[]> GetAllPath(out List<char> letters);
        public abstract List<bool[]> GetAllPath();
    }
}
