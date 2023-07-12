using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeAddition
{
    public class Nombre : Expression
    {
        private double value;

        public Nombre(double _value)
        {
            this.value = _value;
        }

        public override double Calculer()
        {
            return value;
        }


        public override string GetShortString()
        {
            return value.ToString();
        }
    }
}
