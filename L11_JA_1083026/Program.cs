using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
class Program
{
    static void Main()
    {
        //Ejercicio 1
        string pass;
        Console.Write("Ingrese una contraseña: ");
        pass = Console.ReadLine();


        bool mayus = false, nume = false, especial = false;
        string errores = "";
        char[] contra = pass.ToCharArray();
        if (pass.Length < 8)
        {
            errores += " Falta longitud de 8 caracteres, ";
        }
        for (int i = 0; i < pass.Length; i++)
        {
            if (char.IsUpper(contra[i]))
            {
                mayus = true;
            }

            if (char.IsDigit(contra[i]))
            {
                nume = true;
            }

            if (!char.IsLetter(contra[i]) && !char.IsDigit(contra[i]))
            {
                especial = true;
            }

        }

        if (!mayus) errores += " falta mayuscula, ";
        if (!nume) errores += " falta número, ";
        if (!especial) errores += " falta carácter especial, ";

        if (pass.Length >= 8 && mayus && nume && especial)
        {
            Console.WriteLine("Contraseña válida");
        }
        else
        {
            Console.WriteLine("Inválida:" + errores);
        }

        //Ejercicio 2
        string cadena, invertida = "";
        Console.Write("Ingresa un texto: ");
        cadena = Console.ReadLine();

        for(int i = cadena.Length - 1; i >= 0; i--)
        {
            invertida += cadena[i];
        }
        Console.WriteLine("Cadena invertida = " + invertida);

        //Ejercicio 3
        int cantidad, n, j = 0, mayor = 0, menor = 0;

        Console.Write("Cantidad de numeros a ingresar? ");
        cantidad = int.Parse(Console.ReadLine());
        int[] numeros = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Ingresa el " + (i + 1) + " número: ");
            numeros[i] = int.Parse(Console.ReadLine());
            j += numeros[i];
            if (i == 0)
            {
                mayor = numeros[i];
                menor = numeros[i];
            }

            if (numeros[i] > mayor )
            {
                mayor = numeros[i];
            }

            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }
        double promedio = (double)j / cantidad;
        Console.WriteLine("Suma = " + j);
        Console.WriteLine("Promedio = " + promedio);
        Console.WriteLine("Mayor = " + mayor);
        Console.WriteLine("Menor = " + menor);

        //Ejercicio 4
        int[] busqueda = new int[8];

        for (int i = 0; i < 8; i++)
        {
            Console.Write("Ingrese el número para la posición " + (i+1) + ": ");
            busqueda[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("nIngrese el número que desea buscar: ");
        int buscar = int.Parse(Console.ReadLine());
        bool encontrado = false;
        int posicion = -1;

        for (int i = 0; i < busqueda.Length; i++)
        {
            if (busqueda[i] == buscar)
            {
                encontrado = true;
                posicion = i;
                break; 
            }
        }

        if (encontrado)
        {
            Console.WriteLine("El número sí existe en la posición " + (posicion + 1));
        }
        else
        {
            Console.WriteLine("El número no existe en el arreglo.");
        }
        //Ejercicio 5
        string[] nombres = new string[5];
        int contadorMas5 = 0;
        string nombreMasLargo = "";

        for (int i = 0; i < 5; i++)
        {
            nombres[i] = Console.ReadLine() ?? "";

            if (nombres[i].Length > 5)
            {
                contadorMas5++;
            }

            if (i == 0 || nombres[i].Length > nombreMasLargo.Length)
            {
                nombreMasLargo = nombres[i];
            }
        }
        Console.WriteLine("Nombres ingresados:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(nombres[i]);
        }
            
        Console.WriteLine("Nombres con más de 5 letras: " + contadorMas5);
        Console.WriteLine("El nombre más largo es: " + nombreMasLargo);
    }
}