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

namespace Pet_Shop_Management_System
{
    public partial class homes : Form
    {
        public homes()
        {
            InitializeComponent();
            countDogs();
            countBirds();
            countCats(); 
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\PetShopDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            loginfrm obj = new loginfrm();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            products obj = new products();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            employees obj = new employees();
            obj.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            customers obj = new customers();
            obj.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            billing obj = new billing();
            obj.Show();
            this.Hide();
        }

        private void CatsLbl_Click(object sender, EventArgs e)
        {

        }

        private void countDogs()
        {
            string cat="Dog";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"Select count(*) from ProductTbl Where Prcat='"+cat+"'" ,Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DogsLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void countBirds()
        {
            string cat = "Bird";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from ProductTbl Where Prcat='" + cat + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BirdsLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void countCats()
        {
            string cat = "Cat";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"Select count(*) from ProductTbl Where Prcat='" + cat + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CatsLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void homes_Load(object sender, EventArgs e)
        {

        }
    }
}
