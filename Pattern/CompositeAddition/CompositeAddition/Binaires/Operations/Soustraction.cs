using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CompositeAddition.Binaires.Operations
{
    public class Soustraction : Binaire
    {
        public Soustraction(IExpression ex1, IExpression ex2) : base(ex1, ex2)
        {
        }

        public override double Calculer()
        {
            return expression1.Calculer() - expression2.Calculer();
        }

        public override string GetShortString()
        {
            return String.Format("({0}-{1})", expression1.GetShortString(), expression2.GetShortString());
        }
    }
}
