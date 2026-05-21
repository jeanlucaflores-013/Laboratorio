using System;
class Program
{
    static void Main()
    {
        //Ejercicio 1
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Saludo(nombre);
        Curso();

        //Ejercicio 2
        Console.Write("Area de que figura quiere calcular --> 1. Cuadrado, 2. Rectángulo, 3. Triángulo ");
        int opcion = int.Parse(Console.ReadLine());

        int ladoCuadrado, baseRectangulo, alturaRectangulo, baseTriangulo, alturaTriangulo; 
        switch (opcion)
        {
            case 1:
                Console.Write("Ingrese cuanto mide el lado del cuadrado: ");
                ladoCuadrado = int.Parse(Console.ReadLine());
                areaCuadrado(ladoCuadrado);
                break;

            case 2:
                Console.Write("Ingrese cuanto mide la base del rectángulo ");
                baseRectangulo = int.Parse(Console.ReadLine());

                Console.Write("Ingrese cuanto mide la altura del rectángulo ");
                alturaRectangulo = int.Parse(Console.ReadLine());

                areaRectangulo(baseRectangulo, alturaRectangulo);
                break;



            case 3:
                Console.Write("Ingrese cuanto mide la base del triángulo: ");
                baseTriangulo = int.Parse(Console.ReadLine());
                Console.Write("Ingrese cuanto mide la altura del triángulo: ");
                alturaTriangulo = int.Parse(Console.ReadLine());

                areaTriangulo(baseTriangulo, alturaTriangulo);
                break;

            default:
                Console.WriteLine("Opción invalida");
                break;
        }

        //Ejercicio 3
        int opcionFiguras, n;
        do
        {
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("3. Línea");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcionFiguras = int.Parse(Console.ReadLine());

            if (opcionFiguras >= 1 && opcionFiguras <= 3)
            {
                Console.Write("Ingrese valor de N: ");
                n = int.Parse(Console.ReadLine());
            }
            else
            {
                n = 0;
            }
            switch (opcionFiguras)
            {
                case 1:
                    Cuadrado(n);
                    break;
                case 2:
                    Triangulo(n);
                    break;
                case 3:
                    Linea(n);
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa");
                    break;
                default:
                    Console.WriteLine("Opción invalida");
                    break;
            }
        } while (opcionFiguras != 4);

        //Ejercicio 4
        int nota, suma = 0, aprobados = 0, reprobados = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Ingrese nota " + i + ": ");
            nota = int.Parse(Console.ReadLine());

            EvaluarNota(nota);

            suma += nota;

            if (nota >= 61)
                aprobados++;
            else
                reprobados++;
            
        }
        double promedio = suma / 5.0;
        resumen(promedio, aprobados, reprobados);

        //Ejercicio 5
        int num1, num2, cambio;
        Console.Write("Ingrese num1: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese num2: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Num1 --> " + num1 + " / Num2 --> " + num2);
        intercambio(ref num1, ref num2);
        Console.WriteLine("Num1 --> " + num1 + " / Num2 --> " + num2);
    }



    static void Saludo(string nombre)
    {
        Console.WriteLine("Hola " + nombre + " Como estas?");
    }

    static void Curso() 
    {
        Console.WriteLine("Bienvenido a PENSAMIENTO COMPUTACIONAL");
    }

    static void areaCuadrado(int ladoCuadrado)
    {
        int resultado = ladoCuadrado * ladoCuadrado;
        Console.WriteLine("El área del cuadrado es: " + resultado);
    }

    static void areaRectangulo(int ladoRectangulo, int alturaRectangulo)
    {
        int resultado = ladoRectangulo * alturaRectangulo;
        Console.WriteLine("El área del rectangulo es: " + resultado);
    }

    static void areaTriangulo(int baseTriangulo, int alturaTriangulo)
    {
        int resultado = (baseTriangulo * alturaTriangulo) / 2;
        Console.WriteLine("El área del triángulo es: " + resultado);
    }

    static void Cuadrado(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void Triangulo(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void Linea(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    static void EvaluarNota(int nota)
    {
        if (nota >= 61)
            Console.WriteLine("Aprueba");
        else
            Console.WriteLine("Reprueba");
    }

    static void resumen(double promedio, int aprobados, int reprobados)
    {
        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Reprobados: " + reprobados);
    }

    static void intercambio(ref int num1, ref int num2)
    {
        int cambio = num1;
        num1 = num2;
        num2 = cambio;
    }
}