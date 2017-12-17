using Entidad;
using Modelo.DBTransporteTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class UsuarioModel
    {
        UsuariosTableAdapter adapter = new UsuariosTableAdapter();

        public  Usuario login(string usuario, string clave)
        {
            DBTransporte.usuariosDataTable usuariosDataTable = adapter.LoginUsuario(usuario, clave);
            if (usuariosDataTable.Rows.Count == 0) return null;

            Usuario user = new Usuario();
            DBTransporte.usuariosRow usuariosRow = (DBTransporte.usuariosRow)usuariosDataTable.Rows[0];
            user.usuario = usuariosRow.usuario;
            user.idUsuario = usuariosRow.id_usuario;
            user.nombre = usuariosRow.nombre;
            user.clave = usuariosRow.clave;
            user.foto = usuariosRow.foto;
            user.email = usuariosRow.email;
            user.idRol = usuariosRow.ID_Rol;
            return user;
        }
        public void updateUsuario(string usuario, string clave, string nombre, string email, string foto, int id_usuario)
        {
            adapter.UpdateUsuario(usuario,clave, nombre, email, foto, id_usuario);
        }
        public void cambiarClave(string clave, int id_usuario)
        {
            adapter.CambiarClave(clave, id_usuario);
        }
    }
}
