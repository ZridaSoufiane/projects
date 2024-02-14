using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace nordinLaMangaCar
{
    public partial class NVVoiture : UserControl
    {
        public NVVoiture()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=LaMangaCar;Integrated Security=True");
        SqlCommand cmd;
        DataTable dtImg = new DataTable();
        BindingSource bd = new BindingSource();

       



        private void RDNrml_CheckedChanged(object sender, EventArgs e)
        {
            if(RDNrml.Checked)
            {
                panel1.Visible = false;
                panel2.Visible = true;
               // GRPMat.Height = 264;
            }
            else if (rdNV.Checked)
            {
                panel2.Visible = false;
                panel1.Visible = true;
               // GRPMat.Height = 153;
            }
        }

        private void rdNV_CheckedChanged(object sender, EventArgs e)
        {
            if (RDNrml.Checked)
            {
                panel1.Visible = false;
                panel2.Visible = true;
            }
            else if (rdNV.Checked)
            {
                panel2.Visible = false;
                panel1.Visible = true;
            }
        }

        
        void dataBind(int index)
        {
           if(cn.State == ConnectionState.Closed)
            cn.Open();
            cmd = new SqlCommand("select * from voiture where numV = "+index, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            txtMarque.Text = dt.Rows[0]["marque"].ToString();
            txtType.Text = dt.Rows[0]["TypeV"].ToString();
            txtKM.Text = dt.Rows[0]["kilometrage"].ToString();
            txtVidange.Text = dt.Rows[0]["vidange"].ToString();
            txtRegion.Text = dt.Rows[0]["region"].ToString();
            txtNumerMat.Text = dt.Rows[0]["numMatricule"].ToString();
            lblLaitre.Text = dt.Rows[0]["lettre"].ToString();
            dtpVT.Value = DateTime.Parse(dt.Rows[0]["visiteTechnique"].ToString());
            cn.Close();
        }
        void chargerCombo()
        {
            if (cn.State == ConnectionState.Closed)
            cn.Open();
            cmd = new SqlCommand("select * from voiture", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbNomV.DataSource = dt;
            cmbNomV.DisplayMember = "nomV";
            cmbNomV.ValueMember = "numV";
            cn.Close();
            cmbNomV.Enabled = true;
            charger = true;
        }

        private void NVVoiture_Load(object sender, EventArgs e)
        {
            dtpVT.Value = DateTime.Now;
          //  dtpAssurance.Value = DateTime.Now;
       
        }

        string imgLoc;
        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.ShowDialog();
            imgLoc = opf.FileName.ToString();
            pbVoiture.ImageLocation = imgLoc;
         
         
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            btnModifier.Enabled = false;
            btnsupprimer.Enabled = false;
            btnValider.Visible = true;
            btnAnnuler.Visible = true;
          

        }

        void setImage(int nb)
        {
            if (cn.State == ConnectionState.Closed)
            cn.Open();
            cmd = new SqlCommand("select * from voiture where numV =" + nb, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                byte[] img = (byte[])(dr["photo"]);
                if (img == null)
                    MessageBox.Show("picture is not available !");
                else
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pbVoiture.Image = Image.FromStream(ms);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }

            }
            else
                MessageBox.Show("has no rows !!");

            cn.Close();
          

        }

        void ajouterVoiture()
        {
            try
            {
                if (imgLoc == null)
                    imgLoc = @"C:\Users\aymane\Desktop\projet\logoV.jpg";
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string req = "";
                if (RDNrml.Checked)
                    req = "insert into voiture values(@marque,@VT,@Vidange,@Type,@KM,@photo,@region,@lettre,@numMat,@nomV)";
                else if (rdNV.Checked)
                    req = "insert into voiture values(@marque,null,@Vidange,@Type,@KM,@photo,null,null,@numMat,@nomV)";
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                SqlCommand cmd2 = new SqlCommand(req, cn);
                cmd2.Parameters.AddWithValue("@photo", img);
                cmd2.Parameters.AddWithValue("@marque", txtMarque.Text);
                cmd2.Parameters.AddWithValue("@VT", dtpVT.Value);
                cmd2.Parameters.AddWithValue("@Vidange", txtVidange.Text);
                cmd2.Parameters.AddWithValue("@Type", txtType.Text);
                cmd2.Parameters.AddWithValue("@KM", txtKM.Text);
                cmd2.Parameters.AddWithValue("@region", txtRegion.Text);
                cmd2.Parameters.AddWithValue("@lettre", cmbLtr.SelectedItem.ToString());
                cmd2.Parameters.AddWithValue("@numMat", txtNumerMat.Text);
                cmd2.Parameters.AddWithValue("@nomV", txtMarque.Text + " " + txtType.Text + txtNumerMat.Text);
                cmd2.ExecuteNonQuery();
                MessageBox.Show(txtMarque.Text + " " + txtType.Text + " est ajoutée avec succees");
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void modifierVoiture()
        {    string req = "";
            byte[] img = null;
            SqlCommand cmd2 = new SqlCommand();
            if (cn.State == ConnectionState.Closed)
            cn.Open();
            
            
            if (imgLoc == null)
            {
                req = "update voiture set marque = @marque , visiteTechnique = @VT , vidange = @Vidange , TypeV = @Type , kilometrage = @KM  , region = @region , lettre = @lettre , numMatricule = @numMat , nomV = @nomV where numV = " + cmbNomV.SelectedValue.ToString();

                
            }
            else
            {
                 if (RDNrml.Checked)
                req = "update voiture set marque = @marque , visiteTechnique = @VT , vidange = @Vidange , TypeV = @Type , kilometrage = @KM , photo = @photo , region = @region , lettre = @lettre , numMatricule = @numMat , nomV = @nomV where numV = " + cmbNomV.SelectedValue.ToString();
                else if (rdNV.Checked)
                req = "update voiture set marque = @marque ,   vidange = @Vidange , TypeV = @Type , kilometrage = @KM , photo = @photo , numMatricule = @numMat , nomV = @nomV where numV = " + cmbNomV.SelectedValue.ToString();
                
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length); 
                cmd2.Parameters.AddWithValue("@photo", img);
            }
            cmd2.CommandText = req;
            cmd2.Connection = cn;
            cmd2.Parameters.AddWithValue("@marque", txtMarque.Text);
            cmd2.Parameters.AddWithValue("@VT", dtpVT.Value);
            cmd2.Parameters.AddWithValue("@Vidange", txtVidange.Text);
            cmd2.Parameters.AddWithValue("@Type", txtType.Text);
            cmd2.Parameters.AddWithValue("@KM", txtKM.Text);
            cmd2.Parameters.AddWithValue("@region", txtRegion.Text);
            if (cmbLtr.SelectedItem!=null)
            cmd2.Parameters.AddWithValue("@lettre", cmbLtr.SelectedItem.ToString());
            else
            cmd2.Parameters.AddWithValue("@lettre", lblLaitre.Text);
            cmd2.Parameters.AddWithValue("@numMat", txtNumerMat.Text);
            cmd2.Parameters.AddWithValue("@nomV", txtMarque.Text + " " + txtType.Text + txtNumerMat.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show(txtMarque.Text + " " + txtType.Text + " est Modifié avec succees");
            cn.Close();
            
        }
 

        private void cmbNomV_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            

            try
            {
                string index = cmbNomV.SelectedValue.ToString();
                setImage(int.Parse(index));
                dataBind(int.Parse(index));
             
            }
            catch (Exception  )
            {
                
            }
        }

        bool charger = false;

        private void btnModifier_Click(object sender, EventArgs e)
        {
            btnAjouter.Enabled = false;
            btnsupprimer.Enabled = false;
            btnValider.Visible = true;
            btnAnnuler.Visible = true;
            if (!charger)
                chargerCombo();
            cmbNomV.Enabled = true;
            lblLaitre.Visible = true;
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            btnModifier.Enabled = false;
            btnAjouter.Enabled = false;
            btnValider.Visible = true;
            btnAnnuler.Visible = true;
            if (!charger)
                chargerCombo();
            cmbNomV.Enabled = true;
        }

        void supprimerVoiture()
        {
            DialogResult dg =  MessageBox.Show("cette voiture va etre supprimer definitevement etes vois sure  ???", "Supprimer voiture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                if (cn.State == ConnectionState.Closed)
                cn.Open();
                cmd = new SqlCommand("delete from voiture where numV = @numV", cn);
                cmd.Parameters.AddWithValue("@numV", cmbNomV.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show(cmbNomV.SelectedItem.ToString() + " est supprimer avec succée");
                cn.Close();
            }
        }

       

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Enabled)
            { ajouterVoiture();}
            else if (btnModifier.Enabled)
            { modifierVoiture();}
            else if (btnsupprimer.Enabled)
            { supprimerVoiture(); }

            btnAnnuler.PerformClick();
        }

        void clear()
        {
            txtKM.Clear();
            txtMarque.Clear();
            txtNumerMat.Clear();
            txtRegion.Clear();
            txtSerie.Clear();
            txtType.Clear();
            txtVidange.Clear();
           
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            btnAjouter.Enabled = true;
            btnModifier.Enabled = true;
            btnsupprimer.Enabled = true;
            btnValider.Visible = false;
            btnAnnuler.Visible = false;
            cmbNomV.Enabled = false;
            clear();
           
            pbVoiture.ImageLocation = @"C:\Users\aymane\Desktop\projet\logoV.jpg";
        }

        private void txtVidange_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtVidange.Text, "[^0-9]"))
            {
                 
                txtVidange.Text = txtVidange.Text.Remove(txtVidange.Text.Length - 1);
            }
        }

        private void txtKM_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtKM.Text, "[^0-9]"))
            {
                 
                txtKM.Text = txtKM.Text.Remove(txtKM.Text.Length - 1);
            }
        }

        private void txtNumerMat_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNumerMat.Text, "[^0-9]"))
            {
                 
                txtNumerMat.Text = txtNumerMat.Text.Remove(txtNumerMat.Text.Length - 1);
            }
        }

        private void txtRegion_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtRegion.Text, "[^0-9]"))
            {
                
                txtRegion.Text = txtRegion.Text.Remove(txtRegion.Text.Length - 1);
            }
        }
    }
}


