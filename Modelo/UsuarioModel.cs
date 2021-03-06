﻿using Entidad;
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

        RolesTableAdapter rolesTableAdapter = new RolesTableAdapter();

        public  Usuario login(string usuario, string clave)
        {
            DBTransporte.usuariosDataTable usuariosDataTable = adapter.LoginUsuario(usuario, clave);
            if (usuariosDataTable.Rows.Count == 0) return null;

            Usuario user = new Usuario();
            DBTransporte.usuariosRow usuariosRow = (DBTransporte.usuariosRow)usuariosDataTable.Rows[0];
            user.usuario = usuariosRow.usuario;
            user.idUsuario = usuariosRow.id_usuario;
            user.nombres = usuariosRow.nombre;
            user.email = usuariosRow.email;
            user.clave = usuariosRow.clave;
            user.foto = usuariosRow.foto;
            user.idRool = usuariosRow.ID_Rol;
            return user;
        }

        // Actualizacion del perfil de usuario
        public void updateUsuario(string usuario, string clave, string nombre, string email, string foto, int id_usuario)
        {
            adapter.UpdateUsuario(usuario,clave,nombre,email,foto,id_usuario);
        }

        // Permisos de los usuarios por roles en cada applicacion
        public bool puedeConsultar(int ID_Rol, string Applicacion)
        {
            if(rolesTableAdapter.PuedeConsultar(ID_Rol, Applicacion) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool puedeEditar(int ID_Rol, string Applicacion)
        {
            if (rolesTableAdapter.PuedeEditar(ID_Rol, Applicacion) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool puedeEliminar(int ID_Rol, string Applicacion)
        {
            if (rolesTableAdapter.PuedeEliminar(ID_Rol, Applicacion) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Finalizando
    }
}
