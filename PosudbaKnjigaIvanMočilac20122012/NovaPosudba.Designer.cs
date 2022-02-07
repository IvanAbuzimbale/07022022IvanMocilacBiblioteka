
namespace PosudbaKnjigaIvanMočilac20122012
{
    partial class NovaPosudba
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
            this.label1 = new System.Windows.Forms.Label();
            this.vrijemePosudbe = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.txtKnjiga = new System.Windows.Forms.TextBox();
            this.buttonUnosPosudbe = new System.Windows.Forms.Button();
            this.checkBoxVracanje = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum posuđivanja:";
            // 
            // vrijemePosudbe
            // 
            this.vrijemePosudbe.Location = new System.Drawing.Point(15, 26);
            this.vrijemePosudbe.Name = "vrijemePosudbe";
            this.vrijemePosudbe.Size = new System.Drawing.Size(133, 20);
            this.vrijemePosudbe.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID korisnika:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID knjige:";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(29, 79);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.Size = new System.Drawing.Size(100, 20);
            this.txtKorisnik.TabIndex = 6;
            // 
            // txtKnjiga
            // 
            this.txtKnjiga.Location = new System.Drawing.Point(30, 135);
            this.txtKnjiga.Name = "txtKnjiga";
            this.txtKnjiga.Size = new System.Drawing.Size(100, 20);
            this.txtKnjiga.TabIndex = 7;
            // 
            // buttonUnosPosudbe
            // 
            this.buttonUnosPosudbe.Location = new System.Drawing.Point(15, 209);
            this.buttonUnosPosudbe.Name = "buttonUnosPosudbe";
            this.buttonUnosPosudbe.Size = new System.Drawing.Size(133, 23);
            this.buttonUnosPosudbe.TabIndex = 8;
            this.buttonUnosPosudbe.Text = "Unos posudbe";
            this.buttonUnosPosudbe.UseVisualStyleBackColor = true;
            this.buttonUnosPosudbe.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxVracanje
            // 
            this.checkBoxVracanje.AutoSize = true;
            this.checkBoxVracanje.Location = new System.Drawing.Point(48, 175);
            this.checkBoxVracanje.Name = "checkBoxVracanje";
            this.checkBoxVracanje.Size = new System.Drawing.Size(68, 17);
            this.checkBoxVracanje.TabIndex = 9;
            this.checkBoxVracanje.Text = "Vraćanje";
            this.checkBoxVracanje.UseVisualStyleBackColor = true;
            // 
            // NovaPosudba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 329);
            this.Controls.Add(this.checkBoxVracanje);
            this.Controls.Add(this.buttonUnosPosudbe);
            this.Controls.Add(this.txtKnjiga);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vrijemePosudbe);
            this.Controls.Add(this.label1);
            this.Name = "NovaPosudba";
            this.Text = "Nova Posudba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker vrijemePosudbe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.TextBox txtKnjiga;
        private System.Windows.Forms.Button buttonUnosPosudbe;
        private System.Windows.Forms.CheckBox checkBoxVracanje;
    }
}