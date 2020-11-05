namespace Tailleur
{
    partial class Form8
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imgModel = new System.Windows.Forms.PictureBox();
            this.btnrtr = new System.Windows.Forms.Button();
            this.dgvCmmde = new System.Windows.Forms.DataGridView();
            this.lblListCommde = new System.Windows.Forms.Label();
            this.btnlivreCmmde = new System.Windows.Forms.Button();
            this.btnannulerCmmde = new System.Windows.Forms.Button();
            this.btnmodicommande = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmmde)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgModel
            // 
            this.imgModel.Location = new System.Drawing.Point(763, 79);
            this.imgModel.Name = "imgModel";
            this.imgModel.Size = new System.Drawing.Size(343, 438);
            this.imgModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgModel.TabIndex = 0;
            this.imgModel.TabStop = false;
            // 
            // btnrtr
            // 
            this.btnrtr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnrtr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnrtr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnrtr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnrtr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrtr.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrtr.ForeColor = System.Drawing.Color.White;
            this.btnrtr.Location = new System.Drawing.Point(1029, 43);
            this.btnrtr.Name = "btnrtr";
            this.btnrtr.Size = new System.Drawing.Size(77, 30);
            this.btnrtr.TabIndex = 4;
            this.btnrtr.Text = "Retour";
            this.btnrtr.UseVisualStyleBackColor = false;
            this.btnrtr.Click += new System.EventHandler(this.btnrtr_Click);
            // 
            // dgvCmmde
            // 
            this.dgvCmmde.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCmmde.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCmmde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCmmde.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCmmde.Location = new System.Drawing.Point(3, 79);
            this.dgvCmmde.Name = "dgvCmmde";
            this.dgvCmmde.Size = new System.Drawing.Size(754, 300);
            this.dgvCmmde.TabIndex = 5;
            this.dgvCmmde.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCmmde_CellClick);
            // 
            // lblListCommde
            // 
            this.lblListCommde.AutoSize = true;
            this.lblListCommde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblListCommde.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCommde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblListCommde.Location = new System.Drawing.Point(231, 44);
            this.lblListCommde.Name = "lblListCommde";
            this.lblListCommde.Size = new System.Drawing.Size(247, 29);
            this.lblListCommde.TabIndex = 9;
            this.lblListCommde.Text = "Liste des Commandes";
            // 
            // btnlivreCmmde
            // 
            this.btnlivreCmmde.BackColor = System.Drawing.Color.White;
            this.btnlivreCmmde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlivreCmmde.Enabled = false;
            this.btnlivreCmmde.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnlivreCmmde.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnlivreCmmde.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnlivreCmmde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlivreCmmde.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlivreCmmde.ForeColor = System.Drawing.Color.Teal;
            this.btnlivreCmmde.Location = new System.Drawing.Point(3, 385);
            this.btnlivreCmmde.Name = "btnlivreCmmde";
            this.btnlivreCmmde.Size = new System.Drawing.Size(754, 40);
            this.btnlivreCmmde.TabIndex = 12;
            this.btnlivreCmmde.Text = "&Livrer la Commande";
            this.btnlivreCmmde.UseVisualStyleBackColor = false;
            this.btnlivreCmmde.Click += new System.EventHandler(this.btnlivreCmmde_Click);
            // 
            // btnannulerCmmde
            // 
            this.btnannulerCmmde.BackColor = System.Drawing.Color.White;
            this.btnannulerCmmde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnannulerCmmde.Enabled = false;
            this.btnannulerCmmde.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnannulerCmmde.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnannulerCmmde.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnannulerCmmde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnannulerCmmde.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannulerCmmde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnannulerCmmde.Location = new System.Drawing.Point(3, 477);
            this.btnannulerCmmde.Name = "btnannulerCmmde";
            this.btnannulerCmmde.Size = new System.Drawing.Size(754, 40);
            this.btnannulerCmmde.TabIndex = 13;
            this.btnannulerCmmde.Text = "&Annuler la Commande";
            this.btnannulerCmmde.UseVisualStyleBackColor = false;
            this.btnannulerCmmde.Click += new System.EventHandler(this.btnannulerCmmde_Click);
            // 
            // btnmodicommande
            // 
            this.btnmodicommande.BackColor = System.Drawing.Color.White;
            this.btnmodicommande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodicommande.Enabled = false;
            this.btnmodicommande.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnmodicommande.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnmodicommande.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnmodicommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodicommande.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodicommande.ForeColor = System.Drawing.Color.Navy;
            this.btnmodicommande.Location = new System.Drawing.Point(3, 431);
            this.btnmodicommande.Name = "btnmodicommande";
            this.btnmodicommande.Size = new System.Drawing.Size(754, 40);
            this.btnmodicommande.TabIndex = 14;
            this.btnmodicommande.Text = "&Modifier la commande";
            this.btnmodicommande.UseVisualStyleBackColor = false;
            this.btnmodicommande.Click += new System.EventHandler(this.btnmodicommande_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label19);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 29);
            this.panel1.TabIndex = 15;
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
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 524);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnmodicommande);
            this.Controls.Add(this.btnannulerCmmde);
            this.Controls.Add(this.btnlivreCmmde);
            this.Controls.Add(this.lblListCommde);
            this.Controls.Add(this.dgvCmmde);
            this.Controls.Add(this.btnrtr);
            this.Controls.Add(this.imgModel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form8";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sama Taillor V1.0 </mballo>";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmmde)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnrtr;
        public System.Windows.Forms.DataGridView dgvCmmde;
        private System.Windows.Forms.Button btnlivreCmmde;
        private System.Windows.Forms.Button btnannulerCmmde;
        private System.Windows.Forms.Button btnmodicommande;
        protected internal System.Windows.Forms.PictureBox imgModel;
        protected internal System.Windows.Forms.Label lblListCommde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
    }
}