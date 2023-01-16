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
        String userloged;


        public static string usuario_nombre;
        void p_logueo()
        {
            DataTable dt = new DataTable();
            objent.usuario = txtusuario.Text;
            objent.clave = txtcontra.Text;

            dt = objneg.N_user(objent);

            if (dt.Rows.Count > 0)
            {
               //MessageBox.Show("BIENVENIDO" + dt.Rows[0][1].ToString(),"Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][1].ToString();
                //this.Hide();

                setUser(usuario_nombre);

                txtcontra.Clear();
                txtusuario.Clear();
                label1.Text = "";

                this.Hide();
                PRINCIPAL frm1 = new PRINCIPAL(getUser());
                frm1.ShowDialog();
                this.Show();
                
                //Application.Run(new PRINCIPAL());


            }
            else
            {
                label1.Text = "Usuario o contraseña Incorrecta";
            }
        }

        public logueo(string userloged)
        {
            InitializeComponent();
            this.userloged = userloged;
        }

        void setUser(String user)
        {
            this.userloged = user;
        }

        String getUser() {
            return this.userloged;  
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
           // label1.Parent = pictureBox1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
