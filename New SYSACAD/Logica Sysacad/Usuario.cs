using System.Text;

namespace Logica_Sysacad
{
    public abstract class Usuario
    {
        protected ushort legajo;
        protected string nombres;
        protected string apellidos;
        protected string dni;
        protected DateTime fechaNacimiento;
        protected byte edad;
        protected string email;
        protected string clave;
        protected string telefono;
        protected string direccion;

        protected const sbyte ESP_COLM_1 = -30;
        protected const sbyte ESP_COLM_2 = -5;


        protected Usuario(string nombres, string apellidos, string dni, DateTime fechaNacimiento, byte edad, string email, string telefono, string direccion)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.dni = dni;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            this.edad = edad;
            clave = dni;
            this.telefono = telefono;
            this.direccion = direccion;
        }


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

        public byte Edad
        {
            get { return edad; }
        }

        public string Email
        {
            get { return email; }
        }

        public string Clave
        {
            get { return clave; }
            private set { clave = value; }
        }

        public string Telefono
        {
            get { return telefono; }
        }

        public string Direccion
        {
            get { return direccion; }
        }

        public virtual string MostrarDatos()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine()
                .AppendLine($"{"Legajo:",ESP_COLM_1} {legajo.ToString("000000"),ESP_COLM_2}")
                .AppendLine($"{"Nombre:",ESP_COLM_1} {nombres,ESP_COLM_2}")
                .AppendLine($"{"Apellido:",ESP_COLM_1} {apellidos,ESP_COLM_2}")
                .AppendLine($"{"DNI:",ESP_COLM_1} {dni,ESP_COLM_2}")
                .AppendLine($"{"Fecha de Nacimiento:",ESP_COLM_1} {fechaNacimiento.ToString("dd/MMM/yyyy"),ESP_COLM_2}")
                .AppendLine($"{"Edad:",ESP_COLM_1} {edad.ToString(),ESP_COLM_2}")
                .AppendLine($"{"Email:",ESP_COLM_1} {email,ESP_COLM_2}")
                .AppendLine($"{"Clave:",ESP_COLM_1} {clave,ESP_COLM_2}")
                .AppendLine($"{"Telefono:",ESP_COLM_1} {telefono,ESP_COLM_2}")
                .AppendLine($"{"Dirección:",ESP_COLM_1} {direccion,ESP_COLM_2}")
                ;
            return text.ToString();
        }

        public bool ComprobarUsuario(string emailIngresado, string claveIngresada)
        {
            return email == emailIngresado && clave == claveIngresada;
        }



        public static bool operator ==(Usuario usuario1, Usuario usuario2)
        {
            if (usuario1 is not null && usuario2 is not null)
            {
                return usuario1.email.Equals(usuario2.email, StringComparison.Ordinal) && usuario1.clave.Equals(usuario2.clave, StringComparison.Ordinal)
                       ;
            }
            return false;
        }

        public static bool operator !=(Usuario estudiante1, Usuario estudiante2)
        {
            return !(estudiante1 == estudiante2);
        }


    }
}