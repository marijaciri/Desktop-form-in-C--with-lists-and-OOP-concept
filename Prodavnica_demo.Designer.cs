namespace Prodavnica_mateja
{
    partial class Prodavnica_demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prodavnica_demo));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listaProizvoda = new System.Windows.Forms.ListBox();
            this.listaProdatih = new System.Windows.Forms.ListBox();
            this.buttonKupovina = new System.Windows.Forms.Button();
            this.labelKorpa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listaProvizija = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelProfitProdavnice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelUkupanProfit = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(684, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "DODATO U KORPU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proizvodi";
            // 
            // listaProizvoda
            // 
            this.listaProizvoda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listaProizvoda.ColumnWidth = 2;
            this.listaProizvoda.FormattingEnabled = true;
            this.listaProizvoda.Location = new System.Drawing.Point(344, 76);
            this.listaProizvoda.Name = "listaProizvoda";
            this.listaProizvoda.Size = new System.Drawing.Size(321, 199);
            this.listaProizvoda.TabIndex = 0;
            // 
            // listaProdatih
            // 
            this.listaProdatih.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listaProdatih.FormattingEnabled = true;
            this.listaProdatih.Location = new System.Drawing.Point(908, 76);
            this.listaProdatih.Name = "listaProdatih";
            this.listaProdatih.Size = new System.Drawing.Size(307, 199);
            this.listaProdatih.TabIndex = 3;
            // 
            // buttonKupovina
            // 
            this.buttonKupovina.BackColor = System.Drawing.Color.Red;
            this.buttonKupovina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKupovina.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonKupovina.Location = new System.Drawing.Point(721, 234);
            this.buttonKupovina.Name = "buttonKupovina";
            this.buttonKupovina.Size = new System.Drawing.Size(126, 41);
            this.buttonKupovina.TabIndex = 4;
            this.buttonKupovina.Text = "KUPLJENO";
            this.buttonKupovina.UseVisualStyleBackColor = false;
            this.buttonKupovina.Click += new System.EventHandler(this.buttonKupovina_Click);
            // 
            // labelKorpa
            // 
            this.labelKorpa.AutoSize = true;
            this.labelKorpa.BackColor = System.Drawing.Color.SlateBlue;
            this.labelKorpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorpa.Location = new System.Drawing.Point(915, 24);
            this.labelKorpa.Name = "labelKorpa";
            this.labelKorpa.Size = new System.Drawing.Size(97, 33);
            this.labelKorpa.TabIndex = 5;
            this.labelKorpa.Text = "Korpa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(915, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Provizija Prodavci";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // listaProvizija
            // 
            this.listaProvizija.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listaProvizija.FormattingEnabled = true;
            this.listaProvizija.Location = new System.Drawing.Point(921, 381);
            this.listaProvizija.Name = "listaProvizija";
            this.listaProvizija.Size = new System.Drawing.Size(294, 186);
            this.listaProvizija.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Profit Prodavnice";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelProfitProdavnice
            // 
            this.labelProfitProdavnice.AutoSize = true;
            this.labelProfitProdavnice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfitProdavnice.Location = new System.Drawing.Point(608, 414);
            this.labelProfitProdavnice.Name = "labelProfitProdavnice";
            this.labelProfitProdavnice.Size = new System.Drawing.Size(148, 33);
            this.labelProfitProdavnice.TabIndex = 8;
            this.labelProfitProdavnice.Text = "RSD 0.00";
            this.labelProfitProdavnice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ukupan Pofit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelUkupanProfit
            // 
            this.labelUkupanProfit.AutoSize = true;
            this.labelUkupanProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUkupanProfit.Location = new System.Drawing.Point(22, 242);
            this.labelUkupanProfit.Name = "labelUkupanProfit";
            this.labelUkupanProfit.Size = new System.Drawing.Size(148, 33);
            this.labelUkupanProfit.TabIndex = 10;
            this.labelUkupanProfit.Text = "RSD 0.00";
            this.labelUkupanProfit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(684, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "UKLONI IZ KORPE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Prodavnica_demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1233, 579);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelUkupanProfit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelProfitProdavnice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelKorpa);
            this.Controls.Add(this.buttonKupovina);
            this.Controls.Add(this.listaProdatih);
            this.Controls.Add(this.listaProvizija);
            this.Controls.Add(this.listaProizvoda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Prodavnica_demo";
            this.Text = "PRODAVNICA DEMO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaProizvoda;
        private System.Windows.Forms.ListBox listaProdatih;
        private System.Windows.Forms.Button buttonKupovina;
        private System.Windows.Forms.Label labelKorpa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listaProvizija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelProfitProdavnice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelUkupanProfit;
        private System.Windows.Forms.Button button2;
    }
}

