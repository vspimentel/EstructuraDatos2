using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EstructuraDatos2
{
    class LDEC
    {
        private NodoDoble primero;
        private NodoDoble ultimo;

        public LDEC()
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

        public bool Vacio()
        {
            if (primero == null)
                return true;
            return false;
        }

        public void Insertar(int info)
        {
            NodoDoble p;
            if (Vacio())
            {
                primero = new NodoDoble(info, null, null);
                primero.EnlaceD = primero;
                primero.EnlaceI = primero;
                ultimo = primero;
            }
            else
            {
                p = new NodoDoble(info, ultimo, primero);
                ultimo.EnlaceD = p;
                ultimo = p;
                primero.EnlaceI = ultimo;
            }
        }

        public void Eliminar(int dato)
        {
            NodoDoble eliminar, p, q, r;
            p = primero;
            eliminar = null;
            if (Vacio())
                MessageBox.Show("Error, la lista está vacía");
            else
            {
                do
                {
                    if (p.Info == dato)
                        eliminar = p;
                    p = p.EnlaceD;
                } while (p != primero);
                if (eliminar == null)
                {
                    MessageBox.Show("Error, el elemento no está en la lista");
                }
                else if (eliminar == primero)
                {
                    if (eliminar.EnlaceD == primero)
                    {
                        primero = null;
                        ultimo = null;
                    }
                    else
                    {
                        primero = primero.EnlaceD;
                        primero.EnlaceI = ultimo;
                        ultimo.EnlaceD = primero;
                    }
                    eliminar.EnlaceD = null;
                    eliminar.EnlaceI = null;
                    eliminar = null;
                }
                else
                {
                    q = eliminar.EnlaceD;
                    r = eliminar.EnlaceI;
                    r.EnlaceD = q;
                    q.EnlaceI = r;
                    if (q == primero)
                        ultimo = r;
                    eliminar.EnlaceD = null;
                    eliminar.EnlaceI = null;
                    eliminar = null;
                }
            }
        }
    }
}
