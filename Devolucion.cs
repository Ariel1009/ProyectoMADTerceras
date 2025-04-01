using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMADTerceras
{
    class Devolucion
    {
        private int ID_VENTA;
        private bool stock;
        private float cantTotal;

        public Devolucion (int ID, float cant, bool val)
        {
            ID_VENTA = ID;
            cantTotal = cant;
            stock = val;
        }

        public int Venta_Id
        {
            get { return ID_VENTA; }
            set { ID_VENTA = value; }
        }

        public float Cantidad
        {
            get { return cantTotal; }
            set { cantTotal = value; }
        }

        public bool Stock
        {
            get { return stock; }
            set { stock = value; }
        }

    }
}
