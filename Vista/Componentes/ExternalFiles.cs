using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Componentes
{
    public class ExternalFiles
    {
        public static DataTable ImporExcel(string query = "SELECT * FROM [Hoja1$]")
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivo Excel|*.xls;*.xlsx;*.xlsm;*.csv";
            open.Title = "Abrir archivo Excel";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string ExcelFileName = open.FileName;
                string connectionString = string.Empty;

                if (Path.GetExtension(ExcelFileName) == ".xlsx")
                {
                    connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=No;IMEX=1\";", ExcelFileName);
                }
                else
                {
                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ExcelFileName + ";Extended Properties=Excel 8.0;";
                }
                OleDbConnection conector = default(OleDbConnection);

                conector = new OleDbConnection(connectionString);
                conector.Open();

                OleDbCommand consulta = default(OleDbCommand);
                consulta = new OleDbCommand(query, conector);

                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = consulta;

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                return dataTable;
            }
            return null;
        }
    }
}
