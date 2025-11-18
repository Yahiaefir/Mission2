using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Mission_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           gp.Visible = false;
           gp1.Visible = false; 
           
        }

        private void afficherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tb.Visible = false;
            gp.Visible = true;
            lbl.Text = "Afficher les liaisons correspondantes";
            btn.Text = "Afficher";
            btn.Tag = "1";
            

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb.Visible = true; 
            gp.Visible = true;
            lbl.Text = " Modifier la durée : ";
            btn.Text = "Valider";
            btn.Tag = "2";
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb.Visible = false;
            gp.Visible = true;
            lbl.Text = "Supprimer une liaison ";
            btn.Text = "Supprimer";
            btn.Tag = "3";
            
        }

        private void insérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Compte co = (Compte)lb.SelectedItem;
           // Client leClient = co.Propriétaire();

            
            
            FormInsertion fc = new FormInsertion();
            fc.ShowDialog();
        }
    }
}
