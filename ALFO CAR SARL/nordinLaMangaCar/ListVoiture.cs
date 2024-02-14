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
using System.IO;
using System.Drawing.Imaging;
namespace nordinLaMangaCar
{
    public partial class ListVoiture : UserControl
    {
        public ListVoiture()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=LaMangaCar;Integrated Security=True");
        SqlCommand cmd;
        DataTable dtImg = new DataTable();
      

        private void btn1_Click(object sender, EventArgs e)
        {
            selectedImage(11);
            setImage(11);
         
        }
        void selectedImage(int nb)
        {
            if (nb == 11)
            {
                btn1.BorderThickness = 1;
                btn2.BorderThickness = 0; btn3.BorderThickness = 0; btn4.BorderThickness = 0; btn5.BorderThickness = 0; btn6.BorderThickness = 0;
            }
            else if (nb == 13)
            {
                btn2.BorderThickness = 1;
                btn1.BorderThickness = 0; btn3.BorderThickness = 0; btn4.BorderThickness = 0; btn5.BorderThickness = 0; btn6.BorderThickness = 0;
            }
            else if (nb == 14)
            {
                btn3.BorderThickness = 1;
                btn2.BorderThickness = 0; btn1.BorderThickness = 0; btn4.BorderThickness = 0; btn5.BorderThickness = 0; btn6.BorderThickness = 0;
            }
            else if (nb == 15)
            {
                btn4.BorderThickness = 1;
                btn2.BorderThickness = 0; btn3.BorderThickness = 0; btn1.BorderThickness = 0; btn5.BorderThickness = 0; btn6.BorderThickness = 0;
            }
            else if (nb == 12)
            {
                btn5.BorderThickness = 1;
                btn2.BorderThickness = 0; btn4.BorderThickness = 0; btn3.BorderThickness = 0; btn6.BorderThickness = 0; btn1.BorderThickness = 0;
            }
            else if (nb == 16)
            {
                btn6.BorderThickness = 1;
                btn2.BorderThickness = 0; btn4.BorderThickness = 0; btn3.BorderThickness = 0; btn1.BorderThickness = 0; btn5.BorderThickness = 0;
            }
            
        }

        void details(int nb)
        {
            DataRow dr = dtImg.Rows[0];
            string marque = dr["marque"].ToString();
            string type = dr["TypeV"].ToString();
            DateTime vt = DateTime.Parse( dr["visiteTechnique"].ToString());
            lblVT.Text = vt.ToShortDateString();
            lblKilometrage.Text = dr["kilometrage"].ToString();
            lblVidanfe.Text = dr["vidange"].ToString();
            lblDesignation.Text = marque + " " + type;
            lblRegion.Text = dr["region"].ToString();
            lblLaitre.Text = dr["lettre"].ToString();
            lblNumMatr.Text = dr["numMatricule"].ToString();
            lblNumero.Text = nb.ToString();
            dtImg.Rows.Clear();
        }

        void setImage(int nb)
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select * from voiture where numV ="+nb, cn);
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
            fillDT(nb);
           
        }

