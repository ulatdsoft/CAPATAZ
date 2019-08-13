using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebClient.Models.IYD
{
    public class Sector
    {
        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }

        public virtual TimeSpan Inicio { get; set; } = new TimeSpan(8, 0, 0);
        public virtual int SegundosLun { get; set; }
        public virtual int SegundosMar { get; set; }
        public virtual int SegundosMie { get; set; }
        public virtual int SegundosJue { get; set; }
        public virtual int SegundosVie { get; set; }
        public virtual int SegundosSab { get; set; }
        public virtual int SegundosDom { get; set; }

    }
}
