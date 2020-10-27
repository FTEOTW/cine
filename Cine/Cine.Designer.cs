namespace Cine
{
    partial class Cine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConsulta1 = new System.Windows.Forms.Button();
            this.panelC1 = new System.Windows.Forms.Panel();
            this.btnConsulta2 = new System.Windows.Forms.Button();
            this.dgvConsulta1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.panelC1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta1
            // 
            this.btnConsulta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta1.Location = new System.Drawing.Point(12, 34);
            this.btnConsulta1.Name = "btnConsulta1";
            this.btnConsulta1.Size = new System.Drawing.Size(196, 117);
            this.btnConsulta1.TabIndex = 0;
            this.btnConsulta1.Text = "Consulta 1";
            this.btnConsulta1.UseVisualStyleBackColor = true;
            this.btnConsulta1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelC1
            // 
            this.panelC1.Controls.Add(this.dateTimePicker1);
            this.panelC1.Controls.Add(this.btnConsulta);
            this.panelC1.Location = new System.Drawing.Point(279, 350);
            this.panelC1.Name = "panelC1";
            this.panelC1.Size = new System.Drawing.Size(763, 177);
            this.panelC1.TabIndex = 1;
            this.panelC1.Visible = false;
            this.panelC1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelC1_Paint);
            // 
            // btnConsulta2
            // 
            this.btnConsulta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta2.Location = new System.Drawing.Point(12, 173);
            this.btnConsulta2.Name = "btnConsulta2";
            this.btnConsulta2.Size = new System.Drawing.Size(196, 117);
            this.btnConsulta2.TabIndex = 2;
            this.btnConsulta2.Text = "Consulta 2";
            this.btnConsulta2.UseVisualStyleBackColor = true;
            this.btnConsulta2.Click += new System.EventHandler(this.btnConsulta2_Click);
            // 
            // dgvConsulta1
            // 
            this.dgvConsulta1.AllowUserToAddRows = false;
            this.dgvConsulta1.AllowUserToDeleteRows = false;
            this.dgvConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta1.Location = new System.Drawing.Point(279, 34);
            this.dgvConsulta1.Name = "dgvConsulta1";
            this.dgvConsulta1.ReadOnly = true;
            this.dgvConsulta1.RowTemplate.Height = 24;
            this.dgvConsulta1.Size = new System.Drawing.Size(763, 256);
            this.dgvConsulta1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(80, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(451, 82);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(202, 52);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // Cine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvConsulta1);
            this.Controls.Add(this.btnConsulta2);
            this.Controls.Add(this.panelC1);
            this.Controls.Add(this.btnConsulta1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cine";
            this.Text = "Cine";
            this.panelC1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta1;
        private System.Windows.Forms.Panel panelC1;
        private System.Windows.Forms.Button btnConsulta2;
        private System.Windows.Forms.DataGridView dgvConsulta1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnConsulta;
    }
}

