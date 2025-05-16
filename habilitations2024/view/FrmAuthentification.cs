using habilitations2024.controller;
using habilitations2024.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace habilitations2024.view
{
    public partial class FrmAuthentification : Form
    {
        private FrmAuthentificationController authentificationController;

        public FrmAuthentification()
        {
            InitializeComponent();
            authentificationController = new FrmAuthentificationController();
        }

        private void connecter_Click(object sender, EventArgs e)
        {
            // Vérification que tous les champs sont remplis
            if (string.IsNullOrWhiteSpace(nomAuth.Text) ||
                string.IsNullOrWhiteSpace(prénomAuth.Text) ||
                string.IsNullOrWhiteSpace(pwdAuth.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Création de l'objet Admin avec les infos saisies
            Admin admin = new Admin(nomAuth.Text.Trim(), prénomAuth.Text.Trim(), pwdAuth.Text);

            // Appel au contrôleur pour vérifier l'authentification
            bool estAuthentifie = authentificationController.ControleAuthentification(admin);

            if (estAuthentifie)
            {
                // Authentification réussie : ouvrir FrmHabilitations
                FrmHabilitations frmHabilitations = new FrmHabilitations();
                frmHabilitations.Show();
                this.Hide();
            }
            else
            {
                // Authentification échouée : message d'erreur
                MessageBox.Show("Nom, prénom ou mot de passe incorrect.", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
