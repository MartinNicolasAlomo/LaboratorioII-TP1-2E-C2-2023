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

    public class Curso
    {
        #region CAMPOS
        private static byte ultimoCodigo;
        private ushort codigo;
        private string nombre;
        private string descripcion;
        private byte cupoMaximo;
        private Turno turno;
        private string aula;    //  numero en texto
        private Profesor profesor;
        private string horaInicio;
        private string horaFinal;
        private string minutoInicio;
        private string minutoFinal;



        #endregion



        #region CONSTRUCTOR
        static Curso()
        {
            ultimoCodigo = 3; //  EL ULTIMO LEGAJO ESTA EN LA BASE DE DATOS
        }

        public Curso(string nombre, string descripcion, byte cupoMaximo, Turno turno, string aula, Profesor profesor, 
                     string horaInicio, string horaFinal, string minutoInicio, string minutoFinal)
        {
            codigo = 0;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cupoMaximo = cupoMaximo;
            this.turno = turno;
            this.aula = aula;
            this.profesor = profesor;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;
            this.minutoInicio = minutoInicio;
            this.minutoFinal = minutoFinal;
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
        
        public Profesor Profesor
        {
            get { return profesor; }
        }
        
        public string HorarioInicio
        {
            get { return $"{horaInicio}:{minutoInicio}"; }
        }      
        public string HorarioFinal
        {
            get { return $"{horaFinal}:{minutoFinal}"; }
        }


        #endregion



        #region METODOS



        #endregion


    }




}

