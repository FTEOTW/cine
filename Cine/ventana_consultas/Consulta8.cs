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
        private Button btnConsulta;

        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDuracionPeliculaDesde = new System.Windows.Forms.TextBox();
            this.txtDuracionPeliculaHasta = new System.Windows.Forms.TextBox();
            this.lblConsulta2 = new System.Windows.Forms.Label();
            this.dgvConsulta1 = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Duracion pelicula hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Duracion pelicula desde";
            // 
            // txtDuracionPeliculaDesde
            // 
            this.txtDuracionPeliculaDesde.Location = new System.Drawing.Point(422, 75);
            this.txtDuracionPeliculaDesde.Name = "txtDuracionPeliculaDesde";
            this.txtDuracionPeliculaDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDuracionPeliculaDesde.TabIndex = 26;
            // 
            // txtDuracionPeliculaHasta
            // 
            this.txtDuracionPeliculaHasta.Location = new System.Drawing.Point(564, 75);
            this.txtDuracionPeliculaHasta.Name = "txtDuracionPeliculaHasta";
            this.txtDuracionPeliculaHasta.Size = new System.Drawing.Size(100, 20);
            this.txtDuracionPeliculaHasta.TabIndex = 25;
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
            // Consulta8
            // 
            this.ClientSize = new System.Drawing.Size(688, 417);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDuracionPeliculaDesde);
            this.Controls.Add(this.txtDuracionPeliculaHasta);
            this.Controls.Add(this.lblConsulta2);
            this.Controls.Add(this.dgvConsulta1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Consulta8";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaDB con = new ConsultaDB();
            // con.ejecutarConsulta("exec consulta8 "  + , 1); //TODO  Parametrizacion consulta 8

            dgvConsulta1.DataSource = con.pGetTable;
        }
    }
}
