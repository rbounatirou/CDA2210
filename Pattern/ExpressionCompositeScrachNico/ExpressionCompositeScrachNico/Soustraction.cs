using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionCompositeScrachNico
{
    public class Soustraction : Opperation
    {
        public Soustraction(IExpression g, IExpression d) : base(g, d)
        {
        }

        public override double GetValue()
        {
            return sonExpressionGauche.GetValue() - sonExpressionDroite.GetValue();
        }
    }
}
