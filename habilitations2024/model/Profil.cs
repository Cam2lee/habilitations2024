﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.model
{
    public class Profil
    {
        public int Idprofil { get; }
        public string Nom { get; }

        public Profil(int idprofil, string nom)
        {
            Idprofil = idprofil;
            Nom = nom;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
