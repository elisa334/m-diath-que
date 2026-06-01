using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using médiatèque.bddmanager;

namespace médiatèque
{
    internal class Access
    {

        private static Access? instance = null;

        public BddManager Manager { get; }

         private static readonly string connectionName = "mediathequeConnectionString";

         private Access()
         {
             try
             {
                 string connectionString =
                     ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;

                 Manager = BddManager.GetInstance(connectionString);
             }
             catch (Exception e)
             {
                 Console.WriteLine("Erreur BDD : " + e.Message);
                 Environment.Exit(0);
             }
         }

         public static Access GetInstance()
         {
             if (instance == null)
             {
                 instance = new Access();
             }
             return instance;
         }
    }
}
