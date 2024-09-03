using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Arsivim
{
    public partial class Ekran : Form
    {
        public Ekran()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Ekran_Load(object sender, EventArgs e)
        {
            
           
        }
        public void PlayVideo(string link)
        {
            webView21.Source = new Uri(link);
        }
    }
}
