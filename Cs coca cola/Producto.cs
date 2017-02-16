using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cs_coca_cola
{
    public class Producto
    {
        private int cantidad;
        private String nombre;
        private int precio;

        public Producto()
        {
            this.cantidad = 0;
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }
    }
}