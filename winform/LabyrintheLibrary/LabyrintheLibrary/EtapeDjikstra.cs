using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrintheLibrary
{
    public class EtapeDjikstra
    {

        private EtapeDjikstra? etapePrecedente;
        private int distanceTotale;
        private Point pointArrivee;

        public EtapeDjikstra? EtapePrecedente { get => etapePrecedente; }
        public int DistanceTotale { get => distanceTotale; }
        public Point PointArrivee { get => pointArrivee; }
        public EtapeDjikstra(EtapeDjikstra? origine, int distanceTotale, Point arrivee)
        {
            this.etapePrecedente = origine;
            this.distanceTotale = distanceTotale;
            this.pointArrivee = arrivee;
        }

        public override string ToString()
        {
            return (etapePrecedente != null ? etapePrecedente.PointArrivee.X + "/" + etapePrecedente.PointArrivee.Y + "->": "" )+
                (pointArrivee.X + "/" + pointArrivee.Y) + "(" + distanceTotale + ")";
        }

    }
}
