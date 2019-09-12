using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryNetFrameworkToMigrate
{
    public class Persona
    {
        public int Id { get; set; }

        [Index(IsUnique = true, Order = 1)]
        //[MaxLength(100)]
        public string Nombre { get; set; }

        public DateTime Nacimiento { get; set; }

        public ICollection<Persona> Hijos { get; set; }
            = new HashSet<Persona>();

        public Persona Papa { get; set; }
    }
}
