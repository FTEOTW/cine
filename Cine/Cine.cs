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
using Cine.ventana_consultas;

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
           // panelC1.Visible = true;
            Consulta1 c = new Consulta1();
            c.ShowDialog();
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            Consulta2 consulta2 = new Consulta2();
            consulta2.ShowDialog();
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

        private void btnConsulta5_Click(object sender, EventArgs e)
        {
            Consulta5 consulta5 = new Consulta5();
            consulta5.ShowDialog();
        }

        private void btnConsulta6_Click(object sender, EventArgs e)
        {
            Consulta6 consulta6 = new Consulta6();
            consulta6.ShowDialog();
        }

        private void Consulta3_Click(object sender, EventArgs e)
        {
            Consulta3 consulta3 = new Consulta3();
            consulta3.ShowDialog();
        }

        private void btnConsulta4_Click(object sender, EventArgs e)
        {
            Consulta4 consulta4 = new Consulta4();
            consulta4.ShowDialog();
        }

        private void btnConsulta7_Click(object sender, EventArgs e)
        {
            Consulta7 consulta7 = new Consulta7();
            consulta7.ShowDialog();
        }

        private void btnConsulta8_Click(object sender, EventArgs e)
        {
            Consulta7 consulta7 = new Consulta7();
            consulta7.ShowDialog();
        }
    }
}
