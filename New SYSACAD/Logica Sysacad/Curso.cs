using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    public enum Turno
    {
        Mañana,
        Tarde,
        Noche
    }

    public enum Dia
    {
        Lunes,
        Martes,
        Miércoles,
        Jueves,
        Viernes
    }

    public enum Division
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H,
    }


    public class Curso
    {
        #region CAMPOS

        public static string[]? cuatrimestres;//= new string[] { "1°", "2°", "3°", "4°" };
        public static string[]? divisiones;
        public static string[]? aulas;
        public static string[]? turnos;
        public static string[]? dias;
        public static Dictionary<Turno, List<string>>? horarioPorTurno;
        public static Dictionary<string, List<string>>? materiaPorCuatrimestre;



        private static byte ultimoCodigo;
        private ushort codigo;
        private string nombre;
        private string descripcion;
        private byte cupoMaximo;
        //private string turno;
        //private string dia;1
        private string aula;
        private string horario;
        private Turno turno;
        private Dia dia;


        #endregion



        #region CONSTRUCTOR
        static Curso()
        {
            ultimoCodigo = 153; //  EL ULTIMO LEGAJO ESTA EN LA BASE DE DATOS
            HardcodearCuartimestres();
            HardcodearDivisiones();
            HardcodearAulas();
            HardcodearDias();
            HardcodearTurnos();
            HardcodearHorarios11();
            HardcodearMaterias11();
        }

        public Curso(string nombre, string descripcion, byte cupoMaximo, Turno turno, Dia dia, //string turno, string dia,
                     string aula, string horario)
        {
            codigo = 0;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cupoMaximo = cupoMaximo;
            this.turno = turno;
            this.dia = dia;
            this.aula = aula;
            this.horario = horario;
            //this.horaFinal = horaFinal;
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

        public string Descripcion
        {
            get { return descripcion; }
        }

        public string Aula
        {
            get { return aula; }
        }

        public byte CupoMaximo
        {
            get { return cupoMaximo; }
        }

        public string Turno
        {
            get { return turno.ToString(); }
        }

        public string Dia
        {
            get { return dia.ToString(); }
        }

        public string Horario
        {
            get { return horario; }
        }



        #endregion



        #region METODOS
        private static void HardcodearTurnos()
        {
            turnos = new string[3];
            turnos[0] = "Mañana°";
            turnos[1] = "Tarde";
            turnos[2] = "Noche";
        }

        private static void HardcodearHorarios11()
        {
            horarioPorTurno = new Dictionary<Turno, List<string>>
            {
                {Logica_Sysacad.Turno.Mañana, new List<string> { "08:00 - 10:00", "10:00 - 12:00", "08:00 - 12:00" } },
                {Logica_Sysacad. Turno.Tarde, new List<string> { "13:00 - 15:00", "15:00 - 17:00", "13:00 - 17:00" } },
                {Logica_Sysacad.Turno.Noche, new List<string> { "18:30 - 20:30", "20:30 - 22:30", "18:30 - 22:30" } }
            };
        }

        private static void HardcodearMaterias11()
        {
            materiaPorCuatrimestre = new Dictionary<string, List<string>>
            {
                {cuatrimestres[0], new List<string> { "Programación I", "Laboratorio I", "Matématica", "Sist. de Proc. de Datos", "Inglés I" } },
                {cuatrimestres[1], new List<string> { "Programación II", "Laboratorio II", "Estadística", "Arq. y Sist. Oper.", "Inglés II", "Metod. de la Inv." } },
                {cuatrimestres[2], new List<string> { "Programación III", "Laboratorio III", "Org. Contable", "Org. Empresarial", "Elem. de Inv. Oper." } },
                {cuatrimestres[3], new List<string> { "Laboratorio IV", "Diseño de Admin. de Bases de Datos", "Metod. de Sistemas I", "Legislación" } }
            };
        }


        private static void HardcodearDias()
        {
            dias = new string[5];
            dias[0] = "Lunes°";
            dias[1] = "Martes°";
            dias[2] = "Miércoles";
            dias[3] = "Jueves";
            dias[4] = "Viernes";
        }

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


        public string Mostrar()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"{codigo}")
                .AppendLine($"{nombre}")
                .AppendLine($"{descripcion}")
                .AppendLine($"{cupoMaximo.ToString()}")
                .AppendLine($"{turno.ToString()}")
                .AppendLine($"{dia.ToString()}")
                .AppendLine($"{horario}")
                .AppendLine($"{aula}")
                .AppendLine($"")
                ;
            return text.ToString();
        }




        public const sbyte ESP_COLM_1 = -30;
        public const sbyte ESP_COLM_2 = -15;
        public string MostrarDatos()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine()
                .AppendLine($"Informacion ingresada del Curso:")
                .AppendLine($"{"Código:",ESP_COLM_1}{codigo,ESP_COLM_2}")
                .AppendLine($"{"Nombre:",ESP_COLM_1}{nombre,ESP_COLM_2}")
                .AppendLine($"{"Descripción:",ESP_COLM_1}{descripcion,ESP_COLM_2}")
                .AppendLine($"{"Turno:",ESP_COLM_1}{turno.ToString(),ESP_COLM_2}")
                .AppendLine($"{"Horario:",ESP_COLM_1}{horario,ESP_COLM_2}")
                .AppendLine($"{"Día:",ESP_COLM_1}{dia.ToString(),ESP_COLM_2}")
                .AppendLine($"{"Aula:",ESP_COLM_1}{aula,ESP_COLM_2}")
                .AppendLine($"{"Cupo Máx.:",ESP_COLM_1}{cupoMaximo.ToString(),ESP_COLM_2}")
                ;
            return text.ToString();
        }

        #endregion


    }




}

