using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDatos2
{
    public partial class Form1 : Form
    {
        LSE listaSE = new LSE();
        LDE listaDE = new LDE();
        LSEC listaSEC = new LSEC();
        void MostarListaSE()
        {
            Nodo p;
            lview.Clear();
            p = listaSE.Primero;
            while (p != null)
            {
                if (!listaSE.Vacia())
                {
                    lview.Items.Add(p.Info.ToString());
                    p = p.Enlace;
                }
            }
        }

        void MostarListaDE()
        {
            NodoDoble p;
            lview.Clear();
            p = listaDE.Primero;
            while (p != null)
            {
                if (!listaDE.Vacio())
                {
                    lview.Items.Add(p.Info.ToString());
                    p = p.EnlaceD;
                }
            }
        }

        void MostrarListaSEC()
        {
            Nodo p;
            lview.Clear();
            p = listaSEC.Primero;
            do
            {
                if (!listaSEC.Vacio())
                {
                    lview.Items.Add(p.Info.ToString());
                    p = p.Enlace;
                }
            } while (p != listaSEC.Primero);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void LSEIntOrd_Click(object sender, EventArgs e)
        {
            listaSE.InsertarOrdenado(Int32.Parse(txtInLSE.Text));
            MostarListaSE();
            txtInLSE.Clear();
        }

        private void txtIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                listaSE.InsertarOrdenado(Int32.Parse(txtInLSE.Text));
                MostarListaSE();
                txtInLSE.Clear();
            }

        }

        private void LDEInt_Click(object sender, EventArgs e)
        {
            listaDE.Insertar(Int32.Parse(txtInLDE.Text));
            MostarListaDE();
            BoxMul7.Clear();
            if(listaDE.Mult7 > 0)
                BoxMul7.Items.Add(listaDE.Mult7.ToString());
            txtInLDE.Clear();
        }

        private void txtInLDE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                listaDE.Insertar(Int32.Parse(txtInLDE.Text));
                MostarListaDE();
                BoxMul7.Clear();
                if (listaDE.Mult7 > 0)
                    BoxMul7.Items.Add(listaDE.Mult7.ToString());
                txtInLDE.Clear();
            }
        }

        private void LSECInt_Click(object sender, EventArgs e)
        {
            listaSEC.Insertar(Int32.Parse(txtInLSEC.Text));
            MostrarListaSEC();
            txtInLSEC.Clear();
        }

        private void txtInLSEC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                listaSEC.Insertar(Int32.Parse(txtInLSEC.Text));
                MostrarListaSEC();
                txtInLSEC.Clear();
            }
        }

        private void LSECEli_Click(object sender, EventArgs e)
        {
            listaSEC.Eliminar(Int32.Parse(txtInLSEC.Text));
            MostrarListaSEC();
            txtInLSEC.Clear();
        }
    }
}
