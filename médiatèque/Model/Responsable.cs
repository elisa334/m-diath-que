using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace médiatèque.Model
{
    internal class Responsable
    {
        public int IdResponsable { get; set; }
        public string Nom { get; set; } = "";
        public string Prenom { get; set; } = "";
        public string Login { get; set; } = "";
        public string Password { get; set; } = "";

        public Responsable() { }

        public Responsable(int id, string nom, string prenom, string login, string password)
        {
            IdResponsable = id;
            Nom = nom;
            Prenom = prenom;
            Login = login;
            Password = password;
        }
    }
}
