using System;
using System.Windows.Forms;

// referencias
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
        // Parametro de la clase
        String user;

        // Constructor de la clase
        public PRINCIPAL(string user)
        {
            InitializeComponent();
            this.user = user;
            // iniciar la ventana con el nombre de la clase instanciada
            label5.Text = "Bienvenido "+this.user;
        }

        //--------------------------------------------------------------------- Eventos de la interfaz de usuario
        private void PRINCIPAL_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Erick Campuzano", "Proyecto de Construcción de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
