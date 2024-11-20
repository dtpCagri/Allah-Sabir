using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avzi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PB_Kus.Width = 75;
            PB_Kus.Height = 50;

            lbl_mermi.Parent = pictureBox1;
            lbl_mermi.BackColor = Color.Transparent;

            PB_Kus.Parent = pictureBox1;
            PB_Kus.BackColor = Color.Transparent;

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            Kalan_Kus.Parent = pictureBox1;
            Kalan_Kus.BackColor = Color.Transparent;

            Can_1.Parent = pictureBox1;
            Can_1.BackColor = Color.Transparent;

            Can_2.Parent = pictureBox1;
            Can_2.BackColor = Color.Transparent;

            Can_3.Parent = pictureBox1;
            Can_3.BackColor = Color.Transparent;
        }

        int mermi = 20;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mermi--;
            lbl_mermi.Text = mermi.ToString();

            if (mermi == 0)
            {
                Kus_Ucur.Enabled = false;
                MessageBox.Show("Vurulmayan kuş sayısı:" + vurulmayan.ToString() + "\n Kalan kuş sayısı:" + kalanKus.ToString(), "MERMİ BİTTİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            
        }

        int x, y;
        Random r = new Random();

        int vurulmayan = 0;
        int can = 3;
        private void Kus_Ucur_Tick(object sender, EventArgs e)
        {
            y -= 2;

            PB_Kus.SetBounds(x, y, 75, 50);

            if(y < 10)
            {
                x = r.Next(880);
                y = 230;

                PB_Kus.SetBounds(x, y, 75, 50);

                kalanKus--;
                Kalan_Kus.Text = kalanKus.ToString();

                vurulmayan++;

                can--;

                if (can == 2)
                {
                    this.Controls.Remove(Kcan3);
                }

                if (can == 1)
                {
                    this.Controls.Remove(Kcan2);
                }

                if (can == 0)
                {
                    this.Controls.Remove(Kcan1);
                    Kus_Ucur.Stop();
                    MessageBox.Show("Vurulmayan kuş sayısı:" + vurulmayan.ToString() + "\n Kalan kuş sayısı:" + kalanKus.ToString(), "KAYBETTİNİZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }

            /*
            if (kalanKus == 0)
            {
                Kus_Ucur.Enabled = false;
                if(vurulmayan == 0)
                {
                    MessageBox.Show("Vurulmayan kuş sayısı:" + vurulmayan.ToString() + "\n TEKBRİKLER KAZANDINIZ", "KAZANDINIZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Vurulmayan kuş sayısı:" + vurulmayan.ToString() + "\n MAALESEF KAYBETTİNİZ", "KAYBETTİNİZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            } */
        }

        int kalanKus = 16;

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PB_Kus_Click(object sender, EventArgs e)
        {
            kalanKus--;
            Kalan_Kus.Text = kalanKus.ToString();

            if (kalanKus == 0)
            {
                Kus_Ucur.Enabled = false;
                MessageBox.Show("Vurulmayan kuş sayısı:" + vurulmayan.ToString() + "\n Kalan kuş sayısı:" + kalanKus.ToString(), "KAZNDINIZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            mermi--;
            lbl_mermi.Text = mermi.ToString();    
            
            x = r.Next(880);
            y = 230; 

            PB_Kus.SetBounds(x, y, 75, 50);

            Kus_Ucur.Enabled = true;
            
        }
    }
}
