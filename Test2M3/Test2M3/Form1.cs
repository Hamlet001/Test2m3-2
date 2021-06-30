using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2M3
{
    public partial class Form1 : Form
    {

        //  DataTable dgvDatos = new DataTable();

        String[] rows = { "Inversion", "Ingresos", "Egresos", "Depreciacion", "VS", "UAI", "IR", "UDI", "Depreciacion", "FNE"};
        
        public Form1()
        {
            InitializeComponent();
            
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            decimal inversion = decimal.Parse(txtInversion.Text);
            int Plazo = int.Parse(txtPlazo.Text);
            decimal Tasa = decimal.Parse(txtTasa.Text);
            decimal Inflacion = decimal.Parse(txtInflacion.Text);
            decimal vs = decimal.Parse(txtSalvamento.Text);

      

            dgvDatos.Columns.Add(" ", " ");
            for (int  i = 0; i  <= Plazo; i++)
            {
                dgvDatos.Columns.Add("", i.ToString());

            }

            for(int i = 1; i < rows.Length; i++)
            {
                
                dgvDatos.Rows.Add(rows[i]);
            }

            dgvDatos.Rows[1].Cells[1].Value = inversion;     
        
        }
    }
}
