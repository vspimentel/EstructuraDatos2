using System;
using System.Collections.Generic;
using System.Text;

namespace EstructuraDatos2
{
    class LDE
    {
        private NodoDoble primero;
        private NodoDoble ultimo;
        private int mult7;

        public LDE()
        {
            primero = null;
            ultimo = null;
        }

        public NodoDoble Primero
        {
            get { return primero; }
            set { primero = value; }
        }

        public NodoDoble Ultimo
        {
            get { return ultimo; }
            set { ultimo = value; }
        }

        public int Mult7
        {
            get { return mult7; }
            set { mult7 = value; }
        }

        public bool Vacio()
        {
            if(primero == null)
                return true;
            return false;
        }

        public void Insertar(int info)
        {
            NodoDoble p;

            if(info % 7 == 0)
                mult7++;

            if (Vacio())
            {
                primero = new NodoDoble(info, null, null);
                ultimo = primero;
            }
            else
            {
                p = new NodoDoble(info, ultimo, null);
                ultimo.EnlaceD = p;
                ultimo = p;
            }
        }
    }
}
