﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    public class Administrador : Usuario
    {
        #region CAMPOS


        #endregion



        #region CONSTRUCTOR
        public Administrador(string nombres, string apellidos, string dni, DateTime fechaNacimiento, string correoElectronico, string telefono, string direccion)
                            : base(nombres, apellidos, dni, fechaNacimiento, correoElectronico, telefono, direccion)
        {

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
                //   crear clase SISTEMAUTN

                // si admin, acepta datos, los guarda
                //  SistemaUTN.ListaEstudiantes.add(estudiante)

                // luego, envia mail al estudiante con la confirmacion


            }
        }



        #endregion

    }
}
