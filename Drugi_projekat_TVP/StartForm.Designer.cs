namespace Drugi_projekat_TVP
{
    partial class StartForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvJelo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFindJelo = new System.Windows.Forms.TextBox();
            this.btnDodajJela = new System.Windows.Forms.Button();
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.rbRastuce = new System.Windows.Forms.RadioButton();
            this.rbOpadajuce = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTrenutniRacun = new System.Windows.Forms.DataGridView();
            this.pripadnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new Drugi_projekat_TVP.RestoranDataSet();
            this.pripadnostTableAdapter = new Drugi_projekat_TVP.RestoranDataSetTableAdapters.PripadnostTableAdapter();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunTableAdapter = new Drugi_projekat_TVP.RestoranDataSetTableAdapters.RacunTableAdapter();
            this.btnIzbrisiStavku = new System.Windows.Forms.Button();
            this.btnIzbrisiSve = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpMin = new System.Windows.Forms.DateTimePicker();
            this.dtpMax = new System.Windows.Forms.DateTimePicker();
            this.lblNajprodavanijeJelo = new System.Windows.Forms.Label();
            this.btnGrafika = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.lblGrafika = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrenutniRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pripadnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJelo
            // 
            this.dgvJelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJelo.Location = new System.Drawing.Point(48, 134);
            this.dgvJelo.Name = "dgvJelo";
            this.dgvJelo.ReadOnly = true;
            this.dgvJelo.Size = new System.Drawing.Size(407, 279);
            this.dgvJelo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pronadjite jelo";
            // 
            // txtFindJelo
            // 
            this.txtFindJelo.Location = new System.Drawing.Point(124, 88);
            this.txtFindJelo.Name = "txtFindJelo";
            this.txtFindJelo.Size = new System.Drawing.Size(100, 20);
            this.txtFindJelo.TabIndex = 2;
            this.txtFindJelo.TextChanged += new System.EventHandler(this.txtFindJelo_TextChanged);
            // 
            // btnDodajJela
            // 
            this.btnDodajJela.Location = new System.Drawing.Point(48, 603);
            this.btnDodajJela.Name = "btnDodajJela";
            this.btnDodajJela.Size = new System.Drawing.Size(407, 30);
            this.btnDodajJela.TabIndex = 3;
            this.btnDodajJela.Text = "Dodaj jelo u bazu";
            this.btnDodajJela.UseVisualStyleBackColor = true;
            this.btnDodajJela.Click += new System.EventHandler(this.btnDodajJela_Click);
            // 
            // dgvRacun
            // 
            this.dgvRacun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Location = new System.Drawing.Point(958, 149);
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.ReadOnly = true;
            this.dgvRacun.Size = new System.Drawing.Size(343, 233);
            this.dgvRacun.TabIndex = 6;
            // 
            // rbRastuce
            // 
            this.rbRastuce.AutoSize = true;
            this.rbRastuce.Location = new System.Drawing.Point(479, 215);
            this.rbRastuce.Name = "rbRastuce";
            this.rbRastuce.Size = new System.Drawing.Size(65, 17);
            this.rbRastuce.TabIndex = 8;
            this.rbRastuce.TabStop = true;
            this.rbRastuce.Text = "Rastuce";
            this.rbRastuce.UseVisualStyleBackColor = true;
            this.rbRastuce.CheckedChanged += new System.EventHandler(this.rbOpadajuce_CheckedChanged);
            // 
            // rbOpadajuce
            // 
            this.rbOpadajuce.AutoSize = true;
            this.rbOpadajuce.Location = new System.Drawing.Point(479, 256);
            this.rbOpadajuce.Name = "rbOpadajuce";
            this.rbOpadajuce.Size = new System.Drawing.Size(77, 17);
            this.rbOpadajuce.TabIndex = 9;
            this.rbOpadajuce.TabStop = true;
            this.rbOpadajuce.Text = "Opadajuce";
            this.rbOpadajuce.UseVisualStyleBackColor = true;
            this.rbOpadajuce.CheckedChanged += new System.EventHandler(this.rbOpadajuce_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sortirajte po ceni:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1078, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Trenutni racun";
            // 
            // dgvTrenutniRacun
            // 
            this.dgvTrenutniRacun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrenutniRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrenutniRacun.Location = new System.Drawing.Point(739, 486);
            this.dgvTrenutniRacun.Name = "dgvTrenutniRacun";
            this.dgvTrenutniRacun.ReadOnly = true;
            this.dgvTrenutniRacun.Size = new System.Drawing.Size(786, 147);
            this.dgvTrenutniRacun.TabIndex = 12;
            // 
            // pripadnostBindingSource
            // 
            this.pripadnostBindingSource.DataMember = "Pripadnost";
            this.pripadnostBindingSource.DataSource = this.restoranDataSet;
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pripadnostTableAdapter
            // 
            this.pripadnostTableAdapter.ClearBeforeFill = true;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "Racun";
            this.racunBindingSource.DataSource = this.restoranDataSet;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // btnIzbrisiStavku
            // 
            this.btnIzbrisiStavku.Location = new System.Drawing.Point(598, 486);
            this.btnIzbrisiStavku.Name = "btnIzbrisiStavku";
            this.btnIzbrisiStavku.Size = new System.Drawing.Size(135, 31);
            this.btnIzbrisiStavku.TabIndex = 13;
            this.btnIzbrisiStavku.Text = "Izbrisi izabranu stavku";
            this.btnIzbrisiStavku.UseVisualStyleBackColor = true;
            this.btnIzbrisiStavku.Click += new System.EventHandler(this.btnIzbrisiStavku_Click);
            // 
            // btnIzbrisiSve
            // 
            this.btnIzbrisiSve.Location = new System.Drawing.Point(598, 605);
            this.btnIzbrisiSve.Name = "btnIzbrisiSve";
            this.btnIzbrisiSve.Size = new System.Drawing.Size(135, 28);
            this.btnIzbrisiSve.TabIndex = 14;
            this.btnIzbrisiSve.Text = "Izbrisi sve stavke";
            this.btnIzbrisiSve.UseVisualStyleBackColor = true;
            this.btnIzbrisiSve.Click += new System.EventHandler(this.btnIzbrisiSve_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1108, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Svi racuni";
            // 
            // dtpMin
            // 
            this.dtpMin.Location = new System.Drawing.Point(815, 113);
            this.dtpMin.Name = "dtpMin";
            this.dtpMin.Size = new System.Drawing.Size(200, 20);
            this.dtpMin.TabIndex = 16;
            this.dtpMin.ValueChanged += new System.EventHandler(this.dtpMin_ValueChanged);
            // 
            // dtpMax
            // 
            this.dtpMax.Location = new System.Drawing.Point(1252, 113);
            this.dtpMax.Name = "dtpMax";
            this.dtpMax.Size = new System.Drawing.Size(200, 20);
            this.dtpMax.TabIndex = 17;
            this.dtpMax.ValueChanged += new System.EventHandler(this.dtpMax_ValueChanged);
            // 
            // lblNajprodavanijeJelo
            // 
            this.lblNajprodavanijeJelo.AutoSize = true;
            this.lblNajprodavanijeJelo.ForeColor = System.Drawing.Color.IndianRed;
            this.lblNajprodavanijeJelo.Location = new System.Drawing.Point(654, 22);
            this.lblNajprodavanijeJelo.Name = "lblNajprodavanijeJelo";
            this.lblNajprodavanijeJelo.Size = new System.Drawing.Size(10, 13);
            this.lblNajprodavanijeJelo.TabIndex = 18;
            this.lblNajprodavanijeJelo.Text = ".";
            // 
            // btnGrafika
            // 
            this.btnGrafika.BackColor = System.Drawing.Color.Lime;
            this.btnGrafika.Location = new System.Drawing.Point(48, 460);
            this.btnGrafika.Name = "btnGrafika";
            this.btnGrafika.Size = new System.Drawing.Size(407, 30);
            this.btnGrafika.TabIndex = 19;
            this.btnGrafika.Text = "Prikazi graficki prodaju izabranog jela";
            this.btnGrafika.UseVisualStyleBackColor = false;
            this.btnGrafika.Click += new System.EventHandler(this.btnGrafika_Click);
            // 
            // pnl
            // 
            this.pnl.Location = new System.Drawing.Point(620, 183);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(113, 199);
            this.pnl.TabIndex = 20;
            // 
            // lblGrafika
            // 
            this.lblGrafika.AutoSize = true;
            this.lblGrafika.Location = new System.Drawing.Point(750, 274);
            this.lblGrafika.Name = "lblGrafika";
            this.lblGrafika.Size = new System.Drawing.Size(153, 26);
            this.lblGrafika.TabIndex = 21;
            this.lblGrafika.Text = "Plava- prodaja preostalih jela\r\nCrvena - prodaja izabranog jela\r\n";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 651);
            this.Controls.Add(this.lblGrafika);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.btnGrafika);
            this.Controls.Add(this.lblNajprodavanijeJelo);
            this.Controls.Add(this.dtpMax);
            this.Controls.Add(this.dtpMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIzbrisiSve);
            this.Controls.Add(this.btnIzbrisiStavku);
            this.Controls.Add(this.dgvTrenutniRacun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbOpadajuce);
            this.Controls.Add(this.rbRastuce);
            this.Controls.Add(this.dgvRacun);
            this.Controls.Add(this.btnDodajJela);
            this.Controls.Add(this.txtFindJelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvJelo);
            this.Name = "StartForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrenutniRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pripadnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFindJelo;
        private System.Windows.Forms.Button btnDodajJela;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource pripadnostBindingSource;
        private RestoranDataSetTableAdapters.PripadnostTableAdapter pripadnostTableAdapter;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private RestoranDataSetTableAdapters.RacunTableAdapter racunTableAdapter;
        private System.Windows.Forms.DataGridView dgvRacun;
        private System.Windows.Forms.RadioButton rbRastuce;
        private System.Windows.Forms.RadioButton rbOpadajuce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTrenutniRacun;
        private System.Windows.Forms.Button btnIzbrisiStavku;
        private System.Windows.Forms.Button btnIzbrisiSve;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpMin;
        private System.Windows.Forms.DateTimePicker dtpMax;
        private System.Windows.Forms.Label lblNajprodavanijeJelo;
        private System.Windows.Forms.Button btnGrafika;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lblGrafika;
    }
}

