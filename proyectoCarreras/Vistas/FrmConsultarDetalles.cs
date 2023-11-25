using proyectoCarreras.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoCarreras.Dominio;

namespace proyectoCarreras.Vistas
{
    public partial class FrmConsultarDetalles : Form
    {
        Carrera carrera;
        private AccesoBD accesoBD = new AccesoBD();

        public FrmConsultarDetalles()
        {
            carrera = new Carrera();
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea salir de la aplicación ?",
       "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        private void CargarCombo()
        {
            List<Carrera> lsta = new List<Carrera>();
            lsta = accesoBD.ConsultarCarreras();
            cboCarreras.DataSource = lsta;
            cboCarreras.ValueMember = "Id_carrera";
            cboCarreras.DisplayMember = "Nombre_Titulo";
            cboCarreras.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        private void FrmConsultarDetalles_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cboCarreras.SelectedIndex != -1)
            {
                int idCarrera = Convert.ToInt32(cboCarreras.SelectedValue);
                dgvConsultarDetalles.DataSource = accesoBD.ConsultarPlanCarrera(idCarrera);
            }
        }
    }
}
