using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class EmpresaController
    {
        private EmpresaModel empresaModel = new EmpresaModel();
        public void insertEmpresa(DataTable empresas)
        {
            //empresaModel.insertEmpresa(codigo, nombre, gerente, propietario, telefono, direccion, ciudad, id_tipo_empresa);
            foreach (DataRow row in empresas.Rows)
            {
                empresaModel.insertEmpresa(
                        row[0].ToString(),
                        row[1].ToString(),
                        row[2].ToString(),
                        row[3].ToString(),
                        row[4].ToString(),
                        row[5].ToString(),
                        row[5].ToString(),
                        Convert.ToInt32(row[7].ToString())
                    );
            }
        }
    }
}
