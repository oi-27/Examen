using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Examen.CapaLogica
{
    public class LogicaEquipos
    {
        public static int AgregarEquipo(int equipoID, string tipoEquipo, string modelo, string usuarioID)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = CapaLogica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Insert into equipo (EquipoID, TipoEquipo, Modelo, UsuarioID) values (@EquipoID, @TipoEquipo, @Modelo, @UsuarioID)", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@EquipoID", equipoID));
                    cmd.Parameters.Add(new SqlParameter("@TipoEquipo", tipoEquipo));
                    cmd.Parameters.Add(new SqlParameter("@Modelo", modelo));
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
        public static int ModificarEquipo(int equipoID, string tipoEquipo, string modelo, string usuarioID)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = CapaLogica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("update equipo set TipoEquipo=@TipoEquipo, Modelo=@Modelo, UsuarioID=@UsuarioID where EquipoID=@EquipoID", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@EquipoID", equipoID));
                    cmd.Parameters.Add(new SqlParameter("@TipoEquipo", tipoEquipo));
                    cmd.Parameters.Add(new SqlParameter("@Modelo", modelo));
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

        public static int EliminarEquipo(int equipoID)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = CapaLogica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Delete from equipo where EquipoID=@EquipoID", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@EquipoID", equipoID));

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