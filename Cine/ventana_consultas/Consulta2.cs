using Cine.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.ventana_consultas
{
    class Consulta2 : Form
    {
        private DataGridView dgvConsulta1;
        private TextBox txtCantidadVisitas;
        private Label lblConsulta2;
        private Button btnConsulta;

        public Consulta2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dgvConsulta1 = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtCantidadVisitas = new System.Windows.Forms.TextBox();
            this.lblConsulta2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsulta1
            // 
            this.dgvConsulta1.AllowUserToAddRows = false;
            this.dgvConsulta1.AllowUserToDeleteRows = false;
            this.dgvConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta1.Location = new System.Drawing.Point(9, 52);
            this.dgvConsulta1.Name = "dgvConsulta1";
            this.dgvConsulta1.ReadOnly = true;
            this.dgvConsulta1.RowTemplate.Height = 24;
            this.dgvConsulta1.Size = new System.Drawing.Size(546, 218);
            this.dgvConsulta1.TabIndex = 5;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(353, 286);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(202, 52);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtCantidadVisitas
            // 
            this.txtCantidadVisitas.Location = new System.Drawing.Point(455, 16);
            this.txtCantidadVisitas.Name = "txtCantidadVisitas";
            this.txtCantidadVisitas.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadVisitas.TabIndex = 6;
            // 
            // lblConsulta2
            // 
            this.lblConsulta2.AutoSize = true;
            this.lblConsulta2.Location = new System.Drawing.Point(9, 16);
            this.lblConsulta2.Name = "lblConsulta2";
            this.lblConsulta2.Size = new System.Drawing.Size(360, 13);
            this.lblConsulta2.TabIndex = 7;
            this.lblConsulta2.Text = "Todas las visitas al cine hechas por clientes que fueron X veces algun año";
            // 
            // Consulta2
            // 
            this.ClientSize = new System.Drawing.Size(567, 342);
            this.Controls.Add(this.lblConsulta2);
            this.Controls.Add(this.txtCantidadVisitas);
            this.Controls.Add(this.dgvConsulta1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Consulta2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaDB con = new ConsultaDB();
            con.ejecutarConsulta("exec consulta2 " + txtCantidadVisitas.Text, 1);
            dgvConsulta1.DataSource = con.pGetTable;
        }
    }
}
