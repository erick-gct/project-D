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
        String user;

        public PRINCIPAL(string user)
        {
            InitializeComponent();
            this.user = user;

            label5.Text = "Bienvenido "+this.user;
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

        private void gestiónDeEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grupo D", "Proyecto de Construcción de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistroCL formulario = new RegistroCL();
            formulario.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            actualizacion formulario = new actualizacion();

            formulario.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            registroAM formulario = new registroAM();

            formulario.ShowDialog();
        }

        private void modificarEliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegistroCO formulario = new RegistroCO();

            formulario.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            actCond formulario = new actCond();

            formulario.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            registroPA formulario = new registroPA();

            formulario.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            actParamedico formulario = new actParamedico();

            formulario.ShowDialog();
        }
    }
}
