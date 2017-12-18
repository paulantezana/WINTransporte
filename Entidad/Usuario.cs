using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string clave { get; set; }
        public string foto { get; set; }
        public string email { get; set; }
        public int idRool { get; set; }
        public DateTime fechaModificacionClave { get; set; }
    }
}
