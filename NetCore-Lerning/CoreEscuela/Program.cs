// See https://aka.ms/new-console-template for more information
using System;
namespace CoreEscuela
{
    class Escuela
    {
        public string nombre = "";
        public string direccion = "";
        public int añoFundacion;

        public string ceo = "Camilo Alvarado";

        public void Timbrar()
        {
            //todo
            Console.Beep(400,3000);
        }
    }
    class Program
    {
        static void Main (string[] args)
        {
            var miEscuela = new Escuela();
            miEscuela.nombre = "Platzi Academy";
            miEscuela.direccion = "Bogota Colombia";
            miEscuela.añoFundacion = 2012;
            Console.WriteLine("Timbre");
            miEscuela.Timbrar();
        }
        /* {Console.WriteLine("Hello, World!");} */
    }
}

