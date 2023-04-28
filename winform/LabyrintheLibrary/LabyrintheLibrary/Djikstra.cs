using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrintheLibrary
{
    public class Djikstra
    {
        private Labyrinthe labyrinthe;
        private int initX, initY, endX, endY;
        private List<EtapeDjikstra> pattern;

        public EtapeDjikstra[]? Pattern { get => (pattern != null ? pattern.ToArray() : null); }
        public Djikstra(Labyrinthe l, int posX, int posY, int posArriveeX, int posArriveeY)
        {
            if (posX < 0 ||
                posArriveeX < 0 ||
                posArriveeY < 0 ||
                posY < 0 ||
                posX >= l.W ||
                posY >= l.H ||
                posArriveeX >= l.W ||
                posArriveeY >= l.H ||
                l.Murs[posX,posY] ||
                l.Murs[posArriveeX, posArriveeY] ||
                !l.EstTermine())
            {
                throw new Exception("Erreur, point invalides");
            }
            initX = posX;
            initY = posY;
            endX = posArriveeX;
            endY = posArriveeY;
            labyrinthe = l;
            List<EtapeDjikstra> resume = DeterminerCheminPossibles(0);
            if (resume != null)
            {

                List<EtapeDjikstra> resumeArrivee = resume.FindAll(x => x.PointArrivee.X == endX && x.PointArrivee.Y == endY);
                resumeArrivee.Sort((x, y) => x.DistanceTotale - y.DistanceTotale);
                EtapeDjikstra suivi = resumeArrivee[0];
                pattern = new();
                
                while (suivi != null)
                {
                    pattern.Add(suivi);
                    suivi = suivi.EtapePrecedente;
                }
                pattern.Sort((x, y) => x.DistanceTotale - y.DistanceTotale);

            }
        }
        

        private List<EtapeDjikstra>? DeterminerCheminPossibles(int dst, List<EtapeDjikstra>? ancienneListe = null )
        {
            List<EtapeDjikstra> ets = ancienneListe ?? new();
            List<int> direction = new();
            if (dst == 0)
            {
                ets.Add(new EtapeDjikstra(null,0,new Point(initX, initY)));
                labyrinthe.GetDirectionsPossibles(initX, initY);
                              
            }
            List<EtapeDjikstra> etapesActuelles = ets.FindAll(x => x.DistanceTotale == dst);
            List<EtapeDjikstra> nouvellesEtapes = new();
            foreach(EtapeDjikstra et in etapesActuelles)
            {
                nouvellesEtapes.AddRange(DeterminerPointDepuisEtape(et));
            }
            List<EtapeDjikstra> ajouts = nouvellesEtapes.FindAll(x => !ets.Exists(y => x.PointArrivee.X == y.PointArrivee.X && y.PointArrivee.Y == x.PointArrivee.Y));
            ets.AddRange(ajouts);

            dst++;
            List<EtapeDjikstra> arrivee = ets.FindAll(x => x.PointArrivee.X == endX && x.PointArrivee.Y == endY);
            if (arrivee.Count > 0 && arrivee.Exists(x => x.DistanceTotale <= dst))
            {
                return ets;
            }
            if(ajouts.Count == 0 && !ets.Exists(x=>x.DistanceTotale > dst))
            {
                return null;
            }
            return DeterminerCheminPossibles(dst, ets);
        }

       private List<EtapeDjikstra> DeterminerPointDepuisEtape(EtapeDjikstra et)
        {
            List<EtapeDjikstra> point = new();
            List<int> direction = labyrinthe.GetDirectionsPossibles(et.PointArrivee.X, et.PointArrivee.Y);

            
            foreach(int i in direction)
            {
                Point arrivee;
                arrivee = new Point(et.PointArrivee.X + (i == 0 ? -1 : (i == 1 ? 1 : 0)),
                    et.PointArrivee.Y + (i == 2 ? -1 : (i==3 ? 1 : 0)));
                point.Add(new EtapeDjikstra(et, et.DistanceTotale + labyrinthe.Poids[arrivee.X, arrivee.Y], arrivee));
            }
            return point;
        }


    }
}
