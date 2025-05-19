using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using habilitations2024.dal;
using habilitations2024.model;

namespace habilitations2024.controller
{
    public class FrmHabilitationsController
    {
        // Objets d'accès aux données
        private readonly DeveloppeurAccess developpeurAccess;
        private readonly ProfilAccess profilAccess;

        // Constructeur
        public FrmHabilitationsController()
        {
            developpeurAccess = new DeveloppeurAccess();
            profilAccess = new ProfilAccess();
        }

        // Récupérer tous les développeurs
        public List<Developpeur> GetLesDeveloppeursParProfil(int? idProfil)
        {
            return developpeurAccess.GetLesDeveloppeurs(idProfil);
        }

        // Récupérer tous les profils
        public List<Profil> GetLesProfils()
        {
            return profilAccess.GetLesProfils();
        }

        // Supprimer un développeur
        public void DelDeveloppeur(Developpeur developpeur)
        {
            developpeurAccess.DelDeveloppeur(developpeur);
        }

        // Ajouter un développeur
        public void AddDeveloppeur(Developpeur developpeur)
        {
            developpeurAccess.AddDeveloppeur(developpeur);
        }

        // Modifier un développeur
        public void UpdateDeveloppeur(Developpeur developpeur)
        {
            developpeurAccess.UpdateDeveloppeur(developpeur);
        }

        // Modifier le mot de passe d’un développeur
        public void UpdatePwd(Developpeur developpeur)
        {
            developpeurAccess.UpdatePwd(developpeur);
        }
    }
}
