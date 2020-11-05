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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        tailleurdbEntities DBA = new tailleurdbEntities();
        int idmesure;
        int idhomme;
        int idfemme;
        Boolean okey = false;
        public Boolean recherche = false;
        public int idclient = 0;
        private void btnrtr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dgvMesure.Columns.Add("prenom", "Prenom");
            dgvMesure.Columns.Add("nom", "Nom");
            dgvMesure.Columns.Add("genre", "Genre");
            dgvMesure.Columns.Add("id", "ID");
            List<client> listClt = DBA.clients.ToList();

            foreach (client Cl in listClt)
            {
                    dgvMesure.Rows.Add(Cl.prenom, Cl.nom, Cl.genre, Cl.id);
            }
            if (recherche)
            {
                listerMesures(idclient);
            }
        }
        //On verifi si le clien a des mesures!
        Boolean verifiMesureExiste(int idCl)
        {
            List<mesure> listMsure = DBA.mesures.ToList();
            foreach (mesure Lm in listMsure)
            {
                if (Lm.idclient == idCl)
                {
                    return true;
                    
                }
            }
                return false;
        }
        //Pour lire toute les mesures d'un clients
        int listerMesures(int idclient)
        {
            List<mesure> listMsure = DBA.mesures.ToList();
            int ok = 0;
            foreach (mesure Cl in listMsure)
            {
                if (Cl.idclient == idclient)
                {
                    txtceinture.Text = Cl.ceinture.ToString();
                    txtcrteManche.Text = Cl.manchecourte.ToString();
                    txtepole.Text = Cl.epole.ToString();
                    txtlngManche.Text = Cl.manchelong.ToString();
                    txtlngPentaln.Text = Cl.longpentalon.ToString();
                    txtpoitrine.Text = Cl.poitrine.ToString();
                    txttourBras.Text = Cl.tourebras.ToString();
                    txtTourCuisse.Text = Cl.tourecuisse.ToString();
                    txttourFsse.Text = Cl.tourefesse.ToString();
                    idmesure = Cl.id;
                    ok = 1;
                    break;
                }
            }
            if (ok == 1)
            {
                if (dgvMesure.CurrentRow.Cells[2].Value.ToString().ToLowerInvariant().CompareTo("masculin") == 0)
                {
                    homme Hmme = new homme();
                    List<homme> listHomme = DBA.hommes.ToList();
                    foreach (homme H in listHomme)
                    {
                        if (H.idmesure == idmesure)
                        {
                            txtcout.Text = H.cout.ToString();
                            txtlngSaison.Text = H.longdemisaison.ToString();
                            idhomme = H.id;
                            break;
                        }
                    }
                }
                else
                {
                    femme Fmme = new femme();
                    List<femme> listfemme = DBA.femmes.ToList();
                    foreach (femme F in listfemme)
                    {
                        if (F.idmesure == idmesure)
                        {
                            txtlng3_4.Text = F.long3_4.ToString();
                            txtlngRobe.Text = F.longrobe.ToString();
                            txtlngTlleBasse.Text = F.longtaillebasse.ToString();
                            txtlngZupe.Text = F.longzupe.ToString();
                            txtTaille.Text = F.taille.ToString();
                            idfemme = F.id;
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas enregistré des mesures pour ce client");
            }
            return ok;
        }


        Boolean verificationMesure()
        {
            if (txtceinture.Text==""||
                txtcrteManche.Text==""||
                txtepole.Text==""||
                txtlngManche.Text==""||
                txtlngPentaln.Text==""||
                txtpoitrine.Text==""||
                txttourBras.Text==""||
                txtTourCuisse.Text==""||
                txttourFsse.Text=="")
            {
                return false;
            }
            return true;
        }

        Boolean champsHomme()
        {
            if (txtlngSaison.Text==""|| txtcout.Text=="")
            {
                return false;
            }
            return true;
        }
        Boolean champsFemme()
        {
            if (
                txtlng3_4.Text==""||
                txtlngRobe.Text==""||
                txtlngTlleBasse.Text==""||
                txtlngZupe.Text==""||
                txtTaille.Text==""
                )
            {
                return false;
            }
            return true;
        }
        void activationChamps()
        {
            txtceinture.Enabled = true;
            txtcrteManche.Enabled = true;
            txtepole.Enabled = true;
            txtlngManche.Enabled = true;
            txtlngPentaln.Enabled = true;
            txtpoitrine.Enabled = true;
            txttourBras.Enabled = true;
            txtTourCuisse.Enabled = true;
            txttourFsse.Enabled = true;
            lblMessage.Text = "";
            if (dgvMesure.CurrentRow.Cells[2].Value.ToString().ToLowerInvariant().CompareTo("masculin") == 0)
            {
                txtlngSaison.Enabled = true;
                txtcout.Enabled = true;
                txtlngSaison.Focus();

                txtlng3_4.Enabled = false;
                txtlngRobe.Enabled = false;
                txtlngTlleBasse.Enabled = false;
                txtlngZupe.Enabled = false;
                txtTaille.Enabled = false;
            }
            else
            {
                txtlng3_4.Enabled = true;
                txtlngRobe.Enabled = true;
                txtlngTlleBasse.Enabled = true;
                txtlngZupe.Enabled = true;
                txtTaille.Enabled = true;
                txtlngZupe.Focus();

                txtlngSaison.Enabled = false;
                txtcout.Enabled = false;
            }
        }


        Boolean testchampsDesactiver()
        {
            if (txtlngSaison.Enabled == false && txtcout.Enabled == false)
            {
                return true;
            }
            return false;
        }
        void vider()
        {
            txtceinture.Text = "";
            txtcrteManche.Text = "";
            txtepole.Text = "";
            txtlngManche.Text = "";
            txtlngPentaln.Text = "";
            txtpoitrine.Text = "";
            txttourBras.Text = "";
            txtTourCuisse.Text = "";
            txttourFsse.Text = "";
            txtlngSaison.Text = "";
            txtcout.Text = "";
            txtlng3_4.Text = "";
            txtlngRobe.Text = "";
            txtlngTlleBasse.Text ="";
            txtlngZupe.Text = "";
            txtTaille.Text = "";
        }
        void lectureSeul()
        {
            txtceinture.Enabled = false;
            txtcrteManche.Enabled = false;
            txtepole.Enabled = false;
            txtlngManche.Enabled = false;
            txtlngPentaln.Enabled = false;
            txtpoitrine.Enabled = false;
            txttourBras.Enabled = false;
            txtTourCuisse.Enabled = false;
            txttourFsse.Enabled = false;
            txtlng3_4.Enabled = false;
            txtlngRobe.Enabled = false;
            txtlngTlleBasse.Enabled = false;
            txtlngZupe.Enabled = false;
            txtTaille.Enabled = false;
            txtlngSaison.Enabled = false;
            txtcout.Enabled = false;
        }
        void reinitialiser()
        {
            lectureSeul();
            btnAnnulerMesure.Enabled = false;
            btnEditMesure.Enabled = false;
            btnenregistrerMesure.Enabled = false;
            btnSupprimer.Enabled = false;
        }
        private void dgvMesure_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditMesure.Text = "&Modifier";
            vider();
            activationChamps();
            btnenregistrerMesure.Enabled = true;
            btnEditMesure.Enabled = true;
            btnSupprimer.Enabled = true;
            btnAfficher.Enabled = true;
        }

        private void btnenregistrerMesure_Click(object sender, EventArgs e)
        {
            
            if (verificationMesure())
            {
                if(( testchampsDesactiver() && champsFemme())|| (testchampsDesactiver() == false && champsHomme()))
                {
                    if (!(verifiMesureExiste(int.Parse(dgvMesure.CurrentRow.Cells[3].Value.ToString()))))
                    {
                        mesure Mesure = new mesure();
                        homme Homme = new homme();
                        femme Femme = new femme();
                        Mesure.ceinture = int.Parse(txtceinture.Text);
                        Mesure.epole = int.Parse(txtepole.Text);
                        Mesure.longpentalon = int.Parse(txtlngPentaln.Text);
                        Mesure.manchecourte = int.Parse(txtcrteManche.Text);
                        Mesure.manchelong = int.Parse(txtlngManche.Text);
                        Mesure.poitrine = int.Parse(txtpoitrine.Text);
                        Mesure.tourebras = int.Parse(txttourBras.Text);
                        Mesure.tourecuisse = int.Parse(txtTourCuisse.Text);
                        Mesure.tourefesse = int.Parse(txttourFsse.Text);
                        Mesure.idclient = int.Parse(dgvMesure.CurrentRow.Cells[3].Value.ToString());
                        DBA.mesures.Add(Mesure);
                        DBA.SaveChanges();
                        if (dgvMesure.CurrentRow.Cells[2].Value.ToString().ToLowerInvariant().CompareTo("masculin") == 0)
                        {
                            Homme.longdemisaison = int.Parse(txtlngSaison.Text);
                            Homme.cout = int.Parse(txtcout.Text);
                            Homme.idmesure = DBA.mesures.ToList().Last().id;
                            DBA.hommes.Add(Homme);
                            DBA.SaveChanges();
                            lblMessage.Text = "La mesure est ajoutée avec succé...!";

                            vider();
                            reinitialiser();

                        }
                        else
                        {
                            Femme.long3_4 = int.Parse(txtlng3_4.Text);
                            Femme.longrobe = int.Parse(txtlngRobe.Text);
                            Femme.longtaillebasse = int.Parse(txtlngTlleBasse.Text);
                            Femme.longzupe = int.Parse(txtlngZupe.Text);
                            Femme.taille = int.Parse(txtTaille.Text);
                            Femme.idmesure = DBA.mesures.ToList().Last().id;
                            DBA.femmes.Add(Femme);
                            DBA.SaveChanges();
                            lblMessage.Text = "La mesure est ajoutée avec succé...!";
                            vider();
                            reinitialiser();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Desolé! vous avez déja ajouté des mesures pour ce client");
                        listerMesures(int.Parse(dgvMesure.CurrentRow.Cells[3].Value.ToString()));
                        reinitialiser();
                        btnEditMesure.Enabled = true;
                        btnAfficher.Enabled = false;
                        btnAnnulerMesure.Enabled = true;
                        
                    }
                }
                else
                {
                    MessageBox.Show("Merci de bien vouloir remplir tous les champs Activés!");
                }
               
            }
            else
            {
                MessageBox.Show("Merci de bien vouloir remplir tous les champs Activés!");
            }
           
           
        }

        private void btnEditMesure_Click(object sender, EventArgs e)
        {
            activationChamps();
            if (okey == false)
            {
                if (listerMesures(int.Parse(dgvMesure.CurrentRow.Cells[3].Value.ToString())) == 1)
                {
                    btnEditMesure.Text = "&Valider la modification";
                    btnAnnulerMesure.Enabled = true;
                    okey = true;
                }
            }
            else
            {
                mesure MesureEdit = DBA.mesures.Find(idmesure);
                MesureEdit.ceinture = int.Parse(txtceinture.Text);
                MesureEdit.epole = int.Parse(txtepole.Text);
                MesureEdit.longpentalon = int.Parse(txtlngPentaln.Text);
                MesureEdit.manchecourte = int.Parse(txtcrteManche.Text);
                MesureEdit.manchelong = int.Parse(txtlngManche.Text);
                MesureEdit.poitrine = int.Parse(txtpoitrine.Text);
                MesureEdit.tourebras = int.Parse(txttourBras.Text);
                MesureEdit.tourecuisse = int.Parse(txtTourCuisse.Text);
                MesureEdit.tourefesse = int.Parse(txttourFsse.Text);
                

                if (dgvMesure.CurrentRow.Cells[2].Value.ToString().ToLowerInvariant().CompareTo("masculin") == 0)
                {
                    homme HommeEdit = DBA.hommes.Find(idhomme);
                    HommeEdit.longdemisaison = int.Parse(txtlngSaison.Text);
                    HommeEdit.cout = int.Parse(txtcout.Text);
                    DBA.SaveChanges();
                }
                else
                {
                    femme FemmeEdit = DBA.femmes.Find(idfemme);
                    FemmeEdit.long3_4 = int.Parse(txtlng3_4.Text);
                    FemmeEdit.longrobe = int.Parse(txtlngRobe.Text);
                    FemmeEdit.longtaillebasse = int.Parse(txtlngTlleBasse.Text);
                    FemmeEdit.longzupe = int.Parse(txtlngZupe.Text);
                    FemmeEdit.taille = int.Parse(txtTaille.Text);
                }
                DBA.SaveChanges();
                lblMessage.Text = "La mesure est modifiée avec succé...!";
                okey = false;
                vider();
                btnEditMesure.Text = "&Modifier";
                reinitialiser();
            }

        }

        private void txtlngSaison_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnenregistrerMesure.Text = "&Enregistrer";
            btnAnnulerMesure.Enabled = true;
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (txtlngSaison.Text == "")
            {
                btnenregistrerMesure.Text = "&Ajouter";
                btnAnnulerMesure.Enabled = false;
            }
        }

        private void txtlngZupe_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnenregistrerMesure.Text = "&Enregistrer";
            btnAnnulerMesure.Enabled = true;
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (txtlngZupe.Text == "")
            {
                btnenregistrerMesure.Text = "&Ajouter";
                btnAnnulerMesure.Enabled = false;
            }
        }

        private void btnAnnulerMesure_Click(object sender, EventArgs e)
        {
            okey = false;
            btnEditMesure.Text = "&Modifier";
            vider();
            reinitialiser();
        }

        private void txtcout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtlngRobe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtTaille_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtlng3_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtlngTlleBasse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtepole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtpoitrine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtlngManche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtlngPentaln_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) ||  Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txttourBras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)|| Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtcrteManche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtTourCuisse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)  || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtceinture_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txttourFsse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)  || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.lblSup.Text += " Supprimer ses mesures?";
            f6.idmesureSup = int.Parse(dgvMesure.CurrentRow.Cells[3].Value.ToString());
            f6.genre = dgvMesure.CurrentRow.Cells[2].Value.ToString();
            f6.Show();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            listerMesures(int.Parse(dgvMesure.CurrentRow.Cells[3].Value.ToString()));
            reinitialiser();
            btnEditMesure.Enabled = true;
            btnSupprimer.Enabled = true;
        }
    }
}
