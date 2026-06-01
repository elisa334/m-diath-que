using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace médiatèque.Model
{
    internal class Personnel
    {
        public int IdPersonnel { get; set; }
        public string Nom { get; set; } = "";
        public string Prenom { get; set; } = "";
        public string Tel { get; set; } = "";
        public string Mail { get; set; } = "";

        public Personnel() { }

        public Personnel(int idPersonnel, string nom, string prenom, string tel, string mail)
        {
            IdPersonnel = idPersonnel;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            Mail = mail;
        }
    }
}
