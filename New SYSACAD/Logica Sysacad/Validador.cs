using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    public class Validador
    {
        private const decimal LETRA_E = 2.71828M;
        const decimal NUMERO_PI = 3.141592653589793238462643383279502884197M;


        public decimal LetraE
        {
            get { return LETRA_E; }
        }

        public decimal NumeroPI
        {
            get { return NUMERO_PI; }
        }


        //public static bool VerificarEsNumeroValido(out byte numeroFinal, string textoIngresado, byte minimo, byte maximo)
        //{
        //    if (!string.IsNullOrEmpty(textoIngresado) && !string.IsNullOrWhiteSpace(textoIngresado) &&
        //        byte.TryParse(textoIngresado, out numeroFinal) && ValidarRangoNumero(numeroFinal, minimo, maximo))
        //    {
        //        return true;
        //    }
        //    numeroFinal = 0;
        //    return false;
        //}


        //public static bool IngresarRespuesta(string mensajeIngreso, string mensajeInvalido, int minimo, int maximo, int respuestaAfirmativaEsperada)
        //{
        //    if (IngresarNumero(out int confirmacion, mensajeIngreso, mensajeInvalido, minimo, maximo) && confirmacion == respuestaAfirmativaEsperada)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public static bool IngresarRespuesta(string mensajeIngreso, string mensajeInvalido, char respuestaAfirmativaEsperada)
        //{
        //    if (IngresarCaracter(out char confirmacion, mensajeIngreso, mensajeInvalido) && confirmacion == respuestaAfirmativaEsperada)
        //    {
        //        return true;
        //    }
        //    return false;
        //}



        public static bool VerificarEsDatoVacio(string datonIngresado)
        {
            datonIngresado = datonIngresado.Trim();
            return string.IsNullOrEmpty(datonIngresado) || string.IsNullOrWhiteSpace(datonIngresado);
        }


        public static bool ValidarNumeroIngresado(out decimal numero, string datoIngresado, decimal minimo, decimal maximo)
        {
            numero = 0;
            return !VerificarEsDatoVacio(datoIngresado) && ConvertirTextoANumero(datoIngresado, out numero) && ValidarRangoNumero(numero, minimo, maximo);
        }

        public static bool ConvertirTextoANumero(string datoIngresado, out decimal numero)
        {
            return decimal.TryParse(datoIngresado, out numero);
        }

        public static bool ValidarRangoNumero(decimal numero, decimal minimo, decimal maximo)
        {
            if (minimo <= maximo && numero >= minimo && numero <= maximo)
            {
                return true;
            }
            return false;
        }



        public static bool ValidarTextoNumerico(string datoIngresado, byte cantidadCaracteresPermitidos)
        {
            return !VerificarEsDatoVacio(datoIngresado) && datoIngresado.Length == cantidadCaracteresPermitidos && VerificarEsNumero(datoIngresado);
        }

        public static bool VerificarEsNumero(string datoIngresado)
        {
            for (int i = 0; i < datoIngresado.Length && datoIngresado[i] != '\0'; i++)
            {
                if (datoIngresado[i] < '0' || datoIngresado[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }




        //public static bool ValidarRespuesta(string respuestaRecibida, string respuestaEsperada)
        //{
        //    if (respuestaRecibida.Equals(respuestaEsperada, StringComparison.Ordinal))
        //    {
        //        return true;
        //    }
        //    return false;
        //}



        #region VALIDAR NUMEROS



















        #endregion


        #region VALIDAR NOMBRES
        public static bool ValidarNombreIngresado(ref string datoIngresado, byte cantidadCaracteresPermitidos)
        {
            return !VerificarEsDatoVacio(datoIngresado) && datoIngresado.Length <= cantidadCaracteresPermitidos && VerificarEsNombre(ref datoIngresado);
        }

        public static bool VerificarEsNombre(ref string nombre)
        {
            for (int i = 0; i < nombre.Length && nombre[i] != '\0'; i++)
            {
                if (!VerificarEsCaracterNombre(nombre[i]))
                {
                    return false;
                }
            }
            nombre = PasarInicialesNombreAMayusculas(nombre);
            return true;
        }

        public static bool VerificarEsCaracterNombre(char caracter)
        {
            if ((caracter != ' ') && (caracter != '-') &&
                (caracter < 'a' || caracter > 'z') &&
                (caracter < 'A' || caracter > 'Z') &&
                (caracter != 'ñ') && (caracter != 'Ñ') && (caracter != 'ç') && (caracter != 'Ç') &&
                (caracter != 'á') && (caracter != 'é') && (caracter != 'í') && (caracter != 'ó') && (caracter != 'ú') &&
                (caracter != 'Á') && (caracter != 'É') && (caracter != 'Í') && (caracter != 'Ó') && (caracter != 'Ú') &&
                (caracter != 'ä') && (caracter != 'ë') && (caracter != 'ï') && (caracter != 'ö') && (caracter != 'ü') &&
                (caracter != 'Ä') && (caracter != 'Ë') && (caracter != 'Ï') && (caracter != 'Ö') && (caracter != 'Ü'))
            {
                return false;
            }
            return true;
        }


        public static bool ValidarDireccionIngresada(ref string datoIngresado, byte cantidadCaracteresPermitidos)
        {
            return !VerificarEsDatoVacio(datoIngresado) && datoIngresado.Length <= cantidadCaracteresPermitidos && VerificarEsAlfanumerico(ref datoIngresado);
        }

        public static bool VerificarEsAlfanumerico(ref string nombre)
        {
            for (int i = 0; i < nombre.Length && nombre[i] != '\0'; i++)
            {
                if (!VerificarEsCaracterAlfanumerico(nombre[i]))
                {
                    return false;
                }
            }
            nombre = PasarInicialesNombreAMayusculas(nombre);
            return true;
        }

        public static bool VerificarEsCaracterAlfanumerico(char caracter)
        {
            if ((caracter != ' ') && (caracter != '-') &&
                (caracter < 'a' || caracter > 'z') &&
                (caracter < 'A' || caracter > 'Z') &&
                (caracter < '0' || caracter > '9') &&
                (caracter != 'ñ') && (caracter != 'Ñ') && (caracter != 'ç') && (caracter != 'Ç') &&
                (caracter != 'á') && (caracter != 'é') && (caracter != 'í') && (caracter != 'ó') && (caracter != 'ú') &&
                (caracter != 'Á') && (caracter != 'É') && (caracter != 'Í') && (caracter != 'Ó') && (caracter != 'Ú') &&
                (caracter != 'ä') && (caracter != 'ë') && (caracter != 'ï') && (caracter != 'ö') && (caracter != 'ü') &&
                (caracter != 'Ä') && (caracter != 'Ë') && (caracter != 'Ï') && (caracter != 'Ö') && (caracter != 'Ü'))
            {
                return false;
            }
            return true;
        }




        public static string PasarInicialesNombreAMayusculas(string auxNombre)
        {
            string nombreProvisorio = PasarTodasLetrasNombreAMinusculas(auxNombre);
            int largo = nombreProvisorio.Length;
            int i = 0;
            char letraInicial;
            string seccionInicial;
            char primeraLetraNombre;
            string seccionPrevia;
            string seccionSiguiente;
            do
            {
                if (i == 0)
                {
                    seccionInicial = nombreProvisorio.Substring(i + 1);
                    letraInicial = char.ToUpper(nombreProvisorio[i]);
                    nombreProvisorio = string.Concat(letraInicial, seccionInicial);
                    i++;
                    if (largo == 1)
                    {
                        break;
                    }
                }
                if (nombreProvisorio[i].Equals(' ') || nombreProvisorio[i].Equals('-'))
                {
                    seccionPrevia = nombreProvisorio.Substring(0, i);
                    primeraLetraNombre = nombreProvisorio[i + 1];
                    primeraLetraNombre = char.ToUpper(primeraLetraNombre);
                    seccionSiguiente = nombreProvisorio.Substring(i + 2);
                    if (nombreProvisorio[i].Equals(' '))
                    {
                        nombreProvisorio = string.Concat(seccionPrevia, " ", primeraLetraNombre.ToString(), seccionSiguiente);
                        i++;
                    }
                    else
                    {
                        nombreProvisorio = string.Concat(seccionPrevia, "-", primeraLetraNombre.ToString(), seccionSiguiente);
                        i++;
                    }
                }
                i++;
            } while (i + 2 < largo);
            return nombreProvisorio;
        }

        public static string PasarTodasLetrasNombreAMinusculas(string auxNombre)
        {
            string nombreProvisorio = string.Empty;
            char letraNombre;
            for (int i = 0; i < auxNombre.Length; i++)
            {
                if (i != ' ' || i != '-')
                {
                    letraNombre = auxNombre[i];
                    nombreProvisorio += char.ToLower(letraNombre);
                }
                else
                {
                    nombreProvisorio += auxNombre[i];
                }
            }
            return nombreProvisorio;
        }

        public static string PasarTodasLetrasNombreAMayusculas(string auxNombre)
        {
            string nombreProvisorio = string.Empty;
            char letraNombre;
            for (int i = 0; i < auxNombre.Length; i++)
            {
                if (i != ' ' || i != '-')
                {
                    letraNombre = auxNombre[i];
                    nombreProvisorio += char.ToUpper(letraNombre);
                }
                else
                {
                    nombreProvisorio += auxNombre[i];
                }
            }
            return nombreProvisorio;
        }


        #endregion


        #region VALIDAR EMAILS
        public static bool ValidarEmailIngresado(string datoIngresado)
        {
            return !VerificarEsDatoVacio(datoIngresado) && VerificarEsEmailValido(ref datoIngresado);
        }
        public static bool VerificarEsEmailValido(ref string email)
        {
            for (int i = 0; i < email.Length && email[i] != '\0'; i++)
            {
                if (!VerificarEsCaracterEmail(email[i]))
                {
                    return false;
                }
            }
            //if (!VerificarEsGmail(ref email))
            //{
            //    return false;
            //}
            if (!email.Contains("@gmail.com"))
            {
                return false;
            }
            return true;
        }

        public static bool VerificarEsCaracterEmail(char caracter)
        {
            if ((caracter < 'a' || caracter > 'z') &&
                (caracter < 'A' || caracter > 'Z') &&
                (caracter < '0' || caracter > '9') &&
                (caracter != '.') && (caracter != '-') && (caracter != '+') && (caracter != '_') && (caracter != '~') && (caracter != '@'))
            {
                return false;
            }
            return true;
        }


        public static bool VerificarEsGmail(ref string nombre)
        {
            for (int i = 0; i < nombre.Length && nombre[i] != '\0'; i++)
            {
                if (nombre[i] == '@' && nombre[i + 1] == 'g' && nombre[i + 2] == 'm' && nombre[i + 3] == 'a' && nombre[i + 4] == 'i' && nombre[i + 5] == 'l'
                    && nombre[i + 6] == '.' && nombre[i + 7] == 'c' && nombre[i + 8] == 'o' && nombre[i + 9] == 'm'
                    && (nombre[i + 10] == '\0' || nombre[i + 10] == '\n'))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ValidarClaveIngresada(string datoIngresado)
        {
            return !VerificarEsDatoVacio(datoIngresado) && VerificarEsClaveValida(ref datoIngresado);
        }
        public static bool VerificarEsClaveValida(ref string clave)
        {
            for (int i = 0; i < clave.Length && clave[i] != '\0'; i++)
            {
                if (!VerificarEsCaracterEmail(clave[i]))
                {
                    return false;
                }
            }
            return true;
        }



        #endregion


        //public static bool VerificarEsNombre(string cadena, out string mensajeError)
        //{

        //    for (int i = 0; i < cadena.Length && cadena[i] != '\0'; i++)
        //    {
        //        if (cadena[i] == ' ' && cadena[i + 1] == ' ' && (cadena[i + 2] == ' ' || cadena[i + 2] == '\n' || cadena[i + 2] == '\0'))
        //        {
        //            mensajeError = "Se ingresaron múltiples espacios en blanco consecutivos.";
        //            return false;
        //        }
        //        else if ((i == 0 && (cadena[0] == ' ' || cadena[0] == '-')) ||
        //                (cadena[i] == ' ' && (cadena[i + 1] == ' ' || cadena[i + 1] == '-' || cadena[i + 1] == '\0')) ||
        //                (cadena[i] == '-' && (cadena[i + 1] == ' ' || cadena[i + 1] == '-' || cadena[i + 1] == '\0')))
        //        {
        //            mensajeError = "Se escribieron caracteres en posiciones no debidas.";
        //            return false;
        //        }
        //        else if (!ValidarCaracterNombre(cadena[i]))
        //        {
        //            mensajeError = "Se ingresaron caracteres no aceptados.";
        //            return false;
        //        }
        //    }

        //    mensajeError = "";
        //    string auxCadena = PasarInicialesNombreAMayusculas(cadena);
        //    cadena = auxCadena;
        //    return true;
        //}

        //public static bool VerificarAlfanumerico(string cadena, out string mensajeError)
        //{
        //    for (int i = 0; i < cadena.Length && cadena[i] != '\0'; i++)
        //    {
        //        if (cadena[i] == ' ' && cadena[i + 1] == ' ' && (cadena[i + 2] == ' ' || cadena[i + 2] == '\n' || cadena[i + 2] == '\0'))
        //        {
        //            mensajeError = "Se ingresaron múltiples espacios en blanco consecutivos.";
        //            return false;
        //        }
        //        else if ((i == 0 && cadena[0] == ' ') || (cadena[i] == ' ' && (cadena[i + 1] == ' ' || cadena[i + 1] == '\0')))
        //        {
        //            mensajeError = "Se escribieron caracteres en posiciones no debidas.";
        //            return false;
        //        }
        //        else if (!ValidarCaracterAlfanumerico(cadena[i]))
        //        {
        //            mensajeError = "Se ingresaron caracteres no aceptados.";
        //            return false;
        //        }
        //    }
        //    mensajeError = "";
        //    return true;
        //}





        //public static bool VerificarEsOperadorAritmetico(string cadena, out string mensajeError)
        //{
        //    for (int i = 0; i < cadena.Length && cadena[i] != '\0'; i++)
        //    {
        //        if (!ValidarCaracterOperadorAritmetico(cadena[i]))
        //        {
        //            mensajeError = "Se ingresaron carácteres no aceptados.";
        //            return false;
        //        }
        //    }
        //    mensajeError = "";
        //    return true;
        //}

        //public static bool ValidarCaracterOperadorAritmetico(char caracter)
        //{
        //    if ((caracter != '+') && (caracter != '-') && (caracter != '*') && (caracter != '/'))
        //    {
        //        return false;
        //    }
        //    return true;
        //}






        ////public static bool IngresarTelefonoFijo(out string telefono, uint largoTelefono, string mensajeIngreso, string mensajeInvalido, byte reintentos = 3)
        ////{
        ////    if (largoTelefono>0)
        ////    {
        ////        do
        ////        {
        ////            Console.WriteLine($"{Environment.NewLine}{mensajeIngreso}");
        ////            if (ObtenerCadena(out string auxTelefono, uint largo, string mensajeError) &&
        ////                VerificarAlfanumerico(auxTelefono, out mensajeError))
        ////            {
        ////                telefono = PasarTodasLetrasNombreAMayusculas(auxTelefono);
        ////                return true;
        ////            }
        ////            else
        ////            {
        ////                Console.WriteLine($"¡Error! {mensajeInvalido} {mensajeError}{Environment.NewLine}");
        ////                reintentos--;
        ////            }
        ////        } while (reintentos >= 0);
        ////    }
        ////    else
        ////    {
        ////        Console.WriteLine("¡Error! El número minimo establecido es mayor que el número máximo establecido.");
        ////    }
        ////    telefono = "";
        ////    return false;
        ////}

        ////public static bool VerificarEsTelefonoFijo(string cadena, out string mensajeError)
        ////{
        ////    for (short i = 0; i < cadena.Length && cadena[i] != '\0'; i++)
        ////    {
        ////        if (cadena[i] == ' ' && cadena[i + 1] == ' ' && (cadena[i + 2] == ' ' || cadena[i + 2] == '\n' || cadena[i + 2] == '\0'))
        ////        {
        ////            mensajeError = "Se ingresaron múltiples espacios en blanco consecutivos.";
        ////            return false;
        ////        }
        ////        else if ((i == 0 && cadena[0] == ' ') || (cadena[i] == ' ' && (cadena[i + 1] == ' ' || cadena[i + 1] == '\0')))
        ////        {
        ////            mensajeError = "Se escribieron caracteres en posiciones no debidas.";
        ////            return false;
        ////        }
        ////        else if (!ValidarCaracterTelefonoFijo(cadena[i]))
        ////        {
        ////            mensajeError = "Se ingresaron caracteres no aceptados.";
        ////            return false;
        ////        }
        ////    }
        ////    mensajeError = "";
        ////    return true;
        ////}


        ////public static bool ValidarCaracterTelefonoFijo(char caracter)
        ////{
        ////    if (caracter < '0' || caracter > '9')
        ////    {
        ////        return false;
        ////    }
        ////        return true;
        ////}


        #region VALIDAR FECHAS

        //public static bool IngresarFecha(out DateTime fechaIngresada, string mensajeAnio, string mensajeMes, string mensajeDia,
        //                                 ushort anioMinimo, ushort anioMaximo, byte reintentos = 3)
        //{
        //    if (anioMinimo <= anioMaximo && anioMinimo != 0 && anioMaximo != 0 &&
        //        IngresarAnio(out ushort anioIngresado, $"{mensajeAnio} (entre {anioMinimo} y {anioMaximo})", anioMinimo, anioMaximo, reintentos))
        //    {
        //        byte mesIngresado;
        //        byte diaIngresado;
        //        string mensajeErrorDia = "No es un día válido.";
        //        byte anioActual = (byte)DateTime.Now.Year;
        //        bool esBisiesto = VerificarEsAnioBisiesto(anioIngresado);

        //        if (anioIngresado == anioActual)
        //        {
        //            Console.WriteLine($"{Environment.NewLine}Actualmente estamos en el año {anioActual}.");
        //            if (esBisiesto)
        //            {
        //                Console.WriteLine($"El año {anioActual} es un año Bisiesto, tiene 366 dias, febrero tiene/tuvo 29 dias.{Environment.NewLine}");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"El año {anioActual} es un año Normal, tiene 365 dias, febrero tiene/tuvo 28 dias.{Environment.NewLine}");
        //            }
        //            byte mesActualNumero = (byte)DateTime.Now.Month;
        //            byte diaActual = (byte)DateTime.Now.Day;
        //            if (IngresarNumero(out mesIngresado, $"{mensajeMes} (hasta el mes actual {DateTime.Now:MMMM} {mesActualNumero})", "No es un mes válido.", 1, mesActualNumero, reintentos) &&
        //                    ((mesIngresado == mesActualNumero && IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al dia de hoy {diaActual})", mensajeErrorDia, 1, diaActual, reintentos)) ||
        //                        (mesIngresado == 2 &&
        //                        ((esBisiesto &&
        //                        IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al 29, es/fue un año bisiesto)", mensajeErrorDia, 1, 29, reintentos)) ||
        //                        (!esBisiesto &&
        //                        IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al 28, es/fue un año normal)", mensajeErrorDia, 1, 28, reintentos)))) ||
        //                        ((mesIngresado == 1 || mesIngresado == 3 || mesIngresado == 5 || mesIngresado == 7 || mesIngresado == 8 || mesIngresado == 10 || mesIngresado == 12) &&
        //                        IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al 31)", mensajeErrorDia, 1, 31, reintentos)) ||
        //                        ((mesIngresado == 4 || mesIngresado == 6 || mesIngresado == 9 || mesIngresado == 11) &&
        //                        IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al 30)", mensajeErrorDia, 1, 30, reintentos))) &&
        //                DateTime.TryParse($"{diaIngresado}/{mesIngresado}/{anioIngresado}", out fechaIngresada))
        //            {
        //                return true;
        //            }
        //        }
        //        else
        //        {
        //            if (esBisiesto)
        //            {
        //                Console.WriteLine($"*El año {anioIngresado} fue un año Bisiesto, tiene 366 dias, febrero tuvo 29 dias.{Environment.NewLine}");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"*El año {anioIngresado} fue un año Normal, tuvo 365 dias, febrero tuvo 28 dias.{Environment.NewLine}");
        //            }
        //            if (IngresarNumero(out mesIngresado, $"{mensajeMes} (del 1 al 12)", "No es un mes válido.", 1, 12, reintentos) &&
        //                    ((mesIngresado == 2 &&
        //                    ((esBisiesto &&
        //                        IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al 29, fue un año bisiesto)", mensajeErrorDia, 1, 29, reintentos)) ||
        //                    (!esBisiesto &&
        //                        IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al 28, fue un año normal)", mensajeErrorDia, 1, 28, reintentos)))) ||
        //                    ((mesIngresado == 1 || mesIngresado == 3 || mesIngresado == 5 || mesIngresado == 7 || mesIngresado == 8 || mesIngresado == 10 || mesIngresado == 12) &&
        //                        IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al 31)", mensajeErrorDia, 1, 31, reintentos)) ||
        //                    ((mesIngresado == 4 || mesIngresado == 6 || mesIngresado == 9 || mesIngresado == 11) &&
        //                        IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al 30)", mensajeErrorDia, 1, 30, reintentos))) &&
        //                    DateTime.TryParse($"{diaIngresado}/{mesIngresado}/{anioIngresado}", out fechaIngresada))
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    else if (anioMinimo > anioMaximo)
        //    {
        //        Console.WriteLine("El numero minimo establecido es mayor al numero maximo establecido.");
        //    }
        //    else if (anioMinimo == 0)
        //    {
        //        Console.WriteLine("El numero establecido como minimo fue 0 (cero), y no existió el año 0.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No se ingreso un año válido.");
        //    }
        //    fechaIngresada = DateTime.Now;
        //    return false;
        //}

        public static bool ValidaFechaIngresada(out DateTime fechaFinal, string anioIngresado, string mesIngresado, string diaIgresado)
        {
            if (ValidarNumeroIngresado(out decimal anioFinal, anioIngresado, 1905, 2006))
            {
                decimal MesFinal;
                decimal diaFinal;
                bool esBisiesto = VerificarEsAnioBisiesto((ushort)anioFinal);

                if (ValidarNumeroIngresado(out MesFinal, mesIngresado, 1, 12) &&
                        (MesFinal == 2 &&
                        (esBisiesto && ValidarNumeroIngresado(out diaFinal, diaIgresado, 1, 29)) ||
                        (!esBisiesto && ValidarNumeroIngresado(out diaFinal, diaIgresado, 1, 28)))
                        ||
                        ((MesFinal == 1 || MesFinal == 3 || MesFinal == 5 || MesFinal == 7 || MesFinal == 8 || MesFinal == 10 || MesFinal == 12) && ValidarNumeroIngresado(out diaFinal, diaIgresado, 1, 31))
                        ||
                        ((MesFinal == 4 || MesFinal == 6 || MesFinal == 9 || MesFinal == 11) && ValidarNumeroIngresado(out diaFinal, diaIgresado, 1, 30))
                )
                {
                    fechaFinal = new DateTime((int)anioFinal, (int)MesFinal, (int)diaFinal);
                    return true;
                }
            }
            fechaFinal = DateTime.MinValue;
            return false;
        }

        public static bool VerificarEsAnioBisiesto(ushort anioIngresado)
        {
            if (anioIngresado != 0 && (anioIngresado % 400 == 0 || (anioIngresado % 4 == 0 && anioIngresado % 100 != 0)))
            {
                return true;
            }
            return false;
        }

        //public static TimeSpan CalcularDiferenciaDias(DateTime fechaIngresada)
        //{
        //    return DateTime.Now.Subtract(fechaIngresada);
        //}

        //public static TimeSpan CalcularAniosDiferencia(DateTime fechaNacimiento)
        //{
        //    return DateTime.Now - fechaNacimiento;
        //}

        //public static byte CalcularAniosTotales(DateTime fechaNacimiento)
        //{
        //    TimeSpan edadActual = CalcularAniosDiferencia(fechaNacimiento);
        //    double aniosConvertidos = (double)edadActual.TotalDays / 365.2425;
        //    return (byte)aniosConvertidos;
        //}


        //public static TimeSpan CalcularDiferenciaFechas(DateTime fechaIngresada)
        //{
        //    return DateTime.Now.Subtract(fechaIngresada);
        //}


        /*  if (DateTime.TryParse($"{2013}/{1}/{2}", out fecha))
            {
                personaNueva.FechaNacimiento = fecha;
            }
        */


        #endregion


        #region CALCULADORA


        public static decimal CalcularDescuento(decimal precio, decimal descuento)
        {
            return precio - (precio * descuento / 100);
        }

        public static decimal CalcularDescuento(decimal precio, decimal descuento, out decimal descuentoAplicado)
        {
            descuentoAplicado = (precio * descuento / 100);
            return precio - descuentoAplicado;
        }


        public static decimal CalcularInteres(decimal precio, decimal interes)
        {
            return precio + (precio * interes / 100);
        }


        public static decimal CalcularInteres(decimal precio, decimal interes, out decimal interesAplicado)
        {
            interesAplicado = (precio * interes / 100);
            return precio + interesAplicado;
        }


        public static bool Calcular(out decimal resultadoOperacion, decimal primerOperando, decimal segundoOperando, char operadorAritmetico)
        {
            resultadoOperacion = 0;
            switch (operadorAritmetico)
            {
                case '+':
                    resultadoOperacion = SumarDosNumeros(primerOperando, segundoOperando);
                    return true;
                case '-':
                    resultadoOperacion = RestarDosNumeros(primerOperando, segundoOperando);
                    return true;
                case '*':
                    resultadoOperacion = MultiplicarDosNumeros(primerOperando, segundoOperando);
                    return true;
                case '/':
                    return DividirDosNumeros(out resultadoOperacion, primerOperando, segundoOperando);
                default:
                    return true;
            }
        }

        public static decimal SumarDosNumeros(decimal primerNumero, decimal segundoNumero)
        {
            return primerNumero + segundoNumero;
        }

        public static decimal RestarDosNumeros(decimal primerNumero, decimal segundoNumero)
        {
            return primerNumero - segundoNumero;
        }

        public static decimal MultiplicarDosNumeros(decimal primerNumero, decimal segundoNumero)
        {
            return primerNumero * segundoNumero;
        }

        public static bool DividirDosNumeros(out decimal resultado, decimal primerNumero, decimal segundoNumero)
        {
            resultado = 0;
            if (segundoNumero == 0)
            {
                return false;
            }
            else
            {
                resultado = primerNumero / segundoNumero;
            }
            return true;
        }

        public static decimal DividirDosNumeros(decimal primerNumero, decimal segundoNumero)
        {
            if (segundoNumero == 0)
            {
                return 0;
            }
            else
            {
                return primerNumero / segundoNumero;
            }
        }

        public static double ElevarPotenciaNumero(double numero, double potencia)
        {
            return Math.Pow(numero, potencia);
        }
        #endregion







    }
}
