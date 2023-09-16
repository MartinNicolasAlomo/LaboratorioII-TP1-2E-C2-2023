using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    internal class Validador
    {





        public static bool ValidarRespuesta(string respuestaRecibida, string respuestaEsperada)
        {
            if (respuestaRecibida.Equals(respuestaEsperada, StringComparison.Ordinal))
            {
                return true;
            }
            return false;
        }





        public static bool IngresarRespuesta(string mensajeIngreso, string mensajeInvalido, int minimo, int maximo, int respuestaAfirmativaEsperada)
        {
            if (IngresarNumero(out int confirmacion, mensajeIngreso, mensajeInvalido, minimo, maximo) && confirmacion == respuestaAfirmativaEsperada)
            {
                return true;
            }
            return false;
        }

        //public static bool IngresarRespuesta(string mensajeIngreso, string mensajeInvalido, char respuestaAfirmativaEsperada)
        //{
        //    if (IngresarCaracter(out char confirmacion, mensajeIngreso, mensajeInvalido) && confirmacion == respuestaAfirmativaEsperada)
        //    {
        //        return true;
        //    }
        //    return false;
        //}



        public static bool IngresarNumero(out sbyte numero, string mensajeIngreso, string mensajeInvalido, sbyte minimo = 1, sbyte maximo = 100, byte reintentos = 3)
        {
            if (minimo <= maximo)
            {
                do
                {
                    Console.WriteLine($"{Environment.NewLine}{mensajeIngreso}");
                    if (sbyte.TryParse(Console.ReadLine(), out sbyte auxNumero) &&
                        ValidarRangoNumero(auxNumero, minimo, maximo))
                    {
                        numero = auxNumero;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"¡Error! No es {mensajeInvalido}.{Environment.NewLine}");
                        reintentos--;
                    }
                } while (reintentos >= 0);
            }
            else
            {
                Console.WriteLine("¡Error! El número minimo establecido es mayor que el número máximo establecido.");
            }
            numero = 0;
            return false;
        }

        private static bool ValidarRangoNumero(sbyte numero, sbyte minimo, sbyte maximo)
        {
            if (numero >= minimo && numero <= maximo)
            {
                return true;
            }
            return false;
        }


        public static bool IngresarNumero(out byte numero, string mensajeIngreso, string mensajeInvalido, byte minimo = 1, byte maximo = 100, byte reintentos = 3)
        {
            if (minimo <= maximo)
            {
                do
                {
                    Console.WriteLine($"{Environment.NewLine}{mensajeIngreso}");
                    if (byte.TryParse(Console.ReadLine(), out byte auxNumero) &&
                        ValidarRangoNumero(auxNumero, minimo, maximo))
                    {
                        numero = auxNumero;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"¡Error! No es {mensajeInvalido}.{Environment.NewLine}");
                        reintentos--;
                    }
                } while (reintentos >= 0);
            }
            else
            {
                Console.WriteLine("¡Error! El número minimo establecido es mayor que el número máximo establecido.");
            }
            numero = 0;
            return false;
        }

        public static bool ValidarRangoNumero(byte numero, byte minimo, byte maximo)
        {
            if (numero >= minimo && numero <= maximo)
            {
                return true;
            }
            return false;
        }


        //private static bool ValidarRangoNumero(decimal numero, byte minimo, byte maximo)
        //{
        //    if (numero >= minimo && numero <= maximo)
        //    {
        //        return true;
        //    }
        //    return false;
        //}


        //public static bool ValidarNumero(byte numero, byte minimo, byte maximo)
        //{
        //    if (byte.TryParse(Console.ReadLine(), out byte auxNumero) &&
        //        ValidarRangoNumero(auxNumero, minimo, maximo))
        //    {
        //        numero = auxNumero;
        //        return true;
        //    }
        //    return false;
        //}

        public static bool IngresarNumero(out short numero, string mensajeIngreso, string mensajeInvalido, short minimo = 1, short maximo = 100, byte reintentos = 3)
        {
            if (minimo <= maximo)
            {
                do
                {
                    Console.WriteLine($"{Environment.NewLine}{mensajeIngreso}");
                    if (short.TryParse(Console.ReadLine(), out short auxNumero) &&
                        ValidarRangoNumero(auxNumero, minimo, maximo))
                    {
                        numero = auxNumero;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"¡Error! No es {mensajeInvalido}.{Environment.NewLine}");
                        reintentos--;
                    }
                } while (reintentos >= 0);
            }
            else
            {
                Console.WriteLine("¡Error! El número minimo establecido es mayor que el número máximo establecido.");
            }
            numero = 0;
            return false;
        }

        private static bool ValidarRangoNumero(short numero, short minimo, short maximo)
        {
            if (numero >= minimo && numero <= maximo)
            {
                return true;
            }
            return false;
        }


        public static bool IngresarNumero(out ushort numero, string mensajeIngreso, string mensajeInvalido, ushort minimo = 1, ushort maximo = 100, byte reintentos = 3)
        {
            if (minimo <= maximo)
            {
                do
                {
                    Console.WriteLine($"{Environment.NewLine}{mensajeIngreso}");
                    if (ushort.TryParse(Console.ReadLine(), out ushort auxNumero) &&
                        ValidarRangoNumero(auxNumero, minimo, maximo))
                    {
                        numero = auxNumero;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"¡Error! No es {mensajeInvalido}.{Environment.NewLine}");
                        reintentos--;
                    }
                } while (reintentos >= 0);
            }
            else
            {
                Console.WriteLine("¡Error! El número minimo establecido es mayor que el número máximo establecido.");
            }
            numero = 0;
            return false;
        }

        private static bool ValidarRangoNumero(ushort numero, ushort minimo, ushort maximo)
        {
            if (numero >= minimo && numero <= maximo)
            {
                return true;
            }
            return false;
        }


        public static bool IngresarNumero(out int numero, string mensajeIngreso, string mensajeInvalido, int minimo = 1, int maximo = 100, byte reintentos = 3)
        {
            // DEVOLVER MENSAJE ERROR POR STRING BUILDER . TOSTRING()
            if (minimo <= maximo)
            {
                do
                {
                    Console.WriteLine($"{Environment.NewLine}{mensajeIngreso}");
                    if (int.TryParse(Console.ReadLine(), out int auxNumero) &&
                        ValidarRangoNumero(auxNumero, minimo, maximo))
                    {
                        numero = auxNumero;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"¡Error! No es {mensajeInvalido}.{Environment.NewLine}");
                        reintentos--;
                    }
                } while (reintentos >= 0);
            }
            else
            {
                Console.WriteLine("¡Error! El número minimo establecido es mayor que el número máximo establecido.");
            }
            numero = 0;
            return false;
        }

        private static bool ValidarRangoNumero(int numero, int minimo, int maximo)
        {
            if (numero >= minimo && numero <= maximo)
            {
                return true;
            }
            return false;
        }


        public static bool IngresarNumero(out uint numero, string mensajeIngreso, string mensajeInvalido, uint minimo = 1, uint maximo = 100, byte reintentos = 3)
        {
            if (minimo <= maximo)
            {
                do
                {
                    Console.WriteLine($"{Environment.NewLine}{mensajeIngreso}");
                    if (uint.TryParse(Console.ReadLine(), out uint auxNumero) &&
                        ValidarRangoNumero(auxNumero, minimo, maximo))
                    {
                        numero = auxNumero;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"¡Error! No es {mensajeInvalido}.{Environment.NewLine}");
                        reintentos--;
                    }
                } while (reintentos >= 0);
            }
            else
            {
                Console.WriteLine("¡Error! El número minimo establecido es mayor que el número máximo establecido.");
            }
            numero = 0;
            return false;
        }

        private static bool ValidarRangoNumero(uint numero, uint minimo, uint maximo)
        {
            if (numero >= minimo && numero <= maximo)
            {
                return true;
            }
            return false;
        }


        public static bool IngresarNumero(out long numero, string mensajeIngreso, string mensajeInvalido, long minimo = 1, long maximo = 100, byte reintentos = 3)
        {
            if (minimo <= maximo)
            {
                do
                {
                    Console.WriteLine($"{Environment.NewLine}{mensajeIngreso}");
                    if (long.TryParse(Console.ReadLine(), out long auxNumero) &&
                        ValidarRangoNumero(auxNumero, minimo, maximo))
                    {
                        numero = auxNumero;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"¡Error! No es {mensajeInvalido}.{Environment.NewLine}");
                        reintentos--;
                    }
                } while (reintentos >= 0);
            }
            else
            {
                Console.WriteLine("¡Error! El número minimo establecido es mayor que el número máximo establecido.");
            }
            numero = 0;
            return false;
        }

        private static bool ValidarRangoNumero(long numero, long minimo, long maximo)
        {
            if (numero >= minimo && numero <= maximo)
            {
                return true;
            }
            return false;
        }


        public static bool IngresarNumero(out ulong numero, string mensajeIngreso, string mensajeInvalido, ulong minimo = 1, ulong maximo = 100, byte reintentos = 3)
        {
            if (minimo <= maximo)
            {
                do
                {
                    Console.WriteLine($"{Environment.NewLine}{mensajeIngreso}");
                    if (ulong.TryParse(Console.ReadLine(), out ulong auxNumero) &&
                        ValidarRangoNumero(auxNumero, minimo, maximo))
                    {
                        numero = auxNumero;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"¡Error! No es {mensajeInvalido}.{Environment.NewLine}");
                        reintentos--;
                    }
                } while (reintentos >= 0);
            }
            else
            {
                Console.WriteLine("¡Error! El número minimo establecido es mayor que el número máximo establecido.");
            }
            numero = 0;
            return false;
        }

        private static bool ValidarRangoNumero(ulong numero, ulong minimo, ulong maximo)
        {
            if (numero >= minimo && numero <= maximo)
            {
                return true;
            }
            return false;
        }


        public static bool IngresarNumero(out float numero, string mensajeIngreso, string mensajeInvalido, float minimo = 1, float maximo = 100, byte reintentos = 3)
        {
            if (minimo <= maximo)
            {
                do
                {
                    Console.WriteLine($"{Environment.NewLine}{mensajeIngreso}");
                    if (float.TryParse(Console.ReadLine(), out float auxNumero) &&
                        ValidarRangoNumero(auxNumero, minimo, maximo))
                    {
                        numero = auxNumero;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"¡Error! No es {mensajeInvalido}.{Environment.NewLine}");
                        reintentos--;
                    }
                } while (reintentos >= 0);
            }
            else
            {
                Console.WriteLine("¡Error! El número minimo establecido es mayor que el número máximo establecido.");
            }
            numero = 0;
            return false;
        }

        private static bool ValidarRangoNumero(float numero, float minimo, float maximo)
        {
            if (numero >= minimo && numero <= maximo)
            {
                return true;
            }
            return false;
        }


        public static bool IngresarNumero(out double numero, string mensajeIngreso, string mensajeInvalido, double minimo = 1, double maximo = 100, byte reintentos = 3)
        {
            if (minimo <= maximo)
            {
                do
                {
                    Console.WriteLine($"{Environment.NewLine}{mensajeIngreso}");
                    if (double.TryParse(Console.ReadLine(), out double auxNumero) &&
                        ValidarRangoNumero(auxNumero, minimo, maximo))
                    {
                        numero = auxNumero;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"¡Error! No es {mensajeInvalido}.{Environment.NewLine}");
                        reintentos--;
                    }
                } while (reintentos >= 0);
            }
            else
            {
                Console.WriteLine("¡Error! El número minimo establecido es mayor que el número máximo establecido.");
            }
            numero = 0;
            return false;
        }

        private static bool ValidarRangoNumero(double numero, double minimo, double maximo)
        {
            if (numero >= minimo && numero <= maximo)
            {
                return true;
            }
            return false;
        }




        public static bool IngresarNumero(out decimal numero, string mensajeIngreso, string mensajeInvalido, decimal minimo = 1, decimal maximo = 100, byte reintentos = 3)
        {
            if (minimo <= maximo)
            {
                do
                {
                    Console.WriteLine($"{Environment.NewLine}{mensajeIngreso}");
                    if (VerificarEsNumeroValido(out numero, Console.ReadLine(), minimo, maximo))
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"¡Error! No es {mensajeInvalido}.{Environment.NewLine}");
                        reintentos--;
                    }
                } while (reintentos >= 0);
            }
            else
            {
                Console.WriteLine("¡Error! El número minimo establecido es mayor que el número máximo establecido.");
            }
            numero = 0;
            return false;
        }

        private static bool ValidarRangoNumero(decimal numero, decimal minimo, decimal maximo)
        {
            if (numero >= minimo && numero <= maximo)
            {
                return true;
            }
            return false;
        }


        public static bool VerificarEsNumeroValido(out byte numeroFinal, string textoIngresado, byte minimo, byte maximo)
        {
            if (!string.IsNullOrEmpty(textoIngresado) && !string.IsNullOrWhiteSpace(textoIngresado) &&
                byte.TryParse(textoIngresado, out numeroFinal) && ValidarRangoNumero(numeroFinal, minimo, maximo))
            {
                return true;
            }
            numeroFinal = 0;
            return false;
        }

        public static bool VerificarEsNumeroValido(out decimal numeroFinal, string textoIngresado, decimal minimo, decimal maximo)
        {
            if (!string.IsNullOrEmpty(textoIngresado) && !string.IsNullOrWhiteSpace(textoIngresado) &&
                decimal.TryParse(textoIngresado, out numeroFinal) && ValidarRangoNumero(numeroFinal, minimo, maximo))
            {
                return true;
            }
            numeroFinal = 0;
            return false;
        }

        public static bool VerificarEsNumeroValido(out long numeroFinal, string textoIngresado, long minimo, long maximo)
        {
            if (!string.IsNullOrEmpty(textoIngresado) && !string.IsNullOrWhiteSpace(textoIngresado) &&
                long.TryParse(textoIngresado, out numeroFinal) && ValidarRangoNumero(numeroFinal, minimo, maximo))
            {
                return true;
            }
            numeroFinal = 0;
            return false;
        }

        public static bool VerificarEsNumeroValido(out ulong numeroFinal, string textoIngresado, ulong minimo, ulong maximo)
        {
            if (!string.IsNullOrEmpty(textoIngresado) && !string.IsNullOrWhiteSpace(textoIngresado) &&
                ulong.TryParse(textoIngresado, out numeroFinal) && ValidarRangoNumero(numeroFinal, minimo, maximo))
            {
                return true;
            }
            numeroFinal = 0;
            return false;
        }



        /*
         ingresar numero
            verificicar numero
                tryparse & validar rango



         */



        public static bool ValidarEsNumeroBinario(string binarioIngresado)
        {
            for (int i = 0; i < binarioIngresado.Length; i++)
            {
                if (binarioIngresado[i] <= '0' && binarioIngresado[i] >= '1')
                {
                    return false;
                }
            }
            return true;
        }


        /*
                 public static bool ValidarCaracterNombre(char caracter)
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
         */

        //public static bool ObtenerCadena(out string cadena, short largoCadena)
        //{
        //    string auxCadena = Console.ReadLine();
        //    /*if (auxCadena[0] == '\0' || string.IsNullOrEmpty(auxCadena))
        //    {
        //        cadena = "";
        //        mensajeError = "No se ingresó ningun carácter";
        //        return false;
        //    }*/
        //    if (auxCadena.Length <= largoCadena)
        //    {
        //        cadena = auxCadena;
        //        return true;
        //    }
        //    else
        //    {
        //        cadena = "";
        //        return false;
        //    }
        //}


        public static bool ObtenerCadena(out string cadena, uint largoCadena, string mensajeError)
        {
            string auxCadena = Console.ReadLine();
            /*if (auxCadena[0] == '\0' || string.IsNullOrEmpty(auxCadena))
            {
                cadena = "";
                mensajeError = "No se ingresó ningun carácter";
                return false;
            }*/
            if (auxCadena.Length <= largoCadena)
            {
                cadena = auxCadena;
                return true;
            }
            else
            {
                cadena = "";
                return false;
            }
        }


        //nombre.Trim() == usuario.Nombre.Trim()
        public static string ObtenerCadena(short largoCadena)
        {
            string auxCadena = Console.ReadLine();
            /*if (auxCadena[0] == '\0' || string.IsNullOrEmpty(auxCadena))
            {
                cadena = "";
                mensajeError = "No se ingresó ningun carácter";
                return false;
            }*/
            if (auxCadena.Length <= largoCadena)
            {
                return auxCadena.Trim();
            }
            else
            {
                return "";
            }
        }

        public static bool ObtenerCadena(out string cadena, short largoCadena, out string mensajeError)
        {
            string auxCadena = Console.ReadLine();
            if (string.IsNullOrEmpty(auxCadena) || string.IsNullOrWhiteSpace(auxCadena))
            {
                cadena = "";
                mensajeError = "No se ingresó ningun carácter";
                return false;
            }
            if (auxCadena.Length <= largoCadena)
            {
                cadena = auxCadena.Trim();
                mensajeError = "";
                return true;
            }
            else
            {
                cadena = "";
                mensajeError = "Se excedió el limite de caracteres permitidos.";
                return false;
            }
        }



        public static bool IngresarNombre(out string nombre, byte largoNombre, string mensajeIngreso, string mensajeInvalido, byte reintentos = 3)
        {
            do
            {
                Console.WriteLine($"{Environment.NewLine}{mensajeIngreso}");
                if (ObtenerCadena(out string auxNombre, largoNombre, out string mensajeError) &&
                    VerificarEsNombre(auxNombre, out mensajeError))
                {
                    nombre = PasarInicialesNombreAMayusculas(auxNombre);
                    return true;
                }
                else
                {
                    Console.WriteLine($"¡Error! No es {mensajeInvalido}. {mensajeError}{Environment.NewLine}");
                    reintentos--;
                }
            } while (reintentos >= 0);
            nombre = "";
            return false;
        }

        public static bool VerificarEsNombre(string cadena, out string mensajeError)
        {
            if (!string.IsNullOrWhiteSpace(cadena))
            {
                cadena = cadena.Trim();
                for (int i = 0; i < cadena.Length && cadena[i] != '\0'; i++)
                {
                    if (cadena[i] == ' ' && cadena[i + 1] == ' ' && (cadena[i + 2] == ' ' || cadena[i + 2] == '\n' || cadena[i + 2] == '\0'))
                    {
                        mensajeError = "Se ingresaron múltiples espacios en blanco consecutivos.";
                        return false;
                    }
                    else if ((i == 0 && (cadena[0] == ' ' || cadena[0] == '-')) ||
                            (cadena[i] == ' ' && (cadena[i + 1] == ' ' || cadena[i + 1] == '-' || cadena[i + 1] == '\0')) ||
                            (cadena[i] == '-' && (cadena[i + 1] == ' ' || cadena[i + 1] == '-' || cadena[i + 1] == '\0')))
                    {
                        mensajeError = "Se escribieron caracteres en posiciones no debidas.";
                        return false;
                    }
                    else if (!ValidarCaracterNombre(cadena[i]))
                    {
                        mensajeError = "Se ingresaron caracteres no aceptados.";
                        return false;
                    }
                }
            }
            mensajeError = "";
            string auxCadena = PasarInicialesNombreAMayusculas(cadena);
            cadena = auxCadena;
            return true;
        }

        public static bool ValidarCaracterNombre(char caracter)
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

        public static bool ValidarEsNombre(ref string nombre)
        {
            if (String.IsNullOrWhiteSpace(nombre))
            {
                return false;
            }
            else
            {
                nombre = nombre.Trim();
                for (int i = 0; i < nombre.Length && nombre[i] != '\0'; i++)
                {
                    if (!ValidarCaracterNombre(nombre[i]))
                    {
                        return false;
                    }
                }
            }
            nombre = PasarInicialesNombreAMayusculas(nombre);
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



        public static bool IngresarAlfanumerico(out string alfanumerico, byte largoAlfanumerico, string mensajeIngreso, string mensajeInvalido, int reintentos = 3)
        {
            do
            {
                Console.WriteLine($"{Environment.NewLine}{mensajeIngreso}");
                if (ObtenerCadena(out string auxAlfanumerico, largoAlfanumerico, out string mensajeError) &&
                    VerificarAlfanumerico(auxAlfanumerico, out mensajeError))
                {
                    alfanumerico = PasarTodasLetrasNombreAMayusculas(auxAlfanumerico);
                    return true;
                }
                else
                {
                    Console.WriteLine($"¡Error! {mensajeInvalido} {mensajeError}{Environment.NewLine}");
                    reintentos--;
                }
            } while (reintentos >= 0);
            alfanumerico = "";
            return false;
        }

        public static bool VerificarAlfanumerico(string cadena, out string mensajeError)
        {
            for (int i = 0; i < cadena.Length && cadena[i] != '\0'; i++)
            {
                if (cadena[i] == ' ' && cadena[i + 1] == ' ' && (cadena[i + 2] == ' ' || cadena[i + 2] == '\n' || cadena[i + 2] == '\0'))
                {
                    mensajeError = "Se ingresaron múltiples espacios en blanco consecutivos.";
                    return false;
                }
                else if ((i == 0 && cadena[0] == ' ') || (cadena[i] == ' ' && (cadena[i + 1] == ' ' || cadena[i + 1] == '\0')))
                {
                    mensajeError = "Se escribieron caracteres en posiciones no debidas.";
                    return false;
                }
                else if (!ValidarCaracterAlfanumerico(cadena[i]))
                {
                    mensajeError = "Se ingresaron caracteres no aceptados.";
                    return false;
                }
            }
            mensajeError = "";
            return true;
        }

        public static bool ValidarCaracterAlfanumerico(char caracter)
        {
            if ((caracter != ' ') &&
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



        public static bool IngresarOperadorAritmetico(out char operador, string mensajeIngreso, byte reintentos = 3)
        {
            byte largoOperador = 1;
            do
            {
                Console.WriteLine($"{Environment.NewLine}{mensajeIngreso}");
                if (ObtenerCadena(out string auxOperador, largoOperador, out string mensajeError) &&
                    VerificarEsOperadorAritmetico(auxOperador, out mensajeError) &&
                    char.TryParse(auxOperador, out operador))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"¡Error! No es un operador aritmético. {mensajeError}{Environment.NewLine}");
                    reintentos--;
                }
            } while (reintentos >= 0);
            operador = ' ';
            return false;
        }

        public static bool VerificarEsOperadorAritmetico(string cadena, out string mensajeError)
        {
            for (int i = 0; i < cadena.Length && cadena[i] != '\0'; i++)
            {
                if (!ValidarCaracterOperadorAritmetico(cadena[i]))
                {
                    mensajeError = "Se ingresaron carácteres no aceptados.";
                    return false;
                }
            }
            mensajeError = "";
            return true;
        }

        public static bool ValidarCaracterOperadorAritmetico(char caracter)
        {
            if ((caracter != '+') && (caracter != '-') && (caracter != '*') && (caracter != '/'))
            {
                return false;
            }
            return true;
        }




        public static decimal CalcularDescuento(decimal precio, decimal descuento)
        {
            return precio - (precio * descuento / 100);
        }

        public static decimal CalcularDescuento(decimal precio, decimal descuento, out decimal descuentoExtraido)
        {
            descuentoExtraido = (precio * descuento / 100);
            return precio - descuentoExtraido;
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



        /*        
        public static bool IngresarAlfanumerico(out string alfanumerico, byte largoAlfanumerico, string mensajeIngreso, string mensajeInvalido, int reintentos = 3)
        {

            return false;
                                ValidarRangoNumero(auxNumero, minimo, maximo))

        }*/

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




        public static bool IngresarFecha(out DateTime fechaIngresada, string mensajeAnio, string mensajeMes, string mensajeDia,
                                         ushort anioMinimo, ushort anioMaximo, byte reintentos = 3)
        {
            if (anioMinimo <= anioMaximo && anioMinimo != 0 && anioMaximo != 0 &&
                IngresarAnio(out ushort anioIngresado, $"{mensajeAnio} (entre {anioMinimo} y {anioMaximo})", anioMinimo, anioMaximo, reintentos))
            {
                byte mesIngresado;
                byte diaIngresado;
                string mensajeErrorDia = "No es un día válido.";
                byte anioActual = (byte)DateTime.Now.Year;
                bool esBisiesto = VerificarEsAnioBisiesto(anioIngresado);

                if (anioIngresado == anioActual)
                {
                    Console.WriteLine($"{Environment.NewLine}Actualmente estamos en el año {anioActual}.");
                    if (esBisiesto)
                    {
                        Console.WriteLine($"El año {anioActual} es un año Bisiesto, tiene 366 dias, febrero tiene/tuvo 29 dias.{Environment.NewLine}");
                    }
                    else
                    {
                        Console.WriteLine($"El año {anioActual} es un año Normal, tiene 365 dias, febrero tiene/tuvo 28 dias.{Environment.NewLine}");
                    }
                    byte mesActualNumero = (byte)DateTime.Now.Month;
                    byte diaActual = (byte)DateTime.Now.Day;
                    if (IngresarNumero(out mesIngresado, $"{mensajeMes} (hasta el mes actual {DateTime.Now:MMMM} {mesActualNumero})", "No es un mes válido.", 1, mesActualNumero, reintentos) &&
                            ((mesIngresado == mesActualNumero && IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al dia de hoy {diaActual})", mensajeErrorDia, 1, diaActual, reintentos)) ||
                                (mesIngresado == 2 &&
                                ((esBisiesto &&
                                IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al 29, es/fue un año bisiesto)", mensajeErrorDia, 1, 29, reintentos)) ||
                                (!esBisiesto &&
                                IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al 28, es/fue un año normal)", mensajeErrorDia, 1, 28, reintentos)))) ||
                                ((mesIngresado == 1 || mesIngresado == 3 || mesIngresado == 5 || mesIngresado == 7 || mesIngresado == 8 || mesIngresado == 10 || mesIngresado == 12) &&
                                IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al 31)", mensajeErrorDia, 1, 31, reintentos)) ||
                                ((mesIngresado == 4 || mesIngresado == 6 || mesIngresado == 9 || mesIngresado == 11) &&
                                IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al 30)", mensajeErrorDia, 1, 30, reintentos))) &&
                        DateTime.TryParse($"{diaIngresado}/{mesIngresado}/{anioIngresado}", out fechaIngresada))
                    {
                        return true;
                    }
                }
                else
                {
                    if (esBisiesto)
                    {
                        Console.WriteLine($"*El año {anioIngresado} fue un año Bisiesto, tiene 366 dias, febrero tuvo 29 dias.{Environment.NewLine}");
                    }
                    else
                    {
                        Console.WriteLine($"*El año {anioIngresado} fue un año Normal, tuvo 365 dias, febrero tuvo 28 dias.{Environment.NewLine}");
                    }
                    if (IngresarNumero(out mesIngresado, $"{mensajeMes} (del 1 al 12)", "No es un mes válido.", 1, 12, reintentos) &&
                            ((mesIngresado == 2 &&
                            ((esBisiesto &&
                                IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al 29, fue un año bisiesto)", mensajeErrorDia, 1, 29, reintentos)) ||
                            (!esBisiesto &&
                                IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al 28, fue un año normal)", mensajeErrorDia, 1, 28, reintentos)))) ||
                            ((mesIngresado == 1 || mesIngresado == 3 || mesIngresado == 5 || mesIngresado == 7 || mesIngresado == 8 || mesIngresado == 10 || mesIngresado == 12) &&
                                IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al 31)", mensajeErrorDia, 1, 31, reintentos)) ||
                            ((mesIngresado == 4 || mesIngresado == 6 || mesIngresado == 9 || mesIngresado == 11) &&
                                IngresarNumero(out diaIngresado, $"{mensajeDia} (del 1 al 30)", mensajeErrorDia, 1, 30, reintentos))) &&
                            DateTime.TryParse($"{diaIngresado}/{mesIngresado}/{anioIngresado}", out fechaIngresada))
                    {
                        return true;
                    }
                }
            }
            else if (anioMinimo > anioMaximo)
            {
                Console.WriteLine("El numero minimo establecido es mayor al numero maximo establecido.");
            }
            else if (anioMinimo == 0)
            {
                Console.WriteLine("El numero establecido como minimo fue 0 (cero), y no existió el año 0.");
            }
            else
            {
                Console.WriteLine("No se ingreso un año válido.");
            }
            fechaIngresada = DateTime.Now;
            return false;
        }

        public static bool IngresarAnio(out ushort anioIngresado, string mensajeAnio, ushort anioMinimo, ushort anioMaximo, byte reintentos = 3)
        {
            if (IngresarNumero(out anioIngresado, mensajeAnio, "No es un año válido.", anioMinimo, anioMaximo, reintentos) && anioIngresado != 0)
            {
                return true;
            }
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

        public static TimeSpan CalcularDiferenciaDias(DateTime fechaIngresada)
        {
            return DateTime.Now.Subtract(fechaIngresada);
        }

        public static TimeSpan CalcularAniosDiferencia(DateTime fechaNacimiento)
        {
            return DateTime.Now - fechaNacimiento;
        }

        public static byte CalcularAniosTotales(DateTime fechaNacimiento)
        {
            TimeSpan edadActual = CalcularAniosDiferencia(fechaNacimiento);
            double aniosConvertidos = (double)edadActual.TotalDays / 365.2425;
            return (byte)aniosConvertidos;
        }


        public static TimeSpan CalcularDiferenciaFechas(DateTime fechaIngresada)
        {
            return DateTime.Now.Subtract(fechaIngresada);
        }


        /*  if (DateTime.TryParse($"{2013}/{1}/{2}", out fecha))
            {
                personaNueva.FechaNacimiento = fecha;
            }
        */
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

        public static decimal Calcular(decimal primerOperando, decimal segundoOperando, char operadorAritmetico)
        {
            decimal resultadoOperacion = 0;
            switch (operadorAritmetico)
            {
                case '+':
                    resultadoOperacion = SumarDosNumeros(primerOperando, segundoOperando);
                    break;
                case '-':
                    resultadoOperacion = RestarDosNumeros(primerOperando, segundoOperando);
                    break;
                case '*':
                    resultadoOperacion = MultiplicarDosNumeros(primerOperando, segundoOperando);
                    break;
                case '/':
                    resultadoOperacion = DividirDosNumeros(primerOperando, segundoOperando);
                    break;
            }
            return resultadoOperacion;
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

        public static double SacarRaizCuadradaNumero(double numero)
        {
            return Math.Sqrt(numero);
        }

        public static double SacarRaizCubicaNumero(double numero)
        {
            return Math.Cbrt(numero);
        }



        public static void MostrarTablaMultiplicacion(int numeroIngresado)
        {
            int resultadoMultiplicacion;
            StringBuilder tablaMultiplicacion = new StringBuilder();
            tablaMultiplicacion.AppendLine()
                .Append($"Tabla de multiplicar del número {numeroIngresado}").AppendLine();
            for (int i = 0; i < 10; i++)
            {
                resultadoMultiplicacion = numeroIngresado * (i + 1);
                tablaMultiplicacion.Append($"{numeroIngresado} x {i + 1} = {resultadoMultiplicacion}");
                Console.WriteLine(tablaMultiplicacion);
                tablaMultiplicacion.Remove(0, tablaMultiplicacion.Length);
            }
        }

        public static bool CalcularFactorial(out uint factorial, uint numeroIngresado)
        {
            if (numeroIngresado == 0)
            {
                factorial = 1;
                return true;
            }
            else if (numeroIngresado > 0)
            {
                factorial = OperacionFactorial(numeroIngresado);    //numeroIngresado * CalcularFactorial(numeroIngresado - 1);
                return true;
            }
            else
            {
                factorial = 0;
                return false;
            }
        }

        public static uint CalcularFactorial(uint numeroIngresado)
        {
            if (numeroIngresado == 0)
            {
                return 1;
            }
            else if (numeroIngresado > 0)
            {
                uint factorial = OperacionFactorial(numeroIngresado);    //numeroIngresado * CalcularFactorial(numeroIngresado - 1);
                return factorial;
            }
            else
            {
                return 0;
            }
        }


        internal static uint OperacionFactorial(uint numeroIngresado)
        {
            uint resultado = 1;
            if (numeroIngresado > 0)
            {
                resultado = numeroIngresado * OperacionFactorial(numeroIngresado - 1);
            }
            return resultado;
        }





        public static uint CalcularPermutacionSimple(uint totalNNN)
        {
            return CalcularFactorial(totalNNN);
        }

        public static uint CalcularVariacionSimple(uint totalNNN, uint parteSeleccionadaKKK)
        {
            return CalcularFactorial(totalNNN) / CalcularFactorial(totalNNN - parteSeleccionadaKKK);
        }

        public static uint CalcularCombinacionSimple(uint totalNNN, uint parteSeleccionadaKKK)
        {
            return CalcularFactorial(totalNNN) / (CalcularFactorial(totalNNN - parteSeleccionadaKKK) * CalcularFactorial(parteSeleccionadaKKK));
        }



        public static uint CalcularVariacionConRepeticion(uint totalNNN, uint parteSeleccionadaKKK)
        {
            return (uint)Math.Pow(totalNNN, parteSeleccionadaKKK);
        }

        public static uint CalcularCombinacionConRepeticion(uint totalNNN, uint parteSeleccionadaKKK)
        {
            return CalcularFactorial(totalNNN + parteSeleccionadaKKK - 1) / (CalcularFactorial(parteSeleccionadaKKK) * CalcularFactorial(totalNNN - 1));
        }

        public static uint CalcularPermutacionConRepeticion(uint totalNNN, uint[] lista)
        {
            uint denominadorFinal = 1;
            foreach (uint numero in lista)
            {
                denominadorFinal *= CalcularFactorial(numero);
            }
            return CalcularFactorial(totalNNN) / denominadorFinal;
        }


        public static decimal CalcularDistribucionDePoisson(uint equis, decimal media)
        {
            decimal AAA = (decimal)Math.Pow((double)LETRA_E, (double)(media * (-1)));
            decimal BBB = (decimal)Math.Pow((double)media, equis);
            decimal CCC = CalcularFactorial(equis);
            return AAA * BBB / CCC;
        }

        //public static decimal CalcularDistribucionNormalConDesviacionEstandar(decimal media, decimal desviacionEstandar)
        //{
        //    decimal AAA = (decimal)Math.Pow((double)LETRA_E, (double)(media * (-1)));
        //    decimal BBB = (decimal)Math.Pow((double)media, equis);
        //    decimal CCC = CalcularFactorial(equis);
        //    return AAA * BBB / CCC;
        //}

        //public static decimal CalcularDistribucionNormalConVarianza(decimal media, decimal varianza)
        //{
        //    decimal AAA = (decimal)Math.Pow((double)LETRA_E, (double)(media * (-1)));
        //    decimal BBB = (decimal)Math.Pow((double)media, equis);
        //    decimal CCC = CalcularFactorial(equis);
        //    return AAA * BBB / CCC;
        //}

        //public static decimal ConvertirFraccionADecimales(out decimal resultado, int numerador, int denominador)
        //{
        //    return DividirDosNumeros(out resultado, numerador, denominador);
        //}


        public static decimal CambiarSigno(decimal numero)
        {
            return (decimal)(-1 * numero);
        }

        public static long CambiarSigno(long numero)
        {
            return (long)(-1 * numero);
        }



        public static bool VerificarEsNumeroPrimo(int numero)
        {
            for (int i = 2; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine($"{numero} NO es un numero primo.");
                    return false;
                }
            }
            Console.WriteLine($"{numero} es un NUMERO PRIMO.");
            return true;
        }



        //  CUADRILATEROS  --------------------------------------------------------------------------------------

        public static decimal CalcularAreaCuadrilatero(decimal ladoBase, decimal ladoAltura)
        {
            return ladoBase * ladoAltura;
        }

        public static decimal CalcularPerimetroCuadrilatero(decimal ladoA, decimal ladoB, decimal ladoC, decimal ladoD)
        {
            return ladoA + ladoB + ladoC + ladoD;
        }


        //  CUADRILATEROS  --------------------------------------------------------------------------------------

        public static decimal CalcularAreaPoligonoRegular(decimal perimetro, decimal apotema)
        {
            return perimetro * apotema / 2;
        }

        public static decimal CalcularAreaPoligonoRegular(decimal lado, decimal cantidadLados, decimal apotema)
        {
            return CalcularPerimetroPoligonoRegular(lado, cantidadLados) * apotema / 2;
        }

        public static decimal CalcularPerimetroPoligonoRegular(decimal lado, decimal cantidadLados)
        {
            return lado * cantidadLados;
        }


        public static decimal CalcularApotemaPoligonoRegular(decimal lado, decimal cantidadLados)
        {
            return CalcularHipotenusaTriangulo(lado / 2, lado);
        }


        //  TRIANGULO  ------------------------------------------------------------------------------------------

        public static decimal CalcularAreaTriangulo(decimal ladoBase, decimal ladoAltura)
        {
            return ladoBase * ladoAltura / 2;
        }

        public static decimal CalcularAreaTriangulo(decimal circunferencia)
        {
            return circunferencia / NUMERO_PI;
        }


        internal static decimal CalcularHipotenusaTriangulo(decimal baseTriangulo, decimal alturaTriangulo)
        {
            double hipotenusaTriangulo = -1;
            baseTriangulo = Math.Abs(baseTriangulo);
            alturaTriangulo = Math.Abs(alturaTriangulo);
            hipotenusaTriangulo = Math.Pow((double)baseTriangulo, 2) + Math.Pow((double)alturaTriangulo, 2);
            return (decimal)Math.Sqrt(hipotenusaTriangulo);
        }


        public static decimal CalcularPerimetroTriangulo(decimal ladoA, decimal ladoB, decimal ladoC)
        {
            return ladoA + ladoB + ladoC;
        }


        //  CIRCULO  --------------------------------------------------------------------------------------------

        public static decimal CalcularAreaCirculoPorCircunferencia(decimal circunferencia, decimal radio)
        {
            return circunferencia * radio / 2;
        }

        public static decimal CalcularAreaCirculoPorRadio(decimal radio)
        {
            return NUMERO_PI * radio * radio;
        }

        public static decimal CalcularAreaCirculoPorDiametro(decimal diametro)
        {
            return NUMERO_PI * diametro * diametro / 4;
        }

        public static decimal CalcularCircunferenciaCirculoPorDiametro(decimal diametro)
        {
            return NUMERO_PI * diametro;
        }

        public static decimal CalcularCircunferenciaCirculoPorRadio(decimal radio)
        {
            return NUMERO_PI * 2 * radio;
        }


        public static decimal CalcularRadioCirculoPorDiametro(decimal diametro)
        {
            return diametro / 2;
        }

        public static decimal CalcularRadioCirculoPorCircunferencia(decimal circunferencia)
        {
            return circunferencia / (NUMERO_PI * 2);
        }

        public static decimal CalcularDiametroCirculoPorRadio(decimal radio)
        {
            return radio * 2;
        }

        public static decimal CalcularDiametroCirculoPorCircunferencia(decimal circunferencia)
        {
            return circunferencia / NUMERO_PI;
        }



        //  ************************************************************************************************************************************************
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double areaCuadrado = 0;
            if (longitudLado > 0)
            {
                areaCuadrado = Math.Pow(longitudLado, 2);//longitudLado * longitudLado;
            }
            return areaCuadrado;
        }

        public static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            double areaTriangulo = 0;
            if (baseTriangulo > 0 && alturaTriangulo > 0)
            {
                areaTriangulo = baseTriangulo * alturaTriangulo / 2;
            }
            return areaTriangulo;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            double circunferenciaCirculo = 0;
            if (radio > 0)
            {
                circunferenciaCirculo = (double)NUMERO_PI * Math.Pow(radio, 2);
            }
            return circunferenciaCirculo;
        }


        public static bool CalcularHipotenusaTriangulo(out double hipotenusaTriangulo, double baseTriangulo, double alturaTriangulo)
        {
            bool retorno = false;
            hipotenusaTriangulo = -1;

            if (baseTriangulo > 0 && alturaTriangulo > 0)
            {
                hipotenusaTriangulo = Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2);
                hipotenusaTriangulo = Math.Sqrt(hipotenusaTriangulo);
                retorno = true;
            }
            return retorno;
        }







    }
}
