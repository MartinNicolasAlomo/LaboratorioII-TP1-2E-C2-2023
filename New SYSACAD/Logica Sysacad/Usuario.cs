using System.Text;

namespace Logica_Sysacad
{
    public abstract class Usuario
    {
        #region CAMPOS
        protected ushort legajo;
        protected string nombres;
        protected string apellidos;
        protected string dni;
       // protected DateTime fechaNacimiento;
        protected string email;
        protected string clave;         // en el constructor poner como contraseña inicial el DNI
        protected string telefono;
        protected string direccion;



        protected const sbyte ESP_COLM_1 = -25;
        protected const sbyte ESP_COLM_2 = -5;

        #endregion


        #region CONSTRUCTOR
        protected Usuario(string nombres, string apellidos, string dni, //DateTime fechaNacimiento,
                       string email, string telefono, string direccion)
        {
            //legajo = ultimoLegajo;
            //ultimoLegajo++;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.dni = dni;
            //this.fechaNacimiento = fechaNacimiento;
            this.email = email;
            clave = dni;
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



        #endregion


        #region METODOS
        public string MostrarDatos()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine()
                .AppendLine($"{"Legajo:",ESP_COLM_1} {legajo.ToString("000000"),ESP_COLM_2}")
                .AppendLine($"{"Nombre:",ESP_COLM_1} {nombres,ESP_COLM_2}")
                .AppendLine($"{"Apellido:",ESP_COLM_1} {apellidos,ESP_COLM_2}")
                .AppendLine($"{"DNI:",ESP_COLM_1} {dni,ESP_COLM_2}")    // Mostrar el DNI con los puntos 40.356.981
             //   .AppendLine($"{"Fecha de Nacimiento:",ESP_COLM_1} {fechaNacimiento.ToString("dd/MM/yyyy"),ESP_COLM_2}")    //Edad, calcular edad - QUE FORMATO MOSTRAR 1 ENE 98??
                .AppendLine($"{"Correo Electrónico:",ESP_COLM_1} {email,ESP_COLM_2}")
                .AppendLine($"{"Contraseña:",ESP_COLM_1} {clave,ESP_COLM_2}")
                .AppendLine($"{"Telefono:",ESP_COLM_1} {telefono,ESP_COLM_2}")      // Mostrar el telefono con los giuiones 4045-9191
                .AppendLine($"{"Dirección:",ESP_COLM_1} {direccion,ESP_COLM_2}")
                ;
            return text.ToString();
        }

        public bool ComprobarUsuario(string emailIngresado, string claveIngresada)
        {
            return email == emailIngresado && clave == claveIngresada;
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