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
    public partial class FrmConsultarCarreras : Form
    {
        private AccesoBD accesoBD = new AccesoBD();
        public FrmConsultarCarreras()
        {
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
        private void cboCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmConsultarCarreras_Load(object sender, EventArgs e)
        {
            CargarCombo();



        }

        public void Limpiar()
        {

            dgvConsultarCarreras.Rows.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Carrera c = (Carrera)cboCarreras.SelectedItem;


            foreach (DataGridViewRow fila in dgvConsultarCarreras.Rows)
            {
                if (c.Id_carrera == Convert.ToInt32(fila.Cells["ColID"].Value))
                {
                    MessageBox.Show("Ya consulto esta carrera");
                    return;
                }

            }


            int Id_Carrera = Convert.ToInt32(c.Id_carrera);
            string Nombre_Titulo = c.Nombre_Titulo;


            dgvConsultarCarreras.Rows.Add(Id_Carrera, Nombre_Titulo);


        }

        private void dgvConsultarCarreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarCarreras.CurrentCell.ColumnIndex == 2)
            {
                int idCarrera = Convert.ToInt32(dgvConsultarCarreras.CurrentRow.Cells["ColID"].Value.ToString());

                DialogResult result = MessageBox.Show("¿Está seguro que quiere eliminar la carrera?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    if (accesoBD.EliminarCarrera(idCarrera))
                    {
                        CargarCombo();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la carrera.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
       
}

