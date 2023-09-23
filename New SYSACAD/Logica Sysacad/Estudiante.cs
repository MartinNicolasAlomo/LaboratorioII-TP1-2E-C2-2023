using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    public class Estudiante : Usuario
    {
        public enum CarrerasUTN
        {
            TecnicaturaProgramacion,
            TecnicaturaIngenieroSistemas
        }

        #region CAMPOS
        protected static ushort ultimoLegajo;
        protected DateTime fechaNacimiento;
        protected CarrerasUTN carrera;



        #endregion



        #region CONSTRUCTOR
        static Estudiante()
        {
            ultimoLegajo = 3;//      1;           //  EL ULTIMO LEGAJO ESTA EN LA BASE DE DATOS
        }

        public Estudiante(string nombres, string apellidos, string dni, string correoElectronico,
                          string telefono, string direccion, DateTime fechaNacimiento, CarrerasUTN carrera = CarrerasUTN.TecnicaturaProgramacion)
                          : base(nombres, apellidos, dni, correoElectronico, telefono, direccion)
        {
            legajo = 0;
            this.fechaNacimiento = fechaNacimiento;
            this.carrera = carrera;
        }

        public void AsignarNumeroLegajo()
        {
            legajo = ultimoLegajo;
            ultimoLegajo++;
        }



        #endregion



        #region PROPIEDADES

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
        }




        #endregion



        #region METODOS

        public bool RegistrarEstudianteIngresado()
        {
            if (!SistemaUTN.EncontrarEstudianteRegistrado(this))
            {
                AsignarNumeroLegajo();
                return true;
            }
            return false;
        }



        //public static bool operator ==(Estudiante estudiante1, Estudiante estudiante2)
        //{
        //    if (estudiante1 is not null && estudiante2 is not null)
        //    {
        //        return estudiante1.legajo == estudiante2.legajo && estudiante1.dni == estudiante2.dni && estudiante1.email == estudiante2.email;
        //    }
        //    return false;
        //}

        //public static bool operator !=(Estudiante estudiante1, Estudiante estudiante2)
        //{
        //    return !(estudiante1 == estudiante2);
        //}






        #endregion




    }

}
