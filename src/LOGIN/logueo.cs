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
namespace LOGIN
{
    

    public partial class logueo : Form
    {
        ClaseEntidad objent = new ClaseEntidad();
        ClaseNegocio objneg = new ClaseNegocio();
        PRINCIPAL frm1 = new PRINCIPAL();

        public static string usuario_nombre;
        void p_logueo()
        {
            DataTable dt = new DataTable();
            objent.usuario = txtusuario.Text;
            objent.clave = txtcontra.Text;
            dt = objneg.N_user(objent);

            if (dt.Rows.Count > 0)
            {
               MessageBox.Show("BIENVENIDO" + dt.Rows[0][1].ToString(),"Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][1].ToString();
                frm1.ShowDialog();
                

                logueo login = new logueo();
                login.ShowDialog();

                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new PRINCIPAL());
                txtcontra.Clear();
                txtusuario.Clear();

            }
            else
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS" , "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public logueo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p_logueo(); 
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void logueo_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            iconPictureBox1.Parent = pictureBox1;
            iconPictureBox2.Parent = pictureBox1;
            iconPictureBox3.Parent = pictureBox1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
