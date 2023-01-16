using System;
using System.Data;
using System.Windows.Forms;

// referencias
using Capa_Entidad;
using Capa_Negocio;

namespace LOGIN
{
    public partial class logueo : Form
    {
        // parámetros de la clase
        ClaseEntidad objent = new ClaseEntidad();
        ClaseNegocio objneg = new ClaseNegocio();
        String userloged;
        public static string usuario_nombre;

        //------------------------------------------------------------------- Método para validar el Login
        void p_logueo()
        {
            // Parámetros de inicio
            DataTable dt = new DataTable();
            objent.usuario = txtusuario.Text;
            objent.clave = txtcontra.Text;

            //Obtener coincidencias
            dt = objneg.N_user(objent);

            // Si existe el usuario
            if (dt.Rows.Count > 0)
            {
                // almacenar nombre del usuario
                usuario_nombre = dt.Rows[0][1].ToString();

                // settear el usuario como parametro de la clase instanciada
                setUser(usuario_nombre);

                // Limpiar entradas de texto y avisos
                txtcontra.Clear();
                txtusuario.Clear();
                label1.Text = "";

                // Esconder ventana de login
                this.Hide();
                // Instanciar e iniciar la pantalla principal
                PRINCIPAL frm1 = new PRINCIPAL(getUser()); // enviar nombre de usuario al constructor
                frm1.ShowDialog();
                // al cerrar la pantalla principal se vuelve a mostrar el login
                this.Show();
            }
            else
            {
                // Mensaje si no existe el usuario
                label1.Text = "Usuario o contraseña Incorrecta";
            }
        }

        // Constructor de la clase
        public logueo(string userloged)
        {
            InitializeComponent();
            this.userloged = userloged;
        }

        // set usuario
        void setUser(String user)
        {
            this.userloged = user;
        }

        // get usuario
        String getUser() {
            return this.userloged;  
        }

        // ------------------------------------------------------------------ Eventos de la interfaz de usuario

        private void button1_Click(object sender, EventArgs e)
        {
            p_logueo(); 
        }

        private void logueo_Load(object sender, EventArgs e)
        {
           // label1.Parent = pictureBox1;
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
