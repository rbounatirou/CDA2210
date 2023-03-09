using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionneurBibli
{
    public class Addition
    {
        private List<int> numbers;

        public int Length { get => numbers.Count();  }
        public Addition(){
            numbers = new();
        }


        public Addition(Addition add) :  this(add.numbers) { }


        public Addition(int _number)
        {
            numbers = new();
            numbers.Add(_number);
        }

        public Addition(int[] _numbers)
        {
            numbers = new();
            for (int i = 0; i < _numbers.Length; i++)
            {
                numbers.Add(_numbers[i]);
            }
        }
        
        public Addition(List<int> _numbers) : this(_numbers.ToArray())
        {
        }


        public void AjouterNombre(int n)
        {
            numbers.Add(n);
        }

        public string PartieGaucheAddition()
        {
            string str = "";
            for (int i = 0; i < numbers.Count; i++)
            {

                str += (i > 0 ? "+" : "") + numbers[i];
            }
            return str;
        }

 


        public int GetResult()
        {
            int result = 0;
            for (int i = 0; i < numbers.Count(); i++)
            {
                result += numbers[i];
            }
            return result;
        }

        public override string ToString()
        {
            return PartieGaucheAddition() + "=" + GetResult();
        }

        public static Addition Parse(string _str)
        {
            List<int> nbs = new();
            string[] nb = _str.Split("+");
            for (int i = 0; i < nb.Length; i++)
            {
                int a;
                if (int.TryParse(nb[i], out a))
                    nbs.Add(a);
            }
            return new Addition(nbs.ToArray());
        }

        public void Clear()
        {
            numbers.Clear();
        }
    }
}
