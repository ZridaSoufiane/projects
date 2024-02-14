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
    public partial class ModifierClt : Form
    {
        public ModifierClt()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=LaMangaCar;Integrated Security=True");
        SqlCommand cmd;

        void chargerDonnee()
        {
            string CIN = Program.cin;
            txtCin.Text = CIN;
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select * from Client where cin = '"+CIN+"'",cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            txtNom.Text = dt.Rows[0]["nom"].ToString();
            txtPrenom.Text = dt.Rows[0]["prenom"].ToString();
            txtPermis.Text = dt.Rows[0]["permise"].ToString();
            txtTele.Text = dt.Rows[0]["tel"].ToString();
            txtAdresse.Text = dt.Rows[0]["adresse"].ToString();
            txtNationalite.Text = dt.Rows[0]["nationalite"].ToString();
            txtPassport.Text = dt.Rows[0]["passport"].ToString();
            dtpDateNaissance.Value = DateTime.Parse(dt.Rows[0]["dateNaissance"].ToString());
            cn.Close();
        }

        void updateTable()
        {
            int res = DateTime.Now.Year - dtpDateNaissance.Value.Year;
            if (res < 18)
            {
              DialogResult dg =  MessageBox.Show("age insuffisent  \n Voulez-vous continuer ??","AgeError", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              if (dg == DialogResult.Yes)
              {
                  if (cn.State == ConnectionState.Closed)
                      cn.Open();
                cmd = new SqlCommand("update  client set  nom = @nom , prenom = @prenom , permise = @permis , adresse = @adresse , tel = @tel , dateNaissance = @datenaissance , nationalite = @nationalite , passport = @passport where cin = '" + txtCin.Text + "'", cn);
                cmd.Parameters.AddWithValue("cin", txtCin.Text);
                cmd.Parameters.AddWithValue("nom", txtNom.Text);
                cmd.Parameters.AddWithValue("prenom", txtPrenom.Text);
                cmd.Parameters.AddWithValue("permis", txtPermis.Text);
                cmd.Parameters.AddWithValue("adresse", txtAdresse.Text);
                cmd.Parameters.AddWithValue("tel", txtTele.Text);
                cmd.Parameters.AddWithValue("datenaissance", dtpDateNaissance.Value);
                cmd.Parameters.AddWithValue("nationalite", txtNationalite.Text);
                cmd.Parameters.AddWithValue("passport", txtPassport.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Client est à jour", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClear();
              }
            }
            else
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                cmd = new SqlCommand("update  client set  nom = @nom , prenom = @prenom , permise = @permis , adresse = @adresse , tel = @tel , dateNaissance = @datenaissance , nationalite = @nationalite , passport = @passport where cin = '" + txtCin.Text + "'", cn);
                cmd.Parameters.AddWithValue("cin", txtCin.Text);
                cmd.Parameters.AddWithValue("nom", txtNom.Text);
                cmd.Parameters.AddWithValue("prenom", txtPrenom.Text);
                cmd.Parameters.AddWithValue("permis", txtPermis.Text);
                cmd.Parameters.AddWithValue("adresse", txtAdresse.Text);
                cmd.Parameters.AddWithValue("tel", txtTele.Text);
                cmd.Parameters.AddWithValue("datenaissance", dtpDateNaissance.Value);
                cmd.Parameters.AddWithValue("nationalite", txtNationalite.Text);
                cmd.Parameters.AddWithValue("passport", txtPassport.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Client est à jour", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClear();
            }
         
        }

        void txtClear()
        {
            txtCin.Clear();
            txtAdresse.Clear();
            txtNationalite.Clear();
            txtNom.Clear();
            txtPassport.Clear();
            txtPermis.Clear();
            txtPrenom.Clear();
            txtTele.Clear();
            dtpDateNaissance.Value = DateTime.Now;
        }

        private void ModifierClt_Load(object sender, EventArgs e)
        {
            chargerDonnee();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            updateTable();
            
        }

        private void txtTele_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTele.Text, "[^0-9]"))
            {
                
                txtTele.Text = txtTele.Text.Remove(txtTele.Text.Length - 1);
            }
        }
    }
}
