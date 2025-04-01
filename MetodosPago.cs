using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMADTerceras
{
    class MetodosPago
    {
        private int id;
        private string name;
        private decimal mont;

        public MetodosPago(int ID, string nombre, decimal montos)
        {
            id = ID;
            name = nombre;
            mont = montos;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Metodo
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Monto
        {
            get { return mont; }
            set { mont = value; }
        }
    }
}
