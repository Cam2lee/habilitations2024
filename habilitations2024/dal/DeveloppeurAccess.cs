using habilitations2024.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.dal
{
    public class DeveloppeurAccess
    {
        private readonly Access access;

        public DeveloppeurAccess()
        {
            access = Access.GetInstance();
        }

        public List<Developpeur> GetLesDeveloppeurs()
        {
            List<Developpeur> lesDevs = new List<Developpeur>();
            string req = "SELECT d.iddeveloppeur, d.nom, d.prenom, d.mail, d.tel, d.pwd, p.idprofil, p.nom " +
                         "FROM developpeur d JOIN profil p ON d.idprofil = p.idprofil ORDER BY d.nom";

            try
            {
                List<object[]> lignes = access.Manager.ReqSelect(req);
                if (lignes != null)
                {
                    foreach (object[] ligne in lignes)
                    {
                        int idDev = Convert.ToInt32(ligne[0]);
                        string nom = ligne[1].ToString();
                        string prenom = ligne[2].ToString();
                        string mail = ligne[3].ToString();
                        string tel = ligne[4].ToString();
                        string pwd = ligne[5].ToString();
                        int idProfil = Convert.ToInt32(ligne[6]);
                        string nomProfil = ligne[7].ToString();

                        Profil profil = new Profil(idProfil, nomProfil);
                        Developpeur dev = new Developpeur(idDev, nom, prenom, mail, tel, pwd, profil);
                        lesDevs.Add(dev);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }

            return lesDevs;
        }

        public void DelDeveloppeur(Developpeur developpeur)
        {
            string req = "DELETE FROM developpeur WHERE iddeveloppeur = @id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", developpeur.Iddeveloppeur }
            };

            try
            {
                access.Manager.ReqUpdate(req, parameters);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void AddDeveloppeur(Developpeur developpeur)
        {
            string req = "INSERT INTO developpeur (nom, prenom, mail, tel, pwd, idprofil) " +
                         "VALUES (@nom, @prenom, @mail, @tel, SHA2(@pwd, 256), @idprofil)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@nom", developpeur.Nom },
                { "@prenom", developpeur.Prenom },
                { "@mail", developpeur.Mail },
                { "@tel", developpeur.Tel },
                { "@pwd", developpeur.Pwd },
                { "@idprofil", developpeur.Profil.Idprofil }
            };

            try
            {
                access.Manager.ReqUpdate(req, parameters);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateDeveloppeur(Developpeur developpeur)
        {
            string req = "UPDATE developpeur SET nom=@nom, prenom=@prenom, mail=@mail, tel=@tel, idprofil=@idprofil WHERE iddeveloppeur=@id";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@nom", developpeur.Nom },
                { "@prenom", developpeur.Prenom },
                { "@mail", developpeur.Mail },
                { "@tel", developpeur.Tel },
                { "@idprofil", developpeur.Profil.Idprofil },
                { "@id", developpeur.Iddeveloppeur }
            };

            try
            {
                access.Manager.ReqUpdate(req, parameters);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdatePwd(Developpeur developpeur)
        {
            string req = "UPDATE developpeur SET pwd = SHA2(@pwd, 256) WHERE iddeveloppeur = @id";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@pwd", developpeur.Pwd },
                { "@id", developpeur.Iddeveloppeur }
            };

            try
            {
                access.Manager.ReqUpdate(req, parameters);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
