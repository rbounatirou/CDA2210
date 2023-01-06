using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huffman
{
    internal static class HuffmanEncyptor
    {

        public static HuffmanMessage Encrypt(string str)
        { 
            List<char> letter = new();
            List<uint> occurences = new();
            for (int i = 0; i < str.Length; i++)
            {
                int idFound = SearchLetterInList(str[i], letter);
                if (idFound < 0)
                {
                    letter.Add(str[i]);
                    occurences.Add(1);
                } else
                {
                    occurences[idFound]++;
                }
            }
            Branch tree = MakeHuffmanTree(letter, occurences);
            Dictionary<char, bool[]> tableForHuffman = tree.MakeCompressDictionary();
            List<bool> strMessage = new();
            foreach(char c in str)
            {
                strMessage.AddRange(tableForHuffman[c]);
            }

            // test
            return new HuffmanMessage(strMessage.ToArray(), tree.MakeUncompressDictionary());

        }

        private static int SearchLetterInList(char letterToSearch, List<char> listToSearch)
        {
            int i=0;
            while (i < listToSearch.Count() && listToSearch[i] != letterToSearch ) {
                i++;
            }
            return (i < listToSearch.Count() ? i : -1);
        }



        private static int[] findTwoMins(List<Content> content)
        {
            if (content.Count() <= 1)
                return null;
            if (content.Count() == 2)
                return (content[0].GetWeight() <= content[1].GetWeight() ? 
                    new int[] { 0, 1 } : new int[] { 1, 0 });

            int min1, min2;
            min1 = 0;
            min2 = 1;
            for (int i = 1; i < content.Count(); i++)
            {
                if (content[i].GetWeight() < content[min1].GetWeight())
                {
                    int tmp = min1;
                    min1 = i;
                    min2 = tmp;
                } else if (content[i].GetWeight() < content[min2].GetWeight())
                {
                    min2 = i;
                }
            }
            return new int[]{ min1, min2};
        }

        private static Branch MakeHuffmanTree(List<char> letter, List<uint> weight)
        {
            if (letter.Count() != weight.Count())
                return null;
            if (letter.Count() == 1)
                return new Branch(new Letter(letter[0], weight[0]));
            List<Content> tree = new();
            for (int i = 0; i < letter.Count(); i++)
            {
                tree.Add(new Letter(letter[i], weight[i]));
            }
            
            while (tree.Count() > 1)
            {
                int[] mins = findTwoMins(tree);
                Content c1 = tree[mins[1]];
                Content c2 = tree[mins[0]];
                Branch tempBranch = new Branch(c1,c2);
                tree.Remove(c1);
                tree.Remove(c2);
                tree.Add(tempBranch);
            }
            
            return tree[0] as Branch;
        }

        private static bool[] SearchContentPathInParent(Content son)
        {
            Content[] parent = son.getParents();
            List<bool> rt = new();
            Content searchFor;
            for (int i = 0; i < parent.Length; i++)
            {
                searchFor = (i+1 < parent.Length ? parent[i+1] : son);
                Content[] sons = ((Branch)parent[i]).GetChildren(); // SI ERREUR DE CAST PROBLEME
                bool found = false;
                int j = 0;
                while(!found && j< sons.Length)
                {
                    found = sons[j].Equals(searchFor);
                    j++;
                }
                if (!found)
                    throw new Exception("not found");
                rt.Add(j == 1);
            }
            return rt.ToArray();
        }
    }
}
