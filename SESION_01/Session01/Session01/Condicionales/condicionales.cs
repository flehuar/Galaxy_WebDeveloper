using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01.Condicionales
{
    public class condicionales
    {
        public void validar(string texto1, string texto2)
        {

            //IF
            if (texto1 == texto2)
            {
                Console.WriteLine($"Los textos son iguales");
            }
            else
            {
                Console.WriteLine($"Los textos son diferentes");
            }
        }

        public void validarNumero(int numero1, int numero2)
        {

            //IF
            if (numero1 == numero2)
            {
                Console.WriteLine($"Los números son iguales");
            }
            else if (numero1 > numero2)
            {
                Console.WriteLine($"El número {numero1} es mayor que {numero2}");
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine($"El número {numero1} es menor que {numero2}");
            }
            else
            {
                Console.WriteLine($"no se pudo encontrar la condición");
            }
        }

        public void MalaPracticaValidacion(string valorTexto)
        {
            //IF
            if (valorTexto == "1")
            {
                Console.WriteLine($"El valor es 1");
                //cantidad de lineas de código ==> 120
            }
            else if (valorTexto == "2")
            {
                Console.WriteLine($"El valor es 2");
                //cantidad de lineas de código ==> 120
            }
            else if (valorTexto == "3")
            {
                Console.WriteLine($"El valor es 3");
                //cantidad de lineas de código ==> 120
            }
            else if (valorTexto == "4")
            {
                Console.WriteLine($"El valor es 4");
                //cantidad de lineas de código ==> 120
            }
            else if (valorTexto == "5")
            {
                Console.WriteLine($"El valor es 5");
                //cantidad de lineas de código ==> 120
            }
            else
            {
                Console.WriteLine($"El valor es diferente a 1,2,3,4,5");
                //cantidad de lineas de código ==> 120
            }
        }

        public void BuenaPracticaValidacion(string valorTexto)
        {
            //SWITCH
            switch (valorTexto)
            {
                case "1":
                    Console.WriteLine($"El valor es 1");
                    //cantidad de lineas de código ==> 120
                    break;
                case "2":
                    Console.WriteLine($"El valor es 2");
                    //cantidad de lineas de código ==> 120
                    break;
                case "3":
                    Console.WriteLine($"El valor es 3");
                    //cantidad de lineas de código ==> 120
                    break;
                case "4":
                    Console.WriteLine($"El valor es 4");
                    //cantidad de lineas de código ==> 120
                    break;
                case "5":
                    Console.WriteLine($"El valor es 5");
                    //cantidad de lineas de código ==> 120
                    break;
                default:
                    Console.WriteLine($"El valor es diferente a 1,2,3,4,5");
                    //cantidad de lineas de código ==> 120
                    break;
            }
        }
    }
}