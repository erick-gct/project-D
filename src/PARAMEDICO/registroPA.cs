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
namespace PARAMEDICO
{
    public partial class registroPA : Form
    {
        ClaseEntidad objent = new ClaseEntidad();
        ClaseNegocio objneg = new ClaseNegocio();
        public registroPA()
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
        private void registroPA_Load(object sender, EventArgs e)
        {
            iconButton3.Parent = pictureBox1;
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            label6.Parent = pictureBox1;
            label7.Parent = pictureBox1;
            label8.Parent = pictureBox1;
            label9.Parent = pictureBox1;
            label10.Parent = pictureBox1;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas registrar a " + txtnombres.Text + "?", "Mensaje",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                mantenimiento("1");
                limpiar();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
