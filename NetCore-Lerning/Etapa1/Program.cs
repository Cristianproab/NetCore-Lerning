// See https://aka.ms/new-console-template for more information
using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2022, TiposEscuela.Primaria, pais:"Colombia", ciudad:"Bogota");
            escuela.Nombre = "Platzi Academy";
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogota";
            escuela.TipoEscuela = TiposEscuela.Primaria;

            var arreglosCursos = new Curso[3];

            arreglosCursos [0] = new Curso()
                    {
                        Nombre = "101"
                    };
            var curso2 = new Curso(){
                Nombre = "201"
            };
            arreglosCursos [1] = curso2;
            arreglosCursos [2] = new Curso
                    {
                        Nombre = "301"
                    };


            Console.WriteLine(escuela);
            System.Console.WriteLine("=============");
            Console.WriteLine(curso1.Nombre + "," + curso1.UniqueId);
            Console.WriteLine(curso2.Nombre + "," + curso2.UniqueId);
            Console.WriteLine($"{curso3.Nombre} , {curso3.UniqueId}");
            Console.WriteLine(curso3);
            
        }
    }
}


