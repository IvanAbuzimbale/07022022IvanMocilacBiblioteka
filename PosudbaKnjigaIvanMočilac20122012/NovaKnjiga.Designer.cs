
namespace PosudbaKnjigaIvanMočilac20122012
{
    partial class NovaKnjiga
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
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnUnesiKnjigu = new System.Windows.Forms.Button();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(30, 58);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(68, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Naziv knjige:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(33, 74);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(146, 20);
            this.txtNaziv.TabIndex = 2;
            // 
            // btnUnesiKnjigu
            // 
            this.btnUnesiKnjigu.Location = new System.Drawing.Point(33, 171);
            this.btnUnesiKnjigu.Name = "btnUnesiKnjigu";
            this.btnUnesiKnjigu.Size = new System.Drawing.Size(140, 23);
            this.btnUnesiKnjigu.TabIndex = 3;
            this.btnUnesiKnjigu.Text = "Unesi knjigu";
            this.btnUnesiKnjigu.UseVisualStyleBackColor = true;
            this.btnUnesiKnjigu.Click += new System.EventHandler(this.btnUnesiKnjigu_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(33, 128);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(146, 20);
            this.txtAutor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(33, 25);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(146, 20);
            this.txtISBN.TabIndex = 6;
            // 
            // NovaKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 247);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.btnUnesiKnjigu);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Name = "NovaKnjiga";
            this.Text = "Nova Knjiga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnUnesiKnjigu;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtISBN;
    }
}