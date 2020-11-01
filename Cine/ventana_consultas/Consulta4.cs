using Cine.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.ventana_consultas
{
    class Consulta4 : Form
    {
        private Label lblConsulta2;
        private DataGridView dgvConsulta1;
        private DateTimePicker dateTimePicker1;
        private Label lblRow;
        private Button btnConsulta;

        public Consulta4()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblConsulta2 = new System.Windows.Forms.Label();
            this.dgvConsulta1 = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblRow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsulta2
            // 
            this.lblConsulta2.AutoSize = true;
            this.lblConsulta2.Location = new System.Drawing.Point(12, 10);
            this.lblConsulta2.Name = "lblConsulta2";
            this.lblConsulta2.Size = new System.Drawing.Size(242, 13);
            this.lblConsulta2.TabIndex = 15;
            this.lblConsulta2.Text = "Recaudación mensual, por pelicula, para el X año";
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
            // Consulta4
            // 
            this.ClientSize = new System.Drawing.Size(568, 340);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblConsulta2);
            this.Controls.Add(this.dgvConsulta1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Consulta4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
