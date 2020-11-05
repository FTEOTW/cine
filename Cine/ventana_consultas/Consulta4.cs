using Cine.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.ventana_consultas
{
    class Consulta4 : Control
    {
        private DataGridView dgvConsulta1;
        private DateTimePicker dateTimePicker1;
        private Label lblRow;
        private Label label6;
        private Button btnConsulta;

        public Consulta4()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dgvConsulta1 = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblRow = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsulta1
            // 
            this.dgvConsulta1.AllowUserToAddRows = false;
            this.dgvConsulta1.AllowUserToDeleteRows = false;
            this.dgvConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta1.Location = new System.Drawing.Point(12, 46);
            this.dgvConsulta1.Name = "dgvConsulta1";
            this.dgvConsulta1.ReadOnly = true;
            this.dgvConsulta1.RowTemplate.Height = 24;
            this.dgvConsulta1.Size = new System.Drawing.Size(546, 218);
            this.dgvConsulta1.TabIndex = 13;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(356, 280);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(202, 52);
            this.btnConsulta.TabIndex = 12;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(444, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(80, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(12, 300);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(0, 13);
            this.lblRow.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(366, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Recaudacion mensual por pelicula para el año:";
            // 
            // Consulta4
            // 
            this.ClientSize = new System.Drawing.Size(568, 340);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvConsulta1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Consulta4";
            this.Text = "Consulta 4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaDB con = new ConsultaDB();
            con.ejecutarConsulta("exec consulta4 " + dateTimePicker1.Text, 1);
            dgvConsulta1.DataSource = con.pGetTable;
            lblRow.Text = Convert.ToString(dgvConsulta1.RowCount) + " rows";
        }
    }
}
