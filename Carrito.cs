using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMADTerceras
{
    class Carrito
    {
        private int ID_PRODUCTO;
        private string nombre;
        private decimal precioUnitario;
        private float descuento;
        private float cantidad;
       

        public Carrito(int id, string name, decimal prec, float cant, float desc)
        {
            ID_PRODUCTO = id;
            nombre = name;
            precioUnitario = prec;
            descuento = desc;
            cantidad = cant;
        }

        public int Id_PRODUCTO
        {
            get { return ID_PRODUCTO; }
            set { ID_PRODUCTO = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public decimal Precio
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }

        public float Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        public float Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
    }
}
