using EstructuraDatos;
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
        void MostarListaSE()
        {
            Nodo p;
            lviewLSE.Clear();
            p = listaSE.Primero;
            while (p != null)
            {
                lviewLSE.Items.Add(p.Info.ToString());
                p = p.Enlace;
            }
        }

        void MostarListaDE()
        {
            NodoDoble p;
            lviewLSE.Clear();
            p = listaDE.Primero;
            while (p != null)
            {
                lviewLSE.Items.Add(p.Info.ToString());
                p = p.EnlaceD;
            }
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

    }
}
