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

        // Login Usuario
        public bool loginUsuario(string userName, string password)
        {
            usuario = userModel.login(userName, password);
            return usuario == null ? false : true;
        }

        // Actualizar usuario
        public void updateUsuario(string usuario, string clave, string nombre, string email, string foto, int id_usuario)
        {
            userModel.updateUsuario(usuario,clave,nombre,email,foto,id_usuario);
        }

        // Permisos de los roles
        public bool puedeConsultar(int ID_Rol, string Applicacion)
        {
            return userModel.puedeConsultar(ID_Rol, Applicacion);
        }

        public bool puedeEditar(int ID_Rol, string Applicacion)
        {
            return userModel.puedeEditar(ID_Rol, Applicacion);
        }

        public bool puedeEliminar(int ID_Rol, string Applicacion)
        {
            return userModel.puedeEliminar(ID_Rol, Applicacion);
        }
    }
}
