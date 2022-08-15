using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        Stack<int> listaBrojeva = new Stack<int>();
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                listaBrojeva.Push(r.Next(100));
            }

            listBox.DataSource = listaBrojeva.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Izbacen je broj " + listaBrojeva.Pop());
            listBox.DataSource = listaBrojeva.ToList();
        }

    }
}
