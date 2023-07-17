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

        public Figure[] Figures { get => sesFigures.ToArray(); private set { sesFigures = value.ToList(); } }

        public EnsembleFigure(Coordonnee? position, double angle, List<Figure> sesFigures) : base(position, angle)
        {
            this.sesFigures = sesFigures??new List<Figure>();
        }

        public EnsembleFigure(Coordonnee? position) : this(position, 0, null) { }


        public EnsembleFigure(double angle): this(null, angle, null) { }

        public EnsembleFigure() : this(null, 0, null) { }

        public void AjouterFigure(Figure f)
        {
            sesFigures.Add(f);
        }

        public EnsembleFigure(EnsembleFigure ef)
        {
            this.saPosition = new Coordonnee(ef.saPosition);
            this.angleEnRadian = ef.angleEnRadian;
            sesFigures = new();
            ef.sesFigures.ForEach(f => sesFigures.Add(((Figure)f.Clone())));
        }

        public override object Clone()
        {
            return new EnsembleFigure(this);
        }




        public override T AccepterVisite<T>(IVisiteurDeFigure<T> f)
        {
              sesFigures.ForEach(d => d.AccepterVisite(f));
              return f.VisiterEnsembleFigure(this);

        }

        public override string AccepterVisite(IVisiteurDeFigure<string> f)
        {
           string str = f.VisiterEnsembleFigure(this);
           for (int i = 0; i < sesFigures.Count; i++)
            {
                Figure fg = sesFigures[i];
                str += Environment.NewLine + fg.AccepterVisite(f);
            }
            return str;
        }

        

        public override Figure[] DissocierGroupe()
        {
            return sesFigures.ToArray();
        }

        public override void RegrouperElementEnUnGroupe(params int[] idEls) {
            List<Figure> f = new List<Figure>();
            List<int> value = idEls.ToList();
            value.Sort((a, b) => a - b);
            if (value[0] < 0 || value[value.Count - 1] >= sesFigures.Count)
                return;
            EnsembleFigure ef = new EnsembleFigure();
            int id = 0;
            value.ForEach(d => {
                
                ef.AjouterFigure(sesFigures[d-id]);
                sesFigures.RemoveAt(d - id);
                id++;
                });

            sesFigures.Insert(value[0], ef);
            
        }

        public override void DissocierElementEnPlusieurs(int idElement)
        {
            if (sesFigures.Count < idElement)
                return;
            Figure[] fig = sesFigures[idElement].DissocierGroupe();
            foreach(Figure f in fig)
            {
                sesFigures.Insert(idElement + 1, f);
            }
            sesFigures.RemoveAt(idElement);
        }

        public override bool IsOnHitbox(double x, double y, double w, double h)
        {
            bool rt = false;
            int i = 0;
            while (!rt && i < sesFigures.Count)
            {
                rt = sesFigures[i].IsOnHitbox(x, y, w, h);
            }
            return rt;
        }
    }
}
