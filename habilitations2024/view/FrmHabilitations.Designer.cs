namespace habilitations2024.view
{
    partial class FrmHabilitations
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listedesdéveloppeurs = new System.Windows.Forms.DataGridView();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.changerpwd = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.labelnom = new System.Windows.Forms.Label();
            this.labelprenom = new System.Windows.Forms.Label();
            this.labelmail = new System.Windows.Forms.Label();
            this.labeltel = new System.Windows.Forms.Label();
            this.labelprofil = new System.Windows.Forms.Label();
            this.listedesprofils = new System.Windows.Forms.ComboBox();
            this.enregistrer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.pwd = new System.Windows.Forms.TextBox();
            this.encore = new System.Windows.Forms.TextBox();
            this.labelpwd = new System.Windows.Forms.Label();
            this.labelencore = new System.Windows.Forms.Label();
            this.annulerpwd = new System.Windows.Forms.Button();
            this.enregistrerpwd = new System.Windows.Forms.Button();
            this.groupBoxPwd = new System.Windows.Forms.GroupBox();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.groupBoxListDev = new System.Windows.Forms.GroupBox();
            this.comboFiltrage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.listedesdéveloppeurs)).BeginInit();
            this.groupBoxPwd.SuspendLayout();
            this.groupBoxListDev.SuspendLayout();
            this.SuspendLayout();
            // 
            // listedesdéveloppeurs
            // 
            this.listedesdéveloppeurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listedesdéveloppeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listedesdéveloppeurs.Location = new System.Drawing.Point(19, 19);
            this.listedesdéveloppeurs.MultiSelect = false;
            this.listedesdéveloppeurs.Name = "listedesdéveloppeurs";
            this.listedesdéveloppeurs.RowHeadersVisible = false;
            this.listedesdéveloppeurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listedesdéveloppeurs.Size = new System.Drawing.Size(730, 227);
            this.listedesdéveloppeurs.TabIndex = 0;
            // 
            // modifier
            // 
            this.modifier.AutoEllipsis = true;
            this.modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifier.Location = new System.Drawing.Point(31, 264);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(75, 23);
            this.modifier.TabIndex = 1;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.AutoEllipsis = true;
            this.supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimer.Location = new System.Drawing.Point(112, 264);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(75, 23);
            this.supprimer.TabIndex = 2;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // changerpwd
            // 
            this.changerpwd.AutoEllipsis = true;
            this.changerpwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changerpwd.Location = new System.Drawing.Point(193, 264);
            this.changerpwd.Name = "changerpwd";
            this.changerpwd.Size = new System.Drawing.Size(94, 23);
            this.changerpwd.TabIndex = 3;
            this.changerpwd.Text = "Changer pwd";
            this.changerpwd.UseVisualStyleBackColor = true;
            this.changerpwd.Click += new System.EventHandler(this.changerpwd_Click);
            // 
            // nom
            // 
            this.nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nom.Location = new System.Drawing.Point(79, 336);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(320, 20);
            this.nom.TabIndex = 4;
            // 
            // prenom
            // 
            this.prenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prenom.Location = new System.Drawing.Point(79, 367);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(320, 20);
            this.prenom.TabIndex = 5;
            // 
            // mail
            // 
            this.mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mail.Location = new System.Drawing.Point(483, 336);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(305, 20);
            this.mail.TabIndex = 6;
            // 
            // tel
            // 
            this.tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tel.Location = new System.Drawing.Point(483, 367);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(161, 20);
            this.tel.TabIndex = 7;
            // 
            // labelnom
            // 
            this.labelnom.AutoSize = true;
            this.labelnom.Location = new System.Drawing.Point(31, 339);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(27, 13);
            this.labelnom.TabIndex = 10;
            this.labelnom.Text = "nom";
            // 
            // labelprenom
            // 
            this.labelprenom.AutoSize = true;
            this.labelprenom.Location = new System.Drawing.Point(31, 370);
            this.labelprenom.Name = "labelprenom";
            this.labelprenom.Size = new System.Drawing.Size(42, 13);
            this.labelprenom.TabIndex = 11;
            this.labelprenom.Text = "prenom";
            // 
            // labelmail
            // 
            this.labelmail.AutoSize = true;
            this.labelmail.Location = new System.Drawing.Point(440, 339);
            this.labelmail.Name = "labelmail";
            this.labelmail.Size = new System.Drawing.Size(25, 13);
            this.labelmail.TabIndex = 12;
            this.labelmail.Text = "mail";
            // 
            // labeltel
            // 
            this.labeltel.AutoSize = true;
            this.labeltel.Location = new System.Drawing.Point(440, 370);
            this.labeltel.Name = "labeltel";
            this.labeltel.Size = new System.Drawing.Size(18, 13);
            this.labeltel.TabIndex = 13;
            this.labeltel.Text = "tel";
            // 
            // labelprofil
            // 
            this.labelprofil.AutoSize = true;
            this.labelprofil.Location = new System.Drawing.Point(440, 400);
            this.labelprofil.Name = "labelprofil";
            this.labelprofil.Size = new System.Drawing.Size(29, 13);
            this.labelprofil.TabIndex = 14;
            this.labelprofil.Text = "profil";
            // 
            // listedesprofils
            // 
            this.listedesprofils.FormattingEnabled = true;
            this.listedesprofils.Location = new System.Drawing.Point(483, 397);
            this.listedesprofils.Name = "listedesprofils";
            this.listedesprofils.Size = new System.Drawing.Size(121, 21);
            this.listedesprofils.TabIndex = 15;
            // 
            // enregistrer
            // 
            this.enregistrer.AutoEllipsis = true;
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.Location = new System.Drawing.Point(36, 425);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(75, 23);
            this.enregistrer.TabIndex = 16;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = true;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // annuler
            // 
            this.annuler.AutoEllipsis = true;
            this.annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annuler.Location = new System.Drawing.Point(132, 425);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 17;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // pwd
            // 
            this.pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwd.Location = new System.Drawing.Point(79, 503);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(320, 20);
            this.pwd.TabIndex = 18;
            this.pwd.UseSystemPasswordChar = true;
            // 
            // encore
            // 
            this.encore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encore.Location = new System.Drawing.Point(468, 503);
            this.encore.Name = "encore";
            this.encore.Size = new System.Drawing.Size(320, 20);
            this.encore.TabIndex = 19;
            this.encore.UseSystemPasswordChar = true;
            // 
            // labelpwd
            // 
            this.labelpwd.AutoSize = true;
            this.labelpwd.Location = new System.Drawing.Point(28, 506);
            this.labelpwd.Name = "labelpwd";
            this.labelpwd.Size = new System.Drawing.Size(27, 13);
            this.labelpwd.TabIndex = 20;
            this.labelpwd.Text = "pwd";
            // 
            // labelencore
            // 
            this.labelencore.AutoSize = true;
            this.labelencore.Location = new System.Drawing.Point(420, 506);
            this.labelencore.Name = "labelencore";
            this.labelencore.Size = new System.Drawing.Size(40, 13);
            this.labelencore.TabIndex = 21;
            this.labelencore.Text = "encore";
            // 
            // annulerpwd
            // 
            this.annulerpwd.AutoEllipsis = true;
            this.annulerpwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annulerpwd.Location = new System.Drawing.Point(132, 536);
            this.annulerpwd.Name = "annulerpwd";
            this.annulerpwd.Size = new System.Drawing.Size(75, 23);
            this.annulerpwd.TabIndex = 23;
            this.annulerpwd.Text = "Annuler";
            this.annulerpwd.UseVisualStyleBackColor = true;
            this.annulerpwd.Click += new System.EventHandler(this.annulerpwd_Click);
            // 
            // enregistrerpwd
            // 
            this.enregistrerpwd.AutoEllipsis = true;
            this.enregistrerpwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrerpwd.Location = new System.Drawing.Point(24, 59);
            this.enregistrerpwd.Name = "enregistrerpwd";
            this.enregistrerpwd.Size = new System.Drawing.Size(75, 23);
            this.enregistrerpwd.TabIndex = 22;
            this.enregistrerpwd.Text = "Enregistrer";
            this.enregistrerpwd.UseVisualStyleBackColor = true;
            this.enregistrerpwd.Click += new System.EventHandler(this.enregistrerpwd_Click);
            // 
            // groupBoxPwd
            // 
            this.groupBoxPwd.Controls.Add(this.enregistrerpwd);
            this.groupBoxPwd.Location = new System.Drawing.Point(12, 477);
            this.groupBoxPwd.Name = "groupBoxPwd";
            this.groupBoxPwd.Size = new System.Drawing.Size(776, 93);
            this.groupBoxPwd.TabIndex = 25;
            this.groupBoxPwd.TabStop = false;
            this.groupBoxPwd.Text = "changer le mot de passe";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Location = new System.Drawing.Point(12, 310);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(776, 153);
            this.groupBoxAdd.TabIndex = 26;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "ajouter un développeur";
            // 
            // groupBoxListDev
            // 
            this.groupBoxListDev.Controls.Add(this.comboFiltrage);
            this.groupBoxListDev.Controls.Add(this.listedesdéveloppeurs);
            this.groupBoxListDev.Location = new System.Drawing.Point(12, 12);
            this.groupBoxListDev.Name = "groupBoxListDev";
            this.groupBoxListDev.Size = new System.Drawing.Size(776, 292);
            this.groupBoxListDev.TabIndex = 27;
            this.groupBoxListDev.TabStop = false;
            this.groupBoxListDev.Text = "les développeurs";
            this.groupBoxListDev.Enter += new System.EventHandler(this.groupBoxListDev_Enter);
            // 
            // comboFiltrage
            // 
            this.comboFiltrage.FormattingEnabled = true;
            this.comboFiltrage.Location = new System.Drawing.Point(628, 254);
            this.comboFiltrage.Name = "comboFiltrage";
            this.comboFiltrage.Size = new System.Drawing.Size(121, 21);
            this.comboFiltrage.TabIndex = 28;
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.annulerpwd);
            this.Controls.Add(this.labelencore);
            this.Controls.Add(this.labelpwd);
            this.Controls.Add(this.encore);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.listedesprofils);
            this.Controls.Add(this.labelprofil);
            this.Controls.Add(this.labeltel);
            this.Controls.Add(this.labelmail);
            this.Controls.Add(this.labelprenom);
            this.Controls.Add(this.labelnom);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.changerpwd);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.groupBoxPwd);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.groupBoxListDev);
            this.Name = "FrmHabilitations";
            this.Text = "FrmHabilitations";
            this.Load += new System.EventHandler(this.FrmHabilitations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listedesdéveloppeurs)).EndInit();
            this.groupBoxPwd.ResumeLayout(false);
            this.groupBoxListDev.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listedesdéveloppeurs;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button changerpwd;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.Label labelprenom;
        private System.Windows.Forms.Label labelmail;
        private System.Windows.Forms.Label labeltel;
        private System.Windows.Forms.Label labelprofil;
        private System.Windows.Forms.ComboBox listedesprofils;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.TextBox encore;
        private System.Windows.Forms.Label labelpwd;
        private System.Windows.Forms.Label labelencore;
        private System.Windows.Forms.Button annulerpwd;
        private System.Windows.Forms.Button enregistrerpwd;
        private System.Windows.Forms.GroupBox groupBoxPwd;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.GroupBox groupBoxListDev;
        private System.Windows.Forms.ComboBox comboFiltrage;
    }
}

