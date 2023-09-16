using System.Text;

namespace Logica_Sysacad
{
    public class Usuario
    {
        #region CAMPOS
        protected static ushort ultimoLegajo;
        protected ushort legajo;  // legajo
        protected string nombres;
        protected string apellidos;
        protected string dni;
        protected DateTime fechaNacimiento;
        protected string correoElectronico;
        protected string contrasenia;         // en el constructor poner como contraseña inicial el DNI
        protected string telefono;
        protected string direccion;



        protected const sbyte ESP_COLM_1 = -25;
        protected const sbyte ESP_COLM_2 = -5;

        #endregion


        #region CONSTRUCTOR
        static Usuario()
        {
            ultimoLegajo = 1;       //Este codigo se ejecuta SOLO UNA VEZ y nos sirve de punto de partida
        }

        public Usuario(string nombres, string apellidos, string dni, DateTime fechaNacimiento,
                       string correoElectronico, string telefono, string direccion)
        {
            legajo = ultimoLegajo;
            ultimoLegajo++;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
            this.correoElectronico = correoElectronico;
            contrasenia = dni;
            this.telefono = telefono;
            this.direccion = direccion;
        }



        #endregion


        #region PROPIEDADES
        public ushort Legajo
        {
            get { return legajo; }
        }

        public string Nombres
        {
            get { return nombres; }
        }

        public string Apellidos
        {
            get { return apellidos; }
        }

        public string NombreCompleto
        {
            get { return $"{nombres} {apellidos}"; }
        }

        public string NombreCompletoOrdenApellido
        {
            get { return $"{apellidos}, {nombres} "; }
        }

        public string DNI
        {
            get { return dni; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
        }

        public string CorreoElectronico
        {
            get { return correoElectronico; }
        }

        public string Contrasenia
        {
            get { return contrasenia; }
            private set { contrasenia = value; }
        }

        public string Telefono
        {
            get { return telefono; }
        }

        public string Direccion
        {
            get { return direccion; }
        }


        #endregion


        #region METODOS
        public string MostrarDatos()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine()
                .AppendLine($"Informacion Usuario:")
                .AppendLine($"{"Legajo:",ESP_COLM_1} {legajo.ToString("000000"),ESP_COLM_2}")
                .AppendLine($"{"Nombre:",ESP_COLM_1} {nombres,ESP_COLM_2}")
                .AppendLine($"{"Apellido:",ESP_COLM_1} {apellidos,ESP_COLM_2}")
                .AppendLine($"{"DNI:",ESP_COLM_1} {dni,ESP_COLM_2}")    // Mostrar el DNI con los puntos 40.356.981
                .AppendLine($"{"Fecha de Nacimiento:",ESP_COLM_1} {fechaNacimiento.ToString("dd/MM/yyyy"),ESP_COLM_2}")    //Edad, calcular edad - QUE FORMATO MOSTRAR 1 ENE 98??
                .AppendLine($"{"Correo Electrónico:",ESP_COLM_1} {correoElectronico,ESP_COLM_2}")
                .AppendLine($"{"Contraseña:",ESP_COLM_1} {contrasenia,ESP_COLM_2}")
                .AppendLine($"{"Telefono:",ESP_COLM_1} {telefono,ESP_COLM_2}")      // Mostrar el telefono con los giuiones 4045-9191
                .AppendLine($"{"Dirección:",ESP_COLM_1} {direccion,ESP_COLM_2}")
                ;
            return text.ToString();
        }


        //public string FormaterDNI()
        //{
        //    string dniFormateado = "40916734";
        //    dniFormateado.Insert(2,".");
        //    dniFormateado.Insert(6,".");
        //    return dniFormateado;
        //}


        #endregion

    }
}