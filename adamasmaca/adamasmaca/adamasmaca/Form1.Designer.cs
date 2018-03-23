namespace adamasmaca
{
    partial class form
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
            this.harf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_hrfdene = new System.Windows.Forms.Button();
            this.yeni_kelime = new System.Windows.Forms.Button();
            this.aranan_kelime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_tahmin = new System.Windows.Forms.TextBox();
            this.adam = new System.Windows.Forms.PictureBox();
            this.denenenhrf = new System.Windows.Forms.ListBox();
            this.tahmin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.skor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numeric_hrfs = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_hrfs)).BeginInit();
            this.SuspendLayout();
            // 
            // harf
            // 
            this.harf.Location = new System.Drawing.Point(125, 207);
            this.harf.MaxLength = 1;
            this.harf.Multiline = true;
            this.harf.Name = "harf";
            this.harf.Size = new System.Drawing.Size(36, 34);
            this.harf.TabIndex = 0;
            this.harf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harf_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Harf girin :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_hrfdene
            // 
            this.button_hrfdene.Location = new System.Drawing.Point(23, 256);
            this.button_hrfdene.Name = "button_hrfdene";
            this.button_hrfdene.Size = new System.Drawing.Size(199, 44);
            this.button_hrfdene.TabIndex = 2;
            this.button_hrfdene.Text = "Dene";
            this.button_hrfdene.UseVisualStyleBackColor = true;
            this.button_hrfdene.Click += new System.EventHandler(this.button_hrfdene_Click);
            // 
            // yeni_kelime
            // 
            this.yeni_kelime.Location = new System.Drawing.Point(23, 156);
            this.yeni_kelime.Name = "yeni_kelime";
            this.yeni_kelime.Size = new System.Drawing.Size(199, 36);
            this.yeni_kelime.TabIndex = 2;
            this.yeni_kelime.Text = "Yeni kelime";
            this.yeni_kelime.UseVisualStyleBackColor = true;
            this.yeni_kelime.Click += new System.EventHandler(this.yeni_kelime_Click);
            // 
            // aranan_kelime
            // 
            this.aranan_kelime.BackColor = System.Drawing.Color.White;
            this.aranan_kelime.Location = new System.Drawing.Point(23, 316);
            this.aranan_kelime.Name = "aranan_kelime";
            this.aranan_kelime.Size = new System.Drawing.Size(279, 32);
            this.aranan_kelime.TabIndex = 3;
            this.aranan_kelime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tahmininiz :";
            // 
            // text_tahmin
            // 
            this.text_tahmin.Location = new System.Drawing.Point(125, 358);
            this.text_tahmin.Multiline = true;
            this.text_tahmin.Name = "text_tahmin";
            this.text_tahmin.Size = new System.Drawing.Size(177, 31);
            this.text_tahmin.TabIndex = 5;
            // 
            // adam
            // 
            this.adam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.adam.Location = new System.Drawing.Point(324, 156);
            this.adam.Name = "adam";
            this.adam.Size = new System.Drawing.Size(291, 355);
            this.adam.TabIndex = 6;
            this.adam.TabStop = false;
            // 
            // denenenhrf
            // 
            this.denenenhrf.FormattingEnabled = true;
            this.denenenhrf.ItemHeight = 16;
            this.denenenhrf.Location = new System.Drawing.Point(238, 200);
            this.denenenhrf.Name = "denenenhrf";
            this.denenenhrf.Size = new System.Drawing.Size(62, 100);
            this.denenenhrf.TabIndex = 9;
            this.denenenhrf.SelectedIndexChanged += new System.EventHandler(this.denenenhrf_SelectedIndexChanged);
            // 
            // tahmin
            // 
            this.tahmin.Location = new System.Drawing.Point(26, 396);
            this.tahmin.Name = "tahmin";
            this.tahmin.Size = new System.Drawing.Size(276, 44);
            this.tahmin.TabIndex = 2;
            this.tahmin.Text = "Tahminet";
            this.tahmin.UseVisualStyleBackColor = true;
            this.tahmin.Click += new System.EventHandler(this.tahmin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(325, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Skor :";
            // 
            // skor
            // 
            this.skor.BackColor = System.Drawing.SystemColors.Info;
            this.skor.Location = new System.Drawing.Point(373, 155);
            this.skor.Name = "skor";
            this.skor.Size = new System.Drawing.Size(31, 22);
            this.skor.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(591, 102);
            this.label4.TabIndex = 12;
            this.label4.Text = "ADAM ASMACA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "Kelime Ekleme Veya Çıkarma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "harf sayısı :";
            // 
            // numeric_hrfs
            // 
            this.numeric_hrfs.Location = new System.Drawing.Point(117, 131);
            this.numeric_hrfs.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numeric_hrfs.Name = "numeric_hrfs";
            this.numeric_hrfs.Size = new System.Drawing.Size(62, 22);
            this.numeric_hrfs.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(235, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "Denenen Harfler:";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(637, 548);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numeric_hrfs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.skor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.denenenhrf);
            this.Controls.Add(this.adam);
            this.Controls.Add(this.text_tahmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aranan_kelime);
            this.Controls.Add(this.yeni_kelime);
            this.Controls.Add(this.tahmin);
            this.Controls.Add(this.button_hrfdene);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.harf);
            this.Name = "form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_hrfs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox harf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_hrfdene;
        private System.Windows.Forms.Button yeni_kelime;
        private System.Windows.Forms.Label aranan_kelime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_tahmin;
        private System.Windows.Forms.PictureBox adam;
        private System.Windows.Forms.ListBox denenenhrf;
        private System.Windows.Forms.Button tahmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox skor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numeric_hrfs;
        private System.Windows.Forms.Label label6;
    }
}

