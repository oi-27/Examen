using System;
using System.Web.UI;
using Examen.CapaLogica;

namespace Examen.CapaPresentacion
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int usuarioID = int.Parse(txtUsuarioID.Text);
                string nombre = txtNombre.Text;
                string correo = txtCorreo.Text;
                string telefono = txtTelefono.Text;

                int resultado = LogicaUsuarios.AgregarUsuario(usuarioID, nombre, correo, telefono);

                if (resultado > 0)
                    lblMensaje.Text = "Usuario agregado exitosamente.";
                else
                    lblMensaje.Text = "Error al agregar el usuario.";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int usuarioID = int.Parse(txtUsuarioID.Text);
                string nombre = txtNombre.Text;
                string correo = txtCorreo.Text;
                string telefono = txtTelefono.Text;

                int resultado = LogicaUsuarios.ModificarUsuario(usuarioID, nombre, correo, telefono);

                if (resultado > 0)
                    lblMensaje.Text = "Usuario modificado exitosamente.";
                else
                    lblMensaje.Text = "Error al modificar el usuario.";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int usuarioID = int.Parse(txtUsuarioID.Text);

                int resultado = LogicaUsuarios.EliminarUsuario(usuarioID);

                if (resultado > 0)
                    lblMensaje.Text = "Usuario eliminado exitosamente.";
                else
                    lblMensaje.Text = "Error al eliminar el usuario.";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}