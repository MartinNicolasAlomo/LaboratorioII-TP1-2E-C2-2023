using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    public class Estudiante : Usuario
    {

        #region CAMPOS
        protected static ushort ultimoLegajo;




        #endregion



        #region CONSTRUCTOR
        static Estudiante()
        {
            ultimoLegajo = 1;       //Este codigo se ejecuta SOLO UNA VEZ y nos sirve de punto de partida
        }

        public Estudiante(string nombres, string apellidos, string dni, //DateTime fechaNacimiento, 
                           string correoElectronico, string telefono, string direccion) : 
                            base(nombres, apellidos, dni, //fechaNacimiento, 
                                correoElectronico, telefono, direccion)
        {
            legajo = ultimoLegajo;
            ultimoLegajo++;
        }



        #endregion



        #region PROPIEDADES




        #endregion



        #region METODOS
        public static bool operator ==(Estudiante estudiante1, Estudiante estudiante2)
        {
            if (estudiante1 is not null && estudiante2 is not null)
            {
                return estudiante1.legajo == estudiante2.legajo && estudiante1.dni == estudiante2.dni && estudiante1.email == estudiante2.email;
            }
            return false;
        }

        public static bool operator !=(Estudiante estudiante1, Estudiante estudiante2)
        {
            return !(estudiante1 == estudiante2);
        }






        #endregion




    }

}
