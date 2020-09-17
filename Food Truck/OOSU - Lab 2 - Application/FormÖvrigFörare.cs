using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOSU___Lab_2___Application
{
    public partial class FormÖvrigFörare : Form
    {
        public List<Förare> Förare { get; set; }
        public List<ÖvrigAnställd> ÖvrigaAnställd { get; set; }

        public FormÖvrigFörare()
        {
            InitializeComponent();
            GenereraLista();
        }

        public void GenereraLista()
        {
            Förare = new List<Förare>();
            ÖvrigaAnställd = new List<ÖvrigAnställd>();
        }

        public void UpdateInterface()
        {
            dataGridViewFörare.DataSource = null;
            dataGridViewFörare.DataSource = Förare;

            dataGridViewÖvriga.DataSource = null;
            dataGridViewÖvriga.DataSource = ÖvrigaAnställd;
        }

        private void btnAddFörare_Click(object sender, EventArgs e)
        {
            Förare FordonsFörare = new Förare();
            FordonsFörare.anställdNummer = int.Parse(txtAnstNrFörare.Text);
            FordonsFörare.AnställdNamn = txtNamnFörare.Text;
            FordonsFörare.kontaktNummer = int.Parse(txtKontaktNrFörare.Text);
            FordonsFörare.fordonsBehörighet = txtFörarbehörighet.Text;

            Förare.Add(FordonsFörare);
            UpdateInterface();
        }

        private void btnAddÖvrigAnställd_Click(object sender, EventArgs e)
        {
            ÖvrigAnställd ÖvrigAnställd = new ÖvrigAnställd();
            ÖvrigAnställd.anställdNummer = int.Parse(txtAnstNrÖvrig.Text);
            ÖvrigAnställd.AnställdNamn = txtNamnÖvrig.Text;
            ÖvrigAnställd.kontaktNummer = int.Parse(txtKontaktNrÖvrig.Text);
            ÖvrigAnställd.position = txtPosition.Text;

            ÖvrigaAnställd.Add(ÖvrigAnställd);
            UpdateInterface();
        }

        private void btnRemoveFörare_Click(object sender, EventArgs e)
        {
            int i = dataGridViewFörare.CurrentCell.RowIndex;
            Förare.RemoveAt(i);
            UpdateInterface();
        }

        private void btnRemoveÖvrigAnställd_Click(object sender, EventArgs e)
        {
            int i = dataGridViewÖvriga.CurrentCell.RowIndex;
            ÖvrigaAnställd.RemoveAt(i);
            UpdateInterface();
        }
    }
}
       
    


