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

        void MostarLista()
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
        public Form1()
        {
            InitializeComponent();
        }

        private void LSEIntOrd_Click(object sender, EventArgs e)
        {
            listaSE.InsertarOrdenado(Int32.Parse(txtIn.Text));
            MostarLista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
