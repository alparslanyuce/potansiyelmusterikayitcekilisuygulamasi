namespace promosyonTakip.UI.Musteri
{
    partial class hediyeGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hediyeGoster));
            this.button1 = new System.Windows.Forms.Button();
            this.pcthediyeresim = new System.Windows.Forms.PictureBox();
            this.lblhediyeaciklama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcthediyeresim)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(509, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yeni Kayıt Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcthediyeresim
            // 
            this.pcthediyeresim.Image = ((System.Drawing.Image)(resources.GetObject("pcthediyeresim.Image")));
            this.pcthediyeresim.Location = new System.Drawing.Point(13, 13);
            this.pcthediyeresim.Name = "pcthediyeresim";
            this.pcthediyeresim.Size = new System.Drawing.Size(137, 138);
            this.pcthediyeresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcthediyeresim.TabIndex = 1;
            this.pcthediyeresim.TabStop = false;
            // 
            // lblhediyeaciklama
            // 
            this.lblhediyeaciklama.AutoSize = true;
            this.lblhediyeaciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhediyeaciklama.Location = new System.Drawing.Point(156, 13);
            this.lblhediyeaciklama.Name = "lblhediyeaciklama";
            this.lblhediyeaciklama.Size = new System.Drawing.Size(12, 17);
            this.lblhediyeaciklama.TabIndex = 2;
            this.lblhediyeaciklama.Text = ".";
            // 
            // hediyeGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 192);
            this.Controls.Add(this.lblhediyeaciklama);
            this.Controls.Add(this.pcthediyeresim);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hediyeGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hediyeGoster";
            this.Load += new System.EventHandler(this.hediyeGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcthediyeresim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pcthediyeresim;
        private System.Windows.Forms.Label lblhediyeaciklama;
    }
}