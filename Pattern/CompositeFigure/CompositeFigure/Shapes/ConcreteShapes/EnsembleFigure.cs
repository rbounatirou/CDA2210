using CompositeFigure.Visiteur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFigure.Shapes.ConcreteShapes
{
    public class EnsembleFigure : Figure
    {
        private List<Figure> sesFigures;



        public EnsembleFigure(Coordonnee? position, double angle, List<Figure> sesFigures) : base(position, angle)
        {
            this.sesFigures = sesFigures;
        }

        public EnsembleFigure(EnsembleFigure ef)
        {
            this.saPosition = new Coordonnee(ef.saPosition);
            this.angleEnRadian = ef.angleEnRadian;
            sesFigures = new();
            ef.sesFigures.ForEach(f => sesFigures.Add(f.Clone()));
        }

        public override Figure Clone()
        {
            return new EnsembleFigure(this);
        }




        public override void AccepterVisite(IVisiteurDeFigure<string> f)
        {
            f.VisiterEnsembleFigure(this);
        }
    }
}
