using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_de_Gestión_de_GQP
{
    public sealed class Conexion
    {

        private static Conexion instancia = null;
        private static readonly object lockObj = new object();
        private string cadenaConexion;

        private Conexion()
        {
            cadenaConexion = "server=localhost;database=gorros_con_amor;uid=root;pwd=enzomilu;";
        }

        // Patrón Singleton con bloqueo seguro para hilos múltiples
        public static Conexion ObtenerInstancia()
        {
            if (instancia == null)
            {
                lock (lockObj)
                {
                    if (instancia == null)
                    {
                        instancia = new Conexion();
                    }
                }
            }
            return instancia;
        }

        // Método para abrir una nueva conexión cada vez
        public MySqlConnection AbrirConexion()
        {
            MySqlConnection nuevaConexion = new MySqlConnection(cadenaConexion);
            try
            {
                nuevaConexion.Open();
                return nuevaConexion;
            }
            catch (MySqlException e)
            {
                // Manejo de excepciones mejorado
                throw new Exception("Error al abrir la conexión: " + e.Message, e);
            }
        }

        // Método para cerrar la conexión específica
        public void CerrarConexion(MySqlConnection conexion)
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
                conexion.Dispose();
            }
        }
    }

}
