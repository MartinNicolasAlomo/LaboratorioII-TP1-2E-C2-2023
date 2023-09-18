using Logica_Sysacad;

namespace Testeo_Sistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  new DateTime(1998, 1, 7)
            Estudiante E1 = new Estudiante("Martín Nicolás", "Alomo", "40916734", "ma@gmail.com", "42461213", "Corvalan 435");
            Estudiante E2 = new Estudiante("Martín Nicolás", "Alomo", "40916734", "ma@gmail.com", "42461213", "Corvalan 435");
            Estudiante E3 = new Estudiante("Martín Nicolás", "Alomo", "40916734", "ma@gmail.com", "42461213", "Corvalan 435");
            Profesor profe = new Profesor("Mario", "Rampi", "36222777", new DateTime(1971, 10, 19), "mrampi@gmail.com", "mario123", "Av. Mitre 101");
            Administrador ADMIN1 = new Administrador("JULIETA", "------", "*******", "2728@gmail.com", "mario123", "Av. Mitre 101");

            Console.WriteLine(E1.MostrarDatos());
            Console.WriteLine(E2.MostrarDatos());
            Console.WriteLine(profe.MostrarDatos());
            Console.WriteLine(E3.MostrarDatos());
            Console.WriteLine(ADMIN1.MostrarDatos());



            Console.WriteLine("Hello, World!");
            Console.WriteLine("TESTEO DE PUSH1");
        }
    }
}