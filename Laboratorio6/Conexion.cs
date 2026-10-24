
using System;
using Microsoft.Data.SqlClient;

namespace Laboratorio6.Datos
{
    public class Conexion
    {
        private readonly string nombreCadena = "Libreria";

        public SqlConnection CrearConexion()
        {
            System.Configuration.ConnectionStringSettings configuracion =
                System.Configuration.ConfigurationManager.ConnectionStrings[nombreCadena];

            if (configuracion == null)
            {
                throw new InvalidOperationException(
                    "No se encontró la cadena de conexión '" +
                    nombreCadena + "' en App.config.");
            }

            return new SqlConnection(configuracion.ConnectionString);
        }
    }
}