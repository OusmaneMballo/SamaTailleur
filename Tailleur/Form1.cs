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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public tailleurdbEntities DBA = new tailleurdbEntities();
        Boolean ok = true;
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Boolean authentification(string login, string passwd)
        {
            try
            {
                List<admin> listAdmin = DBA.admins.ToList();
                foreach (admin ad in listAdmin)
                {
                    if (ad.login.CompareTo(login) == 0 && ad.passwd.CompareTo(passwd) == 0)
                    {
                        return true;
                    }
                   
                }
            }
            catch(Exception ex)
            {
                return false;
            }
            return false;
        }
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            List<admin> listAdmin = DBA.admins.ToList();

            foreach (admin ad in listAdmin)
                {
                    if (ad.login.CompareTo(txtlogin.Text) == 0 && ad.passwd.CompareTo(txtpasswd.Text) == 0)
                    {
                        Parent f2 = new Parent();
                        f2.lbllogAdmin.Text = ad.login;
                        f2.lblnomAdmin.Text = ad.nom;
                        f2.lblprenomAdm.Text = ad.prenom;
                        if (ad.image != "")
                        {
                            f2.pprofil.ImageLocation = ad.image;
                        }
                    if (ad.droit.CompareTo("privilegie") != 0)
                    {
                        f2.btnaddAmin.Enabled = false;
                        f2.btnretirAdmin.Enabled = false;
                    }
                        f2.id = ad.id;
                        f2.Show();
                        f2.WindowState = FormWindowState.Normal;
                        this.Hide();
                        ok = false;
                        break;
                    }
                }
                if(ok)
                {
                      MessageBox.Show("Login ou Mot de passe incorrect!...");
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
