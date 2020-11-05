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
    public partial class Form7 : Form
    {
        public int idcmmdeEdit=0;
        tailleurdbEntities DBA = new tailleurdbEntities();
        commande Cmd = new commande();
       public  OpenFileDialog file = new OpenFileDialog();
        void vider()
        {
            txtavancement.Text = "";
            txtlngTissu.Text = "";
            txtPrix.Text = "";
        }
        Boolean control()
        {
            if(txtavancement.Text == ""|| txtPrix.Text == ""||cbxTyppeTissu.Text=="")
            {
                return false;
            }
            return true;
        }
        void activation()
        {
            txtavancement.Enabled = true;
            txtlngTissu.Enabled = true;
            txtPrix.Enabled = true;
            cbxTyppeTissu.Enabled = true;
            dateLivraison.Enabled = true;
            btnModel.Enabled = true;
            btnajouterCommde.Enabled = true;

        }
        //La methode permete de verifier si le client a des mesures avant qu'il soit affiche
        Boolean verifiMesure(int idClient)
        {
            List<mesure> listMsure = DBA.mesures.ToList();
            foreach (mesure Cl in listMsure)
            {
                if (Cl.idclient == idClient)
                {
                    return true;
                }
            }
                return false;
        }
        void reinitialiser()
        {
            txtavancement.Enabled=false;
            txtlngTissu.Enabled=false;
            txtPrix.Enabled = false;
            cbxTyppeTissu.Enabled = false;
            dateLivraison.Enabled = false;
            btnModel.Enabled = false;
            btnajouterCommde.Enabled = false;
        }
        public Form7()
        {
            InitializeComponent();
            dgvClientCmmde.Columns.Add("prenom", "Prenom");
            dgvClientCmmde.Columns.Add("nom", "Nom");
            dgvClientCmmde.Columns.Add("genre", "Genre");
            dgvClientCmmde.Columns.Add("id", "ID");
            List<client> listClt = DBA.clients.ToList();

            foreach (client Cl in listClt)
            {
                if(verifiMesure(Cl.id))
                dgvClientCmmde.Rows.Add(Cl.prenom, Cl.nom, Cl.genre, Cl.id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            try
            {
                
                file.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png|All files(*.*)|*.*";
                if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Cmd.model = file.FileName;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur", "Error");
            }
        }

        private void btnajouterCommde_Click(object sender, EventArgs e)
        {
            if(btnajouterCommde.Text.CompareTo("&Ajouter") == 0)
            {
                if (control())
                {
                    Cmd.datecommander = DateTime.Now.Date;
                    Cmd.datelivraison = dateLivraison.Value.Date;
                    Cmd.idclient = int.Parse(dgvClientCmmde.CurrentRow.Cells[3].Value.ToString());
                    Cmd.montantAnvace = int.Parse(txtavancement.Text);
                    Cmd.prixPaye = int.Parse(txtPrix.Text);
                    Cmd.longTissu = int.Parse(txtlngTissu.Text);
                    Cmd.typeTissu = cbxTyppeTissu.Text;
                    Cmd.etat = "Non Livre";
                    DBA.commandes.Add(Cmd);
                    DBA.SaveChanges();
                    lblCmmde.Text = "Commande ajouté...!";
                    vider();
                    reinitialiser();

                }
                else
                {
                    MessageBox.Show("Les champs en (*) sont obligatoirs");
                    lblCmmde.Text = "Commande non ajouté...!";
                }
            }
            else
            {
                if (idcmmdeEdit != 0)
                {
                    Cmd = DBA.commandes.Find(idcmmdeEdit);
                    Cmd.datelivraison = dateLivraison.Value.Date;
                    Cmd.longTissu = int.Parse(txtlngTissu.Text);
                    Cmd.model= file.FileName;
                    Cmd.montantAnvace = int.Parse(txtavancement.Text);
                    Cmd.prixPaye = int.Parse(txtPrix.Text);
                    Cmd.typeTissu = cbxTyppeTissu.Text;
                    DBA.SaveChanges();
                    Form8 f8 = new Form8();
                    f8.Show();
                    MessageBox.Show("La Commande numéro " + idcmmdeEdit+" est modifiée");
                    this.Close();
                }
            }
           
        }

        private void dgvClientCmmde_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            activation();
            activation();
            lblCmmde.Text = "";
        }

        private void btnAnnulerEditcmmde_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Close();
        }
    }
}
