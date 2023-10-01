using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    public sealed class Profesor : Usuario
    {
        #region CAMPOS
        protected static ushort ultimoLegajo;




        #endregion



        #region CONSTRUCTOR
        static Profesor()
        {
            ultimoLegajo = 1;
        }

        public Profesor(string nombres, string apellidos, string dni, DateTime fechaNacimiento, byte edad, string email, string telefono, string direccion)
                        : base(nombres, apellidos, dni, fechaNacimiento, edad, email, telefono, direccion)
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
