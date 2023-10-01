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
        #region CAMPOS
        public static string[]? cuatrimestres;
        public static string[]? divisiones;
        public static Dictionary<string, List<string>>? materiaPorCuatrimestre;
        public static string[]? turnos;
        public static string[]? dias;
        public static Dictionary<string, List<string>>? horarioPorTurno;
        public static string[]? aulas;

        private static byte ultimoCodigo;
        private ushort codigo;
        private string nombre;
        private string cuatrimestre;
        private string division;
        private string descripcion;
        private string turno;
        private string dia;
        private string horario;
        private string aula;
        private byte cupoMaximo;

        public const sbyte ESP_COLM_1 = -30;
        public const sbyte ESP_COLM_2 = -15;

        //private Turno turno;
        //private Dia dia;     
        //public static Dictionary<Turno, List<string>>? horarioPorTurno;


        #endregion



        #region CONSTRUCTOR
        static Curso()
        {
            ultimoCodigo = 153; //  EL ULTIMO LEGAJO ESTA EN LA BASE DE DATOS
            HardcodearCuartimestres();
            HardcodearDivisiones();
            HardcodearMaterias11();
            HardcodearTurnos();
            HardcodearDias();
            HardcodearHorarios11();
            HardcodearAulas();
        }

        public Curso(string cuatrimestre, string division, string descripcion, string turno, string dia, string horario, string aula, byte cupoMaximo)
        {
            codigo = 0;
            this.cuatrimestre = cuatrimestre;
            this.division = division;
            nombre = $"{cuatrimestre}{division}";
            this.descripcion = descripcion;
            this.turno = turno;
            this.dia = dia;
            this.horario = horario;
            this.aula = aula;
            this.cupoMaximo = cupoMaximo;
        }

        public void AsignarCodigo()
        {
            codigo = ultimoCodigo;
            ultimoCodigo++;
        }


        #endregion



        #region PROPIEDADES
        public ushort Codigo
        {
            get { return codigo; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Cuatrimentre
        {
            get { return cuatrimestre; }
        }

        public string Division
        {
            get { return division; }
        }

        public string Descripcion
        {
            get { return descripcion; }
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

        public byte CupoMaximo
        {
            get { return cupoMaximo; }
        }


        #endregion



        #region METODOS
        private static void HardcodearCuartimestres()
        {
            cuatrimestres = new string[4];
            cuatrimestres[0] = "1°";
            cuatrimestres[1] = "2°";
            cuatrimestres[2] = "3°";
            cuatrimestres[3] = "4°";
        }

        private static void HardcodearDivisiones()
        {
            divisiones = new string[8];
            divisiones[0] = "A";
            divisiones[1] = "B";
            divisiones[2] = "C";
            divisiones[3] = "D";
            divisiones[4] = "E";
            divisiones[5] = "F";
            divisiones[6] = "G";
            divisiones[7] = "H";
        }

        private static void HardcodearMaterias11()
        {
            materiaPorCuatrimestre = new Dictionary<string, List<string>>
            {
                {"1°", new List<string> { "Programación I", "Laboratorio I", "Matématica", "Sist. de Proc. de Datos", "Inglés I" } },
                {"2°", new List<string> { "Programación II", "Laboratorio II", "Estadística", "Arq. y Sist. Oper.", "Inglés II", "Metod. de la Inv." } },
                {"3°", new List<string> { "Programación III", "Laboratorio III", "Org. Contable", "Org. Empresarial", "Elem. de Inv. Oper." } },
                {"4°", new List<string> { "Laboratorio IV", "Diseño de Admin. de Bases de Datos", "Metod. de Sistemas I", "Legislación" } }
            };
        }

        private static void HardcodearTurnos()
        {
            turnos = new string[3];
            turnos[0] = "Mañana";
            turnos[1] = "Tarde";
            turnos[2] = "Noche";
        }

        private static void HardcodearDias()
        {
            dias = new string[5];
            dias[0] = "Lunes";
            dias[1] = "Martes";
            dias[2] = "Miércoles";
            dias[3] = "Jueves";
            dias[4] = "Viernes";
        }

        private static void HardcodearHorarios11()
        {
            horarioPorTurno = new Dictionary<string, List<string>>
            {
                {"Mañana", new List<string> { "08:00 - 10:00", "10:00 - 12:00", "08:00 - 12:00" } },
                {"Tarde", new List<string> { "13:00 - 15:00", "15:00 - 17:00", "13:00 - 17:00" } },
                {"Noche", new List<string> { "18:30 - 20:30", "20:30 - 22:30", "18:30 - 22:30" } }
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
            aulas = new string[12];
            aulas[0] = "201";
            aulas[1] = "202";
            aulas[2] = "203";
            aulas[3] = "204";
            aulas[4] = "205";
            aulas[5] = "206";
            aulas[6] = "207";
            aulas[7] = "208";
            aulas[8] = "209";
            aulas[9] = "210";
            aulas[10] = "211";
            aulas[11] = "212";
        }



        public string MostrarDatos()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine()
                .AppendLine($"Informacion ingresada del Curso:")
                .AppendLine($"{"Código:",ESP_COLM_1}{codigo,ESP_COLM_2}")
                .AppendLine($"{"Nombre:",ESP_COLM_1}{nombre,ESP_COLM_2}")
                .AppendLine($"{"Descripción:",ESP_COLM_1}{descripcion,ESP_COLM_2}")
                .AppendLine($"{"Turno:",ESP_COLM_1}{turno,ESP_COLM_2}")
                .AppendLine($"{"Horario:",ESP_COLM_1}{horario,ESP_COLM_2}")
                .AppendLine($"{"Día:",ESP_COLM_1}{dia,ESP_COLM_2}")
                .AppendLine($"{"Aula:",ESP_COLM_1}{aula,ESP_COLM_2}")
                .AppendLine($"{"Cupo Máx.:",ESP_COLM_1}{cupoMaximo.ToString(),ESP_COLM_2}")
                ;
            return text.ToString();
        }




        public void ModificarCursoExistente(string cuatrimestre, string division, string descripcion, string turno, string dia, string horario, string aula, byte cupoMaximo)
        {
            this.cuatrimestre = cuatrimestre;
            this.division = division;
            nombre = $"{cuatrimestre}{division}";
            this.descripcion = descripcion;
            this.turno = turno;
            this.dia = dia;
            this.horario = horario;
            this.aula = aula;
            this.cupoMaximo = cupoMaximo;
        }


        #endregion


    }




}

