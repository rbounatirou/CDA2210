using System.Security.Cryptography.X509Certificates;

namespace PaysBibli
{
    public class ListePays
    {
        private Dictionary<string, bool> selectionPays;


        /// <summary>
        /// Renvoie le nombre de pays dans la liste
        /// </summary>
        /// <returns>int correspondant au nombre d'éléments</returns>
        public int Count() => selectionPays.Count;
        public ListePays()
        {
            selectionPays = new Dictionary<string, bool>();
        }

        public ListePays(Dictionary<string, bool> selectionPays)
        {
            this.selectionPays = new Dictionary<string, bool>();

            for (int i = 0; i < selectionPays.Count; i++)
            {
                this.selectionPays.Add(selectionPays.Keys.ElementAt(i), selectionPays.Values.ElementAt(i));
            }
        }

        public ListePays(ListePays p) : this(p.selectionPays) { }


        /// <summary>
        /// Permet de savoir si un élément ayant la clé str existe
        /// </summary>
        /// <param name="str">Clé recherchée</param>
        /// <returns>index de l'élément > 0 si trouvée, -1 sinon</returns>
        public int KeyExist(string str)
        {
            int i = 0;
            bool found = false;
            while (i < selectionPays.Count)
            {
                found = selectionPays.Keys.ElementAt(i) == str;
                if (!found)
                    i++;
            }
            return (found ? i : -1);
        }

        /// <summary>
        /// Renvoie la liste des pays n'ayant été séléctionnés
        /// </summary>
        /// <returns></returns>
        public List<string> GetUnselectedListOfPays() => GetListOfPaysWithState(false);

        /// <summary>
        /// Renvoie la liste des pays ayant été séléctionnés
        /// </summary>
        /// <returns></returns>
        public List<string> GetSelectedListOfPays() => GetListOfPaysWithState(true);


        /// <summary>
        /// Ajoute un pays dans la liste,
        /// Peut échouer si chaine vide ou si le pays existe
        /// </summary>
        /// <param name="paysName">Nom du pays à ajouter</param>
        /// <param name="value">Correspond à l'état de séléction initial du pays</param>
        /// <returns>true si l'oppération à fonctionné, false sinon</returns>
        public bool AjouterPays(string paysName, bool value = false)
        {
            if (paysName.Trim() == "")
                return false;
            if (KeyExist(paysName) != -1)
                return false;
            selectionPays.Add(paysName, value);
            return true;

        }

        /// <summary>
        /// Renvoie la valeur de l'element situé à l'index i
        /// </summary>
        /// <param name="i">position de l'index désiré</param>
        /// <returns></returns>
        public bool GetElementValueAtIndex(int i)
        {
            return selectionPays.Values.ElementAt(i);
        }

        /// <summary>
        /// Renvoie la clé de l'element situé à l'index i
        /// </summary>
        /// <param name="i">position de l'index désiré</param>
        /// <returns></returns>
        public string GetElementKeyAtIndex(int i)
        {
            return selectionPays.Keys.ElementAt(i);
        }

        /// <summary>
        /// Renvoie les element dont la valeur (qui correspond à la selection) est
        /// équivalente à celle du paramètre state
        /// </summary>
        /// <param name="state">Etat à rechercher</param>
        /// <returns>Ensemble des elements correspondant à l'etat recherché</returns>
        private List<string> GetListOfPaysWithState(bool state)
        {
            List<string> list = new();
            for (int i = 0; i < selectionPays.Count(); i++)
            {
                if (selectionPays.Values.ElementAt(i) == state)
                    list.Add(selectionPays.Keys.ElementAt(i));
            }
            return list;
        }

        /// <summary>
        /// Passe l'état séléctionné à l'élément dont la clé correspond
        /// à l'argument s
        /// </summary>
        /// <param name="s">Clé recherchée</param>
        /// <returns>True si l'état à pu être changé, 
        /// False si l'état était déjà selectioonné
        /// </returns>
        public bool SelectByKeyName(string s)
        {
            if (!selectionPays[s])
            {
                selectionPays[s] = true;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Passe l'état non séléctionné à l'élément dont la clé correspond
        /// à l'argument s
        /// </summary>
        /// <param name="s">Clé recherchée</param>
        /// <returns>True si l'état à pu être changé, 
        /// False si l'état était déjà non séléctionné
        /// </returns>
        public bool UnselectByKeyName(string s)
        {
            if (selectionPays[s])
            {
                selectionPays[s] = false;
                return true;
            }
            return false;
        }

    }
}