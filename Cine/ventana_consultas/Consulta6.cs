using Cine.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.ventana_consultas
{
    class Consulta6 : Form
    {
        private DataGridView dgvConsulta1;
        private Label lblConsulta6;
        private Label lblRow;
        private Button btnConsulta;

        public Consulta6()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dgvConsulta1 = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblConsulta6 = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsulta1
            // 
            this.dgvConsulta1.AllowUserToAddRows = false;
            this.dgvConsulta1.AllowUserToDeleteRows = false;
            this.dgvConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta1.Location = new System.Drawing.Point(12, 105);
            this.dgvConsulta1.Name = "dgvConsulta1";
            this.dgvConsulta1.ReadOnly = true;
            this.dgvConsulta1.RowTemplate.Height = 24;
            this.dgvConsulta1.Size = new System.Drawing.Size(692, 218);
            this.dgvConsulta1.TabIndex = 5;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(502, 349);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(202, 52);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblConsulta6
            // 
            this.lblConsulta6.AutoSize = true;
            this.lblConsulta6.Location = new System.Drawing.Point(9, 44);
            this.lblConsulta6.Name = "lblConsulta6";
            this.lblConsulta6.Size = new System.Drawing.Size(236, 13);
            this.lblConsulta6.TabIndex = 6;
            this.lblConsulta6.Text = "Muestra los clientes que se le cayeron la reserva";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(12, 369);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(0, 13);
            this.lblRow.TabIndex = 7;
            // 
            // Consulta6
            // 
            this.ClientSize = new System.Drawing.Size(720, 406);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.lblConsulta6);
            this.Controls.Add(this.dgvConsulta1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Consulta6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta 6";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaDB con = new ConsultaDB();
            con.ejecutarConsulta("exec consulta6 " , 1);
            dgvConsulta1.DataSource = con.pGetTable;
            lblRow.Text = Convert.ToString(dgvConsulta1.RowCount) + " rows";
        }
    }
}
