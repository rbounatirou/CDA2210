using CompositeFigure.Shapes.ConcreteShapes;
using CompositeFigure.Visiteur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWinform
{
    public class VisiteurDeFigureWinform : IVisiteurDeFigure<object>
    {

        private Panel drawPanel;
        private Pen pen;


        public VisiteurDeFigureWinform(Panel drawPanel)
        {
            this.drawPanel = drawPanel;
            this.pen = new Pen(Color.Blue, 2);
            
        }
        public object VisiterCarre(Carre c)
        {
            Graphics e = drawPanel.CreateGraphics();
            e.DrawRectangle(pen, (int)c.Position.X, (int)c.Position.Y, (int)c.TailleCoteEnMM, (int)c.TailleCoteEnMM);
            return null;
            
        }

        public object VisiterEnsembleFigure(EnsembleFigure e)
        {
            return null;
        }

        public object VisiterRond(Rond r)
        {
            Graphics e = drawPanel.CreateGraphics();
            Rectangle rect = new Rectangle((int)(r.Position.X - r.Rayon), (int)(r.Position.Y - r.Rayon), (int) r.Rayon * 2, (int)r.Rayon * 2);
            e.DrawEllipse(pen, rect);
            return null;
        }
    }
}
