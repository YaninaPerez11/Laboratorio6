using System;
using System.Windows.Forms;
using Laboratorio6.Logica;

namespace Laboratorio6
/* Integrantes
* Yanina Pérez
* Cristher Valdes
* David Barría
*/
{
    public partial class Form1 : Form
    {
        private LogicaLibros logica;
        public Form1()
        {
            InitializeComponent();

            logica = new LogicaLibros();

            this.BackgroundImage = Properties.Resources.Fondo6;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // Carga los libros registrados al abrir el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarLibros();
        }

        // Consulta y muestra todos los libros en el DataGridView
        private void CargarLibros()
        {
            try
            {
                dgvLibros.DataSource = logica.ConsultarLibros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron consultar los libros.\n\n" + ex.Message,
                    "Error de consulta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Permite registrar un nuevo libro en el sistema
        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form2 formulario = new Form2())
                {
                    if (formulario.ShowDialog() == DialogResult.OK)
                    {
                        CargarLibros();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo abrir el formulario de registro.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Permite actualizar la información del libro seleccionado
        private void btnActualizarCantidad_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow == null ||
                dgvLibros.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccione un libro para actualizar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(
                    dgvLibros.CurrentRow.Cells["id"].Value);

                string titulo = Convert.ToString(
                    dgvLibros.CurrentRow.Cells["Titulo"].Value);

                string autor = Convert.ToString(
                    dgvLibros.CurrentRow.Cells["Autor"].Value);

                int cantidad = Convert.ToInt32(
                    dgvLibros.CurrentRow.Cells["CantidadDisponible"].Value);

                string categoria = Convert.ToString(
                    dgvLibros.CurrentRow.Cells["Categoria"].Value);

                using (Form2 formulario = new Form2(
                    id, titulo, autor, categoria, cantidad))
                {
                    if (formulario.ShowDialog() == DialogResult.OK)
                    {
                        CargarLibros();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Los datos del libro seleccionado no tienen un formato válido.",
                    "Error de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show(
                    "No se pudieron interpretar los datos del libro.",
                    "Error de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo actualizar el libro.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Gestiona la eliminación de un libro seleccionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow == null ||
                dgvLibros.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccione un libro para eliminar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea eliminar el libro seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                int id = Convert.ToInt32(
                    dgvLibros.CurrentRow.Cells["id"].Value);

                logica.EliminarLibro(id);

                MessageBox.Show(
                    "El libro se eliminó correctamente.",
                    "Operación completada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarLibros();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "El identificador del libro no es válido.",
                    "Error de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar el libro.\n\n" + ex.Message,
                    "Error de eliminación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Realiza búsquedas por título o autor
        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            string texto = txtBuscarLibro.Text.Trim();

            if (texto == "")
            {
                MessageBox.Show(
                    "Escriba el título o autor del libro que desea buscar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBuscarLibro.Focus();
                return;
            }

            try
            {
                var resultados = logica.BuscarLibros(texto);
                dgvLibros.DataSource = resultados;

                if (dgvLibros.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron coincidencias.",
                        "Resultado de búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo realizar la búsqueda.\n\n" + ex.Message,
                    "Error de búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Restaura la vista completa de libros
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            txtBuscarLibro.Clear();
            CargarLibros();
        }
    }
}