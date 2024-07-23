using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.models
{
    internal class Persona
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Edad { get; set; }

        public Persona() { }
        public Persona(string name, int id, int edad)
        {
            Name = name;
            Id = id;
            Edad = edad;
        }
        public virtual string ToStringMethod()
        {
            return $"{Id}\n{Name}\n{Edad}";
        }
    }

    
}
