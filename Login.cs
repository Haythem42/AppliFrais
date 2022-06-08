using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliFrais
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Haythem42\source\repos\AppliFrais\AppliFraisDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void ConnexionBtn_Click(object sender, EventArgs e)
        {
            if (MailTb.Text == "" || MdpTb.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from acteurs where mail = '" + MailTb.Text + "' and mdp = '" + MdpTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Accueil Obj = new Accueil();
                        Obj.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Le mail ou le mot de passe est incorrect");
                    }
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
