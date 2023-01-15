using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clientes;
using actualizarclientess;
using AMBULANCIA;
using PARAMEDICO;
using actualizarconductor;
using actualizarparamedico;
using CONDUCTOR;
namespace LOGIN
{
    public partial class PRINCIPAL : Form
    {
        public PRINCIPAL()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCL formulario = new RegistroCL();
            formulario.ShowDialog();
            
        }

        private void PRINCIPAL_Load(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            registroAM formulario = new registroAM();
            
            formulario.ShowDialog();
            
        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RegistroCO formulario = new RegistroCO();
            
            formulario.ShowDialog();
        }

        private void modificarEliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            actCond formulario = new actCond();
            
            formulario.ShowDialog();
        }

        private void registrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            registroPA formulario = new registroPA();
            
            formulario.ShowDialog();
        }

        private void modificarEliminarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            actParamedico formulario = new actParamedico();
            
            formulario.ShowDialog();
        }

        private void modificarEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizacion formulario = new actualizacion();
            
            formulario.ShowDialog();
        }
    }
}
