using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    public class Profesor : Usuario
    {
        #region CAMPOS
        protected static ushort ultimoLegajo;




        #endregion



        #region CONSTRUCTOR
        static Profesor()
        {
            ultimoLegajo = 1;
        }

        public Profesor(string nombres, string apellidos, string dni, DateTime fechaNacimiento, string correoElectronico, string telefono, string direccion) : base(nombres, apellidos, dni, fechaNacimiento, correoElectronico, telefono, direccion)
        {
            legajo = ultimoLegajo;
            ultimoLegajo++;

        }


        #endregion



        #region PROPIEDADES




        #endregion



        #region METODOS




        #endregion
    }
}
