using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaForms.Entidades
{
    internal class Ventas
    {
        // Atributos
        private int idVenta;
        private int idCliente;
        private string nombreProducto;
        private double precio;
        private int cantidad;

        // Constructor por defecto
        public Ventas()
        {
            idVenta = 0;
            idCliente = 0;
            nombreProducto = "Sin nombre";
            precio = 0.0;
            cantidad = 0;
        }

        // Constructor con parámetros
        public Ventas(int idVenta, int idCliente, string nombreProducto, double precio, int cantidad)
        {
            this.idVenta = idVenta;
            this.idCliente = idCliente;
            this.nombreProducto = nombreProducto;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        // Getters y Setters
        public int IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
    }
}
