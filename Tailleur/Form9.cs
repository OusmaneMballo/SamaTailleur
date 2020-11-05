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
    public partial class Form9 : Form
    {
        tailleurdbEntities DBA = new tailleurdbEntities();
        public Form9()
        {
            InitializeComponent();
        }

        private void btnrtre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRecherchtelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            txtnom.Enabled = false;
            txtRechercheprenom.Enabled = false;
            btnRechercher.Enabled = true;
            if (txtRecherchtelephone.Text == "")
            {
                txtnom.Enabled = true;
                txtRechercheprenom.Enabled = true;
                btnRechercher.Enabled = false;
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if(txtRechercheprenom.Text=="" && txtnom.Text=="" && txtRecherchtelephone.Text == "")
            {
                Form8 f8 = new Form8();
                f8.recherche = true;
                f8.dateRecher = dateRecherche.Value.Date;
                f8.lblListCommde.Text += " de la date du " + dateRecherche.Value.Date.ToString();
                this.Close();
                f8.Show();
            }
            else
            {
                if (txtRecherchtelephone.Text != "")
                {
                    List<client> listClt = DBA.clients.ToList();
                    foreach(client cl in listClt)
                    {
                        if (cl.tel.ToLower().CompareTo(txtRecherchtelephone.Text.ToLower()) == 0)
                        {
                            Form5 f5 = new Form5();
                            f5.recherche = true;
                            f5.idclient = cl.id;
                            f5.Show();
                            this.Close();
                        }
                    }

                }
                else
                {
                    List<client> listClt = DBA.clients.ToList();
                    foreach (client cl in listClt)
                    {
                        if (cl.nom.ToLower().CompareTo(txtnom.Text.ToLower()) == 0 && cl.prenom.ToLower().CompareTo(txtRechercheprenom.Text.ToLower()) == 0)
                        {
                            Form5 f5 = new Form5();
                            f5.recherche = true;
                            f5.idclient = cl.id;
                            f5.Show();
                            this.Close();
                        }
                    }
                }

            }
            lblErreur.Visible = true;
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
                btnRechercher.Enabled = true;
            if (txtnom.Text == "")
            {
                btnRechercher.Enabled = false;
            }
        }

        private void txtRechercheprenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
                btnRechercher.Enabled = true;
            if (txtRechercheprenom.Text == "")
            {
                btnRechercher.Enabled = false;
            }
        }

        private void dateRecherche_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
