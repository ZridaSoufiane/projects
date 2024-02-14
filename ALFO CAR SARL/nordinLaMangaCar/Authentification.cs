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

namespace nordinLaMangaCar
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=LaMangaCar;Integrated Security=True");
        SqlCommand cmd;

        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                Form1 f = new Form1();
                this.Hide();
                f.Show();
            }
            else
                MessageBox.Show("mot de posse ou nom d'etulisateur est erronée !", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        bool valid ()
        {
            bool V = false; string userName = null; string PW = null;
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select * from utilisateur where nomuser = @user and motDePasse = @PW", cn);
            cmd.Parameters.AddWithValue("@user", txtUser.Text);
            cmd.Parameters.AddWithValue("@PW", txtPW.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            if (dt.Rows.Count>0)
            {
                userName = dt.Rows[0]["nomuser"].ToString();
                PW = dt.Rows[0]["motDePasse"].ToString();
                if (userName == txtUser.Text && PW == txtPW.Text)
                    V = true;
          
            }
           
            cn.Close();
            return V;
        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            
            
        }

        private void txtPW_Validating(object sender, CancelEventArgs e)
        {
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
                Form1 f = new Form1();
                this.Hide();
                f.Show();
            
        }

        private void guna2TextBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {


        }

        private void btnShowCurrentPW_Click(object sender, EventArgs e)
        {
            txtPW.UseSystemPasswordChar = false;
            btnHideCurrentPW.Visible = true;
            btnShowCurrentPW.Visible = false;
        }

        private void btnHideCurrentPW_Click(object sender, EventArgs e)
        {
            txtPW.UseSystemPasswordChar = true;
            btnHideCurrentPW.Visible = false;
            btnShowCurrentPW.Visible = true;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
