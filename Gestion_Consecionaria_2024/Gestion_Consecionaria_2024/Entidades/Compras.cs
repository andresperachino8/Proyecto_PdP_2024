using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaForms.Entidades
{
    internal class Compras
    {
        // Atributos
        private int idCompra;
        private int idProveedor;
        private string nombreProducto;
        private double precio;
        private int cantidad;

        // Constructor por defecto
        public Compras()
        {
            idCompra = 0;
            idProveedor = 0;
            nombreProducto = "Sin nombre";
            precio = 0.0;
            cantidad = 0;
        }

        // Constructor con parámetros
        public Compras(int idCompra, int idProveedor, string nombreProducto, double precio, int cantidad)
        {
            this.idCompra = idCompra;
            this.idProveedor = idProveedor;
            this.nombreProducto = nombreProducto;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        // Getters y Setters
        public int IdCompra
        {
            get { return idCompra; }
            set { idCompra = value; }
        }

        public int IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
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
