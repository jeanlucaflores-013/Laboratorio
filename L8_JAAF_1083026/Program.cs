using System;
class Program
{
    static void Main()
    {
        //EJERCICIO 1
        int nota = 0, aprueba = 0, reprueba = 0, suma = 0;
        double prom = 0.0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Ingrese nota de " + i +" estudiante: ");
            nota = int.Parse(Console.ReadLine());
            suma = suma + nota;
            if (nota >= 61)
            {
                Console.WriteLine("Aprobó");
                aprueba++;
            }
            else
            {
                Console.WriteLine("Reprobó");
                reprueba++;
            }

        }
        prom = (double)suma / 10;
        Console.WriteLine("Promedio de la clase: " + prom);
        Console.WriteLine("Aprobados: " + aprueba);
        Console.WriteLine("Reprobados: " + reprueba);


        //EJERCICIO 2
        int num, sum = 0, pares = 0, impar = 0;
        Console.Write("Ingrese un número entero: ");
        num = int.Parse(Console.ReadLine());

        for(int i = 1; i<= num; i++)
        {
            sum += i;

            if (i % 2 == 0)
            {
                pares++;
            }
            else 
            {
                impar++;
            }
        }
        Console.WriteLine("Suma desde 1 hasta " + num + " --> " + sum);
        Console.WriteLine("Cantidad de numeros pares: " + pares);
        Console.WriteLine("Cantidad de numeros impares: " + impar);

        //EJERCICIO 3
        int opcion;
        double monto = 0, total = 0;
        int clientes = 0;

        do
        {
            Console.WriteLine("1. Registrar compra, 2. Ver total vendido, 3. Ver cantidad, 4. Salir ");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese monto de la compra: ");
                    monto = double.Parse(Console.ReadLine());

                    total += monto;
                    clientes++;
                    Console.WriteLine("Compra exitosa");
                    break;

                case 2:
                    Console.WriteLine("Total vendido: " + total);
                    break;

                case 3:
                    Console.WriteLine("Cantidad de compras: " + clientes);
                    break;

                case 4:
                    Console.WriteLine("Salir");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 4);

        //EJERCICIO 4
        int numerito, j = 0, pos = 0, neg = 0, sumita = 0;
        
        do
        {
            Console.Write("Ingresa un número (0 para salir) --> ");
            numerito = int.Parse(Console.ReadLine());

            if (numerito != 0)
            {
                j++;
                sumita = sumita + numerito;

                if (numerito > 0)
                {
                    pos++;
                }
                else
                {
                    neg++;
                }
            }
        } while (numerito != 0);
        Console.WriteLine("Cantidad de numeros --> " + j);
        Console.WriteLine("Cantidad de positivos --> " + pos);
        Console.WriteLine("Cantidad de negativos --> " + neg);
        Console.WriteLine("Suma --> " + sumita);

        //EJERCICIO 5
        int n;
        Console.Write("Ingrese un número: ");
        n = int.Parse(Console.ReadLine());

        for (int p = 1; p <= n; p++)
        {
            for (int o = 1; o <= p; o++)
            {
                Console.Write(o);
            }

            Console.WriteLine();
        }
    }
}