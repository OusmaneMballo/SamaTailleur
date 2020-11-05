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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        tailleurdbEntities DBA = new tailleurdbEntities();
        public int idEdit;

        void listClient()
        {
            List<client> listClt = DBA.clients.ToList();

            foreach (client Cl in listClt)
            {
                dgvClient.Rows.Add(Cl.prenom, Cl.nom, Cl.genre, Cl.tel, Cl.email, Cl.adresse, Cl.id);
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

            dgvClient.Columns.Add("prenom", "Prenom");
            dgvClient.Columns.Add("nom", "Nom");
            dgvClient.Columns.Add("genre", "Genre");
            dgvClient.Columns.Add("tel", "Telephone");
            dgvClient.Columns.Add("mail", "E-mail");
            dgvClient.Columns.Add("adresse", "Adresse");
            dgvClient.Columns.Add("id", "ID");

            listClient();
        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.txtnomEdit.Text = dgvClient.CurrentRow.Cells[1].Value.ToString();
            f4.txtprenomEdit.Text= dgvClient.CurrentRow.Cells[0].Value.ToString();
            f4.txttelephoneEdit.Text = dgvClient.CurrentRow.Cells[3].Value.ToString();
            f4.txtadresseEdit.Text = dgvClient.CurrentRow.Cells[5].Value.ToString();
            f4.txtmailEdit.Text = dgvClient.CurrentRow.Cells[4].Value.ToString();
            f4.txtidedit.Text = dgvClient.CurrentRow.Cells[6].Value.ToString();
            f4.cbxGenreEdit.Text= dgvClient.CurrentRow.Cells[2].Value.ToString();
            f4.Show();
            this.Close();
        }

        private void btnsup_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.idclient= f6.idmesureSup=int.Parse(dgvClient.CurrentRow.Cells[6].Value.ToString());
            f6.genre = dgvClient.CurrentRow.Cells[5].Value.ToString();
            f6.lblSup.Text += " Supprimer ce client?";
            f6.Show();
            this.Close();
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnmodifier.Enabled = true;
            btnsup.Enabled = true;
        }
    }
}
