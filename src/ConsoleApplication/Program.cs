//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            /*
            int length=101;
            for (int i = 0; i < length; i++)
            {
                var train1 = new Train(i.ToString());
            }
            */ 

            /* en el codigo de abajo sucede que a medida que se llena la memoria
            el destructor va eliminando trenes que ya no estan en uso, y el constructor va 
            creando los nuevos trenes*/

            int length=12;
            for (int i = 0; i < length; i++)
            {
                var train1 = new Train(i.ToString());
            }

            var t1 = new Train("Last Train to London");
            var t2 = new Train("Last Train to London");
            var t3 = new Train("Runaway Train");
            
            Console.WriteLine(t1==t2); /*False (las instancias pueden ten¡er el mismo valor pero cada instancia es unica)*/
            Console.WriteLine(t2==t3); /*False*/
        }
    }
}