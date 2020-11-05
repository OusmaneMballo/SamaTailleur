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
    public partial class Form6 : Form
    {
        public string genre;
        public int idmesureSup=0;
        public int idclient = 0;
        public int idcommde = 0;
        public Form6()
        {
            InitializeComponent();
        }
        tailleurdbEntities DBA = new tailleurdbEntities();
        int idmesure;
        private void btnNon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOui_Click(object sender, EventArgs e)
        {
            if (idclient != 0)
            {
                client clsup = DBA.clients.Find(idclient);
                DBA.clients.Remove(clsup);
                DBA.SaveChanges();
                MessageBox.Show("Client supprimé");

            }
            if (idmesureSup != 0)
            {
                mesure Mesure = new mesure();
                List<mesure> listMsure = DBA.mesures.ToList();
                foreach (mesure lM in listMsure)
                {
                    if (lM.idclient == idmesureSup)
                    {
                        idmesure = lM.id;
                        Mesure = DBA.mesures.Find(lM.id);
                        DBA.mesures.Remove(Mesure);
                        break;
                    }
                }
                if (genre.ToLowerInvariant().CompareTo("masculin") == 0)
                {
                    homme Hmme = new homme();
                    List<homme> listHomme = DBA.hommes.ToList();
                    foreach (homme H in listHomme)
                    {
                        if (H.idmesure == idmesure)
                        {
                            Hmme = DBA.hommes.Find(H.id);
                            DBA.hommes.Remove(Hmme);
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
                            Fmme = DBA.femmes.Find(F.id);
                            DBA.femmes.Remove(Fmme);
                            break;
                        }
                    }
                }
            }
            if (idcommde != 0) {
                commande com = new commande();
                List<commande> listCmmde = DBA.commandes.ToList();
                foreach(commande cmmde in listCmmde)
                {
                    if (cmmde.id == idcommde)
                    {
                        com = DBA.commandes.Find(cmmde.id);
                        DBA.commandes.Remove(com);
                    }
                }
            }
            DBA.SaveChanges();
            this.Close();
        }
        
    }
}
