using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCarreras.Dominio
{
    public class Carrera
    {
        private int Id_Carrera;
        private string NombreTitulo;
        private List<DetalleCarrera> detallesCarrera = new List<DetalleCarrera>();

        public int Id_carrera
        {
            get { return Id_Carrera; }
            set { Id_Carrera = value; }
        }

        public string Nombre_Titulo
        {
            get { return NombreTitulo; }
            set { NombreTitulo = value; }
        }

        public List<DetalleCarrera> DetallesCarrera
        {
            get { return detallesCarrera; }
            set { detallesCarrera = value; }
        }


        public Carrera(int id_carrera, string nombreTitulo) 
        { 
           Id_Carrera = id_carrera;
           NombreTitulo = nombreTitulo;
            
        
        
        
        }
        public Carrera()
        {
            Id_Carrera = 0;
            NombreTitulo = string.Empty;
            detallesCarrera = new List<DetalleCarrera>() { };



        }





        public override string ToString()
        {
            return "Nombre de Carrera: " + NombreTitulo;
        }

        public void AgregarDetalle(DetalleCarrera detalle)
        {
            detallesCarrera.Add(detalle);
        }

        public void EliminarDetalle(int id)
        {
            detallesCarrera.RemoveAt(id);
        }
    }
}
