using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    public class Administrador : Usuario
    {
        #region CAMPOS
        protected static ushort ultimoLegajo;


        #endregion



        #region CONSTRUCTOR
        static Administrador()
        {
            ultimoLegajo = 1;       //Este codigo se ejecuta SOLO UNA VEZ y nos sirve de punto de partida
        }

        public Administrador(string nombres, string apellidos, string dni, //DateTime fechaNacimiento, 
                             string correoElectronico, string telefono, string direccion)
                            : base(nombres, apellidos, dni, //fechaNacimiento, 
                                  correoElectronico, telefono, direccion)
        {
            legajo = ultimoLegajo;
            ultimoLegajo++;
        }



        #endregion



        #region PROPIEDADES




        #endregion



        #region METODOS
        public void IngresarEstudiante(Estudiante estudiante)
        {
            if (estudiante is not null //   &&  todos los datos estan bien
                )
            {
                //                .AppendLine($"Informacion Usuario:")

                //   crear clase SISTEMAUTN

                // si admin, acepta datos, los guarda
                //  SistemaUTN.ListaEstudiantes.add(estudiante)

                // luego, envia mail al estudiante con la confirmacion


            }
        }

        //                .AppendLine($"Informacion Usuario:")




        #endregion

    }
}
