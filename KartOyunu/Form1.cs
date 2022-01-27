using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox kart1 = new PictureBox();
        PictureBox kart2 = new PictureBox();
        private string[] kartliste = Directory.GetFiles(@"C:\Users\Lenovo\OneDrive\Masaüstü\Projeler\KartOyunu\kartlar");
        string[] kartdizi1 = new string[26];
        string[] kartdizi2 = new string[26];

        int sayi = 0;
        int score = 0;

        private void btnGoster_Click(object sender, EventArgs e)
        {

            if (kartdizi1[sayi][61]==kartdizi2[sayi][61])
            {
                score++;
                LBLscore.Text = score.ToString();
            }

            kart1.ImageLocation = kartdizi1[sayi];
            kart1.Location = new Point(50, 120);
            kart1.Size = new Size(100, 150);
            kart1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(kart1);

            kart2.ImageLocation = kartdizi2[sayi];
            kart2.Location = new Point(570, 120);
            kart2.Size = new Size(100, 150);
            kart2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(kart2);
            sayi++;
            if (sayi==25)
            {
                MessageBox.Show("Game Over!");
                sayi = 0;
            }
        }

        private void btnKaristir_Click(object sender, EventArgs e)
        {
            kartliste = Karistirr(kartliste);
            kartikiyebol(kartliste);
        }

        private void kartikiyebol(string[] kartliste)
        {
            for (int i = 0; i < kartliste.Length/2; i++)
            {
                kartdizi1[i] = kartliste[i];
            }

            int x = 0;

            for (int i = 26; i < kartliste.Length; i++)
            {
                kartdizi2[x] = kartliste[i];
                x++;
            }
        }

        private string[] Karistirr(string[] kartliste)
        {
            string[] cekilenkart = new string[kartliste.Length];
            Random rnd = new Random();
            for (int i = 0; i < kartliste.Length; i++)
            {
                string kart = kartliste[rnd.Next(0, kartliste.Length)];
                if (!cekilenkart.Contains(kart))
                {
                    cekilenkart[i] = kart;
                }
                else
                {
                    i--;
                    continue;
                }
                
            }

            return cekilenkart ;
        }
    }
}
