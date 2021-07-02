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
        LDEC listaDEC = new LDEC();
        LDECabeza listaDECabeza = new LDECabeza();
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

        void MostrarListaDEC()
        {
            NodoDoble p;
            lview.Clear();
            p = listaDEC.Primero;
            do
            {
                if (!listaDEC.Vacio())
                {
                    lview.Items.Add(p.Info.ToString());
                    p = p.EnlaceD;
                }
            } while (p != listaDEC.Primero);
        }

        void MostrarListaDECabeza()
        {
            NodoDoble p;
            lview.Clear();
            p = listaDECabeza.Primero;
            while (p != null)
            {
                if (!listaDECabeza.Vacio())
                {
                    lview.Items.Add(p.Info.ToString());
                    p = p.EnlaceD;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void LSEIntOrd_Click(object sender, EventArgs e)
        {
            if (txtInLSE.Text != "")
            {
                listaSE.InsertarOrdenado(Int32.Parse(txtInLSE.Text));
                MostarListaSE();
                txtInLSE.Clear();
            }
            else
            {
                MessageBox.Show("Error, introduza un valor");
            }
        }

        private void txtIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtInLSE.Text != "")
                {

                    listaSE.InsertarOrdenado(Int32.Parse(txtInLSE.Text));
                    MostarListaSE();
                    txtInLSE.Clear();
                }
                else
                {
                    MessageBox.Show("Error, introduza un valor");
                }
            }

        }

        private void LDEInt_Click(object sender, EventArgs e)
        {
            if (txtInLDE.Text != "")
            {
                listaDE.Insertar(Int32.Parse(txtInLDE.Text));
                MostarListaDE();
                BoxMul7.Clear();
                if (listaDE.Mult7 > 0)
                    BoxMul7.Items.Add(listaDE.Mult7.ToString());
                txtInLDE.Clear();
            }
            else
            {
                MessageBox.Show("Error, introduza un valor");
            }
        }

        private void txtInLDE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtInLDE.Text != "")
                {
                    listaDE.Insertar(Int32.Parse(txtInLDE.Text));
                    MostarListaDE();
                    BoxMul7.Clear();
                    if (listaDE.Mult7 > 0)
                        BoxMul7.Items.Add(listaDE.Mult7.ToString());
                    txtInLDE.Clear();
                }
                else
                {
                    MessageBox.Show("Error, introduza un valor");
                }
            }
        }

        private void LSECInt_Click(object sender, EventArgs e)
        {
            if (txtInLSEC.Text != "")
            {
                listaSEC.Insertar(Int32.Parse(txtInLSEC.Text));
                MostrarListaSEC();
                txtInLSEC.Clear();
            }
            else
            {
                MessageBox.Show("Error, introduza un valor");
            }
        }

        private void txtInLSEC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtInLSEC.Text != "")
                {
                    listaSEC.Insertar(Int32.Parse(txtInLSEC.Text));
                    MostrarListaSEC();
                    txtInLSEC.Clear();
                }
                else
                {
                    MessageBox.Show("Error, introduza un valor");
                }
            }
        }

        private void LSECEli_Click(object sender, EventArgs e)
        {
            if (txtInLSEC.Text != "")
            {
                listaSEC.Eliminar(Int32.Parse(txtInLSEC.Text));
                MostrarListaSEC();
                txtInLSEC.Clear();
            }
            else
            {
                MessageBox.Show("Error, introduza un valor");
            }
        }

        private void LDECInt_Click(object sender, EventArgs e)
        {
            if (txtInLDEC.Text != "")
            {
                listaDEC.Insertar(Int32.Parse(txtInLDEC.Text));
                MostrarListaDEC();
                txtInLDEC.Clear();
            }
            else
            {
                MessageBox.Show("Error, introduza un valor");
            }
        }

        private void txtInLDEC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtInLDEC.Text != "")
                {
                    listaDEC.Insertar(Int32.Parse(txtInLDEC.Text));
                    MostrarListaDEC();
                    txtInLDEC.Clear();
                }
                else
                {
                    MessageBox.Show("Error, introduza un valor");
                }
            }
        }

        private void LDECEli_Click(object sender, EventArgs e)
        {
            if (txtInLDEC.Text != "")
            {
                listaDEC.Eliminar(Int32.Parse(txtInLDEC.Text));
                MostrarListaDEC();
                txtInLDEC.Clear();
            }
            else
            {
                MessageBox.Show("Error, introduza un valor");
            }
        }

        private void LDECCInt_Click(object sender, EventArgs e)
        {
            if (txtInLDECabeza.Text != "")
            {
                listaDECabeza.Insertar(Int32.Parse(txtInLDECabeza.Text));
                MostrarListaDECabeza();
                BoxCabeza.Clear();
                if (listaDECabeza.Cabeza.Elementos > 0)
                    BoxCabeza.Items.Add(listaDECabeza.Cabeza.Elementos.ToString());
                else
                    BoxCabeza.Items.Add(0.ToString());
                txtInLDECabeza.Clear();
            }
            else
            {
                MessageBox.Show("Error, introduza un valor");
            }
        }

        private void txtInLDECC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtInLDECabeza.Text != "")
                {
                    listaDECabeza.Insertar(Int32.Parse(txtInLDECabeza.Text));
                    MostrarListaDECabeza();
                    BoxCabeza.Clear();
                    if (listaDECabeza.Cabeza.Elementos > 0)
                        BoxCabeza.Items.Add(listaDECabeza.Cabeza.Elementos.ToString());
                    else
                        BoxCabeza.Items.Add(0.ToString());
                    txtInLDECabeza.Clear();
                }
                else
                {
                    MessageBox.Show("Error, introduza un valor");
                }
            }
        }

        private void LDECCEli_Click(object sender, EventArgs e)
        {
            if (txtInLDECabeza.Text != "")
            {
                listaDECabeza.Eliminar(Int32.Parse(txtInLDECabeza.Text));
                MostrarListaDECabeza();
                BoxCabeza.Clear();
                if (listaDECabeza.Cabeza != null)
                    BoxCabeza.Items.Add(listaDECabeza.Cabeza.Elementos.ToString());
                else
                    BoxCabeza.Items.Add(0.ToString());
                txtInLDECabeza.Clear();
            }
            else
            {
                MessageBox.Show("Error, introduza un valor");
            }
        }
    }
}
