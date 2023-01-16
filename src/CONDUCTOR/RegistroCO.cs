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
namespace CONDUCTOR
{
    public partial class RegistroCO : Form
    {
        ClaseEntidad objent = new ClaseEntidad();
        ClaseNegocio objneg = new ClaseNegocio();
        public RegistroCO()
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
            String men = objneg.N_mantenimiento_conductor(objent);
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
        private void RegistroCO_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcbancaria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtestado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfnacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtservicios_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas registrar a " + txtnombres.Text + "?", "Mensaje",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantenimiento("1");
                limpiar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
