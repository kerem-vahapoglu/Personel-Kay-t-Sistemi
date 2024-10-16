namespace Personel_Kayıt_Sistemi
{
    partial class formIstatistik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKisiSayisi = new System.Windows.Forms.Label();
            this.lbIlSayisi = new System.Windows.Forms.Label();
            this.lbEvliSayisi = new System.Windows.Forms.Label();
            this.lbBekarSayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Evli Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "İl Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kişi Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bekar Sayısı";
            // 
            // lbKisiSayisi
            // 
            this.lbKisiSayisi.AutoSize = true;
            this.lbKisiSayisi.Location = new System.Drawing.Point(285, 103);
            this.lbKisiSayisi.Name = "lbKisiSayisi";
            this.lbKisiSayisi.Size = new System.Drawing.Size(20, 24);
            this.lbKisiSayisi.TabIndex = 1;
            this.lbKisiSayisi.Text = "0";
            // 
            // lbIlSayisi
            // 
            this.lbIlSayisi.AutoSize = true;
            this.lbIlSayisi.Location = new System.Drawing.Point(285, 143);
            this.lbIlSayisi.Name = "lbIlSayisi";
            this.lbIlSayisi.Size = new System.Drawing.Size(20, 24);
            this.lbIlSayisi.TabIndex = 1;
            this.lbIlSayisi.Text = "0";
            // 
            // lbEvliSayisi
            // 
            this.lbEvliSayisi.AutoSize = true;
            this.lbEvliSayisi.Location = new System.Drawing.Point(285, 183);
            this.lbEvliSayisi.Name = "lbEvliSayisi";
            this.lbEvliSayisi.Size = new System.Drawing.Size(20, 24);
            this.lbEvliSayisi.TabIndex = 1;
            this.lbEvliSayisi.Text = "0";
            // 
            // lbBekarSayisi
            // 
            this.lbBekarSayisi.AutoSize = true;
            this.lbBekarSayisi.Location = new System.Drawing.Point(285, 225);
            this.lbBekarSayisi.Name = "lbBekarSayisi";
            this.lbBekarSayisi.Size = new System.Drawing.Size(20, 24);
            this.lbBekarSayisi.TabIndex = 1;
            this.lbBekarSayisi.Text = "0";
            // 
            // formIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(578, 375);
            this.Controls.Add(this.lbBekarSayisi);
            this.Controls.Add(this.lbEvliSayisi);
            this.Controls.Add(this.lbIlSayisi);
            this.Controls.Add(this.lbKisiSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formIstatistik";
            this.Text = "formIstatistik";
            this.Load += new System.EventHandler(this.formIstatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbKisiSayisi;
        private System.Windows.Forms.Label lbIlSayisi;
        private System.Windows.Forms.Label lbEvliSayisi;
        private System.Windows.Forms.Label lbBekarSayisi;
    }
}