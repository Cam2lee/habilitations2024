using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.model
{
    public class Developpeur
    {
        public int Iddeveloppeur { get; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Pwd { get; set; }
        public Profil Profil { get; set; }

        public Developpeur(int iddeveloppeur, string nom, string prenom, string mail, string tel, string pwd, Profil profil)
        {
            Iddeveloppeur = iddeveloppeur;
            Nom = nom;
            Prenom = prenom;
            Mail = mail;
            Tel = tel;
            Pwd = pwd;
            Profil = profil;
        }
    }
}
