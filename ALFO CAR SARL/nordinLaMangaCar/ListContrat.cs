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
    public partial class ListContrat : UserControl
    {
        public ListContrat()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=LaMangaCar;Integrated Security=True");
        SqlCommand cmd;

        void CHARGERdgv()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("SELECT LV.numContrat AS 'Contrat N°' ,  C.CIN , c.nom , C.prenom , V.nomV , LV.dateLivraison AS 'Date Livraison' , LV.dateReprise AS 'Date Reprise' ,  CAST(LV.MontantTotal AS decimal(10,1)) AS 'Montant Total' ,  CAST(LV.avance AS decimal(10,1)) AS 'Avance' , LV.DelivreLe FROM client C , Voiture V , louerVoiture LV WHERE C.CIN = LV.client AND V.numV = LV.voiture", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvListContrat.DataSource = dt;
            cn.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnFacture_Click(object sender, EventArgs e)
        {
             
        }

        private void NVContrat_Load(object sender, EventArgs e)
        {
            CHARGERdgv();
            dtpDu.Value = dtpJSQ.Value = guna2DateTimePicker1.Value= DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtRech_TextChanged(object sender, EventArgs e)
        {

            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("SELECT LV.numContrat AS 'Contrat N°',  C.CIN , c.nom , C.prenom , V.nomV , LV.dateLivraison AS 'Date Livraison' , LV.dateReprise AS 'Date Reprise' ,  CAST(LV.MontantTotal AS decimal(10,1)) AS 'Montant Total' ,  CAST(LV.avance AS decimal(10,1)) AS 'Avance' , LV.DelivreLe FROM client C , Voiture V , louerVoiture LV WHERE C.CIN = LV.client AND V.numV = LV.voiture AND ( C.CIN like '" + txtRech.Text + "%' or  c.nom like '" + txtRech.Text + "%' or C.prenom like '" + txtRech.Text + "%' or V.nomV like '" + txtRech.Text + "%' ) ", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvListContrat.DataSource = dt;

            cn.Close();
       
        }

        private void btnRechDate_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("SELECT LV.numContrat AS 'Contrat N°' , C.CIN , c.nom , C.prenom , V.nomV , LV.dateLivraison AS 'Date Livraison' , LV.dateReprise AS 'Date Reprise' ,  CAST(LV.MontantTotal AS decimal(10,1)) AS 'Montant Total' ,  CAST(LV.avance AS decimal(10,1)) AS 'Avance' , LV.DelivreLe FROM client C , Voiture V , louerVoiture LV WHERE C.CIN = LV.client AND V.numV = LV.voiture AND ( LV.dateLivraison between @du and @jsq ) ", cn);
            cmd.Parameters.AddWithValue("@du", dtpDu.Value);
            cmd.Parameters.AddWithValue("@jsq", dtpJSQ.Value);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvListContrat.DataSource = dt;

            cn.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNumC.Text, "[^0-9]"))
            {

                txtNumC.Text = txtNumC.Text.Remove(txtNumC.Text.Length - 1);
            }
            if (txtNumC.Text.Length != 0)
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                cmd = new SqlCommand("SELECT LV.numContrat AS 'Contrat N°' , C.CIN , c.nom , C.prenom , V.nomV , LV.dateLivraison AS 'Date Livraison' , LV.dateReprise AS 'Date Reprise' ,  CAST(LV.MontantTotal AS decimal(10,1)) AS 'Montant Total' ,  CAST(LV.avance AS decimal(10,1)) AS 'Avance' , LV.DelivreLe FROM client C , Voiture V , louerVoiture LV WHERE C.CIN = LV.client AND V.numV = LV.voiture AND ( LV.numContrat = " + txtNumC.Text + " ) ", cn);
                cmd.Parameters.AddWithValue("@du", dtpDu.Value);
                cmd.Parameters.AddWithValue("@jsq", dtpJSQ.Value);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvListContrat.DataSource = dt;

                cn.Close();
            }
            else
                CHARGERdgv();
           
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            CHARGERdgv();
            txtRech.Clear();
            txtNumC.Clear();
            dtpDu.Value = dtpJSQ.Value = DateTime.Now;
        }

        void checkFacture()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select * from Facture where numC = "+txtNumC.Text,cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            if (dt.Rows.Count>0)
            {
                Program.numF = int.Parse(dt.Rows[0][0].ToString());
                cn.Close();
                Program.numF = int.Parse(txtNumC.Text);
                Facture f = new Facture();
                f.ShowDialog();
            }
            else
            {
                cn.Close();
                dgvListContrat.Height = 228;
                pnlF.Visible = true;
            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumC.Text))
                MessageBox.Show("veuiller saisir un numero du Contrat valid !");
            checkFacture();
            duree();
        }

        int  getFactureN ()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select numF from Facture where numF = (select MAX(numF) from Facture)", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            int numF = 0;
            DataTable dt = new DataTable();
            dt.Load(dr);
            string n = dt.Rows[0]["numF"].ToString();
            numF = int.Parse(n);

            cn.Close();
            return numF;
        }

        void NouveauFacture()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("insert into Facture values (@numF,@dateF,@numC,@Duree,@PrixUHT,@PrixTHT,@TotalNet,@TVA)", cn);
            cmd.Parameters.AddWithValue("@numF", txtNumC.Text);
            cmd.Parameters.AddWithValue("@dateF", guna2DateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@numC", txtNumC.Text);
            cmd.Parameters.AddWithValue("@Duree", lblDL.Text);
            cmd.Parameters.AddWithValue("@PrixUHT", txtPUHT.Text);
            cmd.Parameters.AddWithValue("@PrixTHT",txtPTHT.Text );
            cmd.Parameters.AddWithValue("@TotalNet", txtTOTNet.Text);
            cmd.Parameters.AddWithValue("@TVA", txtTVA.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        void duree()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select DATEDIFF(DAY,dateLivraison,dateReprise) as duree from louerVoiture where numContrat = "+txtNumC.Text, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            lblDL.Text = dt.Rows[0][0].ToString();
            cn.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            dgvListContrat.Height = 359;
            pnlF.Visible = false;
           
            NouveauFacture();
            Program.numF = getFactureN();
            Facture f = new Facture();
            f.ShowDialog();
        }

        private void txtPUHT_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPUHT.Text, "[^0-9]"))
            {
                
                txtPUHT.Text = txtPUHT.Text.Remove(txtPUHT.Text.Length - 1);
            }
        }

        private void txtPTHT_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPTHT.Text, "[^0-9]"))
            {
                 
                txtPTHT.Text = txtPTHT.Text.Remove(txtPTHT.Text.Length - 1);
            }
        }

        private void txtTVA_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTVA.Text, "[^0-9]"))
            {
                 
                txtTVA.Text = txtTVA.Text.Remove(txtTVA.Text.Length - 1);
            }
        }

        private void txtTOTNet_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTOTNet.Text, "[^0-9]"))
            {
                
                txtTOTNet.Text = txtTOTNet.Text.Remove(txtTOTNet.Text.Length - 1);
            }
        }

        private void dgvListContrat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
