using Entidad;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class UsuarioController
    {

        public static bool logged { get; set; }

        public static Usuario usuario { get; set; }

        private UsuarioModel userModel = new UsuarioModel();

        public bool loginUsuario(string userName, string password)
        {
            usuario = userModel.login(userName, password);
            return usuario == null ? false : true;
        }
    }
}
