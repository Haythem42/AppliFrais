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
    public partial class Rédiger : Form
    {
        public Rédiger()
        {
            InitializeComponent();
            //populate();
        }

        //private void populate()
        //{
        //    Con.Open();
        //    SqlCommand cmd = new SqlCommand("select id, km, nuit, repas from frais_forfaits", Con);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    ForfaitDGV.DataSource = ds.Tables[0];
        //    Con.Close();
        //}

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Haythem42\source\repos\AppliFrais\AppliFraisDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void InsertForfait()
        {
            if (FKmTb.Text == "" || FNuitTb.Text == "" || FRepasTb.Text == "")
            {
                MessageBox.Show("Toutes les données doivent être renseignées !");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into frais_forfaits(km, nuit, repas) values(@FK, @FN, @FR)", Con);
                    cmd.Parameters.AddWithValue("@FK", FKmTb.Text);
                    cmd.Parameters.AddWithValue("@FN", FNuitTb.Text);
                    cmd.Parameters.AddWithValue("@FR", FRepasTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Frais forfait ajouté(s) !");
                    Con.Close();
                    //populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            
        }
        private void FValiderBtn_Click(object sender, EventArgs e)
        {
            InsertForfait(); 
        }

        private void InsertHorsForfait()
        {
            if (HFDate.Text == "" || HFMontant.Text == "")
            {
                MessageBox.Show("Toutes les données doivent être renseignées !");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into frais_hors_forfaits(dates, description, montant) values(@HFDa, @HFDe, @HFM)", Con);
                    cmd.Parameters.AddWithValue("@HFDa", HFDate.Value.Date);
                    cmd.Parameters.AddWithValue("@HFDe", HFDescription.Text);
                    cmd.Parameters.AddWithValue("@HFM", HFMontant.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Frais hors forfait ajouté(s) !");
                    Con.Close();
                    //populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void HFValiderBtn_Click(object sender, EventArgs e)
        {
            InsertHorsForfait();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
