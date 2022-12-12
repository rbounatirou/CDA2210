
using ExoVoiture.Voitures.Pieces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExoVoiture.Voitures
{
    internal class Voiture
    {
        public string marque { get; private set; }
        public string modele { get; private set; }
        
        public Roue[,] sesRoues {  get; private set; }
        public Moteur sonMoteur {  get; private set; }
        public Voiture(string _marque, string _modele, Roue roue1, Roue roue2, Roue roue3, Roue roue4, Moteur _sonMoteur)
        {
            this.marque = _marque;
            this.modele = _modele;
            sesRoues = new Roue[2,2];
            sesRoues[0, 0] = new Roue(roue1);
            sesRoues[0, 1] = new Roue(roue2);
            sesRoues[1, 0] = new Roue(roue3);
            sesRoues[1,1] = new Roue(roue4);
            sonMoteur = new Moteur(_sonMoteur);
        }


        public Voiture() : this("Citroen", "AX",  new Roue(), new Roue() ,  new Roue(), new Roue() , new Moteur()) {

        }
        
        public Voiture(Voiture _from) : this(_from.marque, _from.modele, _from.sesRoues[0,0], _from.sesRoues[0,1],_from.sesRoues[1,1], _from.sesRoues[1,1], _from.sonMoteur) { }
        public bool Arreter()
        {
            int i = 0;
            bool arretOk = true;
            while (i < sesRoues.GetLength(0) && arretOk) 
            {
                int j = 0;
                while (j < sesRoues.GetLength(1) && arretOk)
                {
                    arretOk = sesRoues[i, j].Rouler();
                    j++;
                }
                i++;
            }
            return arretOk && sonMoteur.Arreter();
        }

        public bool Demarrer()
        {
           return sonMoteur.Demarrer();
        }

        public bool Avancer(float _nbKm)
        {
            bool peutAvancer = true;
            int i=0;
            while (i < sesRoues.GetLength(0) && peutAvancer)
            {
                List<Roue> rouesConcernes = new List<Roue>();
                for(int j = 0; j < sesRoues.GetLength(1); j++)
                    rouesConcernes.Add(sesRoues[i,j]);
                peutAvancer = sonMoteur.Avancer(rouesConcernes);
                i++;
            }
            return peutAvancer;
        }
    }
}
