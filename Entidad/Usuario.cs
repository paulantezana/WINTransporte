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
        public string nombre { get; set; }
        public string clave { get; set; }
        public string foto { get; set; }
        public string email { get; set; }
        public int idRol { get; set; }
        public string descripcion { get; set; }
    }
}
