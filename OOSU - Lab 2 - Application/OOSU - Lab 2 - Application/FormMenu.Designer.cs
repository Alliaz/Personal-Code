namespace OOSU___Lab_2___Application
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewAnställd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_fordon = new System.Windows.Forms.Button();
            this.btn_anställdfordon = new System.Windows.Forms.Button();
            this.txtFordon = new System.Windows.Forms.TextBox();
            this.txtAnställd = new System.Windows.Forms.TextBox();
            this.txtRegNr = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnstNamn = new System.Windows.Forms.TextBox();
            this.txtKontaktnummer = new System.Windows.Forms.TextBox();
            this.dataGridViewBil = new System.Windows.Forms.DataGridView();
            this.dataGridViewMaträtt = new System.Windows.Forms.DataGridView();
            this.btnAddMaträtt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaträtt = new System.Windows.Forms.TextBox();
            this.dataGridViewIngrediens = new System.Windows.Forms.DataGridView();
            this.btnIngrediens = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIngrediensNamn = new System.Windows.Forms.TextBox();
            this.dataGridViewRecept = new System.Windows.Forms.DataGridView();
            this.btnRecept = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRecept = new System.Windows.Forms.TextBox();
            this.dataGridViewAllergi = new System.Windows.Forms.DataGridView();
            this.btnAddAllergi = new System.Windows.Forms.Button();
            this.txtAllergiNamn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPris = new System.Windows.Forms.TextBox();
            this.txtBeskrivning = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAllergiBeskrivning = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnÖvrigaAnställda = new System.Windows.Forms.Button();
            this.btnRemoveFordon = new System.Windows.Forms.Button();
            this.btnRemoveMaträtt = new System.Windows.Forms.Button();
            this.btnRemoveAnställd = new System.Windows.Forms.Button();
            this.btnRemoveRecept = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnRemoveIngrediens = new System.Windows.Forms.Button();
            this.btnRemoveAllergi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnställd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaträtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngrediens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllergi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAnställd
            // 
            this.dataGridViewAnställd.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAnställd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnställd.Location = new System.Drawing.Point(353, 149);
            this.dataGridViewAnställd.Name = "dataGridViewAnställd";
            this.dataGridViewAnställd.Size = new System.Drawing.Size(590, 170);
            this.dataGridViewAnställd.TabIndex = 1;
            this.dataGridViewAnställd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridViewAnställd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridViewAnställd.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fordon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anställda";
            // 
            // btn_fordon
            // 
            this.btn_fordon.Location = new System.Drawing.Point(12, 27);
            this.btn_fordon.Name = "btn_fordon";
            this.btn_fordon.Size = new System.Drawing.Size(115, 32);
            this.btn_fordon.TabIndex = 4;
            this.btn_fordon.Text = "Lägg till Fordon";
            this.btn_fordon.UseVisualStyleBackColor = true;
            this.btn_fordon.Click += new System.EventHandler(this.btn_fordon_Click);
            // 
            // btn_anställdfordon
            // 
            this.btn_anställdfordon.Location = new System.Drawing.Point(353, 26);
            this.btn_anställdfordon.Name = "btn_anställdfordon";
            this.btn_anställdfordon.Size = new System.Drawing.Size(151, 57);
            this.btn_anställdfordon.TabIndex = 5;
            this.btn_anställdfordon.Text = "Lägg till anställd till fordon";
            this.btn_anställdfordon.UseVisualStyleBackColor = true;
            this.btn_anställdfordon.Click += new System.EventHandler(this.btn_anställdfordon_Click);
            // 
            // txtFordon
            // 
            this.txtFordon.Location = new System.Drawing.Point(12, 84);
            this.txtFordon.Name = "txtFordon";
            this.txtFordon.Size = new System.Drawing.Size(115, 20);
            this.txtFordon.TabIndex = 6;
            // 
            // txtAnställd
            // 
            this.txtAnställd.Location = new System.Drawing.Point(517, 27);
            this.txtAnställd.Name = "txtAnställd";
            this.txtAnställd.Size = new System.Drawing.Size(100, 20);
            this.txtAnställd.TabIndex = 7;
            // 
            // txtRegNr
            // 
            this.txtRegNr.Location = new System.Drawing.Point(12, 123);
            this.txtRegNr.Name = "txtRegNr";
            this.txtRegNr.Size = new System.Drawing.Size(115, 20);
            this.txtRegNr.TabIndex = 8;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(9, 67);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(71, 13);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "Fordonsnamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Reg.Nr";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(514, 9);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(70, 13);
            this.lbl4.TabIndex = 13;
            this.lbl4.Text = "Anst.Nummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Namn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kontaktnummer";
            // 
            // txtAnstNamn
            // 
            this.txtAnstNamn.Location = new System.Drawing.Point(517, 66);
            this.txtAnstNamn.Name = "txtAnstNamn";
            this.txtAnstNamn.Size = new System.Drawing.Size(100, 20);
            this.txtAnstNamn.TabIndex = 17;
            // 
            // txtKontaktnummer
            // 
            this.txtKontaktnummer.Location = new System.Drawing.Point(517, 105);
            this.txtKontaktnummer.Name = "txtKontaktnummer";
            this.txtKontaktnummer.Size = new System.Drawing.Size(100, 20);
            this.txtKontaktnummer.TabIndex = 18;
            // 
            // dataGridViewBil
            // 
            this.dataGridViewBil.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewBil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBil.Location = new System.Drawing.Point(12, 149);
            this.dataGridViewBil.Name = "dataGridViewBil";
            this.dataGridViewBil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewBil.Size = new System.Drawing.Size(328, 169);
            this.dataGridViewBil.TabIndex = 19;
            this.dataGridViewBil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridViewBil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridViewBil.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // dataGridViewMaträtt
            // 
            this.dataGridViewMaträtt.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewMaträtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaträtt.Location = new System.Drawing.Point(15, 390);
            this.dataGridViewMaträtt.Name = "dataGridViewMaträtt";
            this.dataGridViewMaträtt.Size = new System.Drawing.Size(325, 144);
            this.dataGridViewMaträtt.TabIndex = 23;
            this.dataGridViewMaträtt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridViewMaträtt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridViewMaträtt.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btnAddMaträtt
            // 
            this.btnAddMaträtt.Location = new System.Drawing.Point(21, 322);
            this.btnAddMaträtt.Name = "btnAddMaträtt";
            this.btnAddMaträtt.Size = new System.Drawing.Size(124, 23);
            this.btnAddMaträtt.TabIndex = 24;
            this.btnAddMaträtt.Text = "Lägg till maträtt";
            this.btnAddMaträtt.UseVisualStyleBackColor = true;
            this.btnAddMaträtt.Click += new System.EventHandler(this.btnAddMaträtt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Pris";
            // 
            // txtMaträtt
            // 
            this.txtMaträtt.Location = new System.Drawing.Point(18, 364);
            this.txtMaträtt.Name = "txtMaträtt";
            this.txtMaträtt.Size = new System.Drawing.Size(100, 20);
            this.txtMaträtt.TabIndex = 26;
            // 
            // dataGridViewIngrediens
            // 
            this.dataGridViewIngrediens.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewIngrediens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIngrediens.Location = new System.Drawing.Point(565, 390);
            this.dataGridViewIngrediens.Name = "dataGridViewIngrediens";
            this.dataGridViewIngrediens.Size = new System.Drawing.Size(378, 358);
            this.dataGridViewIngrediens.TabIndex = 27;
            this.dataGridViewIngrediens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridViewIngrediens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridViewIngrediens.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btnIngrediens
            // 
            this.btnIngrediens.Location = new System.Drawing.Point(633, 337);
            this.btnIngrediens.Name = "btnIngrediens";
            this.btnIngrediens.Size = new System.Drawing.Size(193, 23);
            this.btnIngrediens.TabIndex = 28;
            this.btnIngrediens.Text = "Lägg till ingrediens";
            this.btnIngrediens.UseVisualStyleBackColor = true;
            this.btnIngrediens.Click += new System.EventHandler(this.btnIngrediens_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(562, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ingredienser";
            // 
            // txtIngrediensNamn
            // 
            this.txtIngrediensNamn.Location = new System.Drawing.Point(565, 363);
            this.txtIngrediensNamn.Name = "txtIngrediensNamn";
            this.txtIngrediensNamn.Size = new System.Drawing.Size(261, 20);
            this.txtIngrediensNamn.TabIndex = 30;
            // 
            // dataGridViewRecept
            // 
            this.dataGridViewRecept.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewRecept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecept.Location = new System.Drawing.Point(353, 390);
            this.dataGridViewRecept.Name = "dataGridViewRecept";
            this.dataGridViewRecept.Size = new System.Drawing.Size(196, 144);
            this.dataGridViewRecept.TabIndex = 31;
            this.dataGridViewRecept.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridViewRecept.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridViewRecept.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btnRecept
            // 
            this.btnRecept.Location = new System.Drawing.Point(353, 338);
            this.btnRecept.Name = "btnRecept";
            this.btnRecept.Size = new System.Drawing.Size(96, 23);
            this.btnRecept.TabIndex = 32;
            this.btnRecept.Text = "Lägg till Recept";
            this.btnRecept.UseVisualStyleBackColor = true;
            this.btnRecept.Click += new System.EventHandler(this.btnRecept_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Recept";
            // 
            // txtRecept
            // 
            this.txtRecept.Location = new System.Drawing.Point(356, 364);
            this.txtRecept.Name = "txtRecept";
            this.txtRecept.Size = new System.Drawing.Size(193, 20);
            this.txtRecept.TabIndex = 34;
            // 
            // dataGridViewAllergi
            // 
            this.dataGridViewAllergi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAllergi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllergi.Location = new System.Drawing.Point(12, 620);
            this.dataGridViewAllergi.Name = "dataGridViewAllergi";
            this.dataGridViewAllergi.Size = new System.Drawing.Size(537, 128);
            this.dataGridViewAllergi.TabIndex = 35;
            this.dataGridViewAllergi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridViewAllergi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridViewAllergi.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btnAddAllergi
            // 
            this.btnAddAllergi.Location = new System.Drawing.Point(346, 540);
            this.btnAddAllergi.Name = "btnAddAllergi";
            this.btnAddAllergi.Size = new System.Drawing.Size(93, 74);
            this.btnAddAllergi.TabIndex = 36;
            this.btnAddAllergi.Text = "Lägg till en allergi";
            this.btnAddAllergi.UseVisualStyleBackColor = true;
            this.btnAddAllergi.Click += new System.EventHandler(this.btnAddAllergi_Click);
            // 
            // txtAllergiNamn
            // 
            this.txtAllergiNamn.Location = new System.Drawing.Point(12, 594);
            this.txtAllergiNamn.Name = "txtAllergiNamn";
            this.txtAllergiNamn.Size = new System.Drawing.Size(106, 20);
            this.txtAllergiNamn.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 578);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Allerginamn";
            // 
            // txtPris
            // 
            this.txtPris.Location = new System.Drawing.Point(124, 364);
            this.txtPris.Name = "txtPris";
            this.txtPris.Size = new System.Drawing.Size(100, 20);
            this.txtPris.TabIndex = 39;
            // 
            // txtBeskrivning
            // 
            this.txtBeskrivning.Location = new System.Drawing.Point(230, 364);
            this.txtBeskrivning.Name = "txtBeskrivning";
            this.txtBeskrivning.Size = new System.Drawing.Size(110, 20);
            this.txtBeskrivning.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Maträttsnamn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(227, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Beskrivning";
            // 
            // txtAllergiBeskrivning
            // 
            this.txtAllergiBeskrivning.Location = new System.Drawing.Point(124, 594);
            this.txtAllergiBeskrivning.Name = "txtAllergiBeskrivning";
            this.txtAllergiBeskrivning.Size = new System.Drawing.Size(216, 20);
            this.txtAllergiBeskrivning.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(124, 577);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Allergibeskrivning";
            // 
            // btnÖvrigaAnställda
            // 
            this.btnÖvrigaAnställda.Location = new System.Drawing.Point(633, 27);
            this.btnÖvrigaAnställda.Name = "btnÖvrigaAnställda";
            this.btnÖvrigaAnställda.Size = new System.Drawing.Size(310, 98);
            this.btnÖvrigaAnställda.TabIndex = 45;
            this.btnÖvrigaAnställda.Text = "Övriga Anställda och Förare";
            this.btnÖvrigaAnställda.UseVisualStyleBackColor = true;
            this.btnÖvrigaAnställda.Click += new System.EventHandler(this.btnÖvrigaAnställda_Click);
            // 
            // btnRemoveFordon
            // 
            this.btnRemoveFordon.Location = new System.Drawing.Point(185, 105);
            this.btnRemoveFordon.Name = "btnRemoveFordon";
            this.btnRemoveFordon.Size = new System.Drawing.Size(93, 38);
            this.btnRemoveFordon.TabIndex = 46;
            this.btnRemoveFordon.Text = "Ta bort Fordon";
            this.btnRemoveFordon.UseVisualStyleBackColor = true;
            this.btnRemoveFordon.Click += new System.EventHandler(this.btnRemoveFordon_Click);
            // 
            // btnRemoveMaträtt
            // 
            this.btnRemoveMaträtt.Location = new System.Drawing.Point(214, 322);
            this.btnRemoveMaträtt.Name = "btnRemoveMaträtt";
            this.btnRemoveMaträtt.Size = new System.Drawing.Size(126, 23);
            this.btnRemoveMaträtt.TabIndex = 47;
            this.btnRemoveMaträtt.Text = "Ta bort maträtt";
            this.btnRemoveMaträtt.UseVisualStyleBackColor = true;
            this.btnRemoveMaträtt.Click += new System.EventHandler(this.btnRemoveMaträtt_Click);
            // 
            // btnRemoveAnställd
            // 
            this.btnRemoveAnställd.Location = new System.Drawing.Point(353, 89);
            this.btnRemoveAnställd.Name = "btnRemoveAnställd";
            this.btnRemoveAnställd.Size = new System.Drawing.Size(151, 54);
            this.btnRemoveAnställd.TabIndex = 48;
            this.btnRemoveAnställd.Text = "Ta bort anställd från fordon";
            this.btnRemoveAnställd.UseVisualStyleBackColor = true;
            this.btnRemoveAnställd.Click += new System.EventHandler(this.btnRemoveAnställd_Click);
            // 
            // btnRemoveRecept
            // 
            this.btnRemoveRecept.Location = new System.Drawing.Point(455, 338);
            this.btnRemoveRecept.Name = "btnRemoveRecept";
            this.btnRemoveRecept.Size = new System.Drawing.Size(94, 23);
            this.btnRemoveRecept.TabIndex = 49;
            this.btnRemoveRecept.Text = "Ta bort Recept";
            this.btnRemoveRecept.UseVisualStyleBackColor = true;
            this.btnRemoveRecept.Click += new System.EventHandler(this.btnRemoveRecept_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(183, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 39);
            this.label14.TabIndex = 50;
            this.label14.Text = "Food";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(159, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 39);
            this.label15.TabIndex = 51;
            this.label15.Text = "Truckers";
            // 
            // btnRemoveIngrediens
            // 
            this.btnRemoveIngrediens.Location = new System.Drawing.Point(833, 342);
            this.btnRemoveIngrediens.Name = "btnRemoveIngrediens";
            this.btnRemoveIngrediens.Size = new System.Drawing.Size(110, 41);
            this.btnRemoveIngrediens.TabIndex = 52;
            this.btnRemoveIngrediens.Text = "Ta bort ingrediens";
            this.btnRemoveIngrediens.UseVisualStyleBackColor = true;
            this.btnRemoveIngrediens.Click += new System.EventHandler(this.btnRemoveIngrediens_Click);
            // 
            // btnRemoveAllergi
            // 
            this.btnRemoveAllergi.Location = new System.Drawing.Point(458, 540);
            this.btnRemoveAllergi.Name = "btnRemoveAllergi";
            this.btnRemoveAllergi.Size = new System.Drawing.Size(91, 74);
            this.btnRemoveAllergi.TabIndex = 53;
            this.btnRemoveAllergi.Text = "Ta bort Allergi";
            this.btnRemoveAllergi.UseVisualStyleBackColor = true;
            this.btnRemoveAllergi.Click += new System.EventHandler(this.btnRemoveAllergi_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(955, 760);
            this.Controls.Add(this.btnRemoveAllergi);
            this.Controls.Add(this.btnRemoveIngrediens);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnRemoveRecept);
            this.Controls.Add(this.btnRemoveAnställd);
            this.Controls.Add(this.btnRemoveMaträtt);
            this.Controls.Add(this.btnRemoveFordon);
            this.Controls.Add(this.btnÖvrigaAnställda);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAllergiBeskrivning);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBeskrivning);
            this.Controls.Add(this.txtPris);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAllergiNamn);
            this.Controls.Add(this.btnAddAllergi);
            this.Controls.Add(this.dataGridViewAllergi);
            this.Controls.Add(this.txtRecept);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRecept);
            this.Controls.Add(this.dataGridViewRecept);
            this.Controls.Add(this.txtIngrediensNamn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnIngrediens);
            this.Controls.Add(this.dataGridViewIngrediens);
            this.Controls.Add(this.txtMaträtt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddMaträtt);
            this.Controls.Add(this.dataGridViewMaträtt);
            this.Controls.Add(this.dataGridViewBil);
            this.Controls.Add(this.txtKontaktnummer);
            this.Controls.Add(this.txtAnstNamn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtRegNr);
            this.Controls.Add(this.txtAnställd);
            this.Controls.Add(this.txtFordon);
            this.Controls.Add(this.btn_anställdfordon);
            this.Controls.Add(this.btn_fordon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAnställd);
            this.Name = "FormMenu";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnställd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaträtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngrediens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllergi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAnställd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_fordon;
        private System.Windows.Forms.Button btn_anställdfordon;
        private System.Windows.Forms.TextBox txtFordon;
        private System.Windows.Forms.TextBox txtAnställd;
        private System.Windows.Forms.TextBox txtRegNr;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnstNamn;
        private System.Windows.Forms.TextBox txtKontaktnummer;
        private System.Windows.Forms.DataGridView dataGridViewBil;
        private System.Windows.Forms.DataGridView dataGridViewMaträtt;
        private System.Windows.Forms.Button btnAddMaträtt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaträtt;
        private System.Windows.Forms.DataGridView dataGridViewIngrediens;
        private System.Windows.Forms.Button btnIngrediens;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIngrediensNamn;
        private System.Windows.Forms.DataGridView dataGridViewRecept;
        private System.Windows.Forms.Button btnRecept;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRecept;
        private System.Windows.Forms.DataGridView dataGridViewAllergi;
        private System.Windows.Forms.Button btnAddAllergi;
        private System.Windows.Forms.TextBox txtAllergiNamn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPris;
        private System.Windows.Forms.TextBox txtBeskrivning;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAllergiBeskrivning;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnÖvrigaAnställda;
        private System.Windows.Forms.Button btnRemoveFordon;
        private System.Windows.Forms.Button btnRemoveMaträtt;
        private System.Windows.Forms.Button btnRemoveAnställd;
        private System.Windows.Forms.Button btnRemoveRecept;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRemoveIngrediens;
        private System.Windows.Forms.Button btnRemoveAllergi;
    }
}