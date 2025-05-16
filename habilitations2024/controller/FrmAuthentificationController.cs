using habilitations2024.dal;
using habilitations2024.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.controller
{
    public class FrmAuthentificationController
    {
        // Propriété pour accéder à la classe DeveloppeurAccess
        public DeveloppeurAccess DeveloppeurAccess { get; private set; }

        // Constructeur : on instancie DeveloppeurAccess
        public FrmAuthentificationController()
        {
            DeveloppeurAccess = new DeveloppeurAccess();
        }

        // Méthode qui contrôle l'authentification en appelant la méthode du DAL
        public bool ControleAuthentification(Admin admin)
        {
            return DeveloppeurAccess.ControleAuthentification(admin);
        }
    }
}
