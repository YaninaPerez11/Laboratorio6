using Laboratorio6.Entidad;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Laboratorio6.Datos
{
    public class LibrosDatos
    {
        private readonly Conexion conexionBD;

        public LibrosDatos()
        {
            conexionBD = new Conexion();
        }

        public DataTable ConsultarLibros()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection conexion = conexionBD.CrearConexion())
                using (SqlCommand comando = new SqlCommand("sp_ConsultarLibros", conexion))
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    adaptador.Fill(tabla);
                }
            }
            catch (SqlException ex)
            {
                throw new InvalidOperationException("No se pudieron consultar los libros.", ex);
            }

            return tabla;
        }

        public DataTable BuscarLibros(string texto)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection conexion = conexionBD.CrearConexion())
                using (SqlCommand comando = new SqlCommand("sp_BuscarLibro", conexion))
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@Texto", SqlDbType.VarChar, 100).Value = texto;
                    adaptador.Fill(tabla);
                }
            }
            catch (SqlException ex)
            {
                throw new InvalidOperationException("No se pudieron buscar los libros.", ex);
            }

            return tabla;
        }

        public void AgregarLibro(Libro libro)
        {
            try
            {
                using (SqlConnection conexion = conexionBD.CrearConexion())
                using (SqlCommand comando = new SqlCommand("sp_AgregarLibro", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@Titulo", SqlDbType.VarChar, 100).Value = libro.Titulo;
                    comando.Parameters.Add("@Autor", SqlDbType.VarChar, 100).Value = libro.Autor;
                    comando.Parameters.Add("@CantidadDisponible", SqlDbType.Int).Value = libro.CantidadDisponible;
                    comando.Parameters.Add("@Categoria", SqlDbType.VarChar, 50).Value = libro.Categoria;

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new InvalidOperationException("No se pudo agregar el libro.", ex);
            }
        }

        public void ActualizarCantidad(int id, int cantidad)
        {
            try
            {
                using (SqlConnection conexion = conexionBD.CrearConexion())
                using (SqlCommand comando = new SqlCommand("sp_ActualizarCantidad", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    comando.Parameters.Add("@CantidadDisponible", SqlDbType.Int).Value = cantidad;

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new InvalidOperationException("No se pudo actualizar la cantidad.", ex);
            }
        }

        public void EliminarLibro(int id)
        {
            try
            {
                using (SqlConnection conexion = conexionBD.CrearConexion())
                using (SqlCommand comando = new SqlCommand("sp_EliminarLibro", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new InvalidOperationException("No se pudo eliminar el libro.", ex);
            }
        }
    }
}