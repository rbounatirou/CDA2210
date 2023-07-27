using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionCompositeScrachNico
{
    public class Nombre : IExpression
    {
        private double value;

        public Nombre(double value)
        {
            this.value = value;
        }

        public double GetValue()
        {
            return this.value;
        }
    }
}
