using LibreriaPOO.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPOO.Models.Derivada
{
    public class ArchivoXML : Archivo
    {
        public override string Registrar(string usuario, string msj, string path)
        {
            return "Creando el archivo XML usando System.XML";
        }
    }
}
