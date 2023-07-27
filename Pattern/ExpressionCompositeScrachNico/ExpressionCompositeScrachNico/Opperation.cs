using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionCompositeScrachNico
{
    public abstract class Opperation : IExpression
    {

        protected IExpression sonExpressionGauche;
        protected IExpression sonExpressionDroite;

        public Opperation(IExpression g, IExpression d)
        {
            sonExpressionDroite = d;
            sonExpressionGauche = g;
        }

        public abstract double GetValue();
    }
}
