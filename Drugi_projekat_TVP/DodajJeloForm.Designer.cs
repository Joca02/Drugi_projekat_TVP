namespace Drugi_projekat_TVP
{
    partial class DodajJeloForm
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
            this.txtNazivJela = new System.Windows.Forms.TextBox();
            this.txtCenaJela = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajJelo = new System.Windows.Forms.Button();
            this.clbPrilozi = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodajPrilog = new System.Windows.Forms.Button();
            this.restoranDataSet = new Drugi_projekat_TVP.RestoranDataSet();
            this.restoranDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prilogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prilogTableAdapter = new Drugi_projekat_TVP.RestoranDataSetTableAdapters.PrilogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prilogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazivJela
            // 
            this.txtNazivJela.Location = new System.Drawing.Point(80, 29);
            this.txtNazivJela.Name = "txtNazivJela";
            this.txtNazivJela.Size = new System.Drawing.Size(100, 20);
            this.txtNazivJela.TabIndex = 0;
            // 
            // txtCenaJela
            // 
            this.txtCenaJela.Location = new System.Drawing.Point(80, 79);
            this.txtCenaJela.Name = "txtCenaJela";
            this.txtCenaJela.Size = new System.Drawing.Size(100, 20);
            this.txtCenaJela.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv jela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cena";
            // 
            // btnDodajJelo
            // 
            this.btnDodajJelo.Location = new System.Drawing.Point(15, 334);
            this.btnDodajJelo.Name = "btnDodajJelo";
            this.btnDodajJelo.Size = new System.Drawing.Size(174, 29);
            this.btnDodajJelo.TabIndex = 4;
            this.btnDodajJelo.Text = "Dodaj jelo u bazu";
            this.btnDodajJelo.UseVisualStyleBackColor = true;
            this.btnDodajJelo.Click += new System.EventHandler(this.btnDodajJelo_Click);
            // 
            // clbPrilozi
            // 
            this.clbPrilozi.FormattingEnabled = true;
            this.clbPrilozi.Location = new System.Drawing.Point(12, 152);
            this.clbPrilozi.Name = "clbPrilozi";
            this.clbPrilozi.Size = new System.Drawing.Size(177, 154);
            this.clbPrilozi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dostupni prilozi za jelo";
            // 
            // btnDodajPrilog
            // 
            this.btnDodajPrilog.Location = new System.Drawing.Point(15, 391);
            this.btnDodajPrilog.Name = "btnDodajPrilog";
            this.btnDodajPrilog.Size = new System.Drawing.Size(174, 29);
            this.btnDodajPrilog.TabIndex = 7;
            this.btnDodajPrilog.Text = "Kreiraj novi prilog";
            this.btnDodajPrilog.UseVisualStyleBackColor = true;
            this.btnDodajPrilog.Click += new System.EventHandler(this.btnDodajPrilog_Click);
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restoranDataSetBindingSource
            // 
            this.restoranDataSetBindingSource.DataSource = this.restoranDataSet;
            this.restoranDataSetBindingSource.Position = 0;
            // 
            // prilogBindingSource
            // 
            this.prilogBindingSource.DataMember = "Prilog";
            this.prilogBindingSource.DataSource = this.restoranDataSetBindingSource;
            // 
            // prilogTableAdapter
            // 
            this.prilogTableAdapter.ClearBeforeFill = true;
            // 
            // DodajJeloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 441);
            this.Controls.Add(this.btnDodajPrilog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clbPrilozi);
            this.Controls.Add(this.btnDodajJelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCenaJela);
            this.Controls.Add(this.txtNazivJela);
            this.Name = "DodajJeloForm";
            this.Text = "DodajJeloForm";
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prilogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazivJela;
        private System.Windows.Forms.TextBox txtCenaJela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajJelo;
        private System.Windows.Forms.CheckedListBox clbPrilozi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodajPrilog;
        private System.Windows.Forms.BindingSource restoranDataSetBindingSource;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource prilogBindingSource;
        private RestoranDataSetTableAdapters.PrilogTableAdapter prilogTableAdapter;
    }
}