using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace StdAppParaComAndWwDotNetBridge
{
    public class Persona
    {
        [Index("MiClave", IsUnique = true, Order = 1)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Nacimiento { get; set; }

        public ICollection<Persona> Hijos { get; set; }
            = new HashSet<Persona>();

        public Persona Papa { get; set; }
        // = new Persona();

    }
}
