namespace proyectoCarreras.Vistas
{
    partial class FrmConsultarCarreras
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
            this.lblConsultarCarreras = new System.Windows.Forms.Label();
            this.cboCarreras = new System.Windows.Forms.ComboBox();
            this.dgvConsultarCarreras = new System.Windows.Forms.DataGridView();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultarCarreras
            // 
            this.lblConsultarCarreras.AutoSize = true;
            this.lblConsultarCarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarCarreras.Location = new System.Drawing.Point(315, 25);
            this.lblConsultarCarreras.Name = "lblConsultarCarreras";
            this.lblConsultarCarreras.Size = new System.Drawing.Size(214, 29);
            this.lblConsultarCarreras.TabIndex = 0;
            this.lblConsultarCarreras.Text = "Consultar Carreras";
            // 
            // cboCarreras
            // 
            this.cboCarreras.FormattingEnabled = true;
            this.cboCarreras.Location = new System.Drawing.Point(90, 126);
            this.cboCarreras.Name = "cboCarreras";
            this.cboCarreras.Size = new System.Drawing.Size(168, 21);
            this.cboCarreras.TabIndex = 1;
            this.cboCarreras.SelectedIndexChanged += new System.EventHandler(this.cboCarreras_SelectedIndexChanged);
            // 
            // dgvConsultarCarreras
            // 
            this.dgvConsultarCarreras.AllowUserToAddRows = false;
            this.dgvConsultarCarreras.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvConsultarCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarCarreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNombre,
            this.ColEliminar});
            this.dgvConsultarCarreras.Location = new System.Drawing.Point(90, 163);
            this.dgvConsultarCarreras.Name = "dgvConsultarCarreras";
            this.dgvConsultarCarreras.Size = new System.Drawing.Size(642, 205);
            this.dgvConsultarCarreras.TabIndex = 2;
            this.dgvConsultarCarreras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarCarreras_CellContentClick);
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(86, 90);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(172, 20);
            this.lblCarrera.TabIndex = 3;
            this.lblCarrera.Text = "Seleccione una carrera";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalir.Location = new System.Drawing.Point(611, 396);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 31);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(611, 126);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(121, 21);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // ColID
            // 
            this.ColID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColID.HeaderText = "ID Carrera";
            this.ColID.Name = "ColID";
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombre.HeaderText = "Nombre carrera";
            this.ColNombre.Name = "ColNombre";
            // 
            // ColEliminar
            // 
            this.ColEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEliminar.HeaderText = "Eliminar";
            this.ColEliminar.Name = "ColEliminar";
            this.ColEliminar.Text = "Eliminar";
            this.ColEliminar.UseColumnTextForButtonValue = true;
            // 
            // FrmConsultarCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.dgvConsultarCarreras);
            this.Controls.Add(this.cboCarreras);
            this.Controls.Add(this.lblConsultarCarreras);
            this.Name = "FrmConsultarCarreras";
            this.Text = "FrmConsultarCarreras";
            this.Load += new System.EventHandler(this.FrmConsultarCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCarreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultarCarreras;
        private System.Windows.Forms.ComboBox cboCarreras;
        private System.Windows.Forms.DataGridView dgvConsultarCarreras;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewButtonColumn ColEliminar;
    }
}