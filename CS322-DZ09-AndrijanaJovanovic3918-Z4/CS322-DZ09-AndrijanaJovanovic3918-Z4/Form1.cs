using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_DZ09_AndrijanaJovanovic3918_Z4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            textBox1.Text.Replace("\r\n", "\r");
            listBox1.Items.Add(textBox1.Text);
            
            textBox1.Clear();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            double suma = 0;

            int[] niz = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                niz[i] = Convert.ToInt32(listBox1.Items[i].ToString());
            }
            for (int i = 0; i < niz.Length; i++)
            {
                suma += niz[i];
            }
            int n = listBox1.Items.Count;
            lblSuma.Text = "" + suma;
            lblSrVr.Text = "" + suma / n;

            int min = niz[0];
            int max = niz[0];
            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] < min) {
                    min = niz[i];
                }

                if (niz[i] > max)
                {
                    max = niz[i];
                }
            }

            lblMin.Text = "" + min;
            lblMax.Text = "" + max;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}