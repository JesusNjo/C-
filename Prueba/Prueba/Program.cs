



using Prueba.models;
using Prueba.models.Entitys;

Persona persona = new Persona();

persona.Name = "Alejandro";
persona.Edad = 20;
persona.Id = 1;

Persona persona2 = new Persona("Pedro",2,25);
Persona persona3 = new Persona("Juan",3,26);
Persona persona4 = new Persona("Maria",4,45);
Persona persona5 = new Profesor("Roberto", 5, 58, ["Matematicas","Geografia"]);

List<Persona> list = new List<Persona>() { persona,persona2,persona3,persona4,persona5};


foreach(Persona p in list)
{
    Console.WriteLine(p.ToStringMethod());
    
}


