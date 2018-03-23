namespace adamasmaca
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_kelime = new System.Windows.Forms.TextBox();
            this.button1_ekle = new System.Windows.Forms.Button();
            this.button1_cikar = new System.Windows.Forms.Button();
            this.oyun_dön = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(591, 102);
            this.label4.TabIndex = 13;
            this.label4.Text = "ADAM ASMACA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Eklemek İstediğiniz kelimeyi girin :";
            // 
            // text_kelime
            // 
            this.text_kelime.Location = new System.Drawing.Point(22, 215);
            this.text_kelime.Multiline = true;
            this.text_kelime.Name = "text_kelime";
            this.text_kelime.Size = new System.Drawing.Size(266, 33);
            this.text_kelime.TabIndex = 15;
            // 
            // button1_ekle
            // 
            this.button1_ekle.Location = new System.Drawing.Point(101, 266);
            this.button1_ekle.Name = "button1_ekle";
            this.button1_ekle.Size = new System.Drawing.Size(93, 35);
            this.button1_ekle.TabIndex = 16;
            this.button1_ekle.Text = "Ekle";
            this.button1_ekle.UseVisualStyleBackColor = true;
            this.button1_ekle.Click += new System.EventHandler(this.button1_ekle_Click);
            // 
            // button1_cikar
            // 
            this.button1_cikar.Location = new System.Drawing.Point(406, 401);
            this.button1_cikar.Name = "button1_cikar";
            this.button1_cikar.Size = new System.Drawing.Size(93, 35);
            this.button1_cikar.TabIndex = 16;
            this.button1_cikar.Text = "Çıkar";
            this.button1_cikar.UseVisualStyleBackColor = true;
            this.button1_cikar.Click += new System.EventHandler(this.button1_cikar_Click);
            // 
            // oyun_dön
            // 
            this.oyun_dön.Location = new System.Drawing.Point(38, 341);
            this.oyun_dön.Name = "oyun_dön";
            this.oyun_dön.Size = new System.Drawing.Size(217, 95);
            this.oyun_dön.TabIndex = 17;
            this.oyun_dön.Text = "Oyuna Geri Dön";
            this.oyun_dön.UseVisualStyleBackColor = true;
            this.oyun_dön.Click += new System.EventHandler(this.oyun_dön_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(331, 215);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 180);
            this.listBox1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(327, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Çıkartmak İstediğiniz kelimeyi girin :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.oyun_dön);
            this.Controls.Add(this.button1_cikar);
            this.Controls.Add(this.button1_ekle);
            this.Controls.Add(this.text_kelime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_kelime;
        private System.Windows.Forms.Button button1_ekle;
        private System.Windows.Forms.Button button1_cikar;
        private System.Windows.Forms.Button oyun_dön;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
    }
}