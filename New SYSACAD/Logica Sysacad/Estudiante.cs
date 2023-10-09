using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    public sealed class Estudiante : Usuario
    {
        public enum CarrerasUTN
        {
            TecnicaturaProgramacion,
            TecnicaturaIngenieroSistemas
        }

        #region CAMPOS
        protected static ushort ultimoLegajo;
        //        protected CarrerasUTN carrera;
        public List<Curso>? cursosInscriptos;
        private List<Servicio>? serviciosImpagos;
        private List<Servicio>? serviciosAbonados;


        #endregion



        #region CONSTRUCTOR
        static Estudiante()
        {
            ultimoLegajo = 3;//      1;           //  EL ULTIMO LEGAJO ESTA EN LA BASE DE DATOS
        }

        public Estudiante(string nombres, string apellidos, string dni, DateTime fechaNacimiento, byte edad, string email, string telefono, string direccion)
                          : base(nombres, apellidos, dni, fechaNacimiento, edad, email, telefono, direccion)
        {
            legajo = 0;
            cursosInscriptos = new List<Curso>();
            serviciosImpagos = new List<Servicio>
            {
                new Servicio("Matrícula",7000,1),
                new Servicio("Cuotas Mensuales", 18000, 12),
                new Servicio("Cargos Administrativos",1500, 12),
                new Servicio("Libros de Texto",2000,6)
            };
            serviciosAbonados = new List<Servicio>();
            //CargarServiciosAPagar();
            //, CarrerasUTN carrera = CarrerasUTN.TecnicaturaProgramacion
            //this.carrera = carrera;
        }

        //private void CargarServiciosAPagar()
        //{
        //    serviciosAPagar = new List<Servicio>();
        //    foreach (Servicio servicio in SistemaUTN.ListaServicios)
        //    {
        //        serviciosAPagar.Add(servicio);
        //    }
        //}

        public Estudiante(string nombres, string apellidos, string dni, DateTime fechaNacimiento, byte edad, string email, string clave, string telefono, string direccion)
                  : this(nombres, apellidos, dni, fechaNacimiento, edad, email, telefono, direccion)
        {
            this.clave = clave;
            //, CarrerasUTN carrera = CarrerasUTN.TecnicaturaProgramacion
        }

        public void AsignarNumeroLegajo()
        {
            legajo = ultimoLegajo;
            ultimoLegajo++;
        }


        #endregion



        #region PROPIEDADES
        public List<Curso>? CursosInscriptos
        {
            get { return cursosInscriptos; }
        }

        public List<Servicio>? ServiciosImpagos
        {
            get { return serviciosImpagos; }
        }

        public List<Servicio>? ServiciosAbonados
        {
            get { return serviciosAbonados; }
        }





        #endregion



        #region METODOS

        public void PagarServicios(Servicio servicioElegido, byte cantidadCuotas, out string mensaje)
        {
            serviciosAbonados?.Add(servicioElegido);
            servicioElegido.ActualizarCuotas(cantidadCuotas);
            if (!servicioElegido.EstaPagadoTotalmente)
            {
                mensaje = $"{servicioElegido.Nombre} - ¡Se pagaron {cantidadCuotas} cuotas por un monto de {servicioElegido.CalcularMontoAPagar(cantidadCuotas):C2}!";
            }
            else
            {
                serviciosImpagos?.Remove(servicioElegido);
                mensaje = $"¡Se pagó el total de {servicioElegido.Nombre}, se canceló el total de la deuda!";
            }
        }



        //public static bool operator ==(Estudiante estudiante1, Estudiante estudiante2)
        //{
        //    if (estudiante1 is not null && estudiante2 is not null)
        //    {
        //        return estudiante1.legajo == estudiante2.legajo && estudiante1.dni == estudiante2.dni && estudiante1.email == estudiante2.email;
        //    }
        //    return false;
        //}

        //public static bool operator !=(Estudiante estudiante1, Estudiante estudiante2)
        //{
        //    return !(estudiante1 == estudiante2);
        //}



        public string MostrarCursosSubscritos()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("MI ESTUDIANTE ELIGIO ESTO:");
            foreach (Curso curso in cursosInscriptos)
            {
                text.AppendLine(curso.Materia);
            }
            text.AppendLine("CONFIRMAS????????????????????:");
            return text.ToString();
        }


        public string MostrarServiciosAPagar()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"{NombreCompletoOrdenApellido} pago:{Environment.NewLine}");
            foreach (Servicio servicio in serviciosImpagos)
            {
                text.AppendLine($"{servicio.Nombre} - {servicio.PrecioTotal.ToString("C2")}  -  Imp: {servicio.CuotasImpagas}/{servicio.CuotasTotales}, Abon: {servicio.CuotasAbonadas}/{servicio.CuotasTotales})");
            }
            return text.ToString();
        }


        #endregion

        public void AgregarCursoIncripto(Curso nuevoCurso)
        {
            cursosInscriptos?.Add(nuevoCurso);
            cursosInscriptos?.Sort();
        }


        //private static int CompararDiaCurso(string primerDia, string segundoDia)
        //{
        //    return primerDia - segundoDia;
        //}

    }

}
