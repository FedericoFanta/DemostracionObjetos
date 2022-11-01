using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaPOO.Models.Derivada;
using LibreriaPOO.Escuela.Models;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearArchivos_Click(object sender, EventArgs e)
        {
            ArchivoTXT archivo = new ArchivoTXT();

            MessageBox.Show(archivo.Registrar("Fede", "hola ", "A"));

            ArchivoXML archivoxml = new ArchivoXML();

            MessageBox.Show(archivo.Registrar("Federico", "hola aaa", "A"));
        }

        private void btnCrearPersonas_Click(object sender, EventArgs e)
        {
            //notacion declarativa
            Alumno alumno = new Alumno()
            {
                Apellido="rosa", Nombre= "pepe", Matricula="C"
            };

            Profesor profesor = new Profesor()
            {
                Apellido="Pedro",
                Nombre = "prof",
                Titulo="Admin"
            };

            MessageBox.Show(alumno.Imprimir());
            MessageBox.Show(profesor.Imprimir());

        }
    }
}
