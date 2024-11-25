using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión_de_GQP
{
    public class Vendedor : Personal
    {

        public Vendedor(int idRol, string nombre, string cedula, string usuario, string contrasena, string direccion, string celular)
            : base(idRol, nombre, cedula, usuario, contrasena, direccion, celular) // Llama al constructor base
        {



        }

        public void AgregarPedido(int idVendedor, string nombreCliente, int cantidadProducto, decimal precioUnidad, string detallesProducto, byte[] imagenProducto = null)
        {
            
            Conexion conexion = Conexion.ObtenerInstancia();

            try
            {
                using (var conexionDB = conexion.AbrirConexion())
                {


                    decimal precioTotal = cantidadProducto * precioUnidad;


                    string query = @"INSERT INTO pedidos 
                                 (id_vendedor, nombre_cliente, cant_producto, precio_unidad, precio_total, fecha_pedido, detalles_producto, imagen_producto, estado) 
                                 VALUES 
                                 (@idVendedor, @nombreCliente, @cantidadProducto, @precioUnidad, @precioTotal, @fechaPedido, @detallesProducto, @imagenProducto, @estado)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexionDB))
                    {

                        cmd.Parameters.AddWithValue("@idVendedor", idVendedor);
                        cmd.Parameters.AddWithValue("@nombreCliente", nombreCliente);
                        cmd.Parameters.AddWithValue("@cantidadProducto", cantidadProducto);
                        cmd.Parameters.AddWithValue("@precioUnidad", precioUnidad);
                        cmd.Parameters.AddWithValue("@precioTotal", precioTotal);
                        cmd.Parameters.AddWithValue("@fechaPedido", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@detallesProducto", detallesProducto);
                        cmd.Parameters.AddWithValue("@imagenProducto", imagenProducto ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@estado", "Pendiente"); // Estado inicial por defecto


                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("¡Pedido agregado exitosamente!");
                        }
                        else
                        {
                            Console.WriteLine("No se pudo agregar el pedido.");
                        }
                        conexion.CerrarConexion(conexionDB);
                    }
                }
               

            }

            catch (MySqlException ex)
            {

                Console.WriteLine("Ocurrió un error al agregar el pedido: " + ex.Message);
            }
            
        }
    }

}