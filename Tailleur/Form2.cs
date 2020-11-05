using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tailleur
{
    public partial class Parent : Form
    {
        tailleurdbEntities DBA = new tailleurdbEntities();
        public int id;
        public Parent()
        {
            InitializeComponent();
        }

        Boolean verificationLoginPasswd(string login,string passwd)
        {
            List<admin> listAdmin = DBA.admins.ToList();
            foreach(admin ad in listAdmin)
            {
                if (ad.login.CompareTo(login) == 0)
                {
                    MessageBox.Show("Desolé!... ce login existe déjà veuillez ressaisir un autre.");
                    return false;
                }
                else
                {
                    if(ad.passwd.CompareTo(passwd) == 0)
                    {
                        MessageBox.Show("Desolé!... ce mot de passe existe déjà veuillez ressaisir un autre.");
                        return false;
                    }
                }
            }
            return true;
        }

        void activationFormAdmin(Boolean x)
        {
            lblAdminLog.Visible = x;
            lblAdminName.Visible = x;
            lblAdminPasswd.Visible = x;
            lblAdminprenom.Visible = x;
            btnAjoutAdmin.Visible = x;
            btnannulerAdmin.Visible = x;
            txtAdminlogin.Visible = x;
            txtadminName.Visible = x;
            txtadminPasswd.Visible = x;
            txtAdminprenom.Visible = x;
            panellogin.Visible = x;
            panelNom.Visible = x;
            panelprenom.Visible = x;
            panelpasswd.Visible = x;
            dgvAdmin.Visible = false;//dans tout les cas il sera a false sauf si on l'appelle dans la methode btnRetirerAdmin_click()
            btnprivilegeAdmin.Visible = false;
            btnAjoutAdmin.Text = "&Ajouter";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dgvAdmin.Columns.Add("prenom", "Prenom");
            dgvAdmin.Columns.Add("nom", "Nom");
            dgvAdmin.Columns.Add("login", "Login");
            dgvAdmin.Columns.Add("passwd", "Pass word");
            dgvAdmin.Columns.Add("id", "ID");
            List<admin> listAdmin = DBA.admins.ToList();
            foreach (admin ad in listAdmin)
            {
                dgvAdmin.Rows.Add(ad.prenom, ad.nom, ad.login, ad.passwd, ad.id);
            }

        }
         void effacer()
        {
            txtadresse.Clear();
            txtmail.Clear();
            txtnom.Clear();
            txtprenom.Clear();
            txttelephone.Clear();
            txtnom.Focus();
        }
        Boolean verification()
        {
            if(txtnom.Text == ""|| txtprenom.Text == ""|| txttelephone.Text == ""||cbxGenre.Text=="")
            {
                return false;
            }
            return true;
        }
        private void deconnexionToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
            
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnpprofil_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png|All files(*.*)|*.*";
                if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    admin ad = new admin();
                    ad = DBA.admins.Find(id);
                    ad.image= file.FileName;
                    DBA.SaveChanges();
                    pprofil.ImageLocation = file.FileName;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur", "Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            if (verification())
            {
                client cl = new client();
                cl.nom = txtnom.Text;
                cl.prenom = txtprenom.Text;
                cl.tel = txttelephone.Text;
                cl.email = txtmail.Text;
                cl.adresse = txtadresse.Text;
                cl.genre = cbxGenre.Text;
                DBA.clients.Add(cl);
                DBA.SaveChanges();
                effacer();
            }
            else
            {
                MessageBox.Show("Attention!... Tous les champs en (*) doivent etre renseignés!");
            }

        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            effacer();
        }

        private void txttelephone_TextChanged(object sender, EventArgs e)
        {
           
        
        }

        private void txttelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))) 
            {
                e.Handled = true;
            }
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtprenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnMesure_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void aLivrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.nonlivree = true;
            f8.lblListCommde.Text += " non Livrée";
            f8.Show();
        }

        private void livréeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.livree = true;
            f8.lblListCommde.Text += " Livrée";
            f8.Show();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.lblTitreRecherche.Text += " un(e) ou plusieurs clients(es)";
            f9.lblDateRecherche.Visible = false;
            f9.dateRecherche.Visible = false;
            f9.btnRechercher.Text += " Client";
            f9.Show();
            
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.lblTitreRecherche.Text += " une commande";
            f9.lblRechercheNom.Visible = false;
            f9.lblRecherchePrenom.Visible = false;
            f9.lblRecherTel.Visible = false;
            f9.txtRechercheprenom.Visible = false;
            f9.txtRecherchtelephone.Visible = false;
            f9.txtnom.Visible = false;
            f9.btnRechercher.Text += " Commande";
            f9.btnRechercher.Enabled = true;
            f9.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activationFormAdmin(true);
            btnretirAdmin.Enabled = false;
            btnAjoutAdmin.Enabled = true;
        }

        private void btnannulerAdmin_Click(object sender, EventArgs e)
        {
            txtAdminlogin.Clear();
            txtadminName.Clear();
            txtadminPasswd.Clear();
            txtAdminprenom.Clear();
            activationFormAdmin(false);
            btnaddAmin.Enabled = true;
            btnretirAdmin.Enabled = true;
        }

        private void btnAjoutAdmin_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            if (btnAjoutAdmin.Text.CompareTo("&Ajouter") == 0)
            {
                if (txtAdminlogin.Text == "" || txtadminName.Text == "" || txtadminPasswd.Text == "" || txtAdminprenom.Text == "")
                {
                    MessageBox.Show("Oups!... Veuillez remplir toutes les champs.");
                }
                else
                {
                    if (verificationLoginPasswd(txtAdminlogin.Text, txtadminPasswd.Text))
                    {
                        ad.login = txtAdminlogin.Text;
                        ad.nom = txtadminName.Text;
                        ad.passwd = txtadminPasswd.Text;
                        ad.prenom = txtAdminprenom.Text;
                        ad.image = "";
                        ad.droit = "";
                        DBA.admins.Add(ad);
                        DBA.SaveChanges();
                        
                        txtAdminlogin.Clear();
                        txtadminName.Clear();
                        txtadminPasswd.Clear();
                        txtAdminprenom.Clear();
                        activationFormAdmin(false);
                        MessageBox.Show("Vous avez ajouté un administrateur.");
                    }
                }
            }
            else
            {
                ad = DBA.admins.Find(int.Parse(dgvAdmin.CurrentRow.Cells[4].Value.ToString()));
                DBA.admins.Remove(ad);
                DBA.SaveChanges();
                btnannulerAdmin.Text = "Re&tour";
                MessageBox.Show(dgvAdmin.CurrentRow.Cells[0].Value.ToString()+ " "+dgvAdmin.CurrentRow.Cells[1].Value.ToString() + " est retiré en tant que administrateur");
                dgvAdmin.ClearSelection();
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnaddAmin.Enabled = false;
            btnretirAdmin.Enabled = false;
            dgvAdmin.Visible = true;
            btnAjoutAdmin.Text = "&Retirer";
            btnAjoutAdmin.Visible = true;
            btnannulerAdmin.Visible = true;
            btnprivilegeAdmin.Visible = true;
            btnAjoutAdmin.Enabled = false;
            btnprivilegeAdmin.Enabled = false;
        }

        private void dgvAdmin_Click(object sender, EventArgs e)
        {
            btnAjoutAdmin.Enabled = true;
            btnprivilegeAdmin.Enabled = true;
        }
    }
}
