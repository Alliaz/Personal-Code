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
    public partial class FormMenu : Form
    {
        public List<Fordon> Fordon { get; set; }
        public List<Anställd> Anställd { get; set; }
        public List<Maträtt> Maträtt { get; set; }
        public List<Recept> Recept { get; set; }
        public List<Ingrediens> Ingrediens { get; set; }
        public List<Allergi> Allergi { get; set; }

        public FormMenu()
        {
            InitializeComponent();
            GenereraLista();
            UpdateInterface();
        }
         //Denna metoden genererar våra listor vid exekvering
        public void GenereraLista()
        {
            Fordon = new List<Fordon>();
            Anställd = new List<Anställd>();
            Maträtt = new List<Maträtt>();
            Recept = new List<Recept>();
            Ingrediens = new List<Ingrediens>();
            Allergi = new List<Allergi>();

            Fordon fordon = new Fordon();
            Fordon.Add(
            new Fordon()
            {
                fordonsNamn = "Bil Oscar",
                registereringsNummer = "XBX 405",

            }
            );
          
        }
        //Denna metod uppdaterar UI
        public void UpdateInterface()
        {

            if (dataGridViewBil.CurrentRow != null)
            {
                dataGridViewAnställd.DataSource = null;
                dataGridViewAnställd.DataSource = ((Fordon)dataGridViewBil.CurrentRow.DataBoundItem).Anställd;
                dataGridViewMaträtt.DataSource = null;
                dataGridViewMaträtt.DataSource = ((Fordon)dataGridViewBil.CurrentRow.DataBoundItem).Maträtt;

            }
            if (dataGridViewMaträtt.CurrentRow != null)
            {
                dataGridViewRecept.DataSource = null;
                dataGridViewRecept.DataSource = ((Maträtt)dataGridViewMaträtt.CurrentRow.DataBoundItem).Recept;
            }
            if (dataGridViewRecept.CurrentRow != null)
            {
                dataGridViewIngrediens.DataSource = null;
                dataGridViewIngrediens.DataSource = ((Recept)dataGridViewRecept.CurrentRow.DataBoundItem).Ingrediens;
            }
            if (dataGridViewIngrediens.CurrentRow != null)
            {
                dataGridViewAllergi.DataSource = null;
                dataGridViewAllergi.DataSource = ((Ingrediens)dataGridViewIngrediens.CurrentRow.DataBoundItem).Allergi;

            }

            dataGridViewBil.DataSource = null;
            dataGridViewBil.DataSource = Fordon;


        }
            //Lägga till fordon till system
        private void btn_fordon_Click(object sender, EventArgs e)
        {
            Fordon fordon = new Fordon();
            fordon.fordonsNamn = txtFordon.Text;
            fordon.registereringsNummer = txtRegNr.Text;

            Fordon.Add(fordon);
            UpdateInterface();

            
        }
            //Lägga till anställda till fordon
        private void btn_anställdfordon_Click(object sender, EventArgs e)
        {
            Anställd anställd = new Anställd();
            anställd.anställdNummer = int.Parse(txtAnställd.Text);
            anställd.AnställdNamn = txtAnstNamn.Text;
            anställd.kontaktNummer = int.Parse(txtKontaktnummer.Text);

            ((Fordon)dataGridViewBil.CurrentRow.DataBoundItem).Anställd.Add(anställd);
            UpdateInterface();


        }
            //Lägga till maträtt till fordon
        private void btnAddMaträtt_Click(object sender, EventArgs e)
        {
            Maträtt maträtt = new Maträtt();
            maträtt.maträttNamn = txtMaträtt.Text;
            maträtt.pris = int.Parse(txtPris.Text);
            maträtt.maträttBeskrivning = txtBeskrivning.Text;

           ((Fordon)dataGridViewBil.CurrentRow.DataBoundItem).Maträtt.Add(maträtt);
            UpdateInterface();
        }
            //Lägga till recept till en maträtt
        private void btnRecept_Click(object sender, EventArgs e)
        {
            Recept recept = new Recept();
            recept.receptNamn = txtRecept.Text;

            ((Maträtt)dataGridViewMaträtt.CurrentRow.DataBoundItem).Recept.Add(recept);
            UpdateInterface();
        }
            //Lägga till en ingrediens till ett recept
        private void btnIngrediens_Click(object sender, EventArgs e)
        {
            Ingrediens ingrediens = new Ingrediens();
            ingrediens.ingrediensNamn = txtIngrediensNamn.Text;

            ((Recept)dataGridViewRecept.CurrentRow.DataBoundItem).Ingrediens.Add(ingrediens);
            UpdateInterface();
        }
            //Lägga till allergi till en ingrediens
        private void btnAddAllergi_Click(object sender, EventArgs e)
        {
            Allergi allergi = new Allergi();
            allergi.allergiNamn = txtAllergiNamn.Text;
            allergi.allergiBeskrivning = txtAllergiBeskrivning.Text;

            ((Ingrediens)dataGridViewIngrediens.CurrentRow.DataBoundItem).Allergi.Add(allergi);
            UpdateInterface();
        }
            //Knappen för att öppna form för övriga anställda
        private void btnÖvrigaAnställda_Click(object sender, EventArgs e)
        {
            new FormÖvrigFörare().Show();
        }

            //Denna metoden updaterar vår UI vid klick av objekt i datagridview
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateInterface();
        }
            //Dessa metoder under tar bort objekt för respektive datagridview
        private void btnRemoveFordon_Click(object sender, EventArgs e)
        {
            int i = dataGridViewBil.CurrentCell.RowIndex;
            Fordon.RemoveAt(i);

            UpdateInterface();
        }

        private void btnRemoveAnställd_Click(object sender, EventArgs e)
        {
            int i = dataGridViewAnställd.CurrentCell.RowIndex;
            Anställd.RemoveAt(i);
            UpdateInterface();
        }

        private void btnRemoveMaträtt_Click(object sender, EventArgs e)
        {
            int i = dataGridViewMaträtt.CurrentCell.RowIndex;
            Maträtt.RemoveAt(i);
            UpdateInterface();
        }

        private void btnRemoveRecept_Click(object sender, EventArgs e)
        {
            int i = dataGridViewRecept.CurrentCell.RowIndex;
            Recept.RemoveAt(i);
            UpdateInterface();
        }

        private void btnRemoveIngrediens_Click(object sender, EventArgs e)
        {
            int i = dataGridViewIngrediens.CurrentCell.RowIndex;
            Ingrediens.RemoveAt(i);
            UpdateInterface();
        }

        private void btnRemoveAllergi_Click(object sender, EventArgs e)
        {
            int i = dataGridViewAllergi.CurrentCell.RowIndex;
            Allergi.RemoveAt(i);
            UpdateInterface();
        }
    }
}
