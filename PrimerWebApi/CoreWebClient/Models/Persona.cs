using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CoreWebClient.Models 
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Nacimiento { get; set; }

        public ICollection<Persona> Hijos { get; set; }
            = new HashSet<Persona>();

        public Persona Papa { get; set; }
           // = new Persona();

    }
}