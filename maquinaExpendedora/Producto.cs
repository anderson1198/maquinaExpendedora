using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maquinaExpendedora
{
    class Producto
    {

        private string nombreProduto;
        private int precioProducto;
        private int cantidadProducto;


        public Producto (string nombre,int precio,int cantidad)
        {
            nombreProduto = nombre;
            precioProducto = precio;
            cantidadProducto = cantidad;

        }

        public Producto()
        {
        }

        public void setNombre (string nombre)
        {
            nombreProduto = nombre;
        }

        public string getNombre()
        {
            return nombreProduto;
        }

        public void setCantidad(int cantidad)
        {
            cantidadProducto = cantidad;
        }

        public int getCantidad()
        {
            return cantidadProducto;
        }

        public void setPrecio(int precio)
        {
            precioProducto = precio;
        }

        public int getPrecio()
        {
            return precioProducto;
        }




    }
}
