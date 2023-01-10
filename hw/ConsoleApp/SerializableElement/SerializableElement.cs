using System.Runtime.Serialization;

namespace SerializableElements
{
    [Serializable]
    public class SerializableElement : ISerializable
    {
        private string nom;
        private string prenom;
        private int age;
        private string pseudo;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Age { get => age; set => age = value; }
        public string Pseudo { get => pseudo; set => pseudo = value; }

        public SerializableElement(string nom, string prenom, int age, string pseudo)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.pseudo = pseudo;
        }

        public SerializableElement(SerializationInfo info, StreamingContext context)
        {
            nom = (string)info.GetValue("nom", typeof(string));
            prenom = (string)info.GetValue("prenom", typeof(string));
            pseudo = (string)info.GetValue("pseudo", typeof(string));
            age = (int)info.GetValue("age", typeof(int));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("nom", nom, typeof(string));
            info.AddValue("prenom", prenom, typeof(string));
            info.AddValue("age", age, typeof(int));
            info.AddValue("pseudo",pseudo, typeof(string));
        }
    }
}