using LibraryNetFrameworkToMigrate;
using LibraryNetFrameworkToMigrate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientOfLibraryNetFrameworkToMigrate
{

    class Program

    {
        static void Main(string[] args)
        {

            //var persona = new Persona() { Id = 100, Nombre = "Daniel", Nacimiento = DateTime.Parse("05/06/1979 00:00:00") };
            //Console.WriteLine($"({persona.Id}) {persona.Nombre}, nacido el {persona.Nacimiento}");

            var context = new LibraryNetFrameworkToMigrateContext();
            foreach (var persona in context.Personas)
            {
                Console.WriteLine($"({persona.Id}) {persona.Nombre}, nacido el {persona.Nacimiento}");
            }

            Console.ReadLine();
        }
    }}
