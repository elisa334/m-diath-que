using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace médiatèque.Model
{
    internal class Service
    {
        public int IdService { get; set; }
        public string Libelle { get; set; } = "";

        public Service() { }

        public Service(int idService, string libelle)
        {
            IdService = idService;
            Libelle = libelle;
        }
    }
}
