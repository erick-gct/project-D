using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;
using actualizarclientess;
namespace Clientes
{
    public partial class RegistroCL : Form
    {
        ClaseEntidad objent = new ClaseEntidad();
        ClaseNegocio objneg = new ClaseNegocio();
        public RegistroCL()
        {
            InitializeComponent();
        }
        void mantenimiento(String accion)
        {
            objent.codigo2 = txtcodigo.Text;
            objent.cbancaria = txtcbancaria.Text;
            objent.cedula = txtcedula.Text;
            objent.direccion = txtdireccion.Text;
            objent.estado = txtestado.Text;
            objent.fnacimiento = txtfnacimiento.Text;
            objent.nombres = txtnombres.Text;
            objent.servicios = txtservicios.Text;
            objent.telefono = txttelefono.Text;
            objent.accion2 = accion;
            String men = objneg.N_mantenimiento_clientes(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void limpiar()
        {
            txtcodigo.Text = "";
            txtcbancaria.Text = "";
            txtcedula.Text = "";
            txtdireccion.Text = "";
            txtestado.Text = "";
            txtfnacimiento.Text = "";
            txtnombres.Text = "";
            txtservicios.Text = "";
            txttelefono.Text = "";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas registrar aL cliente " + txtnombres.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantenimiento("1");
                limpiar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           actualizacion formulario = new actualizacion();
            formulario.ShowDialog();
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
