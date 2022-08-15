using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_DZ10_AndrijanaJovanovic3918
{
    public partial class Form1 : Form
    {
        ArrayList listaBrojeva = new ArrayList();
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                listaBrojeva.Add(r.Next(100));
            }

            listBox.DataSource = listaBrojeva;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                object selectedItem = listBox.SelectedItem;
                listaBrojeva.Remove(selectedItem);
                listBox.DataSource = null;
                listBox.DataSource = listaBrojeva;
            }
            catch
            {
                MessageBox.Show("Niste odabrali element liste");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int broj = Convert.ToInt32(txt.Text);
            listaBrojeva.Add(broj);
            listBox.DataSource = null;
            listBox.DataSource = listaBrojeva;
            txt.Text = "";
        }
    }
}
