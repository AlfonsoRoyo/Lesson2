﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson2
{
    class Program
    {
        #region program principal
        /// <summary>Mains the specified arguments.</summary>
        /// <param name="args">The arguments.</param>
        /// <returns></returns>
       
        // se crea un metodo para sumar los valores 
        static int CalculaSuma (int v1, int v2,int v3)
        {
            return v1 + v2 +v3 ;

        }
        //se crea un metodo para multiplicar valores
        static int CalculaMultiplicacion(int v10, int v20, int v30)
        {
            return v10 * v20 * v30;
        }

        //se crea un metodo para dividir valores
        static int CalculaDivision(int v10, int v20)
        {
            return v10 / v20 ;
        }


        static int Main (string[] args)
      {
            // Inicialització de variables
             int Value1 = 4;
             int Value2 = 0x5;
            int Value3 = 1;

            /* Aqui comienza el programi
             * per introduir dos nombres i mostrarlos a la pantalla*/

            // se debe convertir a int ya que Writeline escribe un string
            Console.WriteLine("Entra el primer valor:");       
            Value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entra en segundo valor:");             
            Value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entra en segundo valor:");
            Value3 = Convert.ToInt32(Console.ReadLine());
          

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;
                       
            Console.WriteLine("hola");
        
            int resultat = CalculaSuma (Value1,Value2,Value3);
            int resultat2 = CalculaMultiplicacion(Value1,Value2,Value3);
            int resultat3 = CalculaDivision (Value1, Value2);



            Console.WriteLine("el resultat es:" + resultat);
            Console.WriteLine("el resultat es:" + resultat2);
            Console.WriteLine("el resultat es:" + resultat3);
            Console.ReadLine();
            return 0;
      }




    #endregion
    }
 }















