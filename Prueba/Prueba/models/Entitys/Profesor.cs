using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.models.Entitys
{
    internal class Profesor: Persona
    {
        string[] Matriculas { get; set; } 
        public Profesor() { }
        public Profesor(string name, int id, int edad, string[] matriculas) : base(name, id, edad)
        {
            Matriculas = matriculas;
        }


        public override string ToStringMethod()
        {
            string matriculasString = string.Join(", ", Matriculas);
            return $"{Id}\n{Name}\n{Edad}\n{matriculasString}";
        }
    }
}
