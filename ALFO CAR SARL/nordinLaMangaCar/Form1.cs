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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=LaMangaCar;Integrated Security=True");
        SqlCommand cmd;
          void Current(string cntrl)
        {
            switch (cntrl)
            {
                case "LC": pnlLC.Visible = true; pnlAcc.Visible = false; pnlContrat.Visible = false; pnlLV.Visible = false; pnlNV.Visible = false; pnlNVCTR.Visible = false;  break;
                case "Acc": pnlLC.Visible = false; pnlAcc.Visible = true; pnlContrat.Visible = false; pnlLV.Visible = false; pnlNV.Visible = false; pnlNVCTR.Visible = false; break;
                case "LV": pnlLC.Visible = false; pnlAcc.Visible = false; pnlContrat.Visible = false; pnlLV.Visible = true; pnlNV.Visible = false; pnlNVCTR.Visible = false;  break;
                case "CTR": pnlLC.Visible = false; pnlAcc.Visible = false; pnlContrat.Visible = true; pnlLV.Visible = false; pnlNV.Visible = false; pnlNVCTR.Visible = false;  break;
                case "NV": pnlLC.Visible = false; pnlAcc.Visible = false; pnlContrat.Visible = false; pnlLV.Visible = false;  pnlNVCTR.Visible = false; pnlNV.Visible = true; break;
                case "NVCTR": pnlLC.Visible = false; pnlAcc.Visible = false; pnlContrat.Visible = false; pnlLV.Visible = false;  pnlNV.Visible = false; pnlNVCTR.Visible = true; break;
                default:
                    break;
            }
        }

        void UserCTRL(string ctrl)
        {
            switch (ctrl)
            {
                case "LC": pictureBox1.Visible = true; listVoiture1.Hide(); listContrat1.Hide(); nvVoiture1.Hide(); nvContratSigner1.Hide(); accueil1.Hide(); listClient1.Show(); break;
                case "Acc": pictureBox1.Visible = false; listClient1.Hide(); listVoiture1.Hide(); listContrat1.Hide(); nvVoiture1.Hide(); nvContratSigner1.Hide(); accueil1.Show(); break;
                case "LV": pictureBox1.Visible = true; listClient1.Hide(); listContrat1.Hide(); nvVoiture1.Hide(); nvContratSigner1.Hide(); accueil1.Hide(); listVoiture1.Show(); break;
                case "CTR": pictureBox1.Visible = true; listClient1.Hide(); listVoiture1.Hide(); nvVoiture1.Hide(); nvContratSigner1.Hide(); accueil1.Hide(); listContrat1.Show(); break;
                case "NV": pictureBox1.Visible = true; listClient1.Hide(); listVoiture1.Hide(); listContrat1.Hide(); nvContratSigner1.Hide(); accueil1.Hide(); nvVoiture1.Show(); break;
                case "NVCTR": pictureBox1.Visible = true; listClient1.Hide(); listVoiture1.Hide(); listContrat1.Hide(); nvVoiture1.Hide(); accueil1.Hide(); nvContratSigner1.Show(); break;
                default:
                    break;
            }
        }

        void fillCArs()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select TOP 4 V.nomV as 'Designation' ,LV.dateReprise as 'Fecha_recuperación'  from voiture V , louerVoiture LV where LV.voiture = V.numV order by LV.dateReprise desc ", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            //dgvVoitureL.DataSource = dt;

           

            cn.Close();
        }

        void fillCredits()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
      

            cmd = new SqlCommand("select TOP 4 banc as 'Banco' , montant as 'importe' , datePayer as 'Fecha_pago' from Dépenses order by datePayer desc", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
         //   dataGridView2.DataSource = dt;
          
           cn.Close();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {

            Current("Acc");
            UserCTRL("Acc");
           
        }

        private void btnLC_Click(object sender, EventArgs e)
        {
            Current("LC");
            UserCTRL("LC");
        }

        private void btnLD_Click(object sender, EventArgs e)
        {
            Current("LD");
            UserCTRL("LD");
        }

        private void btnLV_Click(object sender, EventArgs e)
        {
            Current("LV");
            UserCTRL("LV");
        }

        private void btnNV_Click(object sender, EventArgs e)
        {

        }

        void checkVidange()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cmd = new SqlCommand("select numV from voiture where vidange >= 9500", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
                pnlVidange.Visible = true;
            else
                pnlVidange.Visible = false;
            cn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkVidange();
           
            Current("Acc");
            UserCTRL("Acc");
        }

        private void btnCTR_Click(object sender, EventArgs e)
        {
            Current("CTR");
            UserCTRL("CTR");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Current("LV");
            UserCTRL("LV");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Current("LD");
            UserCTRL("LD");
        }

        private void btnNVoiture_Click(object sender, EventArgs e)
        {
            Current("NV");
            UserCTRL("NV");
        }

        private void btnNVCTR_Click(object sender, EventArgs e)
        {
            Current("NVCTR");
            UserCTRL("NVCTR");
        }

        private void nvVoiture1_Load(object sender, EventArgs e)
        {

        }

        private void lblVidanfe_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleProgressBar2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BTNAccAC_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnLCac_Click(object sender, EventArgs e)
        {
             
            Current("LC");
            UserCTRL("LC");
        }

        private void btnLVac_Click(object sender, EventArgs e)
        {
          
            Current("LV");
            UserCTRL("LV");
        }

        private void btnNVac_Click(object sender, EventArgs e)
        {
          
            Current("NV");
            UserCTRL("NV");
        }

        private void btnLCTRac_Click(object sender, EventArgs e)
        {
             
            Current("CTR");
            UserCTRL("CTR");
        }

        private void btnNVCTRac_Click(object sender, EventArgs e)
        {
           
            Current("NVCTR");
            UserCTRL("NVCTR");
        }

        private void btnCompte_Click(object sender, EventArgs e)
        {
            
        }

        private void PanelAcceil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlAccueil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nvVoiture1_Load_1(object sender, EventArgs e)
        {

        }
         


    }
}
