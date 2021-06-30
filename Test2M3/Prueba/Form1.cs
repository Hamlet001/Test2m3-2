using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {

        DataTable tabla = new DataTable();

        // Variables para las columnas y las filas
        DataColumn column;
        DataRow row;
        public Form1()
        {
            InitializeComponent();
        }

        Column = new DataColumn();
        column.DataType = System.Type.GetType("System.Int32");
        column.ColumnName = "Codigo";
        tabla.Columns.Add(column);

        
    }
}
