// Tarea realizada por Miller para evidenciar el flujo de Git


using System;
using System.Linq;
using System.Windows.Forms;

namespace InventarioApp
{
    public partial class Form1 : Form
    {

        private AppDbContext db = new AppDbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            db.Database.EnsureCreated();

            // Cargamos las categorías en el ComboBox
            cmbCategorias.DataSource = db.Categorias.ToList();
            cmbCategorias.DisplayMember = "Nombre"; 
            cmbCategorias.ValueMember = "Id";      
            CargarProductos(); 
        }

        private void CargarProductos()
        {
            var lista = db.Productos
                          .Select(p => new
                          {
                              p.Id,
                              p.Nombre,
                              p.Precio,
                              Categoria = p.Categoria.Nombre // Traemos el nombre, no solo el número
                          }).ToList();

            dgvDatos.DataSource = lista;
        }

       
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            numPrecio.Value = 0;
            cmbCategorias.SelectedIndex = 0;
        }

        // --- EVENTOS DE LOS BOTONES ---

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre.");
                return;
            }

            var nuevoProducto = new Producto
            {
                Nombre = txtNombre.Text,
                Precio = numPrecio.Value,
               
                CategoriaId = Convert.ToInt32(cmbCategorias.SelectedValue)
            };

            db.Productos.Add(nuevoProducto);
            db.SaveChanges(); 

            CargarProductos(); // Actualizamos la tabla
            LimpiarCampos();
            MessageBox.Show("Producto guardado exitosamente.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
    
            if (dgvDatos.SelectedRows.Count > 0)
            {
                
                int idSeleccionado = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value);

                
                var productoAEliminar = db.Productos.Find(idSeleccionado);

                if (productoAEliminar != null)
                {
                    db.Productos.Remove(productoAEliminar);
                    db.SaveChanges();
                    CargarProductos();
                    MessageBox.Show("Producto eliminado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione toda la fila que desea eliminar dando clic en el margen izquierdo de la tabla.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}