using habilitations2024.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;


namespace habilitations2024.dal
{
    public class DeveloppeurAccess
    {
        private readonly Access access;

        public DeveloppeurAccess()
        {
            access = Access.GetInstance();
        }

        public List<Developpeur> GetLesDeveloppeurs(int? idProfil = null)
        {
            List<Developpeur> lesDevs = new List<Developpeur>();
            string req = "SELECT d.iddeveloppeur, d.nom, d.prenom, d.mail, d.tel, d.pwd, p.idprofil, p.nom " +
                         "FROM developpeur d JOIN profil p ON d.idprofil = p.idprofil";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            if (idProfil.HasValue)
            {
                req += " WHERE p.idprofil = @idprofil";
                parameters.Add("@idprofil", idProfil.Value);
            }

            req += " ORDER BY d.nom";

            try
            {
                List<object[]> lignes = access.Manager.ReqSelect(req, parameters);
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
                        int idProfilDev = Convert.ToInt32(ligne[6]);
                        string nomProfil = ligne[7].ToString();

                        Profil profil = new Profil(idProfilDev, nomProfil);
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

        public void Test_GetLesDeveloppeurs_ParProfil()
        {
            int idProfilTest = 4; // dev-back
            List<Developpeur> liste = GetLesDeveloppeurs(idProfilTest);
            int expectedCount = 5; // nombre attendu de dev-back

            if (liste.Count == expectedCount)
            {
                MessageBox.Show("Nombre développeur par Profil : OK");
            }
            else
            {
                MessageBox.Show($"Nombre développeur par Profil : ÉCHEC (attendu : {expectedCount} | obtenu : {liste.Count})");
            }
        }

        public void Test_GetLesDeveloppeurs_TousProfils()
        {
            List<Developpeur> liste = GetLesDeveloppeurs();
            int expectedCount = 17; // nombre total de développeurs attendus

            if (liste.Count == expectedCount)
            {
                MessageBox.Show("Nombre développeur total : OK");
            }
            else
            {
                MessageBox.Show($"Nombre développeur total : ÉCHEC (attendu : {expectedCount} | obtenu : {liste.Count})");
            }
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

        public bool ControleAuthentification(Admin admin)
        {
            string req = "SELECT COUNT(*) FROM developpeur d " +
                         "JOIN profil p ON d.idprofil = p.idprofil " +
                         "WHERE d.nom = @nom AND d.prenom = @prenom AND d.pwd = SHA2(@pwd, 256) AND p.nom = 'admin'";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@nom", admin.Nom },
                { "@prenom", admin.Prenom },
                { "@pwd", admin.Pwd }
            };

            try
            {
                List<object[]> result = access.Manager.ReqSelect(req, parameters);
                if (result != null && result.Count > 0)
                {
                    int count = Convert.ToInt32(result[0][0]);
                    return count > 0;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

    }
}
