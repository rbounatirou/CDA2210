using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternDecoratorPizza
{
    public abstract class Decorator : IDecoratorPizza
    {
        protected IDecoratorPizza sonIDecorator;

        public Decorator(IDecoratorPizza _idecorrator)
        {
            this.sonIDecorator = _idecorrator;
        }

        public abstract string SePresenter();
    }
}
