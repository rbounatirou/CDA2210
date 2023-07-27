using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternDecoratorPizza
{
    public class Tomato : Decorator
    {
        public Tomato(IDecoratorPizza _idecorrator) : base(_idecorrator)
        {
        }

        public override string SePresenter()
        {
            return sonIDecorator.SePresenter() + ", avec de la tomate";
        }
    }
}
