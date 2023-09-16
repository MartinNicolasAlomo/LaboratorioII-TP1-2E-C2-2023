using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    public class SistemaUTN
    {
        #region CAMPOS
        private string nombre;
        private List<Estudiante> listaEstudiantes;
        private List<Administrador> listaAdministradores;
        private List<Profesor> listaProfesor;
        private List<Curso> listaCurso;



        #endregion



        #region CONSTRUCTOR
        //static SistemaUTN()
        //{
        //    listaEstudiantes = new List<Estudiante>();
        //    listaAdministradores = new List<Administrador>();
        //    listaProfesor = new List<Profesor>();
        //    listaCurso = new List<Curso>();
        //}



        #endregion



        #region PROPIEDADES
        public List<Estudiante> ListaEstudiantes
        {
            get { return listaEstudiantes; }
        }



        #endregion



        #region METODOS

        public static bool operator ==(SistemaUTN sistema, Estudiante estudianteRecibido)
        {
            if (sistema.listaEstudiantes.Count > 0 && estudianteRecibido is not null)
            {
                // Determinamos si este estudiante ya pertenece al sistema
                foreach (Estudiante estudianteAnalizado in sistema.listaEstudiantes)
                {
                    if (estudianteRecibido == estudianteAnalizado)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(SistemaUTN sistema, Estudiante estudiante)
        {
            return !(sistema == estudiante);
        }





        public static bool operator +(SistemaUTN sistema, Estudiante estudianteRecibido)
        {
            // Agrega el estudiante al registro, si este no existe
            // Evaluamos que el registro tenga espacios, y ademas, que el nuevo estudiante no exista en el registro
            if (sistema != estudianteRecibido)
            {
                sistema.listaEstudiantes.Add(estudianteRecibido);
                return true;
            }
            return false;
        }



        public static bool operator -(SistemaUTN sistema, Estudiante estudianteRecibido)
        {
            // Elimina el estudiante del registro, si este ya existe
            // Evaluamos que el registro tenga estudiantes, y ademas, que el estudiante ya exista dentro del registro
            if (sistema == estudianteRecibido)
            {
                sistema.listaEstudiantes.Remove(estudianteRecibido);
                return true;
            }
            return false;
        }

        public bool BuscarSiExisteEstudiante(Estudiante estudianteRecibido)
        {
            if (this == estudianteRecibido)
            {
                return true;
            }
            return false;
        }


        public bool AgregarEstudiante(Estudiante estudianteRecibido)
        {
            if (this + estudianteRecibido)
            {
                return true;
            }
            return false;
        }


        public bool EliminarEstudiante(Estudiante estudianteRecibido)
        {
            if (this - estudianteRecibido)
            {
                return true;
            }
            return false;
        }


        #endregion




    }
}
