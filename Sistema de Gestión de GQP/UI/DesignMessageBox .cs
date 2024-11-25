using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Sistema_de_Gestión_de_GQP
{
    public partial class DesignMessageBox : Form
    {
        private Label lblMensaje;
        private Label lblTitulo;
        private PictureBox pictureBox1;
        private Button btn;

        public DesignMessageBox(string mensaje, string titulo, Image imagen = null)
        {

            InitializeComponent();


            lblMensaje.Text = mensaje;
            lblTitulo.Text = titulo;

            if (imagen != null)
            {
                pictureBox1.Image = imagen;
            }
            else
            {
                pictureBox1.Visible = false; // Ocultar si no hay imagen
            }
        }

        public void InitializeComponent()
        {
            lblMensaje = new Label();
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            btn = new Button();

        }
    }
}
