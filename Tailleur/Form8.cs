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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        tailleurdbEntities DBA = new tailleurdbEntities();
        int restant = 0;
        public Boolean livree = false;
        public Boolean nonlivree = false;
        public Boolean recherche = false;
        public DateTime dateRecher;
        commande Cmd = new commande();
        List<commande> listCmmde;
        void activation(Form7 f7)
        {
            f7.btnajouterCommde.Text = "&Valider la modification";
            f7.btnAnnulerEditcmmde.Visible = true;
            f7.btnajouterCommde.Enabled = true;
            f7.btnAnnulerEditcmmde.Enabled = true;
            f7.cbxTyppeTissu.Enabled = true;
            f7.txtavancement.Enabled = true;
            f7.txtlngTissu.Enabled = true;
            f7.txtPrix.Enabled = true;
            f7.dgvClientCmmde.Enabled = false;
            f7.dateLivraison.Enabled = true;
            f7.btnModel.Enabled = true;
        }
        void afficheCommande(commande cmm, List<client> listclient)
        {
            restant = cmm.prixPaye - cmm.montantAnvace;
            foreach (client cl in listclient)
            {
                if (cl.id == cmm.idclient)
                {
                    dgvCmmde.Rows.Add(cmm.id, cmm.datecommander, cmm.datelivraison,
                                        cmm.typeTissu, cmm.longTissu, cmm.prixPaye,
                                        cmm.montantAnvace, restant, cmm.etat, cl.nom, cl.prenom);
                    break;
                }
            }

            imgModel.ImageLocation = cmm.model;
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            dgvCmmde.Columns.Add("id", "Numero Commande");
            dgvCmmde.Columns.Add("datecommander", "Date Commandé");
            dgvCmmde.Columns.Add("datecommander", "Date Livraison");
            dgvCmmde.Columns.Add("typeTissu", "Tissu");
            dgvCmmde.Columns.Add("longTissu", "Longueur");
            dgvCmmde.Columns.Add("prixPaye", "Prix   (f CFA)");
            dgvCmmde.Columns.Add("montantAvance", "Avance   (f CFA)");
            dgvCmmde.Columns.Add("restant", "Restant   (f CFA)");
            dgvCmmde.Columns.Add("etat", "Etat");
            dgvCmmde.Columns.Add("nom", "Nom Client");
            dgvCmmde.Columns.Add("prenom", "Prenom Client");
            listCmmde = DBA.commandes.ToList();
            List<client> listclient = DBA.clients.ToList();
            //On test pour verifier quel etat de commande qu'on veut afficher(livrer ou non ou les 2)
            if (livree)
            {
                foreach (commande cmm in listCmmde)
                {
                    if (cmm.etat.CompareTo("Livre") == 0)//on filtre toutes les commande livrees et on les affiches
                    {
                        afficheCommande(cmm, listclient);
                    }
                    

                }
            }
            else
            {
                if (nonlivree)
                {
                    foreach (commande cmm in listCmmde)
                    {
                        if (cmm.etat.CompareTo("Non Livre") == 0)//on filtre toutes les commande Non livrees et on les affiches
                        {
                            afficheCommande(cmm, listclient);
                        }


                    }
                }
                else
                {
                    if (recherche)
                    {
                        foreach (commande cmm in listCmmde)
                        {
                            if (cmm.datecommander==dateRecher.Date)//on affiche toutes les commandes qui ont etees enregistrees a cette date
                            {
                                afficheCommande(cmm, listclient);
                            }


                        }
                    }
                    else
                    {//on affiche toutes les commandes
                        foreach (commande cmm in listCmmde)
                        {
                            afficheCommande(cmm, listclient);
                        }
                    }
                }
            }
        }

        private void btnrtr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCmmde_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnlivreCmmde.Enabled = true;
            btnmodicommande.Enabled = true;
            btnannulerCmmde.Enabled = true;
            foreach (commande cmd in listCmmde)
            {
                try
                {
                   if((int.Parse(dgvCmmde.CurrentRow.Cells[0].Value.ToString()) == cmd.id))
                    {
                        imgModel.ImageLocation = cmd.model;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oups!... y'a pas de commande existante pour ce cas");
                    this.Close();
                }
            }
        }

        private void btnlivreCmmde_Click(object sender, EventArgs e)
        {
            commande cmmde = DBA.commandes.Find(int.Parse(dgvCmmde.CurrentRow.Cells[0].Value.ToString()));
            cmmde.etat = "Livre";
            DBA.SaveChanges();
            MessageBox.Show("La commande de numero: "+dgvCmmde.CurrentRow.Cells[0].Value.ToString()+" est livrée!");
            
        }

        private void btnannulerCmmde_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.lblSup.Text += "Annuler la commande numero " + dgvCmmde.CurrentRow.Cells[0].Value.ToString();
            f6.idcommde = int.Parse(dgvCmmde.CurrentRow.Cells[0].Value.ToString());
            f6.Show();
        }

        private void btnmodicommande_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.btnfermer.Visible = false;
            activation(f7);
            f7.idcmmdeEdit= int.Parse(dgvCmmde.CurrentRow.Cells[0].Value.ToString());
            f7.cbxTyppeTissu.Text = dgvCmmde.CurrentRow.Cells[3].Value.ToString();
            f7.txtlngTissu.Text= dgvCmmde.CurrentRow.Cells[4].Value.ToString();
            f7.txtPrix.Text= dgvCmmde.CurrentRow.Cells[5].Value.ToString();
            f7.txtavancement.Text = dgvCmmde.CurrentRow.Cells[6].Value.ToString();
            f7.file.FileName = imgModel.ImageLocation;
            f7.Show();
            this.Close();
        }
    }
}