        void NVMatricul(int nb)
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select region , lettre from voiture where numV =" + nb, cn);
            SqlDataReader drMat = cmd.ExecuteReader();
            drMat.Read();
            DataTable dt = new DataTable();
            dt.Load(drMat);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("code is working !");
                //GRPMat.Visible = true;
            }
             
            
            cn.Close();
        }

        void fillDT(int nb)
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select * from voiture where numV =" + nb, cn);
            SqlDataReader dr2 = cmd.ExecuteReader();
            dtImg.Load(dr2);
            if (dtImg.Rows.Count > 0)
            {
                details(nb);
               
            }
            else
                MessageBox.Show("un erreur c'est produit veuiller contacter le developpeur pour le resoudre !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            cn.Close();
            checkVD();
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            selectedImage(13);
            setImage(13);
          
            //pbVoiture.ImageLocation = @"C:\Users\aymane\Documents\Visual Studio 2013\Projects\nordinLaMangaCar\nordinLaMangaCar\Resources\Voitures\DaciaL.png";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            selectedImage(14);
            setImage(14);
           
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            selectedImage(15);
            setImage(15);
        }

        void chargerCombo()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select numV , nomV from voiture",cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbNomV.DataSource = dt;
            cmbNomV.DisplayMember = "nomV";
            cmbNomV.ValueMember = "numV";
            cn.Close();
        }

        private void ListVoiture_Load(object sender, EventArgs e)
        {
            chargerCombo();
            selectedImage(11);
            setImage(11);
        }
        string imgLoc;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.ShowDialog();
            imgLoc = opf.FileName.ToString();
            pbVoiture.ImageLocation = imgLoc;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] img = null;
            FileStream fs = new FileStream(imgLoc,FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            string req = "insert into voiture values('Citroen',GETDATE(),0,'SX9HJC/AOW',0,@photo,7,N'ب',20587)";
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            SqlCommand cmd2 = new SqlCommand(req, cn);
            cmd2.Parameters.AddWithValue("@photo", img);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("6  saved");
            cn.Close();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            selectedImage(12);
            setImage(12);
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtNVKM.Visible = true;
            lblKilometrage.Visible = false;
            btnOK.Visible = true;
            btnUpdate.Visible = false;
            lblk.Visible = false;
        }

        void vidange()
        {
            int Kilometrage = int.Parse(lblKilometrage.Text);
            int NvKiloM = int.Parse(txtNVKM.Text);
            int vidange = int.Parse(lblVidanfe.Text);
            int kilometrageConsommer = NvKiloM - Kilometrage;
            int NvVidange = 0;
            bool vid = false;
            if (kilometrageConsommer > 0 && kilometrageConsommer < 20000)
            {
                if (kilometrageConsommer >= 9500)
                {
                    vid = true;
                    NvVidange = kilometrageConsommer + vidange;

                }
                else if (kilometrageConsommer < 9500)
                {
                    lblVidanfe.ForeColor = Color.FromArgb(41, 39, 40);
                    pbWarning.Visible = false;

                    NvVidange = kilometrageConsommer + vidange;
                    if (NvVidange < 9500)
                    {
                        // NouveauKM(NvVidange);

                    }
                    else if (NvVidange >= 9500)
                    {
                        vid = true;
                    }


                }

                if (vid)
                {
                    lblVidanfe.ForeColor = Color.Red;
                    pbWarning.Visible = true;
                    btnVidange.Visible = true;
                }
                lblVidanfe.Text = NvVidange.ToString();
                lblKilometrage.Text = txtNVKM.Text;
                NouveauKM(NvVidange);
            }
            else
                MessageBox.Show("veuiller se verifier de kilometrage saisie !","Saisie erroné",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        void checkVD()
        {
            if (int.Parse(lblVidanfe.Text) < 9500)
            {
                lblVidanfe.ForeColor = Color.FromArgb(41, 39, 40);
                pbWarning.Visible = false;
                btnVidange.Visible = false;
            }
            else if (int.Parse(lblVidanfe.Text) >= 9500)
            {
                lblVidanfe.ForeColor = Color.Red;
                pbWarning.Visible = true;
                btnVidange.Visible = true;
            }
        }

        void NouveauKM(int NvVidange)
        {
            if (string.IsNullOrEmpty(txtNVKM.Text))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                cmd = new SqlCommand("update Voiture set kilometrage =" + lblKilometrage.Text + " , vidange = " + NvVidange + " where numV = " + lblNumero.Text, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                fillDT(int.Parse(lblNumero.Text));
            }
            else {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                cmd = new SqlCommand("update Voiture set kilometrage =" + txtNVKM.Text + " , vidange = "+NvVidange+" where numV = " + lblNumero.Text, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                fillDT(int.Parse(lblNumero.Text));
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNVKM.Text != "")
            {
                if (int.Parse(txtNVKM.Text) > 2000 && lblKilometrage.Text == "0")
                    NouveauKM(int.Parse(txtNVKM.Text) % 10000);
                else
                    vidange();
                txtNVKM.Visible = false;
                lblKilometrage.Visible = true;
                btnOK.Visible = false;
                btnUpdate.Visible = true;
                lblk.Visible = true;
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
         //   GRPMat.Visible = false;
        }

        private void cmbNomV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index =cmbNomV.SelectedValue.ToString();
         
            try
            {
                setImage(int.Parse(index));
                selectedImage(int.Parse(index));
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            selectedImage(16);
            setImage(16);
        }

        private void lblVidanfe_Click(object sender, EventArgs e)
        {

        }

        private void txtNVKM_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNVKM.Text, "[^0-9]"))
            {

                txtNVKM.Text = txtNVKM.Text.Remove(txtNVKM.Text.Length - 1);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chargerCombo();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            lblVidanfe.ForeColor = Color.FromArgb(41, 39, 40);
            lblVidanfe.Text = "O";
            btnVidange.Visible=false;
            pbWarning.Visible = false;
            NouveauKM(0);
        }

        private void lblKilometrage_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pbWarning_Click(object sender, EventArgs e)
        {

        }

        private void pbVoiture_Click(object sender, EventArgs e)
        {

        }
    }
}
