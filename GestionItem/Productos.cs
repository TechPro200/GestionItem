using System;
using System.Windows.Forms;
using GestionItem.Data;
using GestionItem.Models; 
namespace GestionItem
{
    public partial class Productos : Form
    {
        private int _itemIdAEditar;
        private Item _itemActual;

        public Productos()
        {
            InitializeComponent();
            ConfigurarFormularioBase();
            ConfigurarFormularioParaNuevo();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        public Productos(int itemId) : this()
        {
            _itemIdAEditar = itemId;
            ConfigurarFormularioParaEdicion();
        }
        private void ConfigurarFormularioBase()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void ConfigurarFormularioParaNuevo()
        {
            this.Text = "Agregar Nuevo Producto";
            AgregarBtn.Text = "Guardar Nuevo";
            _itemIdAEditar = 0;
            lblMensaje.Text = "Introduce los datos del nuevo producto.";
            lblMensaje.ForeColor = System.Drawing.Color.Blue;
            LimpiarCampos();
        }
        private void ConfigurarFormularioParaEdicion()
        {
            this.Text = "Editar Producto";
            AgregarBtn.Text = "Guardar Cambios";
            lblMensaje.Text = "Modificando ítem existente.";
            lblMensaje.ForeColor = System.Drawing.Color.Blue;
            CargarItemParaEdicion();
        }
        private void LimpiarCampos()
        {
            NombreTxt.Clear();
            DescripcionTxt.Clear();
            CantidadTxt.Clear();
            PrecioTxt.Clear();
            NombreTxt.Focus();
        }
        private void CargarItemParaEdicion()
        {
            if (_itemIdAEditar <= 0)
            {
                MostrarMensajeError("No se ha proporcionado un ID de ítem válido para editar.");
                AgregarBtn.Enabled = false;
                return;
            }

            using (var dbContext = new ApplicationDbContext())
            {
                try
                {
                    _itemActual = dbContext.Items.Find(_itemIdAEditar);
                    if (_itemActual != null)
                    {
                        NombreTxt.Text = _itemActual.Nombre;
                        DescripcionTxt.Text = _itemActual.Descripcion;
                        CantidadTxt.Text = _itemActual.Cantidad.ToString();
                        PrecioTxt.Text = _itemActual.Precio.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        MostrarMensajeError($"Error: Ítem con ID {_itemIdAEditar} no encontrado en la base de datos.");
                        AgregarBtn.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MostrarMensajeError($"Error al cargar ítem para edición: {ex.Message}");
                    AgregarBtn.Enabled = false;
                }
            }
        }
        private bool ValidarEntradas(out string nombre, out string descripcion, out int cantidad, out decimal precio)
        {
            nombre = NombreTxt.Text.Trim();
            descripcion = DescripcionTxt.Text.Trim();
            cantidad = 0;
            precio = 0m;


            if (string.IsNullOrWhiteSpace(nombre))
            {
                MostrarMensajeError("El nombre del producto es obligatorio.");
                NombreTxt.Focus();
                return false;
            }


            if (!int.TryParse(CantidadTxt.Text.Trim(), System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out cantidad) || cantidad < 0)
            {
                MostrarMensajeError("La cantidad debe ser un número entero no negativo válido.");
                CantidadTxt.Focus();
                return false;
            }


            if (!decimal.TryParse(PrecioTxt.Text.Trim(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out precio) || precio <= 0)
            {
                MostrarMensajeError("El precio debe ser un número decimal válido y positivo (ej. 10.50).");
                PrecioTxt.Focus();
                return false;
            }

            return true;
        }
        private void MostrarMensajeError(string mensaje)
        {
            lblMensaje.Text = "Error: " + mensaje;
            lblMensaje.ForeColor = System.Drawing.Color.Red;
            MessageBox.Show(mensaje, "Error de Validación/Operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MostrarMensajeExito(string mensaje)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.ForeColor = System.Drawing.Color.Green;

        }
        private void AgregarBtn_Click(object sender, EventArgs e)
        {

            if (!ValidarEntradas(out string nombre, out string descripcion, out int cantidad, out decimal precio))
            {
                return;
            }
            using (var dbContext = new ApplicationDbContext())
            {
                try
                {
                    if (_itemIdAEditar == 0)
                    {
                        _itemActual = new Item();
                        dbContext.Items.Add(_itemActual);
                    }
                    else
                    {

                        _itemActual = dbContext.Items.Find(_itemIdAEditar);
                        if (_itemActual == null)
                        {
                            MostrarMensajeError("El ítem que intentas editar no se encontró en la base de datos.");
                            return;
                        }

                    }


                    _itemActual.Nombre = nombre;
                    _itemActual.Descripcion = descripcion;
                    _itemActual.Cantidad = cantidad;
                    _itemActual.Precio = precio;

                    dbContext.SaveChanges();

                    MostrarMensajeExito("¡Ítem guardado exitosamente!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {

                    string errorMessage = $"Error al guardar el ítem en la base de datos: {ex.Message}";
                    if (ex.InnerException != null)
                    {
                        errorMessage += $"\nDetalles: {ex.InnerException.Message}";
                    }
                    MostrarMensajeError(errorMessage);
                }
            }
        }
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}