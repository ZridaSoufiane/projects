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
    public partial class NVClient : Form
    {
        public NVClient()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=LaMangaCar;Integrated Security=True");
        SqlCommand cmd;

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool saisie()
        {

            if (txtCin.Text.Trim() == "" || txtNom.Text.Trim() == "" || txtPrenom.Text.Trim() == "" || txtPermis.Text.Trim() == "")
            {
                return false;
            }
            else
                return true;
        }

        void champsNull()
        {
            if (txtNationalite.Text == "")
                txtNationalite.Text = "   ";
            if (txtPassport.Text == "")
                txtPassport.Text = "   ";
            if (txtTele.Text == "")
                txtTele.Text = "   ";
            if (txtAdresse.Text == "")
                txtAdresse.Text = "   ";
           
        }

        void ajouterClient()
        {
            champsNull();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("insert into client values (@cin,@nom,@prenom,@permis,@adresse,@tel,@datenaissance,@nationalite,@passport)",cn);
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

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (!saisie())
            {
                MessageBox.Show("Veuiller verifier que les champs 'CIN' , 'Nom' , 'Prenom' et 'Permis' sont remplis !", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else  {
                ajouterClient();
                txtClear();
                MessageBox.Show("Un client est ajouter avec succées", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           // this.Close();
        }

        private void NVClient_Load(object sender, EventArgs e)
        {
            dtpDateNaissance.Value = DateTime.Now;
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
