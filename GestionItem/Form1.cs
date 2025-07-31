using GestionItem.Data;
using System.Linq; 
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;

namespace GestionItem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Contrase�aTxt.UseSystemPasswordChar = true;
            try
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    dbContext.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = $"Error cr�tico de base de datos: {ex.Message}";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                IniciarseccionBtn.Enabled = false;
                RegistrarseBtn.Enabled = false;
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
            string nombreUsuario = NombreTxt.Text.Trim();
            string contrasena = Contrase�aTxt.Text;

            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                lblMensaje.Text = "Error: Por favor, ingrese su nombre de usuario y contrase�a.";
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
                        lblMensaje.Text = "Error: Nombre de usuario o contrase�a incorrectos.";
                        lblMensaje.ForeColor = System.Drawing.Color.Red;
                        return;
                    }

                    if (BCrypt.Net.BCrypt.Verify(contrasena, usuario.ContrasenaHash))
                    {
                        lblMensaje.Text = $"�Bienvenido, {usuario.NombreUsuario}! Iniciando sistema...";
                        lblMensaje.ForeColor = System.Drawing.Color.Blue;

    
                        this.Hide();
                        Sistema_Inventario sistemaInventarioForm = new Sistema_Inventario(usuario);
                        sistemaInventarioForm.ShowDialog(); 

                       
                        this.Show(); 
                        NombreTxt.Clear();
                        Contrase�aTxt.Clear();
                        lblMensaje.Text = "";
                    }
                    else
                    {
                        lblMensaje.Text = "Error: Nombre de usuario o contrase�a incorrectos.";
                        lblMensaje.ForeColor = System.Drawing.Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = $"Error al iniciar sesi�n: {ex.Message}";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}
