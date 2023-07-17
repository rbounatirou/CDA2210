using CompositeFigure.Shapes.ConcreteShapes;
using CompositeFigure.Visiteur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFigureConsole
{
    public class VisiteurDeFigure : IVisiteurDeFigure<string>
    {
        public string VisiterCarre(Carre c)
        {
            string str = String.Format("La figure {0} a une position {1} un angle de {2} radian",
                "Carre", (c.Position == null ? "indefinie" : String.Format("x:{0}/y:{1}", c.Position.X, c.Position.Y)), c.AngleEnRadian);
            str += String.Format(" et un coté mesurant {0} mm", c.TailleCoteEnMM);
            return str;
        }

        public string VisiterEnsembleFigure(EnsembleFigure e)
        {
            string str = String.Format("La figure {0} a une position {1} un angle de {2} radian",
                "Ensemble de figure", (e.Position == null ? "indefinie" : String.Format("x:{0}/y:{1}", e.Position.X, e.Position.Y)), e.AngleEnRadian);
            str += String.Format(" et possede {0} figures ", e.Figures.Length);
            return str;
        }

        public string VisiterRond(Rond r)
        {
            string str = String.Format("La figure {0} a une position {1} un angle de {2} radian",
                 "Rond", (r.Position == null ? "indefinie" : String.Format("x:{0}/y:{1}", r.Position.X, r.Position.Y)), r.AngleEnRadian);
            str += String.Format(" et possede un rayon de {0} mm", r.Rayon);
            return str;
        }
    }
}
