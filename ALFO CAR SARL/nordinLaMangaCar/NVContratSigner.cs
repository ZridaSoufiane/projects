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
    public partial class NVContratSigner : UserControl
    {
        public NVContratSigner()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=LaMangaCar;Integrated Security=True");
        SqlCommand cmd;

        void insertContrat()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                cmd = new SqlCommand("insert into louerVoiture values (@client,@voiture,@dateLivraison,@dateReprise,@MontantTotal,@avance,@DelivreLe)", cn);
                cmd.Parameters.AddWithValue("@client", txtCin.Text);
                cmd.Parameters.AddWithValue("voiture", cmbVoiture.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@dateLivraison", dtpDateLivraison.Value);
                cmd.Parameters.AddWithValue("@dateReprise", dtpDateReprise.Value);
                cmd.Parameters.AddWithValue("@MontantTotal", txtTotal.Text);
                cmd.Parameters.AddWithValue("@avance", txtAvance.Text);
                cmd.Parameters.AddWithValue("@DelivreLe", dtpDelivreLe.Value);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void imprimer()
        {
           Program.numContrat =  getContratNum();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            insertContrat();
            imprimer();
            ContratSG c = new ContratSG();
            c.ShowDialog();
        }

        void chargerCombo()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select * from voiture", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbVoiture.DataSource = dt;
            cmbVoiture.DisplayMember = "nomV";
            cmbVoiture.ValueMember = "numV";
            cn.Close();
           
        }

        int getContratNum()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select numContrat from louerVoiture where numContrat = (select MAX(numContrat) from louerVoiture)", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            int numC = 0;
            DataTable dt = new DataTable();
            dt.Load(dr);
            string n = dt.Rows[0]["numContrat"].ToString();
            numC = int.Parse(n);
          
            cn.Close();
            return numC;
        }

        private void NVContratSigner_Load(object sender, EventArgs e)
        {
            dtpDateLivraison.Value = DateTime.Now; dtpDateReprise.Value = DateTime.Now; dtpDelivreLe.Value = DateTime.Now;
            chargerCombo();
           // lblContrat.Text = getContratNum().ToString();
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            remplireClient();
        }

        void remplireVoiture()
        {
            if(cn.State == ConnectionState.Closed)
            cn.Open();
            cmd = new SqlCommand("select * from voiture where numV = @numV", cn);
            cmd.Parameters.AddWithValue("@numV", cmbVoiture.SelectedValue.ToString());
            SqlDataReader dr = cmd.ExecuteReader();
           
            DataTable dt = new DataTable();
            if (dr.HasRows)
            {
                dt.Load(dr);
                lblLettre.Text = dt.Rows[0]["lettre"].ToString();
                lblMarque.Text = dt.Rows[0]["marque"].ToString() + " " + dt.Rows[0]["TypeV"].ToString();
                lblMatriculation.Text = dt.Rows[0]["numMatricule"].ToString();
                lblRegion.Text = dt.Rows[0]["region"].ToString();
               
            }
            cn.Close();
        }

        void remplireClient()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select * from client where CIN = @cin", cn);
            cmd.Parameters.AddWithValue("@cin", txtCin.Text);
            SqlDataReader dr = cmd.ExecuteReader();
          
            DataTable dt = new DataTable();
            if(dr.HasRows)
            {
                dt.Load(dr);
                lblNomComplet.Text = dt.Rows[0]["nom"].ToString() + " " + dt.Rows[0]["prenom"].ToString();
                lblPermis.Text = dt.Rows[0]["permise"].ToString();
                lblCIN.Text = txtCin.Text;
                lblTel.Text = dt.Rows[0]["tel"].ToString();
               
            }
            cn.Close();
        }

        private void cmbVoiture_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplireVoiture();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            getContrat();
        }

        void getContrat()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select numContrat ,voiture,client,DelivreLe,dateLivraison,dateReprise,CAST(MontantTotal AS decimal(10,1)) AS 'Montant Total' ,  CAST(avance AS decimal(10,1)) AS 'Avance'  from louerVoiture where numContrat = @numC", cn);
            cmd.Parameters.AddWithValue("@numC", guna2TextBox1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            if (dt.Rows.Count >0)
            {
                cmbVoiture.SelectedValue = int.Parse(dt.Rows[0]["voiture"].ToString());
                txtCin.Text = dt.Rows[0]["client"].ToString();
                btnV.PerformClick();
                dtpDelivreLe.Value = DateTime.Parse( dt.Rows[0]["DelivreLe"].ToString());
                dtpDateLivraison.Value = DateTime.Parse(dt.Rows[0]["dateLivraison"].ToString());
                dtpDateReprise.Value = DateTime.Parse(dt.Rows[0]["dateReprise"].ToString());
                txtTotal.Text = dt.Rows[0]["Montant Total"].ToString();
                txtAvance.Text = dt.Rows[0]["Avance"].ToString();
            }
            cn.Close();
        }

        void updateContrat()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("update louerVoiture   set client = @client , voiture = @voiture, dateLivraison = @dateLivraison, dateReprise = @dateReprise , MontantTotal = @MontantTotal , avance = @avance, DelivreLe = @DelivreLe where numContrat = "+guna2TextBox1.Text, cn);
            cmd.Parameters.AddWithValue("@client", txtCin.Text);
            cmd.Parameters.AddWithValue("voiture", cmbVoiture.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@dateLivraison", dtpDateLivraison.Value);
            cmd.Parameters.AddWithValue("@dateReprise", dtpDateReprise.Value);
            cmd.Parameters.AddWithValue("@MontantTotal", txtTotal.Text);
            cmd.Parameters.AddWithValue("@avance", txtAvance.Text);
            cmd.Parameters.AddWithValue("@DelivreLe", dtpDelivreLe.Value);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("contrat est à jour ", "update Contrat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                updateContrat();
            }
            catch (Exception)
            {
                MessageBox.Show("un erreur c'est produit vuillier contacter nous");
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTotal.Text, "[^0-9]"))
            {
                 
                txtTotal.Text = txtTotal.Text.Remove(txtTotal.Text.Length - 1);
            }
        }

        private void txtAvance_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAvance.Text, "[^0-9]"))
            {
                 
                txtAvance.Text = txtAvance.Text.Remove(txtAvance.Text.Length - 1);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(guna2TextBox1.Text, "[^0-9]"))
            {

                guna2TextBox1.Text = guna2TextBox1.Text.Remove(guna2TextBox1.Text.Length - 1);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

    }
}
