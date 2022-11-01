using LibreriaPOO.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPOO.Models.Derivada
{
    public class ArchivoTXT : Archivo
    {
        public override string Registrar(string usuario, string msj, string path)
        {
            //PALABRA TODO PARA LISTA DE TAREAS
            // TODO FALTA COMPLETAR EL CODIGO PARA CREAR UN TXT USANDO SYSTEM.IO
            return "Creando el archivo txt usando System.IO";

        }
    }
}
