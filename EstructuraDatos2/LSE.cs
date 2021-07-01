using System;
using System.Collections.Generic;
using System.Text;

namespace EstructuraDatos
{
    class LSE
    {
        private Nodo primero;

        public Nodo Primero
        {
            get { return primero; }
            set { primero = value; }
        }

        public LSE()
        {
            primero = null;
        }

        private bool Vacia()
        {
            if (primero == null)
                return true;
            return false;
        }

        public void InsertarOrdenado(int info)
        {
            Nodo p, r, q;

            if (Vacia())
                primero = new Nodo(info, null);
            else if (info < primero.Info)
            {
                p = new Nodo(info, primero);
                primero = p;
            }
            else
            {
                r = primero;
                q = primero.Enlace;
                while (q != null && info > q.Info)
                {
                    r = q;
                    q = q.Enlace;
                }
                if (q != null)
                {
                    p = new Nodo(info, q);
                    r.Enlace = p;
                }
                else
                {
                    p = new Nodo(info, null);
                    r.Enlace = p;
                }
            }
        }
    }
}