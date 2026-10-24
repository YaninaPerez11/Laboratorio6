using System;
using System.Windows.Forms;
using Laboratorio6.Entidad;
using Laboratorio6.Logica;

namespace Laboratorio6
{
    public partial class Form2 : Form
    {
        private LogicaLibros logica;
        private int idLibro;
        private bool modoActualizacion = false;

        public Form2()
        {
            InitializeComponent();

            logica = new LogicaLibros();

            this.BackgroundImage = Properties.Resources.Fondo6;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            cmbCategoria.SelectedIndex = -1;
        }

        // Constructor utilizado para actualizar la cantidad de un libro existente
        public Form2(int id, string titulo, string autor,
                     string categoria, int cantidadActual)
        {
            InitializeComponent();

            logica = new LogicaLibros();

            this.BackgroundImage = Properties.Resources.Fondo6;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            idLibro = id;
            modoActualizacion = true;

            label2.Text = "Actualizar cantidad";
            btnGuardar.Text = "Aceptar";

            txtTituloDeLibro.Text = titulo;
            txtAutor.Text = autor;
            cmbCategoria.SelectedItem = categoria;
            nudCantidad.Value = cantidadActual;

            txtTituloDeLibro.Enabled = false;
            txtAutor.Enabled = false;
            cmbCategoria.Enabled = false;
        }

        // Gestiona el registro de libros y la actualización de cantidades
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = Convert.ToInt32(nudCantidad.Value);

                if (modoActualizacion)
                {
                    logica.ActualizarCantidad(idLibro, cantidad);

                    MessageBox.Show(
                        "La cantidad se actualizó correctamente.",
                        "Operación completada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    string titulo = txtTituloDeLibro.Text.Trim();
                    string autor = txtAutor.Text.Trim();

                    if (titulo == "")
                    {
                        MessageBox.Show(
                            "Ingrese el título del libro.",
                            "Validación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        txtTituloDeLibro.Focus();
                        return;
                    }

                    if (autor == "")
                    {
                        MessageBox.Show(
                            "Ingrese el autor del libro.",
                            "Validación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        txtAutor.Focus();
                        return;
                    }

                    if (cmbCategoria.SelectedIndex == -1)
                    {
                        MessageBox.Show(
                            "Seleccione una categoría.",
                            "Validación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        cmbCategoria.Focus();
                        return;
                    }

                    string categoria = cmbCategoria.SelectedItem.ToString();

                    Libro libro = new Libro(
                        titulo, autor, cantidad, categoria);

                    logica.AgregarLibro(libro);

                    MessageBox.Show(
                        "El libro se registró correctamente.",
                        "Operación completada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validación de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    "No se pudo completar la operación.\n\n" + ex.Message,
                    "Error de operación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al guardar los datos.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Cierra el formulario sin guardar cambios
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}