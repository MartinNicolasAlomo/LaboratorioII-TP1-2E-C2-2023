using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Sysacad
{
    public sealed class Administrador : Usuario
    {
        protected static ushort ultimoLegajo;

        static Administrador()
        {
            ultimoLegajo = 1;
        }

        public Administrador(string nombres, string apellidos, string dni, DateTime fechaNacimiento, byte edad, string email, string telefono, string direccion)
                            : base(nombres, apellidos, dni, fechaNacimiento, edad, email, telefono, direccion)
        {
            legajo = ultimoLegajo;
            ultimoLegajo++;
        }

        public void EliminarCurso(Curso cursoElegido)
        {
            SistemaUTN.BaseDatosCursos?.Remove(cursoElegido);
        }

        public void ModificarCurso(Curso cursoElegido, Curso cursoEditado)
        {
            cursoElegido.ModificarCursoExistente(cursoEditado);
        }

        public void RegistrarCurso(Curso cursoIngresado)
        {
            SistemaUTN.BaseDatosCursos?.Add(cursoIngresado);
        }

        public void RegistrarEstudiante(Estudiante nuevoEstudiante)
        {
            SistemaUTN.ListaEstudiantes?.Add(nuevoEstudiante);
            nuevoEstudiante.AsignarNumeroLegajo();
        }
    }
}
