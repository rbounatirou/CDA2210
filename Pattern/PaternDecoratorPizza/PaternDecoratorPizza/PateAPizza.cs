using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternDecoratorPizza
{
    public class PateAPizza : IDecoratorPizza
    {

        bool estEpaisse;
        
        public PateAPizza(bool estEpaisse)
        {
            this.estEpaisse = estEpaisse;
        }
        public string SePresenter()
        {
            return "Je suis une pate à pizza " + (estEpaisse ? "épaisse" : "fine");
        }
    }
}
