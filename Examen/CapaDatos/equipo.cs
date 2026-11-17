using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.CapaDatos
{
    public class equipo
    {
        private int equipoID;
        public int EquipoID
        {
            get { return equipoID; }
            set { equipoID = value; }
        }

        private string tipoEquipo;
        public string TipoEquipo
        {
            get { return tipoEquipo; }
            set { tipoEquipo = value; }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private string usuarioID;
        public string UsuarioID
        {
            get { return usuarioID; }
            set { usuarioID = value; }
        }
    }
}