using Modelo.DBTransporteTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class EmpresaModel
    {
        private EmpresasTableAdapter tableAdapter = new EmpresasTableAdapter();

        public void insertEmpresa(string codigo, string nombre, string gerente, string propietario, string telefono, string direccion, string ciudad, int id_tipo_empresa)
        {
            tableAdapter.InsertEmpresa(codigo, nombre, gerente, propietario, telefono, direccion, ciudad, id_tipo_empresa);
        }
    }
}
