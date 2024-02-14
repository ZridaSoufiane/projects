using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace nordinLaMangaCar
{
    public partial class Accueil : UserControl
    {
        public Accueil()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=LaMangaCar;Integrated Security=True");
        SqlCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            compte c = new compte();
            c.ShowDialog();
        }

        void VoitureSortieCeMois()
        {
            int mois = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            DateTime CeMois = new DateTime(year, mois, 01);
            if(cn.State ==ConnectionState.Closed)
            cn.Open();
            cmd = new SqlCommand("select count(*) as 'Voiture sortie' from louerVoiture as lv , voiture  where lv.voiture = numV and dateReprise between @DebutMois and GETDATE() ", cn);
            cmd.Parameters.AddWithValue("@DebutMois", CeMois);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            lblVSCM.Text = dt.Rows[0][0].ToString();
            cn.Close();
        }

        void NombreVoiture()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select count(*) as 'Nombre Voiture' from voiture ", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            lblNV.Text = dt.Rows[0][0].ToString();
           
            cn.Close();
        }

        void VoitureSortie()
        {

            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select count(lv.numContrat) as 'Voiture sortie' from louerVoiture as lv , voiture  where lv.voiture = numV and dateReprise < GETDATE()", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            lblVS.Text = dt.Rows[0][0].ToString();
            lblVS2.Text = dt.Rows[0][0].ToString();
            cn.Close();
        }

        void contratSignee()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select count(*) as 'contratSigner' from louerVoiture ", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
             lblCtrS.Text = dt.Rows[0][0].ToString();
            cn.Close();
        }

        void contratSigneeCeMois()
        {
            int mois = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            DateTime CeMois = new DateTime(year, mois, 01);
            cn.Open();
            cmd = new SqlCommand("select count(*) as 'contratSigner' from louerVoiture  where dateReprise between @DebutMois and GETDATE() ", cn);
            cmd.Parameters.AddWithValue("@DebutMois", CeMois);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            lblCTRSCM.Text = dt.Rows[0][0].ToString();
            cn.Close();
        }

        void RevenueF()
        {
            int mois = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            DateTime CeMois = new DateTime(year, mois, 01);
            cn.Open();
            cmd = new SqlCommand("select CAST(sum(MontantTotal) AS decimal(10,1)) as 'MT' from louerVoiture  where dateReprise between @DebutMois and GETDATE() ", cn);
            cmd.Parameters.AddWithValue("@DebutMois", CeMois);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            if (dt.Rows.Count == 1)
                lblM.Text = "0";
            else
            lblM.Text = dt.Rows[0][0].ToString();
            cn.Close();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            NombreVoiture();
            VoitureSortieCeMois();
            VoitureSortie();
            contratSignee();
            contratSigneeCeMois();
            RevenueF();
        }

        private void lblVS_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleProgressBar2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleProgressBar3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
