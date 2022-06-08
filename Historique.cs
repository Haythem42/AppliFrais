using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppliFrais
{
    public partial class Historique : Form
    {
        public Historique()
        {
            InitializeComponent();
            populate1();
            populate2();
        }

        private void populate1()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select id, km, nuit, repas from frais_forfaits", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ForfaitDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void populate2()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select id, dates, description, montant from frais_hors_forfaits", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            HorsForfaitDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Haythem42\source\repos\AppliFrais\AppliFraisDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
