using System;
using System.Collections.Generic;
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
            //Branch firstBranch = new Branch(new Letter(occurences[order[0]))
            Content tree = MakeHuffmanTree(letter, occurences);
            return new HuffmanMessage("",tree);
        }

        private static int SearchLetterInList(char letterToSearch, List<char> listToSearch)
        {
            int i=0;
            while (i < listToSearch.Count() && listToSearch[i] != letterToSearch ) {
                i++;
            }
            return (i < listToSearch.Count() ? i : -1);
        }

        /*private static List<uint> BubbleSort(List<Content> compare)
        {
            List<uint> rt = new();
            compare = new List<Content>(compare);
            for (uint i = 0; i < compare.Count(); i++)
                rt.Add(i);
            for (int i = 0; i < compare.Count() - 1; i++)
            {
                for (int j = i; j < compare.Count(); j++)
                {
                    if (compare[j].GetWeight() < compare[i].GetWeight()) {
                        Content tmpVal = compare[j];
                        uint tmpIt = rt[j];
                        compare[j] = compare[i];
                        compare[i] = tmpVal;
                        rt[j] = rt[i];
                        rt[i] = tmpIt;
                    }
                }
            }
            return rt;
        }*/

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

        private static Content MakeHuffmanTree(List<char> letter, List<uint> weight)
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
            
            return tree[0];
        }



        
    }
}
