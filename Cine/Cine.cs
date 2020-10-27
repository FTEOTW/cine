using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cine.database;

namespace Cine
{
    public partial class Cine : Form
    {
        public Cine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelC1.Visible = true;
           // Consulta1 c = new Consulta1();
           // c.ShowDialog();
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            panelC1.Visible = false;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaDB con = new ConsultaDB();
            con.ejecutarConsulta("exec consulta1 " + dateTimePicker1.Text, 1);

            dgvConsulta1.DataSource = con.pGetTable;
        }

        private void panelC1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
