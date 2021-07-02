using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EstructuraDatos2
{
    class LSEC
    {
        private Nodo primero;
        private Nodo ultimo;

        public LSEC()
        {
            primero = null;
            ultimo = null;
        }
        public Nodo Primero
        {
            get { return primero; }
            set { primero = value; }
        }

        public Nodo Ultimo
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
            Nodo p;
            if (Vacio())
            {
                primero = new Nodo(info, null);
                primero.Enlace = primero;
                ultimo = primero;
            }
            else
            {
                p = new Nodo(info, primero);
                ultimo.Enlace = p;
                ultimo = p; 
            }
        }

        public void Eliminar(int info)
        {
            Nodo eliminar, p, q, r;
            p = primero;
            eliminar = null;
            if (Vacio())
                MessageBox.Show("Error, la lista está vacía");
            else
            {
                do
                {
                    if (p.Info == info)
                        eliminar = p;
                    p = p.Enlace;
                } while (p != primero);
                if (eliminar == null)
                {
                    MessageBox.Show("Error, el elemento no está en la lista");
                }
                else if(eliminar == primero)
                {
                    if (eliminar.Enlace == primero)
                    {
                        primero = null;
                        ultimo = null;
                    }
                    else
                    {
                        primero = primero.Enlace;
                        ultimo.Enlace = primero;
                    }
                    eliminar.Enlace = null;
                    eliminar = null;
                }
                else if(eliminar != primero)
                {
                    p = primero;
                    r = null;
                    do
                    {
                        if (p.Enlace == eliminar)
                            r = p;
                        p = p.Enlace;
                    } while (p != primero);

                    if(eliminar.Enlace == primero)
                    {
                        r.Enlace = eliminar.Enlace;
                        ultimo = r;
                    }
                    else
                    {
                        r.Enlace = eliminar.Enlace;
                    }
                    eliminar.Enlace = null;
                    eliminar = null;
                }
            }
        }
    }
}
