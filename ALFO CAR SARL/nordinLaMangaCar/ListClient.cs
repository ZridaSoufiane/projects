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
    public partial class ListClient : UserControl
    {
        public ListClient()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=LaMangaCar;Integrated Security=True");
        SqlCommand cmd;

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnPerso_Click(object sender, EventArgs e)
        {
          
        }

        private void btnNVClient_Click(object sender, EventArgs e)
        {
            NVClient nc = new NVClient();
            
            nc.ShowDialog();
        }

        void chargerGrill()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select CIN , permise , nom , prenom ,tel , dateNaissance , passport from client ", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
            cn.Close();
            
        }

        private void ListClient_Load(object sender, EventArgs e)
        {

            chargerGrill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chargerGrill();
            txtRech.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index >= 0 && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count)
            {
                Program.cin = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
               // MessageBox.Show(Program.cin, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ModifierClt mdC = new ModifierClt();
                mdC.ShowDialog();

            }
            else
                MessageBox.Show("veuillez selectioner le client a modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           DialogResult dg =  MessageBox.Show("voullez-vous vraiment supprimer ce Client ???", "Supprimer Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dg == DialogResult.Yes)
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                cmd = new SqlCommand("delete from client where cin = '" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()+"'", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Client supprimer avec succees","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtRech_TextChanged(object sender, EventArgs e)
        {
            recherchMulti();
        }

        void recherchMulti()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select * from client where CIN like '"+txtRech.Text+"%' or nom like '"+txtRech.Text+"%' or prenom like '"+txtRech.Text+"%' or permise like '"+txtRech.Text+"%' or adresse like '"+txtRech.Text+"%' or tel like '"+txtRech.Text+"%'",cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            cn.Close();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCINRech_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtAdresse_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNatio_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnRechPermis_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select * from client where  permise like '" + txtRech.Text + "%'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            cn.Close();
        }

        private void btnNom_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select * from client where  nom like '" + txtRech.Text + "%'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            cn.Close();
        }

        private void btnPrenom_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select * from client where  prenom like '" + txtRech.Text + "%'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            cn.Close();
        }

        private void btnNationalite_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select * from client where  nationalite like '" + txtRech.Text + "%'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void btnCIN_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select * from client where  CIN like '" + txtRech.Text + "%'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            cn.Close();
        }

        private void btnTel_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select * from client where  tel like '" + txtRech.Text + "%'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            cn.Close();
        }

        private void btnAdresse_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select * from client where  adresse like '" + txtRech.Text + "%'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
