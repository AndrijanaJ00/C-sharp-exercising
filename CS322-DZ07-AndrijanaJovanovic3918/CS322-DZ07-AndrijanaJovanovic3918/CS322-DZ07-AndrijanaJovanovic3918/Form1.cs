using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CS322_DZ07_AndrijanaJovanovic3918
{
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dell\Desktop\CS322-DZ07-AndrijanaJovanovic3918\CS322.accdb");
        public Form1()
        {
            InitializeComponent();
            fillgrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into Studenti(Ime, Godine) values ('"+txtIme.Text+"', "+txtGodine.Text+")", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved...");

            clearTxt();
            fillgrid();
        }

        void fillgrid() {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Studenti order by ID", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE Studenti set Ime = '" + txtIme.Text + "', Godine = " + txtGodine.Text + " WHERE ID="+txtID.Text+"", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated...");

            clearTxt();
            fillgrid();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Studenti WHERE ID=" + txtID.Text + " ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted...");

            clearTxt();
            fillgrid();


        }

        void clearTxt() {
            txtID.Text = "";
            txtIme.Text = "";
            txtGodine.Text = "";
        }
    }
}
