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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        tailleurdbEntities DBA = new tailleurdbEntities();
        Form3 f3 = new Form3();
        private void btnannulerEdit_Click(object sender, EventArgs e)
        {
            this.Close();
            f3.Show();
        }

        private void btnEditCl_Click(object sender, EventArgs e)
        {
            if (verification())
            {
                if (txtidedit.Text != "")
                {
                    client clEdit = DBA.clients.Find(int.Parse(txtidedit.Text));
                    clEdit.adresse = txtadresseEdit.Text;
                    clEdit.email = txtmailEdit.Text;
                    clEdit.genre = cbxGenreEdit.Text;
                    clEdit.nom = txtnomEdit.Text;
                    clEdit.prenom = txtprenomEdit.Text;
                    clEdit.tel = txttelephoneEdit.Text;
                    DBA.SaveChanges();
                    reinitialiser();
                }
                this.Close();
                f3.Show();
            }
            else
            {
                MessageBox.Show("Attention!... Tous les champs en (*) doivent etre renseignés!");
            }
        }

        void reinitialiser()
        {
             txtadresseEdit.Clear();
            txtmailEdit.Clear();
            txtnomEdit.Clear();
            txtprenomEdit.Clear();
           txttelephoneEdit.Clear();
        }

        Boolean verification()
        {
            if (txtnomEdit.Text == "" || txtprenomEdit.Text == "" || txttelephoneEdit.Text == "")
            {
                return false;
            }
            return true;
        }

        private void txtnomEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txttelephoneEdit_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtprenomEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
