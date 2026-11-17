using Examen.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Examen.CapaLogica
{
    public class LogicaUsuarios
    {
        public static int AgregarUsuario(int usuarioID, string nombre, string correoElectronico, string telefono)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = CapaLogica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Insert into usuario (UsuarioID, Nombre, CorreoElectronico, Telefono) values (@UsuarioID, @Nombre, @CorreoElectronico, @Telefono)", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@UsuarioID", usuarioID));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@CorreoElectronico", correoElectronico));
                    cmd.Parameters.Add(new SqlParameter("@Telefono", telefono));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
        public static int ModificarUsuario(int usuarioID, string nombre, string correoElectronico, string telefono)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = CapaLogica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("update usuario set Nombre=@Nombre, CorreoElectronico=@CorreoElectronico, Telefono=@Telefono where UsuarioID=@UsuarioID", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@UsuarioID", usuarioID));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@CorreoElectronico", correoElectronico));
                    cmd.Parameters.Add(new SqlParameter("@Telefono", telefono));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }
            return retorno;
        }

        public static int EliminarUsuario(int usuarioID)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = CapaLogica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Delete from usuario where UsuarioID=@UsuarioID", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@UsuarioID", usuarioID));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
    }
}