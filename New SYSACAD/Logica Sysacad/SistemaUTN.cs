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
        private static string? nombre;

        private static List<Administrador>? listaAdministradores;
        private static List<Usuario>? baseDatosUsuarios;
        private static List<Estudiante>? listaEstudiantes;
        private static List<Curso>? baseDatosCursos;


        public static List<Curso>? BaseDatosCursos
        {
            get { return baseDatosCursos; }
            set { baseDatosCursos = value; }
        }


        public static List<Estudiante>? ListaEstudiantes
        {
            get { return listaEstudiantes; }
            set { listaEstudiantes = value; }
        }

        public static List<Administrador>? ListaAdministradores
        {
            get { return listaAdministradores; }
            set { listaAdministradores = value; }
        }


        #endregion



        #region CONSTRUCTOR
        static SistemaUTN()
        {
            HardcodearUsuarios();
            HardcodearCursos();
            HardcodearAdministradores();
        }

        private static void HardcodearUsuarios()
        {
            baseDatosUsuarios = new List<Usuario>
            {
                new Administrador("Julieta", "Díaz", "30303030", new DateTime(1983,4,27), 40, "jdiaz@utn.com", "40401122", "Av. Mitre 2005"),
                new Administrador("Romina", "Gomez", "30777111", new DateTime(1983,4,27), 40,"rgomez@utn.com", "40404477", "Av. Belgrano 448"),
                new Administrador("Mariano", "González", "35003992", new DateTime(1983,4,27), 40,"mgonzalez@utn.com", "40401010", "Av. Calchaquí 307"),
                new Estudiante("Juan", "García", "45333789", new DateTime(1996,12,29), 27,"jgarcia@gmail.com", "25308811", "Gral. Deheza 651"),
                new Estudiante("Martín Nicolás", "Alomo", "40916734", new DateTime(1998,1,7), 25,"ma@gmail.com", "42461213", "Corvalan 435")
            };
        }

        private static void HardcodearCursos()
        {
            Profesor profe1 = new Profesor("Mario", "Rampi", "33222444", new DateTime(1983, 4, 27), 40, "mrampi@utn.com", "40406060", "Mitre 205");
            baseDatosCursos = new List<Curso>
            {
                new Curso("3°D","Programación III",50,Turno.Noche, Dia.Lunes, "215","18:30 - 22:30"),
                new Curso("3°D","Laboratorio III",50,Turno.Noche, Dia.Martes, "212","18:30 - 22:30"),
                new Curso("3°D","Org. Contable",50,Turno.Noche, Dia.Miércoles, "201","18:30 - 22:30"),
                new Curso("3°D","Org. Empresarial",50,Turno.Noche, Dia.Jueves, "207","18:30 - 22:30"),
                new Curso("3°D","Inv. Operativa",50,Turno.Noche, Dia.Viernes, "210","18:30 - 22:30"),
            };


        }

        private static void HardcodearAdministradores()
        {
            listaAdministradores = new List<Administrador>();
            foreach (Usuario usuario in baseDatosUsuarios)
            {
                if (usuario.GetType() == typeof(Administrador))
                {
                    listaAdministradores.Add((Administrador)usuario);
                }
            }

        }


        private static void HardcodearEstudiantes()
        {
            listaEstudiantes = new List<Estudiante>();
            foreach (Usuario usuario in baseDatosUsuarios)
            {
                if (usuario.GetType() == typeof(Estudiante))
                {
                    listaEstudiantes.Add((Estudiante)usuario);
                }
            }
        }



        #endregion



        #region PROPIEDADES
        public static List<Usuario>? BaseDatosUsuarios
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
            if (baseDatosUsuarios?.Count > 0 && estudianteRecibido is not null)
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

        public static bool EncontrarCursoRegistrado(Curso cursoRecibido)
        {
            if (baseDatosCursos?.Count > 0 && cursoRecibido is not null)
            {
                foreach (Curso cursoAnalizado in baseDatosCursos)
                {
                    if (1 > 10
                        //cursoAnalizado.Codigo == cursoRecibido.Codigo && cursoAnalizado.Nombre == cursoRecibido.Nombre
                        )
                    {
                        return true;
                    }
                }
            }
            return false;
        }



        public static string MostrarCursos()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Curso item in baseDatosCursos)
            {
                if (item is not null)
                {
                    sb.AppendLine(item.Mostrar());
                }
            }

            return sb.ToString();
        }



        #endregion




    }
}
