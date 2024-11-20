namespace Avzi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_mermi = new System.Windows.Forms.Label();
            this.PB_Kus = new System.Windows.Forms.PictureBox();
            this.Kus_Ucur = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Kalan_Kus = new System.Windows.Forms.Label();
            this.Can_1 = new System.Windows.Forms.PictureBox();
            this.Can_2 = new System.Windows.Forms.PictureBox();
            this.Can_3 = new System.Windows.Forms.PictureBox();
            this.Kcan1 = new System.Windows.Forms.PictureBox();
            this.Kcan2 = new System.Windows.Forms.PictureBox();
            this.Kcan3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Kus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Can_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Can_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Can_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kcan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kcan2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kcan3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1271, 627);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_mermi
            // 
            this.lbl_mermi.AutoSize = true;
            this.lbl_mermi.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mermi.Location = new System.Drawing.Point(617, 561);
            this.lbl_mermi.Name = "lbl_mermi";
            this.lbl_mermi.Size = new System.Drawing.Size(77, 57);
            this.lbl_mermi.TabIndex = 1;
            this.lbl_mermi.Text = "20";
            // 
            // PB_Kus
            // 
            this.PB_Kus.Image = ((System.Drawing.Image)(resources.GetObject("PB_Kus.Image")));
            this.PB_Kus.Location = new System.Drawing.Point(1123, 267);
            this.PB_Kus.Name = "PB_Kus";
            this.PB_Kus.Size = new System.Drawing.Size(107, 72);
            this.PB_Kus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Kus.TabIndex = 2;
            this.PB_Kus.TabStop = false;
            this.PB_Kus.Click += new System.EventHandler(this.PB_Kus_Click);
            // 
            // Kus_Ucur
            // 
            this.Kus_Ucur.Interval = 1;
            this.Kus_Ucur.Tick += new System.EventHandler(this.Kus_Ucur_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kalan Kuş Sayısı :";
            // 
            // Kalan_Kus
            // 
            this.Kalan_Kus.AutoSize = true;
            this.Kalan_Kus.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kalan_Kus.Location = new System.Drawing.Point(268, 9);
            this.Kalan_Kus.Name = "Kalan_Kus";
            this.Kalan_Kus.Size = new System.Drawing.Size(47, 34);
            this.Kalan_Kus.TabIndex = 4;
            this.Kalan_Kus.Text = "16";
            // 
            // Can_1
            // 
            this.Can_1.Image = ((System.Drawing.Image)(resources.GetObject("Can_1.Image")));
            this.Can_1.Location = new System.Drawing.Point(1093, 12);
            this.Can_1.Name = "Can_1";
            this.Can_1.Size = new System.Drawing.Size(38, 24);
            this.Can_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Can_1.TabIndex = 5;
            this.Can_1.TabStop = false;
            // 
            // Can_2
            // 
            this.Can_2.Image = ((System.Drawing.Image)(resources.GetObject("Can_2.Image")));
            this.Can_2.Location = new System.Drawing.Point(1137, 12);
            this.Can_2.Name = "Can_2";
            this.Can_2.Size = new System.Drawing.Size(38, 24);
            this.Can_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Can_2.TabIndex = 5;
            this.Can_2.TabStop = false;
            // 
            // Can_3
            // 
            this.Can_3.Image = ((System.Drawing.Image)(resources.GetObject("Can_3.Image")));
            this.Can_3.Location = new System.Drawing.Point(1181, 12);
            this.Can_3.Name = "Can_3";
            this.Can_3.Size = new System.Drawing.Size(38, 24);
            this.Can_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Can_3.TabIndex = 5;
            this.Can_3.TabStop = false;
            // 
            // Kcan1
            // 
            this.Kcan1.Image = ((System.Drawing.Image)(resources.GetObject("Kcan1.Image")));
            this.Kcan1.Location = new System.Drawing.Point(1093, 13);
            this.Kcan1.Name = "Kcan1";
            this.Kcan1.Size = new System.Drawing.Size(38, 24);
            this.Kcan1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kcan1.TabIndex = 6;
            this.Kcan1.TabStop = false;
            // 
            // Kcan2
            // 
            this.Kcan2.Image = ((System.Drawing.Image)(resources.GetObject("Kcan2.Image")));
            this.Kcan2.Location = new System.Drawing.Point(1137, 12);
            this.Kcan2.Name = "Kcan2";
            this.Kcan2.Size = new System.Drawing.Size(38, 25);
            this.Kcan2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kcan2.TabIndex = 7;
            this.Kcan2.TabStop = false;
            // 
            // Kcan3
            // 
            this.Kcan3.Image = ((System.Drawing.Image)(resources.GetObject("Kcan3.Image")));
            this.Kcan3.Location = new System.Drawing.Point(1181, 11);
            this.Kcan3.Name = "Kcan3";
            this.Kcan3.Size = new System.Drawing.Size(38, 25);
            this.Kcan3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kcan3.TabIndex = 8;
            this.Kcan3.TabStop = false;
            this.Kcan3.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 627);
            this.Controls.Add(this.Kcan1);
            this.Controls.Add(this.Kcan2);
            this.Controls.Add(this.Kcan3);
            this.Controls.Add(this.Can_3);
            this.Controls.Add(this.Can_2);
            this.Controls.Add(this.Can_1);
            this.Controls.Add(this.Kalan_Kus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_Kus);
            this.Controls.Add(this.lbl_mermi);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Kus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Can_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Can_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Can_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kcan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kcan2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kcan3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_mermi;
        private System.Windows.Forms.PictureBox PB_Kus;
        private System.Windows.Forms.Timer Kus_Ucur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Kalan_Kus;
        private System.Windows.Forms.PictureBox Can_1;
        private System.Windows.Forms.PictureBox Can_2;
        private System.Windows.Forms.PictureBox Can_3;
        private System.Windows.Forms.PictureBox Kcan1;
        private System.Windows.Forms.PictureBox Kcan2;
        private System.Windows.Forms.PictureBox Kcan3;
    }
}

