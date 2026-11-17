using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.CapaDatos
{
    public class usuario
    {
        private int usuarioID;
        public int UsuarioID
        {
            get { return usuarioID; }
            set { usuarioID = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string correoElectronico;
        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }

        private string telefono;
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}