using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    public partial class Form1 : Form
    {
        Queue<int> listaBrojeva = new Queue<int>();
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Izbacen je broj " + listaBrojeva.Dequeue());
            listBox.DataSource = listaBrojeva.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 15; i++)
            {
                listaBrojeva.Enqueue(r.Next(100));
            }
            listBox.DataSource = listaBrojeva.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int broj = Convert.ToInt32(txt.Text);
            listaBrojeva.Enqueue(broj);
            listBox.DataSource = null;
            listBox.DataSource = listaBrojeva.ToList();
            txt.Text = "";
        }
    }
}
