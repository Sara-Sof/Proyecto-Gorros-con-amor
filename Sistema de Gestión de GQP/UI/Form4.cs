using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión_de_GQP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_imagen.Image = Image.FromFile(openFileDialog.FileName);

                pictureBox_imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Registrar_pedido_Click(object sender, EventArgs e)
        {
            try
            {
                
                string nombreCliente = textBox_cliente.Text;
                int cantidadProducto = int.Parse(textBox_cantidad.Text);
                decimal precioUnidad = decimal.Parse(textBox_unidad.Text);
                decimal total = cantidadProducto * precioUnidad;
                string detallesProducto = richTextBox_detalles.Text;

              
                int dia = int.Parse(textBox_dia.Text);
                int mes = int.Parse(textBox_mes.Text);
                int año = int.Parse(textBox_año.Text);
                DateTime fechaPedido;
                byte[] imagenProducto = null;


                if (!DateTime.TryParse($"{año}-{mes}-{dia}", out fechaPedido))
                {
                    MessageBox.Show("Por favor, ingrese una fecha válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrWhiteSpace(nombreCliente) || cantidadProducto <= 0 || precioUnidad <= 0)
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (pictureBox_imagen.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox_imagen.Image.Save(ms, pictureBox_imagen.Image.RawFormat);
                        imagenProducto = ms.ToArray();
                    }
                }

                
                

                int idRol = 1;
                string nombre = "";
                string cedula = "";
                string usuario = "";
                string contrasena = "";
                string direccion = "";
                string celular = "";

                Vendedor vendedor = new Vendedor(idRol, nombre, cedula, usuario, contrasena, direccion, celular);

                vendedor.AgregarPedido(
                    idVendedor: 2, 
                    nombreCliente: nombreCliente,
                    cantidadProducto: cantidadProducto,
                    precioUnidad: precioUnidad,
                    detallesProducto: detallesProducto,
                    imagenProducto: imagenProducto

                );

                // Mostrar un mensaje de éxito
                MessageBox.Show("¡Pedido registrado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos después del registro
                textBox_cliente.Clear();
                textBox_cantidad.Clear();
                textBox_unidad.Clear();
                textBox_total.Clear();
                textBox_dia.Clear();
                textBox_mes.Clear();
                textBox_año.Clear();
                richTextBox_detalles.Clear();
                pictureBox_imagen.Image = null;
            }
            catch (Exception ex)
            {
                // Manejar cualquier error
                MessageBox.Show("Ocurrió un error al registrar el pedido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }

