using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    public sealed class Estudiante : Usuario
    {
        protected static ushort ultimoLegajo;
        public List<Curso>? cursosInscriptos;
        private List<Servicio>? serviciosImpagos;
        private List<Servicio>? serviciosAbonados;

        static Estudiante()
        {
            ultimoLegajo = 1;
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
        }

        public Estudiante(string nombres, string apellidos, string dni, DateTime fechaNacimiento, byte edad, string email, string clave, string telefono, string direccion)
                  : this(nombres, apellidos, dni, fechaNacimiento, edad, email, telefono, direccion)
        {
            this.clave = clave;
        }

        public void AsignarNumeroLegajo()
        {
            legajo = ultimoLegajo;
            ultimoLegajo++;
        }

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

        public static bool operator ==(Estudiante estudiante1, Estudiante estudiante2)
        {
            if (estudiante1 is not null && estudiante2 is not null)
            {
                return estudiante1.dni.Equals(estudiante2.dni, StringComparison.Ordinal) ||
                       estudiante1.email.Equals(estudiante2.email, StringComparison.Ordinal) ||
                       estudiante1.legajo == estudiante2.legajo ||
                       (estudiante1.nombres.Equals(estudiante2.nombres, StringComparison.Ordinal) &&
                       estudiante1.apellidos.Equals(estudiante2.apellidos, StringComparison.Ordinal))
                       ;
            }
            return false;
        }

        public static bool operator !=(Estudiante estudiante1, Estudiante estudiante2)
        {
            return !(estudiante1 == estudiante2);
        }

        public string MostrarServiciosAPagar()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"El/la estudiante {NombreCompletoOrdenApellido} pagó los siguientes servicios:{Environment.NewLine}");
            foreach (Servicio servicio in serviciosImpagos)
            {
                text.AppendLine($"{servicio.Nombre} - {servicio.PrecioTotal.ToString("C2")}  -  Imp: {servicio.CuotasImpagas}/{servicio.CuotasTotales}, Abon: {servicio.CuotasAbonadas}/{servicio.CuotasTotales})");
            }
            return text.ToString();
        }

        public bool InscribirCurso(Curso cursoIngresado, ref string mensajeError)
        {
            foreach (Curso cursoAnalizado in cursosInscriptos)
            {
                if (cursoAnalizado.Dia == cursoIngresado.Dia &&
                    cursoAnalizado.Turno == cursoIngresado.Turno &&
                    cursoAnalizado.Horario == cursoIngresado.Horario)
                {
                    mensajeError = "Este curso se cruza con otro curso en el mismo día y horario";
                    return false;
                }
            }
            if (cursosInscriptos.Contains(cursoIngresado))
            {
                mensajeError = "Este curso ya esta registrado en la lista";
                return false;
            }


            else if (cursoIngresado.CupoDisponible == 0)
            {
                mensajeError = "Este curso esta completo, no hay mas lugar";
                return false;
            }
            else
            {
                cursosInscriptos?.Add(cursoIngresado);
                cursoIngresado.ActualizarCupoDisponible(false);
                return true;
            }
        }
    }
}
