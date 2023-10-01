using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    public sealed class Estudiante : Usuario
    {
        public enum CarrerasUTN
        {
            TecnicaturaProgramacion,
            TecnicaturaIngenieroSistemas
        }

        #region CAMPOS
        protected static ushort ultimoLegajo;
        //        protected CarrerasUTN carrera;
        public List<Curso>? cursosInscriptos;


        #endregion



        #region CONSTRUCTOR
        static Estudiante()
        {
            ultimoLegajo = 3;//      1;           //  EL ULTIMO LEGAJO ESTA EN LA BASE DE DATOS
        }

        public Estudiante(string nombres, string apellidos, string dni, DateTime fechaNacimiento, byte edad, string email, string telefono, string direccion)
                          : base(nombres, apellidos, dni, fechaNacimiento, edad, email, telefono, direccion)
        {
            legajo = 0;
            //, CarrerasUTN carrera = CarrerasUTN.TecnicaturaProgramacion
            //this.carrera = carrera;
        }

        public Estudiante(string nombres, string apellidos, string dni, DateTime fechaNacimiento, byte edad, string email, string clave, string telefono, string direccion)
                  : this(nombres, apellidos, dni, fechaNacimiento, edad, email, telefono, direccion)
        {
            this.clave = clave;
            //, CarrerasUTN carrera = CarrerasUTN.TecnicaturaProgramacion
        }

        public void AsignarNumeroLegajo()
        {
            legajo = ultimoLegajo;
            ultimoLegajo++;
        }


        #endregion



        #region PROPIEDADES





        #endregion



        #region METODOS




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
