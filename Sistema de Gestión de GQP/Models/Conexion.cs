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
        private MySqlConnection conexion;

        private Conexion()
        {

            string cadenaConexion = "server=localhost;database=gorros_con_amor;uid=root;pwd=enzomilu;";
            conexion = new MySqlConnection(cadenaConexion);
        }

        public static Conexion ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Conexion();
            }
            return instancia;
        }

        public MySqlConnection AbrirConexion()
        {
            try{
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                    MessageBox.Show("exito ");

                }
                return conexion;
            }
            catch (MySqlException e){
            
                MessageBox.Show("Error al abrir la conexión: " + e.Message);
                throw; 
            }
        }

        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();

            }
        }
    }

}
