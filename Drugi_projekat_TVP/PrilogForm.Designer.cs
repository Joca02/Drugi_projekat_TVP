namespace Drugi_projekat_TVP
{
    partial class PrilogForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCenaPriloga = new System.Windows.Forms.TextBox();
            this.txtNazivPriloga = new System.Windows.Forms.TextBox();
            this.btnDodajPrilog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naziv priloga";
            // 
            // txtCenaPriloga
            // 
            this.txtCenaPriloga.Location = new System.Drawing.Point(84, 75);
            this.txtCenaPriloga.Name = "txtCenaPriloga";
            this.txtCenaPriloga.Size = new System.Drawing.Size(100, 20);
            this.txtCenaPriloga.TabIndex = 5;
            // 
            // txtNazivPriloga
            // 
            this.txtNazivPriloga.Location = new System.Drawing.Point(84, 25);
            this.txtNazivPriloga.Name = "txtNazivPriloga";
            this.txtNazivPriloga.Size = new System.Drawing.Size(100, 20);
            this.txtNazivPriloga.TabIndex = 4;
            // 
            // btnDodajPrilog
            // 
            this.btnDodajPrilog.Location = new System.Drawing.Point(13, 123);
            this.btnDodajPrilog.Name = "btnDodajPrilog";
            this.btnDodajPrilog.Size = new System.Drawing.Size(171, 29);
            this.btnDodajPrilog.TabIndex = 8;
            this.btnDodajPrilog.Text = "Dodaj prilog u bazu";
            this.btnDodajPrilog.UseVisualStyleBackColor = true;
            this.btnDodajPrilog.Click += new System.EventHandler(this.btnDodajPrilog_Click);
            // 
            // PrilogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 194);
            this.Controls.Add(this.btnDodajPrilog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCenaPriloga);
            this.Controls.Add(this.txtNazivPriloga);
            this.Name = "PrilogForm";
            this.Text = "PrilogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCenaPriloga;
        private System.Windows.Forms.TextBox txtNazivPriloga;
        private System.Windows.Forms.Button btnDodajPrilog;
    }
}