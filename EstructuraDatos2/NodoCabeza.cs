using System;
using System.Collections.Generic;
using System.Text;

namespace EstructuraDatos2
{
    class NodoCabeza
    {
        private int elementos;
        private NodoDoble lista;

        public NodoCabeza(NodoDoble _lista)
        {
            elementos = 0;
            lista = _lista;
        }

        public int Elementos
        {
            get { return elementos; }
            set { elementos = value; }
        }

        public NodoDoble Lista
        {
            get { return lista; }
            set { lista = value; }
        }
    }
}
