namespace Drugi_projekat_TVP
{
    partial class DodajStavkuRacunaForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.clbPrilozi = new System.Windows.Forms.CheckedListBox();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCenaJela = new System.Windows.Forms.TextBox();
            this.txtNazivJela = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dostupni prilozi za jelo";
            // 
            // clbPrilozi
            // 
            this.clbPrilozi.FormattingEnabled = true;
            this.clbPrilozi.Location = new System.Drawing.Point(12, 146);
            this.clbPrilozi.Name = "clbPrilozi";
            this.clbPrilozi.Size = new System.Drawing.Size(177, 154);
            this.clbPrilozi.TabIndex = 12;
            this.clbPrilozi.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbPrilozi_ItemCheck);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(15, 328);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(174, 29);
            this.btnDodajStavku.TabIndex = 11;
            this.btnDodajStavku.Text = "Dodaj stavku na racun";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naziv jela";
            // 
            // txtCenaJela
            // 
            this.txtCenaJela.Location = new System.Drawing.Point(80, 73);
            this.txtCenaJela.Name = "txtCenaJela";
            this.txtCenaJela.ReadOnly = true;
            this.txtCenaJela.Size = new System.Drawing.Size(100, 20);
            this.txtCenaJela.TabIndex = 8;
            // 
            // txtNazivJela
            // 
            this.txtNazivJela.Location = new System.Drawing.Point(80, 23);
            this.txtNazivJela.Name = "txtNazivJela";
            this.txtNazivJela.ReadOnly = true;
            this.txtNazivJela.Size = new System.Drawing.Size(100, 20);
            this.txtNazivJela.TabIndex = 7;
            // 
            // DodajStavkuRacunaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clbPrilozi);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCenaJela);
            this.Controls.Add(this.txtNazivJela);
            this.Name = "DodajStavkuRacunaForm";
            this.Text = "DodajStavkuRacuna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbPrilozi;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCenaJela;
        private System.Windows.Forms.TextBox txtNazivJela;
    }
}