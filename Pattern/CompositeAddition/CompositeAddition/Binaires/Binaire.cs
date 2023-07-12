using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeAddition.Binaires
{
    public abstract class Binaire : Expression
    {
        protected IExpression expression1;
        protected IExpression expression2;
        public Binaire(IExpression ex1, IExpression ex2)
        {
            expression1 = ex1;
            expression2 = ex2;
        }
    }
}
