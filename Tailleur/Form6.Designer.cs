namespace Tailleur
{
    partial class Form6
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
            this.lblSup = new System.Windows.Forms.Label();
            this.btnOui = new System.Windows.Forms.Button();
            this.btnNon = new System.Windows.Forms.Button();
            this.lblidSup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSup
            // 
            this.lblSup.AutoSize = true;
            this.lblSup.Location = new System.Drawing.Point(47, 19);
            this.lblSup.Name = "lblSup";
            this.lblSup.Size = new System.Drawing.Size(108, 13);
            this.lblSup.TabIndex = 0;
            this.lblSup.Text = "Voulez-vous vraiment";
            // 
            // btnOui
            // 
            this.btnOui.BackColor = System.Drawing.Color.Maroon;
            this.btnOui.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnOui.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOui.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOui.ForeColor = System.Drawing.Color.White;
            this.btnOui.Location = new System.Drawing.Point(70, 66);
            this.btnOui.Name = "btnOui";
            this.btnOui.Size = new System.Drawing.Size(85, 29);
            this.btnOui.TabIndex = 1;
            this.btnOui.Text = "Oui";
            this.btnOui.UseVisualStyleBackColor = false;
            this.btnOui.Click += new System.EventHandler(this.btnOui_Click);
            // 
            // btnNon
            // 
            this.btnNon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNon.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnNon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNon.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNon.ForeColor = System.Drawing.Color.White;
            this.btnNon.Location = new System.Drawing.Point(193, 66);
            this.btnNon.Name = "btnNon";
            this.btnNon.Size = new System.Drawing.Size(85, 29);
            this.btnNon.TabIndex = 2;
            this.btnNon.Text = "Non";
            this.btnNon.UseVisualStyleBackColor = false;
            this.btnNon.Click += new System.EventHandler(this.btnNon_Click);
            // 
            // lblidSup
            // 
            this.lblidSup.AutoSize = true;
            this.lblidSup.Location = new System.Drawing.Point(298, 19);
            this.lblidSup.Name = "lblidSup";
            this.lblidSup.Size = new System.Drawing.Size(0, 13);
            this.lblidSup.TabIndex = 3;
            // 
            // Form6
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 119);
            this.ControlBox = false;
            this.Controls.Add(this.lblidSup);
            this.Controls.Add(this.btnNon);
            this.Controls.Add(this.btnOui);
            this.Controls.Add(this.lblSup);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attention!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOui;
        private System.Windows.Forms.Button btnNon;
        public System.Windows.Forms.Label lblidSup;
        protected internal System.Windows.Forms.Label lblSup;
    }
}