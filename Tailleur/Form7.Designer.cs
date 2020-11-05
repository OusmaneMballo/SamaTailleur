namespace Tailleur
{
    partial class Form7
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
            this.dgvClientCmmde = new System.Windows.Forms.DataGridView();
            this.btnfermer = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCmmde = new System.Windows.Forms.Label();
            this.btnModel = new System.Windows.Forms.Button();
            this.txtavancement = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlngTissu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTyppeTissu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateLivraison = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.btnajouterCommde = new System.Windows.Forms.Button();
            this.btnAnnulerEditcmmde = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientCmmde)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientCmmde
            // 
            this.dgvClientCmmde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientCmmde.Location = new System.Drawing.Point(4, 94);
            this.dgvClientCmmde.Name = "dgvClientCmmde";
            this.dgvClientCmmde.Size = new System.Drawing.Size(441, 369);
            this.dgvClientCmmde.TabIndex = 0;
            this.dgvClientCmmde.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientCmmde_CellClick_1);
            // 
            // btnfermer
            // 
            this.btnfermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnfermer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnfermer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnfermer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnfermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfermer.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfermer.ForeColor = System.Drawing.Color.White;
            this.btnfermer.Location = new System.Drawing.Point(946, 53);
            this.btnfermer.Name = "btnfermer";
            this.btnfermer.Size = new System.Drawing.Size(75, 29);
            this.btnfermer.TabIndex = 1;
            this.btnfermer.Text = "Retour";
            this.btnfermer.UseVisualStyleBackColor = false;
            this.btnfermer.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Gray;
            this.label17.Location = new System.Drawing.Point(4, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(222, 20);
            this.label17.TabIndex = 8;
            this.label17.Text = "Veuillez sélectionné un client *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Date Livraison";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.lblCmmde);
            this.groupBox1.Controls.Add(this.btnModel);
            this.groupBox1.Controls.Add(this.txtavancement);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrix);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtlngTissu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxTyppeTissu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateLivraison);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(451, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 250);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Espace Commande";
            // 
            // lblCmmde
            // 
            this.lblCmmde.AutoSize = true;
            this.lblCmmde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmmde.Location = new System.Drawing.Point(163, 211);
            this.lblCmmde.Name = "lblCmmde";
            this.lblCmmde.Size = new System.Drawing.Size(0, 24);
            this.lblCmmde.TabIndex = 18;
            // 
            // btnModel
            // 
            this.btnModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModel.Enabled = false;
            this.btnModel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnModel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModel.Location = new System.Drawing.Point(397, 155);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(161, 27);
            this.btnModel.TabIndex = 6;
            this.btnModel.Text = "Choisir un model";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // txtavancement
            // 
            this.txtavancement.Enabled = false;
            this.txtavancement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtavancement.Location = new System.Drawing.Point(104, 107);
            this.txtavancement.Name = "txtavancement";
            this.txtavancement.Size = new System.Drawing.Size(161, 26);
            this.txtavancement.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Montant Avance *";
            // 
            // txtPrix
            // 
            this.txtPrix.Enabled = false;
            this.txtPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.Location = new System.Drawing.Point(397, 105);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(161, 26);
            this.txtPrix.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Prix *";
            // 
            // txtlngTissu
            // 
            this.txtlngTissu.Enabled = false;
            this.txtlngTissu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlngTissu.Location = new System.Drawing.Point(397, 48);
            this.txtlngTissu.Name = "txtlngTissu";
            this.txtlngTissu.Size = new System.Drawing.Size(161, 26);
            this.txtlngTissu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Longueur Tissu";
            // 
            // cbxTyppeTissu
            // 
            this.cbxTyppeTissu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTyppeTissu.Enabled = false;
            this.cbxTyppeTissu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTyppeTissu.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTyppeTissu.ForeColor = System.Drawing.Color.Purple;
            this.cbxTyppeTissu.FormattingEnabled = true;
            this.cbxTyppeTissu.Items.AddRange(new object[] {
            "Wax",
            "Basin",
            "Diezner",
            "Soi",
            "Brode",
            "Autres"});
            this.cbxTyppeTissu.Location = new System.Drawing.Point(104, 47);
            this.cbxTyppeTissu.Name = "cbxTyppeTissu";
            this.cbxTyppeTissu.Size = new System.Drawing.Size(161, 29);
            this.cbxTyppeTissu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Type de Tissu *";
            // 
            // dateLivraison
            // 
            this.dateLivraison.CalendarFont = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLivraison.CalendarForeColor = System.Drawing.Color.Teal;
            this.dateLivraison.Enabled = false;
            this.dateLivraison.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLivraison.Location = new System.Drawing.Point(104, 155);
            this.dateLivraison.Name = "dateLivraison";
            this.dateLivraison.Size = new System.Drawing.Size(240, 25);
            this.dateLivraison.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label18.Location = new System.Drawing.Point(475, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(317, 29);
            this.label18.TabIndex = 10;
            this.label18.Text = "Enregistrer une Commande";
            // 
            // btnajouterCommde
            // 
            this.btnajouterCommde.BackColor = System.Drawing.Color.White;
            this.btnajouterCommde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnajouterCommde.Enabled = false;
            this.btnajouterCommde.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnajouterCommde.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnajouterCommde.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnajouterCommde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouterCommde.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouterCommde.ForeColor = System.Drawing.Color.Teal;
            this.btnajouterCommde.Location = new System.Drawing.Point(451, 377);
            this.btnajouterCommde.Name = "btnajouterCommde";
            this.btnajouterCommde.Size = new System.Drawing.Size(570, 40);
            this.btnajouterCommde.TabIndex = 7;
            this.btnajouterCommde.Text = "&Ajouter";
            this.btnajouterCommde.UseVisualStyleBackColor = false;
            this.btnajouterCommde.Click += new System.EventHandler(this.btnajouterCommde_Click);
            // 
            // btnAnnulerEditcmmde
            // 
            this.btnAnnulerEditcmmde.BackColor = System.Drawing.Color.White;
            this.btnAnnulerEditcmmde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnulerEditcmmde.Enabled = false;
            this.btnAnnulerEditcmmde.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAnnulerEditcmmde.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAnnulerEditcmmde.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAnnulerEditcmmde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerEditcmmde.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerEditcmmde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAnnulerEditcmmde.Location = new System.Drawing.Point(451, 423);
            this.btnAnnulerEditcmmde.Name = "btnAnnulerEditcmmde";
            this.btnAnnulerEditcmmde.Size = new System.Drawing.Size(570, 40);
            this.btnAnnulerEditcmmde.TabIndex = 12;
            this.btnAnnulerEditcmmde.Text = "A&nnuler";
            this.btnAnnulerEditcmmde.UseVisualStyleBackColor = false;
            this.btnAnnulerEditcmmde.Visible = false;
            this.btnAnnulerEditcmmde.Click += new System.EventHandler(this.btnAnnulerEditcmmde_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label19);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 29);
            this.panel1.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(9, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "SamaTaillor V1.0 </mballo>";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 475);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAnnulerEditcmmde);
            this.Controls.Add(this.btnajouterCommde);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnfermer);
            this.Controls.Add(this.dgvClientCmmde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.Opacity = 0.96D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sama Taillor V1.0 </mballo>";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientCmmde)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCmmde;
        protected internal System.Windows.Forms.Button btnajouterCommde;
        protected internal System.Windows.Forms.DataGridView dgvClientCmmde;
        protected internal System.Windows.Forms.ComboBox cbxTyppeTissu;
        protected internal System.Windows.Forms.TextBox txtlngTissu;
        protected internal System.Windows.Forms.TextBox txtPrix;
        protected internal System.Windows.Forms.TextBox txtavancement;
        protected internal System.Windows.Forms.Button btnAnnulerEditcmmde;
        protected internal System.Windows.Forms.DateTimePicker dateLivraison;
        protected internal System.Windows.Forms.Button btnModel;
        protected internal System.Windows.Forms.Button btnfermer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
    }
}