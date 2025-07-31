using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionItem.Data;   
using GestionItem.Models; 
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionItem
{
    public partial class Registro_de_usuario : Form
    {
        public Registro_de_usuario()
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


        private void Cancelarbtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
        }

        private void RegistraseBtn_Click(object sender, EventArgs e)
        {

            string nombreUsuario = NombreTxt.Text.Trim();
            string contrasena = ContraseñaTxt.Text;

            string correo = CorreoTxt.Text.Trim();
            string cargo = Cargobox.Text.Trim();


            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena) ||
                string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(cargo))
            {
                lblMensaje.Text = "Error: Todos los campos son obligatorios.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return;
            }



            if (contrasena.Length < 6) 
            {
                lblMensaje.Text = "Error: La contraseña debe tener al menos 6 caracteres.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return;
            }


            try
            {
                var addr = new System.Net.Mail.MailAddress(correo);
            }
            catch
            {
                lblMensaje.Text = "Error: El formato del correo electrónico no es válido.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return;
            }


            string contrasenaHash = BCrypt.Net.BCrypt.HashPassword(contrasena);


            using (var dbContext = new ApplicationDbContext())
            {
                try
                {
                    if (dbContext.Usuarios.Any(u => u.NombreUsuario == nombreUsuario))
                    {
                        lblMensaje.Text = "Error: El nombre de usuario ya está en uso.";
                        lblMensaje.ForeColor = System.Drawing.Color.Red;
                        return;
                    }

                    if (dbContext.Usuarios.Any(u => u.Correo == correo))
                    {
                        lblMensaje.Text = "Error: Este correo electrónico ya está registrado.";
                        lblMensaje.ForeColor = System.Drawing.Color.Red;
                        return;
                    }

                    var nuevoUsuario = new Usuario
                    {
                        NombreUsuario = nombreUsuario,
                        ContrasenaHash = contrasenaHash,
                        Correo = correo,
                        Cargo = cargo
                    };

                    dbContext.Usuarios.Add(nuevoUsuario);
                    dbContext.SaveChanges();

                    lblMensaje.Text = "¡Registro exitoso! Ya puedes iniciar sesión.";
                    lblMensaje.ForeColor = System.Drawing.Color.Green;


                    NombreTxt.Clear();
                    ContraseñaTxt.Clear();
                    CorreoTxt.Clear();
                    Cargobox.Text = string.Empty;

                    this.Hide();
                    Form1 formLogin = new Form1();
                    formLogin.Show();

                }
                catch (Exception ex)
                {
                    lblMensaje.Text = $"Error al registrar usuario: {ex.Message}";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
