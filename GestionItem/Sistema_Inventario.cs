using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore; 
using GestionItem.Data;
using GestionItem.Models; 

namespace GestionItem 
{
    public partial class Sistema_Inventario : Form 
    {
        private Usuario _usuarioLogueado;

        public Sistema_Inventario()
        {
            InitializeComponent();
            CargarItemsEnDataGridView();

            dataGridView.AllowUserToAddRows = false; 
            dataGridView.ReadOnly = true;          
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            dataGridView.MultiSelect = false;      

        }


        public Sistema_Inventario(Usuario usuario) : this() 
        {
            _usuarioLogueado = usuario;

        }


        private void CargarItemsEnDataGridView()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                try
                {
                    var items = dbContext.Items.ToList();
                    dataGridView.DataSource = items; 
                    if (dataGridView.Columns.Contains("Id")) dataGridView.Columns["Id"].HeaderText = "ID";
                    if (dataGridView.Columns.Contains("Nombre")) dataGridView.Columns["Nombre"].HeaderText = "Nombre del Producto";
                    if (dataGridView.Columns.Contains("Descripcion")) dataGridView.Columns["Descripcion"].HeaderText = "Descripción";
                    if (dataGridView.Columns.Contains("Cantidad")) dataGridView.Columns["Cantidad"].HeaderText = "Cantidad";
                    if (dataGridView.Columns.Contains("Precio")) dataGridView.Columns["Precio"].HeaderText = "Precio Unitario";

                    dataGridView.Columns["Id"].DisplayIndex = 0;
                    dataGridView.Columns["Nombre"].DisplayIndex = 1;
                    dataGridView.Columns["Descripcion"].DisplayIndex = 2;
                    dataGridView.Columns["Cantidad"].DisplayIndex = 3;
                    dataGridView.Columns["Precio"].DisplayIndex = 4;

                    lblEstado.Text = $"Items cargados: {items.Count}";
                    lblEstado.ForeColor = System.Drawing.Color.Green;
                }
                catch (Exception ex)
                {
                    lblEstado.Text = $"Error al cargar ítems: {ex.Message}";
                    lblEstado.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show($"Error al cargar ítems: {ex.Message}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ProductoBtn_Click(object sender, EventArgs e) 
        {
            Productos formProductos = new Productos(); 
            if (formProductos.ShowDialog() == DialogResult.OK)
            {

                CargarItemsEnDataGridView(); 
                lblEstado.Text = "¡Nuevo ítem agregado exitosamente!";
                lblEstado.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                lblEstado.Text = "Operación de agregar ítem cancelada.";
                lblEstado.ForeColor = System.Drawing.Color.Orange;
            }
        }

        private void Sistema_Inventario_Load(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
    }
}