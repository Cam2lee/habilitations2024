using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using habilitations2024.model;

namespace habilitations2024.dal
{
    public class ProfilAccess
    {
        private readonly Access access;

        public ProfilAccess()
        {
            access = Access.GetInstance();
        }

        public List<Profil> GetLesProfils()
        {
            List<Profil> lesProfils = new List<Profil>();
            string req = "SELECT idprofil, nom FROM profil ORDER BY nom";

            try
            {
                List<object[]> lignes = access.Manager.ReqSelect(req);
                if (lignes != null)
                {
                    foreach (object[] ligne in lignes)
                    {
                        int idprofil = Convert.ToInt32(ligne[0]);
                        string nom = ligne[1].ToString();

                        Profil profil = new Profil(idprofil, nom);
                        lesProfils.Add(profil);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }

            return lesProfils;
        }
    }
}
