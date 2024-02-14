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
    public partial class compte : Form
    {
        public compte()
        {
            InitializeComponent();
        }

       

        private void compte_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=LaMangaCar;Integrated Security=True");
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            SqlCommand cmd = new SqlCommand("select * from utilisateur where numero = 1", cn);

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable(); 
            dt.Load(dr);
             txtUserName.Text = dt.Rows[0]["nomuser"].ToString();
            string pwAcc = dt.Rows[0]["motDePasse"].ToString();
            txtPWactuel.Text = pwAcc;
            cn.Close();


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtNVMP.Text == txtCnfrm.Text)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=USER-PC\WASPDBEXPRESS;Initial Catalog=LaMangaCar;Integrated Security=True");
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                SqlCommand cmd = new SqlCommand("update utilisateur set nomuser = '"+txtUserName.Text+"' , motDePasse = '"+txtCnfrm.Text+"' where numero = 1", cn);
                cmd.ExecuteNonQuery();
                pbWarning2.Visible = false;
                label2.Visible = false;
                this.Close();
            }
            else
            {
                pbWarning2.Visible = true;
                label2.Visible = true;
            }

        }

        private void txtNVMP_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=USER-PC\WASPDBEXPRESS;Initial Catalog=LaMangaCar;Integrated Security=True");
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            SqlCommand cmd = new SqlCommand("select * from utilisateur where numero = 1", cn);
            
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable(); dt.Load(dr);
           // txtUserName.Text = dt.Rows[0]["nomuser"].ToString();
             string pwAcc = dt.Rows[0]["motDePasse"].ToString();
             cn.Close();
             if (txtPWactuel.Text == pwAcc)
             {
                 pbWarning.Visible = false;
                 label1.Visible = false;
             }
             else
             {
                 pbWarning.Visible = true;
                 label1.Visible = true;

             }
        }

        private void txtCnfrm_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnVidange_Click(object sender, EventArgs e)
        {
             txtPWactuel.UseSystemPasswordChar = false;
             btnShowCurrentPW.Visible=false;
             btnHideCurrentPW.Visible = true;
        }

        private void btnHideCurrentPW_Click(object sender, EventArgs e)
        {
            txtPWactuel.UseSystemPasswordChar = true;
            btnShowCurrentPW.Visible = true;
            btnHideCurrentPW.Visible = false;
        }

        private void btnShowNVPW_Click(object sender, EventArgs e)
        {
            txtNVMP.UseSystemPasswordChar = false;
            btnShowNVPW.Visible = false;
            btnHideNVPW.Visible = true;
        }

        private void btnHideNVPW_Click(object sender, EventArgs e)
        {
            txtNVMP.UseSystemPasswordChar = true;
            btnShowNVPW.Visible = true;
            btnHideNVPW.Visible = false;
        }

        private void btnShowCNFRMPW_Click(object sender, EventArgs e)
        {
            txtCnfrm.UseSystemPasswordChar = false;
            btnShowCNFRMPW.Visible = false;
            btnHideCnfrmPW.Visible = true;
        }

        private void btnHideCnfrmPW_Click(object sender, EventArgs e)
        {
            txtCnfrm.UseSystemPasswordChar = true;
            btnShowCNFRMPW.Visible = true;
            btnHideCnfrmPW.Visible = false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbWarning_Click(object sender, EventArgs e)
        {

        }

        private void pbWarning2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNVMP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
