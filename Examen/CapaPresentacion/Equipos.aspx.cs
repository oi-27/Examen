using System;
using System.Web.UI;
using Examen.CapaLogica;

namespace Examen.CapaPresentacion
{
    public partial class Equipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int equipoID = int.Parse(txtEquipoID.Text);
                string tipoEquipo = txtTipoEquipo.Text;
                string modelo = txtModelo.Text;
                string usuarioID = txtUsuarioID.Text;

                int resultado = LogicaEquipos.AgregarEquipo(equipoID, tipoEquipo, modelo, usuarioID);

                if (resultado > 0)
                    lblMensaje.Text = "Equipo agregado exitosamente.";
                else
                    lblMensaje.Text = "Error al agregar el equipo.";
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
                int equipoID = int.Parse(txtEquipoID.Text);
                string tipoEquipo = txtTipoEquipo.Text;
                string modelo = txtModelo.Text;
                string usuarioID = txtUsuarioID.Text;

                int resultado = LogicaEquipos.ModificarEquipo(equipoID, tipoEquipo, modelo, usuarioID);

                if (resultado > 0)
                    lblMensaje.Text = "Equipo modificado exitosamente.";
                else
                    lblMensaje.Text = "Error al modificar el equipo.";
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
                int equipoID = int.Parse(txtEquipoID.Text);

                int resultado = LogicaEquipos.EliminarEquipo(equipoID);

                if (resultado > 0)
                    lblMensaje.Text = "Equipo eliminado exitosamente.";
                else
                    lblMensaje.Text = "Error al eliminar el equipo.";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}