﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordinario
{
    internal class Usuarios
    {
        private static List<Usuarios> usuarios = new List<Usuarios>
        {
            new Usuarios{NombreUsuario = "Angela", Contrasenia = "1234"},
        };
        public Usuarios(string nombreUsuario, string contrasenia)
        {
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
        }
        public List<Usuarios> ObtenerUsuario()
        {
            return usuarios;
        }
        public Usuarios() { }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
    }
}
