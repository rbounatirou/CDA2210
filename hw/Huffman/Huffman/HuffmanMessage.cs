using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huffman
{
    internal class HuffmanMessage
    {
        private string message;
        private Content hisTree;

        public HuffmanMessage(string message, Content hisTree)
        {
            this.message = message;
            this.hisTree = hisTree;
        }

        public bool generateHTML(string path)
        {
            string text = "<html>\n\t<head></head>\n\t<body>\n\t\t<ul>" + hisTree.ToHTML() + "\n\t\t</ul>\n\t</body>\n</html>";
            try
            {
                File.WriteAllText(path, text);
                return true;
            } catch
            {
                return false;
            }
        }


    }
}
