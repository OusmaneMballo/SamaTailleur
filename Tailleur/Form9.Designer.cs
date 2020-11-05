namespace Tailleur
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.txtRechercheprenom = new System.Windows.Forms.TextBox();
            this.lblRecherchePrenom = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.lblRechercheNom = new System.Windows.Forms.Label();
            this.txtRecherchtelephone = new System.Windows.Forms.TextBox();
            this.lblRecherTel = new System.Windows.Forms.Label();
            this.dateRecherche = new System.Windows.Forms.DateTimePicker();
            this.lblDateRecherche = new System.Windows.Forms.Label();
            this.btnrtre = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblTitreRecherche = new System.Windows.Forms.Label();
            this.lblErreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRechercheprenom
            // 
            resources.ApplyResources(this.txtRechercheprenom, "txtRechercheprenom");
            this.txtRechercheprenom.Name = "txtRechercheprenom";
            this.txtRechercheprenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRechercheprenom_KeyPress);
            // 
            // lblRecherchePrenom
            // 
            resources.ApplyResources(this.lblRecherchePrenom, "lblRecherchePrenom");
            this.lblRecherchePrenom.Name = "lblRecherchePrenom";
            // 
            // txtnom
            // 
            resources.ApplyResources(this.txtnom, "txtnom");
            this.txtnom.Name = "txtnom";
            this.txtnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnom_KeyPress);
            // 
            // lblRechercheNom
            // 
            resources.ApplyResources(this.lblRechercheNom, "lblRechercheNom");
            this.lblRechercheNom.Name = "lblRechercheNom";
            // 
            // txtRecherchtelephone
            // 
            resources.ApplyResources(this.txtRecherchtelephone, "txtRecherchtelephone");
            this.txtRecherchtelephone.Name = "txtRecherchtelephone";
            this.txtRecherchtelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecherchtelephone_KeyPress);
            // 
            // lblRecherTel
            // 
            resources.ApplyResources(this.lblRecherTel, "lblRecherTel");
            this.lblRecherTel.Name = "lblRecherTel";
            // 
            // dateRecherche
            // 
            this.dateRecherche.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.dateRecherche, "dateRecherche");
            this.dateRecherche.Name = "dateRecherche";
            this.dateRecherche.ValueChanged += new System.EventHandler(this.dateRecherche_ValueChanged);
            // 
            // lblDateRecherche
            // 
            resources.ApplyResources(this.lblDateRecherche, "lblDateRecherche");
            this.lblDateRecherche.Name = "lblDateRecherche";
            // 
            // btnrtre
            // 
            this.btnrtre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnrtre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnrtre.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnrtre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnrtre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.btnrtre, "btnrtre");
            this.btnrtre.ForeColor = System.Drawing.Color.White;
            this.btnrtre.Name = "btnrtre";
            this.btnrtre.UseVisualStyleBackColor = false;
            this.btnrtre.Click += new System.EventHandler(this.btnrtre_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.AppStarting;
            resources.ApplyResources(this.btnRechercher, "btnRechercher");
            this.btnRechercher.ForeColor = System.Drawing.Color.White;
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lblTitreRecherche
            // 
            resources.ApplyResources(this.lblTitreRecherche, "lblTitreRecherche");
            this.lblTitreRecherche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTitreRecherche.Name = "lblTitreRecherche";
            // 
            // lblErreur
            // 
            resources.ApplyResources(this.lblErreur, "lblErreur");
            this.lblErreur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErreur.Name = "lblErreur";
            // 
            // Form9
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.lblTitreRecherche);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnrtre);
            this.Controls.Add(this.lblDateRecherche);
            this.Controls.Add(this.dateRecherche);
            this.Controls.Add(this.txtRecherchtelephone);
            this.Controls.Add(this.lblRecherTel);
            this.Controls.Add(this.txtRechercheprenom);
            this.Controls.Add(this.lblRecherchePrenom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.lblRechercheNom);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form9";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnrtre;
        protected internal System.Windows.Forms.Label lblRecherTel;
        protected internal System.Windows.Forms.TextBox txtRecherchtelephone;
        protected internal System.Windows.Forms.Label lblRechercheNom;
        protected internal System.Windows.Forms.Label lblRecherchePrenom;
        protected internal System.Windows.Forms.TextBox txtRechercheprenom;
        protected internal System.Windows.Forms.Label lblDateRecherche;
        protected internal System.Windows.Forms.Button btnRechercher;
        protected internal System.Windows.Forms.Label lblTitreRecherche;
        protected internal System.Windows.Forms.TextBox txtnom;
        public System.Windows.Forms.DateTimePicker dateRecherche;
        protected internal System.Windows.Forms.Label lblErreur;
    }
}