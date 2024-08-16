using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaForms.Entidades
{
    internal class Stock
    {
        // Atributos
        private string producto;
        private int cantidad;

        // Constructor por defecto
        public Stock()
        {
            producto = string.Empty;
            cantidad = 0;
        }

        // Constructor con parámetros
        public Stock(string producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
        }

        // Getters y Setters para 'producto'
        public string Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        // Getters y Setters para 'cantidad'
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
    }
}
