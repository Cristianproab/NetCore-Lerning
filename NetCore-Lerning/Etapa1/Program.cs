// See https://aka.ms/new-console-template for more information
using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2022, TiposEscuela.Primaria,
             ciudad: "Bogota", pais: "Colombia"
            );

            escuela.Cursos = new Curso[]{
                new Curso(){ Nombre = "101"},
                new Curso(){ Nombre = "201"},
                new Curso{ Nombre = "301"}
            };
            ImprimirCusosEscuela(escuela);
        }

        private static void ImprimirCusosEscuela(Escuela escuela)
        {
            Console.WriteLine("====================");
            Console.WriteLine("Cursos de la Escuela");
            Console.WriteLine("====================");

            foreach (var curso in escuela.Cursos)
            {
                Console.WriteLine($"Nombre {curso.Nombre}, id {curso.UniqueId}");
            }
        }

        /* 
                    Console.WriteLine(escuela);
                    System.Console.WriteLine("============="); */
        /*  Console.WriteLine(curso1.Nombre + "," + curso1.UniqueId);
         Console.WriteLine(curso2.Nombre + "," + curso2.UniqueId);
         Console.WriteLine($"{curso3.Nombre} , {curso3.UniqueId}");
         Console.WriteLine(curso3); */

        /* ImprimirCursosWhile(arreglosCursos);
        System.Console.WriteLine("=============");
        ImprimirCursosFor(arreglosCursos);
        System.Console.WriteLine("=============");
        ImprimirCursosForEach(arreglosCursos);
    } */

        private static void ImprimirCursosWhile(Curso[] arreglosCursos)
        {
            int contador = 0;

            while (contador < arreglosCursos.Length)
            {
                Console.WriteLine($"Nombre {arreglosCursos[contador].Nombre}, id {arreglosCursos[contador].UniqueId}");
                contador++;
            }
        }
        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                Console.WriteLine($"Nombre {arregloCursos[i].Nombre}), id {arregloCursos[i].UniqueId}");
            }
        }
        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var Curso in arregloCursos)
            {
                Console.WriteLine($"Nombre {Curso.Nombre}), id {Curso.UniqueId}");
            }
        }
    }
}


