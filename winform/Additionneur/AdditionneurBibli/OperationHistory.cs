using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AdditionneurBibli
{
    public class OperationHistory
    {
        List<Addition> addition = new();
        
        public OperationHistory()
        {
            addition.Add(new Addition());
        }

        public OperationHistory(string str)
        {
            string[] split = str.Split("=");
            for (int i = 0; i < split.Length; i++)
            {
                addition.Add(Addition.Parse(split[i]));
            }
        }

        public void Clear()
        {
            addition.Clear();
            AddNewAddition();
        }

        public void AddNumberInCurrentOperation(int nombre)
        {
            if (addition.Count == 0)
                addition.Add(new Addition());
            addition[addition.Count() - 1].AjouterNombre(nombre);
        }

        public void AddNewAddition()
        {            
            if (addition.Count() > 0)
            {
                int lastNumber;
                Addition add = addition[addition.Count() - 1];
                if (add.Length >= 1)
                {
                    addition.Add(new Addition(add.GetResult()));
                } else
                {
                    addition.Add(new Addition());
                }
            } else
            {
                addition.Add(new Addition());
            }            
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < addition.Count(); i++)
            {
                str+= (i > 0? Environment.NewLine : "") + (i < addition.Count() -1 ? addition[i].ToString() : addition[i].PartieGaucheAddition());
            }
            return str;
        }
    }
}
