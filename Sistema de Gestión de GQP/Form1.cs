using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión_de_GQP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Bitmap img = new Bitmap(Application.StartupPath+@"\img\logo.png");
            this.BackgroundImage = img;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
