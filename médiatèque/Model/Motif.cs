using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace médiatèque.Model
{
    internal class Motif
    {
        public int IdMotif { get; set; }
        public string Libelle { get; set; } = "";

        public Motif() { }

        public Motif(int idMotif, string libelle)
        {
            IdMotif = idMotif;
            Libelle = libelle;
        }
    }
}
