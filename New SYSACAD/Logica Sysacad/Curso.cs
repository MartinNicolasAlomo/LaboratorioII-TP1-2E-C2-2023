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

        public static string[] cuatrimestres;//= new string[] { "1°", "2°", "3°", "4°" };
        public static string[] divisiones;
        public static string[] materias;
        public static string[] horarios;
        public static string[] aulas;
        public static string[] turnos;
        public static string[] dias;

        private static byte ultimoCodigo;
        private ushort codigo;
        private string nombre;
        private string descripcion;
        private byte cupoMaximo;
        //private string turno;
        //private string dia;
        private string aula;
        private string horario;
        private Turno turno;
        private Dia dia;
        //private Profesor profesor;
        //private string minutoInicio;
        //private string minutoFinal;



        #endregion



        #region CONSTRUCTOR
        static Curso()
        {
            ultimoCodigo = 153; //  EL ULTIMO LEGAJO ESTA EN LA BASE DE DATOS
            HardcodearCuartimestres();
            HardcodearDivisiones();
            HardcodearMaterias();
            HardcodearHorarios();
            HardcodearAulas();
            HardcodearDias();
            HardcodearTurnos();
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

        //public Profesor Profesor
        //{
        //    get { return profesor; }
        //}

        public string Horario
        {
            get { return horario; }
        }
        //public string HorarioFinal
        //{
        //    get { return horaFinal; }
        //}


        #endregion



        #region METODOS
        private static void HardcodearTurnos()
        {
            turnos = new string[3];
            turnos[0] = "Mañana°";
            turnos[1] = "Tarde";
            turnos[2] = "Noche";
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

        private static void HardcodearMaterias()
        {

            materias = new string[7];// { "Summer", "Spring", "Autumn", "Winter" };
            materias[0] = "Programación I";
            materias[1] = "Programación II";
            materias[2] = "Programación III";
            materias[3] = "Laboratorio I";
            materias[4] = "Laboratorio II";
            materias[5] = "Laboratorio III";
            materias[6] = "Laboratorio IV";
        }

        private static void HardcodearHorarios()
        {
            horarios = new string[9];
            horarios[0] = "08:00 - 10:00";
            horarios[1] = "10:00 - 12:00";
            horarios[2] = "08:00 - 12:00";
            horarios[3] = "13:00 - 15:00";
            horarios[4] = "15:00 - 17:00";
            horarios[5] = "13:00 - 17:00";
            horarios[6] = "18:30 - 20:30";
            horarios[7] = "20:30 - 22:30";
            horarios[8] = "18:30 - 22:30";
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


        #endregion


    }




}

