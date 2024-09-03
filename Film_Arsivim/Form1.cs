using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Arsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn=new SqlConnection("Data Source=FARUK\\SQLEXPRESS;Initial Catalog=FilmArsivim;Integrated Security=True;");


        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        void filmler()
        {
            SqlDataAdapter da=new SqlDataAdapter("select * from TBLFILMLER",conn );
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLFILMLER (AD,KATEGORİ,LİNK) values (@P1,@P2,@P3)", conn);
            cmd.Parameters.AddWithValue("@P1", txt_filmAdı.Text);
            cmd.Parameters.AddWithValue("@P2",txt_kategori.Text);
            cmd.Parameters.AddWithValue("@P3",txt_link.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Kayıt İşlemi Başarılı");
            filmler();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            webView21.Source=new Uri(link);
        }

        private void btn_hakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Herkes Merhaba !!! Biz SİNEMA BABASI olarak sizlere iyi seyirler dileriz.","SİNEMA BABASI",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Çıkış yapmak istediğinize emin misiniz ?","Çıkış",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (result == DialogResult.Yes) 
            {
                Application.Exit();
            }
            
        }

        private void btn_renk_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
        }

        private void btn_TamEkran_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            Ekran fullScreenForm = new Ekran();
            fullScreenForm.PlayVideo(link); // Video linkini yeni forma gönder
            fullScreenForm.ShowDialog(); // Yeni formu tam ekran olarak göster
        }
    }
}
