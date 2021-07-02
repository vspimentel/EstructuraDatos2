using System;
using System.Collections.Generic;
using System.Text;

namespace EstructuraDatos2
{
    class NodoCabeza
    {
        private int elementos;
        private NodoDoble lista;

        public NodoCabeza()
        {
            elementos = 0;
            lista = null;
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
