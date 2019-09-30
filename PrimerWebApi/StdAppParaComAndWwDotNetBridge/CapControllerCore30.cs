using CAPATAZ.Modelo.IYD;
using System;
using System.Collections.Generic;
using System.Text;

namespace StdAppParaComAndWwDotNetBridge
{
    public static class CapControllerCore30
    {
        public static string GetString(string Nombre)
        {
            return $"Hello {Nombre}";
        }

        public static Sector GetSector()
        {
            return new Sector { Id = 1, Nombre = "Mi Sector", SegundosLun = 7200 };
        }
    }
}
