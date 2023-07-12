using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeAddition
{
    public abstract class Expression : IExpression
    {
        public abstract double Calculer();

        public abstract string GetShortString();

        public string Formate()
        {
            return String.Format("{0}={1}", GetShortString(), Convert.ToString(Calculer()));
        }

    }
}
