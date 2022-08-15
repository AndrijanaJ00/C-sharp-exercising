using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms;

namespace CS322_DZ03_AndrijanaJovanovic3918
{
    public partial class Form1 : Form
    {
        static int OUT = 0;
        static int IN = 1;

        Bitmap slika;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string adresa = txtAdresa.Text;
            string telefon = txtTelefon.Text;
            string jmbg = txtJMBG.Text;
            string brLicne = txtLicnaKarta.Text;
            int countAdresa = 0;
            int countIme = 0;

            countAdresa = countWords(adresa);
            countIme = countWords(ime);

            if (countAdresa >= 2 && countIme == 1)
            {
                MessageBox.Show("Ime: " + ime + "\n" + "Adresa: " + adresa + "\n" + "Telefon: " + telefon + "\n" + "JMBG: " + jmbg + "\n" + "Broj licne karte: " + brLicne + "\n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DirectoryInfo[] cDirs = new DirectoryInfo(@"C:\Users\Dell\Desktop\CS322-DZ03-AndrijanaJovanovic3918\CS322-DZ03-AndrijanaJovanovic3918\bin\Debug").GetDirectories();

                using (StreamWriter sw = new StreamWriter("upis.txt"))
                {
                    sw.WriteLine(ime);
                    sw.WriteLine(prezime);
                    sw.WriteLine(adresa);
                    sw.WriteLine(telefon);
                    sw.WriteLine(jmbg);
                    sw.WriteLine(brLicne);

                }
                empty();

            }
            else
            {
                MessageBox.Show("Netacan unos ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                empty();
            }
        }
        static int countWords(String str)
        {
            int state = OUT;
            int wc = 0;
            int i = 0;

            while (i < str.Length)
            {

                if (str[i] == ' ' || str[i] == '\n')
                    state = OUT;

                else if (state == OUT)
                {
                    state = IN;
                    ++wc;
                }

                ++i;
            }

            return wc;
        }

        public void empty()
        {
            txtIme.Clear();
            txtPrezime.Clear();
            txtAdresa.Clear();
            txtJMBG.Clear();
            txtTelefon.Clear();
            txtLicnaKarta.Clear();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            slika.Save("slika.png");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            DialogResult rez = of.ShowDialog();
            if (rez == DialogResult.OK)
            {
                slika = (Bitmap)Bitmap.FromFile(of.FileName);
                pictureBox1.Image = slika;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog of = new SaveFileDialog();
            of.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            of.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            lblShowHide.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblShowHide.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string color = textBox1.Text.ToUpper();
            lblBoja.Text = color;
            switch (color)
            {
                case "GREEN": lblBoja.BackColor = Color.Green; break;
                case "YELLOW": lblBoja.BackColor = Color.Yellow; break;
                case "BLUE": lblBoja.BackColor = Color.Blue; break;
                default: lblBoja.Text = "Repeat"; break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string prikazIzTxtBoxa = txtUpis.Text;

            listBox1.Items.Add(prikazIzTxtBoxa);
            txtUpis.Clear();
        }
    }
}
