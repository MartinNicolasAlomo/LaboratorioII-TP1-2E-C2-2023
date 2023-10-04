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
        private static List<Servicio>? listaServicios;
        private static List<Curso>? baseDatosCursos;


        public static List<Curso>? BaseDatosCursos
        {
            get { return baseDatosCursos; }
            set { baseDatosCursos = value; }
        }

        public static List<Servicio>? ListaServicios
        {
            get { return listaServicios; }
            set { listaServicios = value; }
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
            //HardcodearServicios();
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
            baseDatosCursos = new List<Curso>
            {
                new Curso("3°","D", "Programación III", "Noche", "Lunes", "18:30 - 22:30", "215", 50, 50),
                new Curso("3°","D","Laboratorio III", "Noche", "Martes", "18:30 - 22:30", "212", 50, 50),
                new Curso("3°","D", "Org. Contable", "Noche", "Miércoles", "18:30 - 22:30", "201", 50, 50),
                new Curso("3°","D", "Org. Empresarial", "Noche", "Jueves", "18:30 - 22:30", "207", 50, 50),
                new Curso("3°","D", "Elem. de Invest. Operativa", "Noche", "Viernes", "18:30 - 22:30", "210", 50, 50),
            };
        }

        //private static void HardcodearServicios()
        //{
        //    listaServicios = new List<Servicio>
        //    {
        //        new Servicio("Matrícula",7000,1),
        //        new Servicio("Cuotas Mensuales", 18000, 12),
        //        new Servicio("Cargos Administrativos",1500, 12),
        //        new Servicio("Libros de Texto",2000,6)
        //    };
        //}


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
                    sb.AppendLine(item.MostrarDatos());
                }
            }

            return sb.ToString();
        }



        #endregion




    }
}
