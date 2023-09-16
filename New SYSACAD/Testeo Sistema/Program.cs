using Logica_Sysacad;
namespace Testeo_Sistema
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Estudiante nuevoUser = new Estudiante("Martín Nicolás", "Alomo", "40916734", new DateTime(1998, 1, 7), "ma@gmail.com", "42461213", "Corvalan 435");
            Administrador profe = new Administrador("Mario", "Rampi", "31222777", new DateTime(1971, 10, 19), "mrampi@gmail.com", "mario123", "Av. Mitre 101");
            
            Console.WriteLine(nuevoUser.MostrarDatos());
            Console.WriteLine(profe.MostrarDatos());



            Console.WriteLine("Hello, World!");
            Console.WriteLine("TESTEO DE PUSH1");
        }
    }
}