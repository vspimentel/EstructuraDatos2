using System;
using System.Collections.Generic;
using System.Text;

namespace EstructuraDatos2
{
    class NodoDoble
    {
        private int info;
        private NodoDoble enlaceI;
        private NodoDoble enlaceD;


        public NodoDoble(int _info, NodoDoble _enlaceI, NodoDoble _enlaceD)
        {
            info = _info;
            enlaceD = _enlaceD;
            enlaceI = _enlaceI;
        }
        public int Info
        {
            get { return info; }
            set { info = value; }
        }

        public NodoDoble EnlaceI
        {
            get { return enlaceI; }
            set { enlaceI = value; }
        }

        public NodoDoble EnlaceD
        {
            get { return enlaceD ; }
            set { enlaceD = value; }
        }
    }
}
