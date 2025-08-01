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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);

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

                    if (dataGridView.Rows.Count > 0)
                    {
                        dataGridView.Rows[0].Selected = true;
                        MostrarItemsEnDetalles(); 
                    }
                    else
                    {
                        LimpiarDetalles(); 
                    }
                }
                catch (Exception ex)
                {
                    lblEstado.Text = $"Error al cargar ítems: {ex.Message}";
                    lblEstado.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show($"Error al cargar ítems: {ex.Message}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void MostrarItemsEnDetalles()
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                    Item selectedItem = selectedRow.DataBoundItem as Item;

                    if (selectedItem != null)
                    {
                        IdLbl.Text = selectedItem.Id.ToString();
                        NombreLbl.Text = selectedItem.Nombre;
                        DecripcionLbl.Text = selectedItem.Descripcion;
                        CantidadLbl.Text = selectedItem.Cantidad.ToString();
                        PrecioLbl.Text = selectedItem.Precio.ToString("C", System.Globalization.CultureInfo.CurrentCulture); 
                    }
                    else
                    {
                        IdLbl.Text = selectedRow.Cells["Id"].Value?.ToString() ?? "N/A";
                        NombreLbl.Text = selectedRow.Cells["Nombre"].Value?.ToString() ?? "N/A";
                        DecripcionLbl.Text = selectedRow.Cells["Descripcion"].Value?.ToString() ?? "N/A";
                        CantidadLbl.Text = selectedRow.Cells["Cantidad"].Value?.ToString() ?? "N/A";
                        PrecioLbl.Text = selectedRow.Cells["Precio"].Value?.ToString() ?? "N/A";
                        lblEstado.Text = "Advertencia: No se pudo obtener el objeto Item completo. Se cargó desde celdas.";
                        lblEstado.ForeColor = System.Drawing.Color.Orange;
                    }
                }
                catch (Exception ex)
                {
                    lblEstado.Text = $"Error al mostrar detalles del ítem: {ex.Message}";
                    lblEstado.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                LimpiarDetalles(); 
            }
        }
        private void LimpiarDetalles()
        {
            IdLbl.Text = "N/A";
            NombreLbl.Text = "N/A";
            CantidadLbl.Text = "N/A";
            DecripcionLbl.Text = "N/A";
            PrecioLbl.Text = "N/A";
        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            MostrarItemsEnDetalles(); 
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
                lblEstado.Text = "Operación de agregar ítem fue cancelada.";
                lblEstado.ForeColor = System.Drawing.Color.Orange;
            }
        }
        private void Sistema_Inventario_Load(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                lblEstado.Text = "Por favor, seleccione un ítem para poder eliminar.";
                lblEstado.ForeColor = System.Drawing.Color.Red;
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "¿Está seguro de que desea eliminar el ítem seleccionado? Esta acción no se puede deshacer.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.Yes)
            {
                int itemId = (int)dataGridView.SelectedRows[0].Cells["Id"].Value;

                using (var dbContext = new ApplicationDbContext())
                {
                    try
                    {
                        var itemAEliminar = dbContext.Items.Find(itemId);
                        if (itemAEliminar != null)
                        {
                            dbContext.Items.Remove(itemAEliminar);
                            dbContext.SaveChanges();

                            lblEstado.Text = "¡Item eliminado exitosamente!";
                            lblEstado.ForeColor = System.Drawing.Color.Green;
                            CargarItemsEnDataGridView();
                        }
                        else
                        {
                            lblEstado.Text = "Error: El item a eliminar no se encontro en la base de datos.";
                            lblEstado.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {
                        lblEstado.Text = $"Error al eliminar el ítem: {ex.Message}";
                        lblEstado.ForeColor = System.Drawing.Color.Red;
                        MessageBox.Show($"Error al eliminar el ítem: {ex.Message}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                lblEstado.Text = "Operación de eliminación cancelada.";
                lblEstado.ForeColor = System.Drawing.Color.Orange;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void EditarBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                lblEstado.Text = "Por favor, seleccione un ítem para editar.";
                lblEstado.ForeColor = System.Drawing.Color.Red;
                return;
            }
            int itemId = (int)dataGridView.SelectedRows[0].Cells["Id"].Value;
            Productos formProductos = new Productos(itemId); 
            if (formProductos.ShowDialog() == DialogResult.OK)
            {
                CargarItemsEnDataGridView(); 
                lblEstado.Text = "¡Ítem editado exitosamente!";
                lblEstado.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                lblEstado.Text = "Operación de edición de ítem cancelada.";
                lblEstado.ForeColor = System.Drawing.Color.Orange;
            }
        }
    }
}
    