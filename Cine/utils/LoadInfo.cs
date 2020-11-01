using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cine.database;

namespace Cine.utils
{
    class LoadInfo
    {
        public void CargarCombo(ComboBox combo, String table)
        {
            DataTable dt = new DataTable();
            ConsultaDB consulta = new ConsultaDB();
            consulta.ejecutarConsulta("exec " + table, 1);
            dt = consulta.pGetTable;
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            try //esto es para cuando llenamos combo con tablas que no tienen id, llamando a sp
            {
                combo.DisplayMember = dt.Columns[1].ColumnName;
            }
            catch (IndexOutOfRangeException)
            {
            }
            
        }
    }
}
