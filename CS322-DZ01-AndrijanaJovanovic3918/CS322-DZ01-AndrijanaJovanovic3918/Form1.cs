using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_DZ01_AndrijanaJovanovic3918
{
    public partial class Forma : Form
    {
        public Forma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string adresa = txtAdresa.Text;
            string telefon = txtTelefon.Text;
            string jmbg = txtJMBG.Text;
            string brLicne = txtLicnaKarta.Text;
            char[] characters = jmbg.ToCharArray();

            if (jmbg.Length == 13 && characters[7] == '7' && characters[8] == '3')
            { 
                    MessageBox.Show("Osoba je rodjena u Nisu");
                    lblRezultat.Text = "Rezultat: Osoba je rodjena u Nisu";
             }
                else
                {
                    MessageBox.Show("Osoba nije rodjena u Nisu");
                    lblRezultat.Text = "Rezultat: Osoba nije rodjena u Nisu";
                    empty();
                }
                empty();
     

        }

        public void empty() {
            txtIme.Clear();
            txtPrezime.Clear();
            txtAdresa.Clear();
            txtJMBG.Clear();
            txtTelefon.Clear();
            txtLicnaKarta.Clear();
        }
    }
}
