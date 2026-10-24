using Laboratorio6.Datos;
using Laboratorio6.Entidad;
using System;
using System.Data;

namespace Laboratorio6.Logica
{
    public class LogicaLibros
    {
        private readonly LibrosDatos librosDatos;

        public LogicaLibros()
        {
            librosDatos = new LibrosDatos();
        }

        public DataTable ConsultarLibros()
        {
            return librosDatos.ConsultarLibros();
        }

       public DataTable BuscarLibros(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                throw new ArgumentException(
                    "Escriba el título o autor del libro que desea buscar.");
            }

            texto = texto.Trim();

            if (texto.Length > 100)
            {
                throw new ArgumentException(
                    "La búsqueda no puede exceder 100 caracteres.");
            }

            return librosDatos.BuscarLibros(texto);
        }

        public void AgregarLibro(Libro libro)
        {
            if (libro == null)
            {
                throw new ArgumentNullException(nameof(libro), "El libro no puede ser nulo.");
            }

            ValidarDatos(libro);
            librosDatos.AgregarLibro(libro);
        }

        public void ActualizarCantidad(int id, int cantidad)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Seleccione un libro válido.");
            }

            if (cantidad < 0)
            {
                throw new ArgumentException("La cantidad no puede ser negativa.");
            }

            librosDatos.ActualizarCantidad(id, cantidad);
        }

        public void EliminarLibro(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Seleccione un libro válido.");
            }

            librosDatos.EliminarLibro(id);
        }

        private void ValidarDatos(Libro libro)
        {
            if (string.IsNullOrWhiteSpace(libro.Titulo))
            {
                throw new ArgumentException("El título del libro es obligatorio.");
            }

            if (libro.Titulo.Trim().Length > 100)
            {
                throw new ArgumentException("El título no puede exceder 100 caracteres.");
            }

            if (string.IsNullOrWhiteSpace(libro.Autor))
            {
                throw new ArgumentException("El autor del libro es obligatorio.");
            }

            if (libro.Autor.Trim().Length > 100)
            {
                throw new ArgumentException("El autor no puede exceder 100 caracteres.");
            }

            if (libro.CantidadDisponible < 0)
            {
                throw new ArgumentException("La cantidad disponible no puede ser negativa.");
            }

            if (string.IsNullOrWhiteSpace(libro.Categoria))
            {
                throw new ArgumentException("Debe seleccionar una categoría.");
            }

            libro.Titulo = libro.Titulo.Trim();
            libro.Autor = libro.Autor.Trim();
            libro.Categoria = libro.Categoria.Trim();
        }
    }
}