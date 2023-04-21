using Persistence.Persistent;
using InterfaceDP;
using System.Configuration;
using System.Reflection;
using System.Text.RegularExpressions;

namespace IHMDP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();            
            string typeInstanceCompteStr = ConfigurationManager.AppSettings["compte"];
            Assembly.Load(ConfigurationManager.AppSettings["compteAssembly"]);
            Type typeInstanceCompte = searchForType(typeInstanceCompteStr);
            Application.Run(new Form1((ICrudCompte)Activator.CreateInstance(typeInstanceCompte)));
        }

        private static Type? searchForType(string t)
        {
            Type? trt = Type.GetType(t);
            if (trt != null)
                return trt;
            Assembly[] asms = AppDomain.CurrentDomain.GetAssemblies();
            int i = 0;           
            
            while (i < asms.Length && trt == null)
            {
                trt = asms[i].GetType(t);
                i++;
            }
            return trt;
        }
    }
}