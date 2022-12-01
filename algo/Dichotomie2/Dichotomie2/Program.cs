namespace Dichotomie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* LA RECHERCHE PAR DICHOTOMIE
             * La recherche par dichotomie consiste à rechercher un élèment dans un tableau trié par ordre croissant, en le comparant
             * à l'élèment au milieu du tableau pour savoir si il se situe avant ou après l'élèment centrale.
             */

            /*
             * PSEUDO CODE
             * 
             * DECLARATION
             * déclarer tableau de string noms
             * déclarer string nomAChercher
             * déclarer int min
             * déclarer int max
             * déclarer int delta
             * déclarer int mediane
             * declarer booleen find
             * TRAITEMENT
             * noms <-- {agathe, berthe, chloé, cunégonde, olga, raymonde, sidonie}
             * min <-- 0
             * max <-- longueur de noms
             * nomAChercher <-- olga
             * delta <-- (max - min) / 2
             * médiane <-- min + delta
             * find <-- noms[mediane] egal nomAChercher
             * ECRIRE "Bonjour, vous êtes sur le programme de recherche par dichotomie"
             * TANT QUE (!find et delta different de 0)
             *  
             *  SI nomAChercher est alphabétiquement avant noms[mediane]
             *  max <-- mediane
             *  
             *  SINON
             *  min <-- mediane
             *  
             *  FIN SI
             *  delta <-- (max - min) / 2
             *  médiane <-- min + delta
             *  find <-- noms[mediane] egal nomAChercher
             *  
             *  SI !find et delta == 0
             *      SI nom[max] == nomAChercher
             *          mediane <-- max
             *          find <-- true
             *      FINSI
             *      
             *  FINSI
             * FIN TANT QUE 
             * 
             * AFFICHAGE
             * SI find est vrai
             * ECRIRE "Le nom a été trouvé à l'indice ", mediane
             * SINON
             * ECRIRE "Le nom n'est pas présent dans le tableau"
             * FINSI
             * 
             * FONCTION
             * 
             */
            string[] noms = new[] {"aaa", "agathe", "berthe", "chloé", "cunégonde", "olga", "raymonde", "sidonie" };
            string nomAChercher = "sidonie";
            int min = 0;
            int max = noms.Length - 1;
            int delta = (max - min) / 2;
            int mediane = min + delta;
            bool find = noms[mediane] == nomAChercher;

            Console.WriteLine("Bonjour, vous êtes sur le programme de recherche par dichotomie.");

            int rt = rechercheDicotomique(noms, nomAChercher, 0, noms.Length - 1);
            Console.WriteLine(rt >= 0 ? $"valeur trouvée à l'indice {rt}" : $"valeur non trouvée");


        }

        static int rechercheDicotomique(string[] _noms, string _search, int _min, int _max)
        {

            if (_min != _max)
            {
                int mediane = _min + (_max - _min) / 2;
                if (_search.CompareTo(_noms[mediane]) > 0)
                {
                    return rechercheDicotomique(_noms, _search, mediane + 1, _max);
                }
                    return rechercheDicotomique(_noms, _search, _min, mediane - 1);

            }
            else
            {

                if (_noms[_min] == _search)
                {
                    return _min;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
