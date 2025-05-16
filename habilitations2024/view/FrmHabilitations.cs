using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using habilitations2024.controller;
using MySql.Data.MySqlClient;
using habilitations2024.model;
using System.Security.Policy;

namespace habilitations2024.view
{
    public partial class FrmHabilitations : Form
    {
        private readonly FrmHabilitationsController controller;

        private Developpeur developpeurSelectionne;

        private BindingSource bindingDeveloppeurs;

        public FrmHabilitations()
        {
            InitializeComponent();
            controller = new FrmHabilitationsController();
            this.Load += FrmHabilitations_Load;
        }
        private void FrmHabilitations_Load(object sender, EventArgs e)
        {
            ChargerLesProfils();
            ChargerLesDeveloppeurs();

            pwd.PasswordChar = '*';
            encore.PasswordChar = '*';
            groupBoxPwd.Enabled = false;
            pwd.Enabled = false;
            encore.Enabled = false;
            enregistrerpwd.Enabled = false;
            annulerpwd.Enabled = false;
        }
        private void ChargerLesDeveloppeurs()
        {
            try
            {
                // Récupérer la liste des développeurs depuis le contrôleur
                List<Developpeur> listeDev = controller.GetLesDeveloppeurs();

                // Trier la liste sur Nom puis Prénom
                listeDev.Sort((d1, d2) =>
                {
                    int res = string.Compare(d1.Nom, d2.Nom, StringComparison.OrdinalIgnoreCase);
                    if (res == 0)
                        res = string.Compare(d1.Prenom, d2.Prenom, StringComparison.OrdinalIgnoreCase);
                    return res;
                });

                // Créer un BindingSource et le lier à la liste triée
                bindingDeveloppeurs = new BindingSource();

                bindingDeveloppeurs.DataSource = listeDev;


                // Lier le BindingSource au DataGridView
                listedesdéveloppeurs.DataSource = bindingDeveloppeurs;


                // Configuration DataGridView selon les consignes
                listedesdéveloppeurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                listedesdéveloppeurs.RowHeadersVisible = false;
                listedesdéveloppeurs.MultiSelect = false;
                listedesdéveloppeurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Interdire la modification directe
                listedesdéveloppeurs.ReadOnly = true;

                // Exemple : cacher certaines colonnes si besoin (adapter selon ta classe Developpeur)
                // Supposons que tu as une colonne "Id" que tu veux cacher
                if (listedesdéveloppeurs.Columns["iddeveloppeur"] != null)
                    listedesdéveloppeurs.Columns["iddeveloppeur"].Visible = false;

                if (listedesdéveloppeurs.Columns["pwd"] != null)
                    listedesdéveloppeurs.Columns["pwd"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des développeurs : " + ex.Message);
            }
        }


        private void ChargerLesProfils()
        {
            try
            {
                // Récupérer la liste des profils depuis le contrôleur
                List<Profil> listeProfils = controller.GetLesProfils();

                // Créer un BindingSource et le lier à la liste de profils
                BindingSource bsProfils = new BindingSource();
                bsProfils.DataSource = listeProfils;

                // Lier le BindingSource au ComboBox
                listedesprofils.DataSource = bsProfils;

                // Par défaut, sélectionner le premier élément s’il existe
                if (listedesprofils.Items.Count > 0)
                    listedesprofils.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des profils : " + ex.Message);
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (listedesdéveloppeurs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un développeur à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupérer le développeur sélectionné
            Developpeur dev = (Developpeur)listedesdéveloppeurs.SelectedRows[0].DataBoundItem;

            // Demande de confirmation
            DialogResult result = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer le développeur {dev.Prenom} {dev.Nom} ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    controller.DelDeveloppeur(dev);
                    MessageBox.Show("Développeur supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recharger la liste
                    ChargerLesDeveloppeurs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool enCoursDeModification = false;

        private void enregistrer_Click(object sender, EventArgs e)
        {
            // Vérifie que tous les champs sont remplis
            if (string.IsNullOrWhiteSpace(nom.Text) ||
                string.IsNullOrWhiteSpace(prenom.Text) ||
                string.IsNullOrWhiteSpace(mail.Text) ||
                string.IsNullOrWhiteSpace(tel.Text) ||
                listedesprofils.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Profil profil = (Profil)listedesprofils.SelectedItem;

            if (enCoursDeModification)
            {
                // Mise à jour des propriétés
                developpeurSelectionne.Nom = nom.Text;
                developpeurSelectionne.Prenom = prenom.Text;
                developpeurSelectionne.Mail = mail.Text;
                developpeurSelectionne.Tel = tel.Text;
                developpeurSelectionne.Profil = (Profil)listedesprofils.SelectedItem;

                controller.UpdateDeveloppeur(developpeurSelectionne);

                MessageBox.Show("Développeur modifié avec succès !");

                // Reset
                enCoursDeModification = false;
                groupBoxAdd.Text = "Ajouter un développeur";
                groupBoxListDev.Enabled = true;
                developpeurSelectionne = null;
            }

            else
            {
                // Création d’un nouveau développeur
                Developpeur nouveauDev = new Developpeur(0, nom.Text, prenom.Text, mail.Text, tel.Text, "", profil);

                // Appel au contrôleur pour l’ajout
                controller.AddDeveloppeur(nouveauDev);

                MessageBox.Show("Développeur ajouté avec succès !");
            }

            // Réinitialise le formulaire
            ViderZonesSaisie();
            ChargerLesDeveloppeurs(); // Recharge le DataGridView
        }
        private void annuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Annuler les modifications en cours ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViderZonesSaisie();

                enCoursDeModification = false;
                groupBoxAdd.Text = "Ajouter un développeur";
                groupBoxListDev.Enabled = true;
                developpeurSelectionne = null;
            }
        }

        private void ViderZonesSaisie()
        {
            nom.Text = "";
            prenom.Text = "";
            mail.Text = "";
            tel.Text = "";
            listedesprofils.SelectedIndex = 0;
            enCoursDeModification = false;
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (bindingDeveloppeurs.Position < 0)
            {
                MessageBox.Show("Veuillez sélectionner un développeur dans la liste.");
                return;
            }

            // Passer en mode modification
            enCoursDeModification = true;
            groupBoxAdd.Text = "Modifier un développeur";
            groupBoxListDev.Enabled = false; // désactive zone 1 (ex: groupBox1 ou panel contenant la liste)

            // Récupère le développeur sélectionné
            developpeurSelectionne = (Developpeur)bindingDeveloppeurs.List[bindingDeveloppeurs.Position];

            // Remplit les champs avec les données du développeur
            nom.Text = developpeurSelectionne.Nom;
            prenom.Text = developpeurSelectionne.Prenom;
            mail.Text = developpeurSelectionne.Mail;
            tel.Text = developpeurSelectionne.Tel;

            // Sélectionne le bon profil dans la ComboBox
            for (int i = 0; i < listedesprofils.Items.Count; i++)
            {
                if (((Profil)listedesprofils.Items[i]).Idprofil == developpeurSelectionne.Profil.Idprofil)
                {
                    listedesprofils.SelectedIndex = i;
                    break;
                }
            }
        }

        private void groupBoxListDev_Enter(object sender, EventArgs e)
        {

        }

        private void changerpwd_Click(object sender, EventArgs e)
        {
            if (listedesdéveloppeurs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un développeur dans la liste.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Désactive zones 1 et 2 et active zone 3
            groupBoxListDev.Enabled = false;  // zone 1
            modifier.Enabled = false;
            supprimer.Enabled = false;
            changerpwd.Enabled = false;
            listedesdéveloppeurs.Enabled = false;
            groupBoxAdd.Enabled = false;      // zone 2
            enregistrer.Enabled = false;
            annuler.Enabled = false;
            nom.Enabled = false;
            prenom.Enabled = false;
            mail.Enabled = false;
            tel.Enabled = false;
            listedesprofils.Enabled = false;
            groupBoxPwd.Enabled = true;
            pwd.Enabled = true;
            encore.Enabled = true;
            enregistrerpwd.Enabled = true;
            annulerpwd.Enabled = true;

            // Vide les zones de saisie pwd
            pwd.Text = "";
            encore.Text = "";
        }

        private void enregistrerpwd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pwd.Text) || string.IsNullOrWhiteSpace(encore.Text))
            {
                MessageBox.Show("Veuillez remplir les deux champs de mot de passe.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pwd.Text != encore.Text)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listedesdéveloppeurs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un développeur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Developpeur dev = (Developpeur)listedesdéveloppeurs.SelectedRows[0].DataBoundItem;

            dev.Pwd = pwd.Text; // met à jour le mot de passe dans l'objet

            try
            {
                controller.UpdatePwd(dev); // appelle bien la méthode qui fait la MAJ en base

                MessageBox.Show("Mot de passe modifié avec succès !");
                // Optionnel : vider les champs, désactiver la zone 3, réactiver les zones 1 et 2
                pwd.Text = "";
                encore.Text = "";
                // désactive zone 3 et réactive zones 1 et 2, à coder selon ta structure
                groupBoxPwd.Enabled = false;
                pwd.Enabled = false;
                encore.Enabled = false;
                enregistrerpwd.Enabled = false;
                annulerpwd.Enabled = false;

                // Réactive les zones 1 et 2
                groupBoxListDev.Enabled = true;
                modifier.Enabled = true;
                supprimer.Enabled = true;
                changerpwd.Enabled = true;
                listedesdéveloppeurs.Enabled = true;
                groupBoxAdd.Enabled = true;
                enregistrer.Enabled = true;
                annuler.Enabled = true;
                nom.Enabled = true;
                prenom.Enabled = true;
                mail.Enabled = true;
                tel.Enabled = true;
                listedesprofils.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification du mot de passe : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void annulerpwd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Annuler le changement de mot de passe ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pwd.Text = "";
                encore.Text = "";

                groupBoxPwd.Enabled = false;
                pwd.Enabled = false;
                encore.Enabled = false;
                enregistrerpwd.Enabled = false;
                annulerpwd.Enabled = false;

                groupBoxListDev.Enabled = true;
                modifier.Enabled = true;
                supprimer.Enabled = true;
                changerpwd.Enabled = true;
                listedesdéveloppeurs.Enabled = true;
                groupBoxAdd.Enabled = true;
                enregistrer.Enabled = true;
                annuler.Enabled = true;
                nom.Enabled = true;
                prenom.Enabled = true;
                mail.Enabled = true;
                tel.Enabled = true;
                listedesprofils.Enabled = true;
            }
        }
    }
}
