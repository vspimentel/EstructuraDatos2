using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EstructuraDatos2
{
    class LDECabeza
    {
        NodoCabeza cabeza;
        NodoDoble primero;
        NodoDoble ultimo;

        public LDECabeza()
        {
            cabeza = null;
            primero = null;
            ultimo = null;
        }

        public NodoCabeza Cabeza
        {
            get { return cabeza; }
            set { cabeza = value; }
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
            if (cabeza == null)
                return true;
            return false;
        }


        public void Insertar(int info)
        {
            NodoDoble p;
            if (Vacio())
            {
                cabeza = new NodoCabeza();
                primero = new NodoDoble(info, null, null);
                cabeza.Lista = primero;
                ultimo = primero;
            }
            else
            {
                p = new NodoDoble(info, ultimo, null);
                ultimo.EnlaceD = p;
                ultimo = p;
            }
            cabeza.Elementos++;
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
                while (p != null)
                {
                    if (p.Info == dato)
                        eliminar = p;
                    p = p.EnlaceD;

                }
                if (eliminar == null)
                {
                    MessageBox.Show("Error, el elemento no está en la lista");
                }
                else if (eliminar == primero)
                {
                    if (eliminar.EnlaceD == null)
                    {
                        primero = null;
                        ultimo = null;
                        cabeza = null;
                    }
                    else
                    {
                        primero = primero.EnlaceD;
                        primero.EnlaceI = null;
                        cabeza.Elementos--;
                    }
                    eliminar.EnlaceD = null;
                    eliminar.EnlaceI = null;
                    eliminar = null;
                }
                else
                {
                    q = eliminar.EnlaceD;
                    r = eliminar.EnlaceI;
                    if (q == null)
                    {
                        r.EnlaceD = null;
                    }
                    else
                    {
                        r.EnlaceD = q;
                        q.EnlaceI = r;
                    }
                    eliminar.EnlaceD = null;
                    eliminar.EnlaceI = null;
                    eliminar = null;
                    cabeza.Elementos--;
                }
            }
        }
    }
}
