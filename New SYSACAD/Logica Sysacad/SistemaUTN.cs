using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    public static class SistemaUTN
    {
        private static string? nombre;
        private static List<Administrador>? listaAdministradores;
        private static List<Usuario>? baseDatosUsuarios;
        private static List<Estudiante>? listaEstudiantes;
        private static List<Servicio>? listaServicios;
        private static List<Curso>? baseDatosCursos;


        static SistemaUTN()
        {
            HardcodearUsuarios();
            HardcodearCursos();
            HardcodearAdministradores();
            HardcodearEstudiantes();
        }


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
                new Curso("185","1°","H", Curso.SistemaProcesamientoDatos,"Noche", "Lunes", "18:30 - 22:30", "215", 50),
                new Curso("213","2°","A", Curso.Estadistica, "Mañana", "Lunes", "18:30 - 22:30", "215", 50),
                new Curso("434","4°","C", Curso.Legislacion, "Tarde", "Lunes", "18:30 - 22:30", "215", 50),
                new Curso("341","3°","D", Curso.ProgramacionIII, "Noche", "Lunes", "18:30 - 22:30", "203", 50),
                new Curso("342","3°","D", Curso.LaboratorioIII, "Noche", "Martes", "18:30 - 22:30", "212", 50),
                new Curso("343","3°","D", Curso.OrganizacionContable, "Noche", "Miércoles", "18:30 - 22:30", "201", 50),
                new Curso("344","3°","D", Curso.OrganizacionEmpresarial, "Noche", "Jueves", "18:30 - 22:30", "207", 50),
                new Curso("345","3°","D", Curso.ElementosInvestigacionOperativa, "Noche", "Viernes", "18:30 - 22:30", "210", 50),
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
            foreach (Estudiante estudiante in listaEstudiantes)
            {
                estudiante.AsignarNumeroLegajo();
            }
        }

        public static List<Usuario>? BaseDatosUsuarios
        {
            get { return baseDatosUsuarios; }
        }


        public static bool EncontrarEstudianteRegistrado(Estudiante estudianteRecibido)
        {
            if (baseDatosUsuarios?.Count > 0 && estudianteRecibido is not null)
            {
                foreach (Estudiante estudianteAnalizado in listaEstudiantes)
                {
                    if (estudianteAnalizado == estudianteRecibido)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static Usuario? ObtenerUsuario(string emailIngresado, string claveIngresada)
        {
            foreach (Usuario usuarioEncontrado in baseDatosUsuarios)
            {
                if (usuarioEncontrado.ComprobarUsuario(emailIngresado, claveIngresada))
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
                    if (cursoAnalizado == cursoRecibido)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
