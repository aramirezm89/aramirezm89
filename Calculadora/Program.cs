using System;

namespace CalculadoraSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double resultado = 0;
            int opcion = 0;

            Console.WriteLine("Ingrese primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese primer numero");
            num2 = Convert.ToDouble(Console.ReadLine());



            while ((opcion > 0 && opcion < 4) == false)
            {
                Console.WriteLine("Ingrese la opcion correspondiente al calculo que desea realizar\nOpcion 1: Suma\nOpcion 2: " +
                   "resta\nOpcion 3: Multiplicar\nOpcion 4: Dividir ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }

                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine("La suma de los numeros ingresados es: " + resultado);
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine("La resta de los numeros ingresados es: " + resultado);
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine("La multiplicacaion de los numeros ingresados es: " + resultado);
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("No se puede dividir por 0");

                        }
                        resultado = num1 / num2;
                        Console.WriteLine("La division de los numeros ingresados es: " + resultado);
                        break;

                        //default: Console.WriteLine("Opcion ingresada no valida");
                       

                }

            Console.ReadKey();

        }
    }
}
