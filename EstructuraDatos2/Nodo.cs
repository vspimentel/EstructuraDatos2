using System;
using System.Collections.Generic;
using System.Text;

namespace EstructuraDatos2
{
    class Nodo
    {
        private int info;
        private Nodo enlace;

        public Nodo(int _info, Nodo _enlace)
        {
            info = _info;
            enlace = _enlace;
        }

        public int Info {
            get { return info; }
            set { info = value; }
        }

        public Nodo Enlace
        {
            get { return enlace; }
            set { enlace = value; }
        }
    }
}
