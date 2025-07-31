using GestionItem.Data;
using System.Linq; 
using GestionItem.Models; 
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;

namespace GestionItem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    dbContext.Database.Migrate();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrarseBtn_Click(object sender, EventArgs e)
        {
            Registro_de_usuario Registro_de_usuario = new Registro_de_usuario();
            Registro_de_usuario.Show();


        }

        private void IniciarseccionBtn_Click(object sender, EventArgs e)
        {
            string nombreUsuario = NombreText.Text.Trim();
            string contrasena = ContraseñaText.Text;


            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                lblMensaje.Text = "Error: Por favor, ingrese su nombre de usuario y contraseña.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return;
            }


            using (var dbContext = new ApplicationDbContext()) 
            {
                try
                {

                    var usuario = dbContext.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);


                    if (usuario == null)
                    {
                        lblMensaje.Text = "Error: Nombre de usuario o contraseña incorrectos.";
                        lblMensaje.ForeColor = System.Drawing.Color.Red;
                        return;
                    }

                    if (BCrypt.Net.BCrypt.Verify(contrasena, usuario.ContrasenaHash))
                    {
                        


                    }
                    else
                    {
    
                        lblMensaje.Text = "Error: Nombre de usuario o contraseña incorrectos.";
                        lblMensaje.ForeColor = System.Drawing.Color.Red;
                    }
                }
                catch (Exception ex)
                {
       
                }
            }
        }
    }
}
