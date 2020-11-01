using Cine.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.ventana_consultas
{
    class Consulta8 : Form
    {
        private Label label3;
        private Label label1;
        private TextBox txtDuracionPeliculaDesde;
        private TextBox txtDuracionPeliculaHasta;
        private Label lblConsulta2;
        private DataGridView dgvConsulta1;
        private Label lblRow;
        private Button btnConsulta;

        public Consulta8()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDuracionPeliculaDesde = new System.Windows.Forms.TextBox();
            this.txtDuracionPeliculaHasta = new System.Windows.Forms.TextBox();
            this.lblConsulta2 = new System.Windows.Forms.Label();
            this.dgvConsulta1 = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblRow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Duracion hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Duracion  desde";
            // 
            // txtDuracionPeliculaDesde
            // 
            this.txtDuracionPeliculaDesde.Location = new System.Drawing.Point(137, 41);
            this.txtDuracionPeliculaDesde.Name = "txtDuracionPeliculaDesde";
            this.txtDuracionPeliculaDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDuracionPeliculaDesde.TabIndex = 26;
            this.txtDuracionPeliculaDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuracionPeliculaDesde_KeyPress);
            // 
            // txtDuracionPeliculaHasta
            // 
            this.txtDuracionPeliculaHasta.Location = new System.Drawing.Point(137, 71);
            this.txtDuracionPeliculaHasta.Name = "txtDuracionPeliculaHasta";
            this.txtDuracionPeliculaHasta.Size = new System.Drawing.Size(100, 20);
            this.txtDuracionPeliculaHasta.TabIndex = 25;
            this.txtDuracionPeliculaHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuracionPeliculaHasta_KeyPress);
            // 
            // lblConsulta2
            // 
            this.lblConsulta2.AutoSize = true;
            this.lblConsulta2.Location = new System.Drawing.Point(9, 9);
            this.lblConsulta2.Name = "lblConsulta2";
            this.lblConsulta2.Size = new System.Drawing.Size(572, 13);
            this.lblConsulta2.TabIndex = 24;
            this.lblConsulta2.Text = "Se quiere saber la cantidad de Peliculas y la fecha de la primera y última Pelicu" +
    "la por actor y director , para peliculas con";
            // 
            // dgvConsulta1
            // 
            this.dgvConsulta1.AllowUserToAddRows = false;
            this.dgvConsulta1.AllowUserToDeleteRows = false;
            this.dgvConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta1.Location = new System.Drawing.Point(12, 101);
            this.dgvConsulta1.Name = "dgvConsulta1";
            this.dgvConsulta1.ReadOnly = true;
            this.dgvConsulta1.RowTemplate.Height = 24;
            this.dgvConsulta1.Size = new System.Drawing.Size(652, 218);
            this.dgvConsulta1.TabIndex = 23;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(462, 353);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(202, 52);
            this.btnConsulta.TabIndex = 22;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(12, 373);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(0, 13);
            this.lblRow.TabIndex = 29;
            // 
            // Consulta8
            // 
            this.ClientSize = new System.Drawing.Size(688, 417);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDuracionPeliculaDesde);
            this.Controls.Add(this.txtDuracionPeliculaHasta);
            this.Controls.Add(this.lblConsulta2);
            this.Controls.Add(this.dgvConsulta1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Consulta8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta 8";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaDB con = new ConsultaDB();
            if (String.IsNullOrEmpty(txtDuracionPeliculaDesde.Text) || String.IsNullOrEmpty(txtDuracionPeliculaHasta.Text))
            {
                MessageBox.Show("El valor del campo no debe estar vacio");
            }
            else
            {
                con.ejecutarConsulta("exec consulta8 " + txtDuracionPeliculaDesde.Text + ", " + txtDuracionPeliculaHasta.Text, 1); //TODO  Parametrizacion consulta 8
                dgvConsulta1.DataSource = con.pGetTable;
                lblRow.Text = Convert.ToString(dgvConsulta1.RowCount) + " rows";
            }
        }

        private void txtDuracionPeliculaDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDuracionPeliculaHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
