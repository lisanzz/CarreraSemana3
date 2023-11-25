namespace proyectoCarreras.Vistas
{
    partial class FrmConsultarDetalles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblConsultarDetalles = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.cboCarreras = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvConsultarDetalles = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultarDetalles
            // 
            this.lblConsultarDetalles.AutoSize = true;
            this.lblConsultarDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarDetalles.Location = new System.Drawing.Point(267, 23);
            this.lblConsultarDetalles.Name = "lblConsultarDetalles";
            this.lblConsultarDetalles.Size = new System.Drawing.Size(209, 29);
            this.lblConsultarDetalles.TabIndex = 1;
            this.lblConsultarDetalles.Text = "Consultar Detalles";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(76, 81);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(172, 20);
            this.lblCarrera.TabIndex = 4;
            this.lblCarrera.Text = "Seleccione una carrera";
            // 
            // cboCarreras
            // 
            this.cboCarreras.FormattingEnabled = true;
            this.cboCarreras.Location = new System.Drawing.Point(80, 122);
            this.cboCarreras.Name = "cboCarreras";
            this.cboCarreras.Size = new System.Drawing.Size(168, 21);
            this.cboCarreras.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(601, 121);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(121, 21);
            this.btnConsultar.TabIndex = 17;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvConsultarDetalles
            // 
            this.dgvConsultarDetalles.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvConsultarDetalles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultarDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultarDetalles.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvConsultarDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarDetalles.Location = new System.Drawing.Point(80, 167);
            this.dgvConsultarDetalles.Name = "dgvConsultarDetalles";
            this.dgvConsultarDetalles.Size = new System.Drawing.Size(642, 205);
            this.dgvConsultarDetalles.TabIndex = 18;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalir.Location = new System.Drawing.Point(601, 395);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 31);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmConsultarDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvConsultarDetalles);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cboCarreras);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblConsultarDetalles);
            this.Name = "FrmConsultarDetalles";
            this.Text = "FrmConsultarDetalles";
            this.Load += new System.EventHandler(this.FrmConsultarDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultarDetalles;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.ComboBox cboCarreras;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvConsultarDetalles;
        private System.Windows.Forms.Button btnSalir;
    }
}