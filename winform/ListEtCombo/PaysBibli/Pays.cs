using System.Security.Cryptography.X509Certificates;

namespace PaysBibli
{
    public class Pays
    {
        Dictionary<string, bool> selectionPays;


        public int Count() => selectionPays.Count;
        public Pays()
        {
            selectionPays = new Dictionary<string, bool>();
        }

        public Pays(Dictionary<string, bool> selectionPays)
        {        
            for(int i = 0; i < selectionPays.Count; i++)
            {
                selectionPays.Add(selectionPays.Keys.ElementAt(i), selectionPays.Values.ElementAt(i);
            }
        }

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

        public List<string> GetUnselectedList() => GetStateList(false);

        public List<string> GetSelectedList() => GetStateList(true);

        public bool AjouterPays(string paysName, bool value = false)
        {
            if (KeyExist(paysName) != -1)
                return false;
            selectionPays.Add(paysName, value);
            return true;

        }

        public bool GetElementValueAtIndex(int i)
        {
            return selectionPays.Values.ElementAt(i);
        }

        public string GetElementKeyAtIndex(int i)
        {
            return selectionPays.Keys.ElementAt(i);
        }

        private List<string> GetStateList(bool state)
        {
            List<string> list = new();
            for (int i = 0; i < selectionPays.Count(); i++)
            {
                if (selectionPays.Values.ElementAt(i) == state)
                    list.Add(selectionPays.Keys.ElementAt(i));
            }
            return list;
        }

        private List<int> GetStateListIndex(bool state)
        {
            List<int> list = new();
            for (int i = 0; i < selectionPays.Count(); i++)
            {
                if (selectionPays.Values.ElementAt(i) == state)
                    list.Add(i);
            }
            return list;
        }

        private bool SetPriorityUp(string indexName)
        {
            int index = KeyExist(indexName);
            if (index == -1)
                return false;
            bool type =  selectionPays.Values.ElementAt(index);
            List<int> id = GetStateListIndex(type);
            int idf = id.IndexOf(index);
            if (idf >= 0)
            {
                selectionPays.
            }
        }

       

        private void SetPriorityDown
    }
}