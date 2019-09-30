using CAPATAZ.Modelo.IYD;
using System;

using System.Collections.Generic;
using System.Text;

namespace CoreAppParaComAndWwDotNetBridge
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

        public static string GetNomEmpresa(int idEmp)
        {
            return ComVFP.UsoDeCapLogon(idEmp).get_emp();
        }

        public static string GetRsDesignUlMovStk()
        {
            var u = ComVFP.UsoDeCapLogon(2);
            return ComVFP.UsoDeUlMovStk(u);
        }


    }
}
