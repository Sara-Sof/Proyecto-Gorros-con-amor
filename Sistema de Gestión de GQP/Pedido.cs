using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_GQP
{
    internal class Pedido
    {
        internal class pedido
        {
            public int Id { get; set; }
            public int IdVendedor { get; set; }
            public string NombreCliente { get; set; }
            public int CantProducto { get; set; }
            public decimal PrecioUnidad { get; set; }
            public decimal PrecioTotal { get; set; }
            public DateTime FechaPedido { get; set; }
            public string DetallesProducto { get; set; }
            public byte[] ImagenProducto { get; set; }
            public string Estado { get; set; }


            public pedido() { }


            public pedido(int id, int idVendedor, string nombreCliente, int cantProducto, decimal precioUnidad,
                          decimal precioTotal, DateTime fechaPedido, string detallesProducto, byte[] imagenProducto, string estado)
            {
                Id = id;
                IdVendedor = idVendedor;
                NombreCliente = nombreCliente;
                CantProducto = cantProducto;
                PrecioUnidad = precioUnidad;
                PrecioTotal = precioTotal;
                FechaPedido = fechaPedido;
                DetallesProducto = detallesProducto;
                ImagenProducto = imagenProducto;
                Estado = estado;
            }
        }
    }
}

