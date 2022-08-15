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

namespace CS322_DZ02_AndrijanaJovanovic3918
{
    public partial class Form1 : Form
    {

        static int OUT = 0;
        static int IN = 1;

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

                DirectoryInfo[] cDirs = new DirectoryInfo(@"C:\Users\Dell\Desktop\CS322-DZ02-AndrijanaJovanovic3918\CS322-DZ02-AndrijanaJovanovic3918\bin\Debug").GetDirectories();

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
    }


}

