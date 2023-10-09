using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    //public enum Turno
    //{
    //    Mañana,
    //    Tarde,
    //    Noche
    //}

    //public enum Dia
    //{
    //    Lunes,
    //    Martes,
    //    Miércoles,
    //    Jueves,
    //    Viernes
    //}

    //public enum Division
    //{
    //    A,
    //    B,
    //    C,
    //    D,
    //    E,
    //    F,
    //    G,
    //    H,
    //}

    public class Curso
    {
        public const string ProgramacionI = "Programación I";
        public const string LaboratorioI = "Laboratorio I";
        public const string Matematica = "Matématica";
        public const string SistemaProcesamientoDatos = "Sistema de Procesamiento de Datos";
        public const string InglesI = "Inglés I";

        public const string ProgramacionII = "Programación II";
        public const string LaboratorioII = "Laboratorio II";
        public const string Estadistica = "Estadística";
        public const string ArquitecturaYSistemasOperativos = "Arquitectura Y Sistemas Operativos";
        public const string InglesII = "Inglés II";
        public const string MetodologiaInvestigación = "Metódologia de la Investigación";

        public const string ProgramacionIII = "Programación III";
        public const string LaboratorioIII = "Laboratorio III";
        public const string OrganizacionContable = "Organización Contable";
        public const string OrganizacionEmpresarial = "Organización Empresarial";
        public const string ElementosInvestigacionOperativa = "Elementos de Investigación Operativa";

        public const string LaboratorioIV = "Laboratorio IV";
        public const string DisenioAdministracionBaseDatos = "Diseño de Administración de Bases de Datos";
        public const string MetodologiaSistemas = "Metod. de Sistemas I";
        public const string Legislacion = "Legislación";


        private static string[]? cuatrimestresDisponibles;
        private static string[]? clasesDisponibles;
        private static Dictionary<string, List<string>>? materiasDisponibles;
        private static string[]? turnosDisponibles;
        private static string[]? diasDisponibles;
        private static Dictionary<string, List<string>>? horariosDisponibles;
        private static string[]? aulasDisponibles;




        private string codigo;
        private string cuatrimestre;
        private string materia;          //  materia
        private string letraClase;
        private string division;
        private string turno;
        private string dia;
        private string horario;
        private string aula;
        private byte cupoMaximo;
        private byte cupoDisponible;


        //  private List<Estudiante> listaEstudiantes;
        //  AGREGAR LISTA DE ESTUDIANTES QUE ESTAN INSCRIPTOS A ESTE CURSO
        //  private string cargaHoraria;    hardcodeada segun el horarioFijo
        //  AGREGAR char carga horariA   DEPUES METODO  calcular carga horaria semanal (convertir de char a byte/int)

        public const sbyte ESP_COLM_1 = -30;
        public const sbyte ESP_COLM_2 = -15;

        //private Turno turno;
        //private Dia dia;     
        //public static Dictionary<Turno, List<string>>? horarioPorTurno;





        static Curso()
        {
            //ultimoCodigo = 153; //  EL ULTIMO LEGAJO ESTA EN LA BASE DE DATOS
            HardcodearCuartimestres();
            HardcodearDivisiones();
            HardcodearMaterias();
            HardcodearTurnos();
            HardcodearDias();
            HardcodearHorarios();
            HardcodearAulas();
        }

        //public Curso(string codigo, string cuatrimestre, string division, string descripcion, string turno, string dia, string horario, string aula, byte cupoMaximo, byte cupoDisponible)
        //{
        //    this.codigo = codigo;
        //    this.cuatrimestre = cuatrimestre;
        //    this.division = division;
        //    nombre = $"{cuatrimestre}{division}";
        //    this.materia = descripcion;
        //    this.turno = turno;
        //    this.dia = dia;
        //    this.horario = horario;
        //    this.aula = aula;
        //    this.cupoMaximo = cupoMaximo;
        //    this.cupoDisponible = cupoDisponible;
        //}

        public Curso(string codigo, string cuatrimestre, string letraClase, string materia,
                     string turno, string dia, string horario, string aula, byte cupoMaximo)
        {
            this.codigo = codigo;
            this.cuatrimestre = cuatrimestre;
            this.letraClase = letraClase;
            division = $"{cuatrimestre}{letraClase}";
            this.materia = materia;
            this.turno = turno;
            this.dia = dia;
            this.horario = horario;
            this.aula = aula;
            this.cupoMaximo = cupoMaximo;
            cupoDisponible = cupoMaximo;
        }
        


        public string Codigo
        {
            get { return codigo; }
        }

        public string Materia
        {
            get { return materia; }
        }

        public string Division
        {
            get { return division; }
        }


        public string Turno
        {
            get { return turno; }
        }

        public string Dia
        {
            get { return dia; }
        }

        public string Horario
        {
            get { return horario; }
        }

        public string Aula
        {
            get { return aula; }
        }

        public byte CupoDisponible
        {
            get { return cupoDisponible; }
        }

        public byte CupoMaximo
        {
            get { return cupoMaximo; }
        }

        public string Cuatrimentre
        {
            get { return cuatrimestre; }
        }

        public string LetraClase
        {
            get { return letraClase; }
        }

        public string NombreMateriaDivision
        {
            get { return $"{materia} - {division}"; }
        }



        public static string[]? CuatrimestresDisponibles
        {
            get { return cuatrimestresDisponibles; }
        }

        public static string[]? ClasesDisponibles
        {
            get { return clasesDisponibles; }
        }

        public static Dictionary<string, List<string>>? MateriasDisponibles
        {
            get { return materiasDisponibles; }
        }

        public static string[]? TurnosDisponibles
        {
            get { return turnosDisponibles; }
        }

        public static string[]? DiasDisponibles
        {
            get { return diasDisponibles; }
        }

        public static Dictionary<string, List<string>>? HorariosDisponibles
        {
            get { return horariosDisponibles; }
        }

        public static string[]? AulasDisponibles
        {
            get { return aulasDisponibles; }
        }



        private static void HardcodearCuartimestres()
        {
            cuatrimestresDisponibles = new string[4];
            cuatrimestresDisponibles[0] = "1°";
            cuatrimestresDisponibles[1] = "2°";
            cuatrimestresDisponibles[2] = "3°";
            cuatrimestresDisponibles[3] = "4°";
        }

        private static void HardcodearDivisiones()
        {
            clasesDisponibles = new string[8];
            clasesDisponibles[0] = "A";
            clasesDisponibles[1] = "B";
            clasesDisponibles[2] = "C";
            clasesDisponibles[3] = "D";
            clasesDisponibles[4] = "E";
            clasesDisponibles[5] = "F";
            clasesDisponibles[6] = "G";
            clasesDisponibles[7] = "H";
        }

        private static void HardcodearMaterias()
        {
            materiasDisponibles = new Dictionary<string, List<string>>
            {
                {"1°", new List<string> { ProgramacionI, LaboratorioI, Matematica, SistemaProcesamientoDatos, InglesI } },
                {"2°", new List<string> { ProgramacionII, LaboratorioII, Estadistica, ArquitecturaYSistemasOperativos, InglesII, MetodologiaInvestigación } },
                {"3°", new List<string> { ProgramacionIII, LaboratorioIII, OrganizacionContable, OrganizacionEmpresarial, ElementosInvestigacionOperativa } },
                {"4°", new List<string> { LaboratorioIV, DisenioAdministracionBaseDatos, MetodologiaSistemas, Legislacion } }
            };
        }

        private static void HardcodearTurnos()
        {
            turnosDisponibles = new string[3];
            turnosDisponibles[0] = "Mañana";
            turnosDisponibles[1] = "Tarde";
            turnosDisponibles[2] = "Noche";
        }

        private static void HardcodearDias()
        {
            diasDisponibles = new string[5];
            diasDisponibles[0] = "Lunes";
            diasDisponibles[1] = "Martes";
            diasDisponibles[2] = "Miércoles";
            diasDisponibles[3] = "Jueves";
            diasDisponibles[4] = "Viernes";
        }

        private static void HardcodearHorarios()
        {
            horariosDisponibles = new Dictionary<string, List<string>>
            {
                {"Mañana", new List<string> { "08:00 - 12:00", "08:00 - 10:00", "10:00 - 12:00" } },
                {"Tarde", new List<string> { "13:00 - 17:00", "13:00 - 15:00", "15:00 - 17:00" } },
                {"Noche", new List<string> { "18:30 - 22:30", "18:30 - 20:30", "20:30 - 22:30"} }
            };
            //horarioPorTurno = new Dictionary<Turno, List<string>>
            //{
            //    {Logica_Sysacad.Turno.Mañana, new List<string> { "08:00 - 10:00", "10:00 - 12:00", "08:00 - 12:00" } },
            //    {Logica_Sysacad. Turno.Tarde, new List<string> { "13:00 - 15:00", "15:00 - 17:00", "13:00 - 17:00" } },
            //    {Logica_Sysacad.Turno.Noche, new List<string> { "18:30 - 20:30", "20:30 - 22:30", "18:30 - 22:30" } }
            //};
        }

        private static void HardcodearAulas()
        {
            aulasDisponibles = new string[12];
            aulasDisponibles[0] = "201";
            aulasDisponibles[1] = "202";
            aulasDisponibles[2] = "203";
            aulasDisponibles[3] = "204";
            aulasDisponibles[4] = "205";
            aulasDisponibles[5] = "206";
            aulasDisponibles[6] = "207";
            aulasDisponibles[7] = "208";
            aulasDisponibles[8] = "209";
            aulasDisponibles[9] = "210";
            aulasDisponibles[10] = "211";
            aulasDisponibles[11] = "212";
        }

        public string MostrarDatos()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine()
                .AppendLine($"Informacion ingresada del Curso:")
                .AppendLine($"{"Código:",ESP_COLM_1}{codigo,ESP_COLM_2}")
                .AppendLine($"{"Nombre:",ESP_COLM_1}{materia,ESP_COLM_2}")
                .AppendLine($"{"Descripción:",ESP_COLM_1}{materia,ESP_COLM_2}")
                .AppendLine($"{"Turno:",ESP_COLM_1}{turno,ESP_COLM_2}")
                .AppendLine($"{"Horario:",ESP_COLM_1}{horario,ESP_COLM_2}")
                .AppendLine($"{"Día:",ESP_COLM_1}{dia,ESP_COLM_2}")
                .AppendLine($"{"Aula:",ESP_COLM_1}{aula,ESP_COLM_2}")
                .AppendLine($"{"Cupo Máx.:",ESP_COLM_1}{cupoMaximo.ToString(),ESP_COLM_2}")
                ;
            return text.ToString();
        }

        //public void ModificarCursoExistente(string codigo, string cuatrimestre, string division, string descripcion,
        //                                    string turno, string dia, string horario, string aula, byte cupoMaximo, byte cupoDisponible)
        //{
        //    this.codigo = codigo;
        //    this.cuatrimestre = cuatrimestre;
        //    this.division = division;
        //    nombre = $"{cuatrimestre}{division}";
        //    this.materia = descripcion;
        //    this.turno = turno;
        //    this.dia = dia;
        //    this.horario = horario;
        //    this.aula = aula;
        //    this.cupoMaximo = cupoMaximo;
        //    this.cupoDisponible = cupoDisponible;
        //}

        public void ModificarCursoExistente(string codigo, string cuatrimestre, string letraClase, string materia,
                                            string turno, string dia, string horario, string aula, byte cupoMaximo)
        {
            this.codigo = codigo;
            this.cuatrimestre = cuatrimestre;
            this.materia = materia;
            this.letraClase = letraClase;
            division = $"{cuatrimestre}{letraClase}";
            this.turno = turno;
            this.dia = dia;
            this.horario = horario;
            this.aula = aula;
            this.cupoMaximo = cupoMaximo;
            if (cupoDisponible > cupoMaximo)
            {
                cupoDisponible = cupoMaximo;
            }
        }




        public void ActualizarCupoDisponible(bool aumenta)
        {
            if (aumenta)
            {
                cupoDisponible++;
            }
            else
            {
                cupoDisponible--;
            }
        }






    }
}

