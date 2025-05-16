namespace habilitations2024.view
{
    partial class FrmAuthentification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNomAuth = new System.Windows.Forms.Label();
            this.labelPrénomAuth = new System.Windows.Forms.Label();
            this.labelPwdAuth = new System.Windows.Forms.Label();
            this.nomAuth = new System.Windows.Forms.TextBox();
            this.prénomAuth = new System.Windows.Forms.TextBox();
            this.pwdAuth = new System.Windows.Forms.TextBox();
            this.connecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomAuth
            // 
            this.labelNomAuth.AutoSize = true;
            this.labelNomAuth.Location = new System.Drawing.Point(66, 70);
            this.labelNomAuth.Name = "labelNomAuth";
            this.labelNomAuth.Size = new System.Drawing.Size(35, 13);
            this.labelNomAuth.TabIndex = 0;
            this.labelNomAuth.Text = "Nom :";
            // 
            // labelPrénomAuth
            // 
            this.labelPrénomAuth.AutoSize = true;
            this.labelPrénomAuth.Location = new System.Drawing.Point(66, 117);
            this.labelPrénomAuth.Name = "labelPrénomAuth";
            this.labelPrénomAuth.Size = new System.Drawing.Size(49, 13);
            this.labelPrénomAuth.TabIndex = 1;
            this.labelPrénomAuth.Text = "Prénom :";
            // 
            // labelPwdAuth
            // 
            this.labelPwdAuth.AutoSize = true;
            this.labelPwdAuth.Location = new System.Drawing.Point(66, 161);
            this.labelPwdAuth.Name = "labelPwdAuth";
            this.labelPwdAuth.Size = new System.Drawing.Size(77, 13);
            this.labelPwdAuth.TabIndex = 2;
            this.labelPwdAuth.Text = "Mot de passe :";
            // 
            // nomAuth
            // 
            this.nomAuth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomAuth.Location = new System.Drawing.Point(152, 70);
            this.nomAuth.Name = "nomAuth";
            this.nomAuth.Size = new System.Drawing.Size(256, 20);
            this.nomAuth.TabIndex = 3;
            // 
            // prénomAuth
            // 
            this.prénomAuth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prénomAuth.Location = new System.Drawing.Point(152, 114);
            this.prénomAuth.Name = "prénomAuth";
            this.prénomAuth.Size = new System.Drawing.Size(256, 20);
            this.prénomAuth.TabIndex = 4;
            // 
            // pwdAuth
            // 
            this.pwdAuth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwdAuth.Location = new System.Drawing.Point(152, 158);
            this.pwdAuth.Name = "pwdAuth";
            this.pwdAuth.Size = new System.Drawing.Size(256, 20);
            this.pwdAuth.TabIndex = 5;
            this.pwdAuth.UseSystemPasswordChar = true;
            // 
            // connecter
            // 
            this.connecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connecter.Location = new System.Drawing.Point(286, 205);
            this.connecter.Name = "connecter";
            this.connecter.Size = new System.Drawing.Size(122, 23);
            this.connecter.TabIndex = 6;
            this.connecter.Text = "Se connecter";
            this.connecter.UseVisualStyleBackColor = true;
            this.connecter.Click += new System.EventHandler(this.connecter_Click);
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 274);
            this.Controls.Add(this.connecter);
            this.Controls.Add(this.pwdAuth);
            this.Controls.Add(this.prénomAuth);
            this.Controls.Add(this.nomAuth);
            this.Controls.Add(this.labelPwdAuth);
            this.Controls.Add(this.labelPrénomAuth);
            this.Controls.Add(this.labelNomAuth);
            this.Name = "FrmAuthentification";
            this.Text = "FrmAuthentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomAuth;
        private System.Windows.Forms.Label labelPrénomAuth;
        private System.Windows.Forms.Label labelPwdAuth;
        private System.Windows.Forms.TextBox nomAuth;
        private System.Windows.Forms.TextBox prénomAuth;
        private System.Windows.Forms.TextBox pwdAuth;
        private System.Windows.Forms.Button connecter;
    }
}