using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    public static class SistemaUTN
    {
        #region CAMPOS
        private static string nombre;

        //private static List<Estudiante> listaEstudiantes;
        //private static List<Administrador> listaAdministradores;
        //private static List<Profesor> listaProfesor;
        private static List<Usuario> baseDatosUsuarios;
        private static List<Curso> listaCurso;



        #endregion



        #region CONSTRUCTOR
        static SistemaUTN()
        {
            HardcodearUsuarios();
        }

        private static void HardcodearUsuarios()
        {
            baseDatosUsuarios = new List<Usuario>
            {
                new Administrador("Julieta", "Pérez", "30321654", "jperez@utn.com", "40401122", "Av. Mitre 2005"),
                new Administrador("Romina", "Gomez", "30777111", "rgomez@utn.com", "40404477", "Av. Belgrano 448"),
                new Administrador("Mariano", "Díaz", "35003992", "mdiaz@utn.com", "40401010", "Av. Calchaquí 307"),
                new Estudiante("Juan", "García", "45333789", "jgarcia@gmail.com", "25308811", "Gral. Deheza 651"),
                new Estudiante("Martín Nicolás", "Alomo", "40916734", "ma@gmail.com", "42461213", "Corvalan 435")
        };


        }


        #endregion



        #region PROPIEDADES
        public static List<Usuario> BaseDatosUsuarios
        {
            get { return baseDatosUsuarios; }
        }



        #endregion



        #region METODOS


        //public static bool operator ==(SistemaUTN sistema, Estudiante estudianteRecibido)
        //{
        //    if (sistema.listaEstudiantes.Count > 0 && estudianteRecibido is not null)
        //    {
        //        // Determinamos si este estudiante ya pertenece al sistema
        //        foreach (Estudiante estudianteAnalizado in sistema.listaEstudiantes)
        //        {
        //            if (estudianteRecibido == estudianteAnalizado)
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}

        //public static bool operator !=(SistemaUTN sistema, Estudiante estudiante)
        //{
        //    return !(sistema == estudiante);
        //}





        //public static bool operator +(SistemaUTN sistema, Estudiante estudianteRecibido)
        //{
        //    // Agrega el estudiante al registro, si este no existe
        //    // Evaluamos que el registro tenga espacios, y ademas, que el nuevo estudiante no exista en el registro
        //    if (sistema != estudianteRecibido)
        //    {
        //        sistema.listaEstudiantes.Add(estudianteRecibido);
        //        return true;
        //    }
        //    return false;
        //}



        //public static bool operator -(SistemaUTN sistema, Estudiante estudianteRecibido)
        //{
        //    // Elimina el estudiante del registro, si este ya existe
        //    // Evaluamos que el registro tenga estudiantes, y ademas, que el estudiante ya exista dentro del registro
        //    if (sistema == estudianteRecibido)
        //    {
        //        sistema.listaEstudiantes.Remove(estudianteRecibido);
        //        return true;
        //    }
        //    return false;
        //}

        //public static bool BuscarSiExisteEstudiante(Estudiante estudianteRecibido)
        //{
        //    if (this == estudianteRecibido)
        //    {
        //        return true;
        //    }
        //    return false;
        //}


        //public static bool AgregarEstudiante(Estudiante estudianteRecibido)
        //{
        //    if (this + estudianteRecibido)
        //    {
        //        return true;
        //    }
        //    return false;
        //}


        //public static bool EliminarEstudiante(Estudiante estudianteRecibido)
        //{
        //    if (this - estudianteRecibido)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        public static bool EncontrarEstudianteRegistrado(Estudiante estudianteRecibido)
        {
            if (baseDatosUsuarios.Count > 0 && estudianteRecibido is not null)
            {
                foreach (Usuario usuarioAnalizado in baseDatosUsuarios)
                {
                    if (usuarioAnalizado.GetType() == typeof(Estudiante) && (usuarioAnalizado.DNI == estudianteRecibido.DNI || usuarioAnalizado.Email == estudianteRecibido.Email))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool VerificarEsUsuarioValido(string usuarioIngresado, string claveIngresada)
        {
            foreach (Usuario usuarioEncontrado in baseDatosUsuarios)
            {
                if (usuarioEncontrado.ComprobarUsuario(usuarioIngresado, claveIngresada))
                {
                    return true;
                }
            }
            return false;
        }

        public static Usuario? ObtenerUsuario(string usuarioIngresado, string claveIngresada)
        {
            foreach (Usuario usuarioEncontrado in baseDatosUsuarios)
            {
                if (usuarioEncontrado.ComprobarUsuario(usuarioIngresado, claveIngresada))
                {
                    return usuarioEncontrado;
                }
            }
            return null;
        }




        #endregion




    }
}
