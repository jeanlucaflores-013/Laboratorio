using System;
class Program
{
    static void Main()
    {
        //Ejercicio 1
        int[,] matriz = new int[4, 4];
        int fila, col;

        llenarMatriz(matriz);

        Console.Write("Ingrese el numero de fila (0 a 3): ");
        fila = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el numero de columna (0 a 3): ");
        col = int.Parse(Console.ReadLine());
        Console.WriteLine("Suma de la fila " + fila + ": " + SumaFila(matriz, fila));
        Console.WriteLine("Suma de la columna " + col + ": " + SumaColumna(matriz, col));

        //Ejercicio 2
        float[,] Matriz2 = new float[3, 5];
        laMatriz(Matriz2);
        float mayor = mayorMatriz(Matriz2);
        Console.WriteLine("El valor mayor de la matriz es: " + mayor);

        //Ejercicio 3
        int[,] A = new int[3, 2];
        int[,] B = new int[2, 3];
        int[,] R = new int[3, 3];

        LlenarMatriz(A, 3, 2);
        LlenarMatriz(B, 2, 3);


        Multiplicar(A, B, R);

        Console.WriteLine("Matriz resultante:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(R[i, j]+ "  ");
            }
            Console.WriteLine();

        }

        //Ejercicio 4
        int[,] matris = new int[5, 5];

        
        fill(matris);

        int sumaPrincipal = Principal(matris);
        int sumaSecundaria = Secundaria(matris);

        Console.WriteLine("Suma principal: " + sumaPrincipal);
        Console.WriteLine("Suma secundaria: " + sumaSecundaria);
        static void llenarMatriz(int[,] m)
        {
            Console.WriteLine("Ingrese los valores de la matriz 4x4:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Elemento [" + i + "][" + j + "]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static int SumaFila(int[,] m, int fila)
        {
            int suma = 0;
            for (int j = 0; j < 4; j++)
            {
                suma += m[fila, j];
            }
            return suma;
        }
        static int SumaColumna(int[,] m, int col)
        {
            int suma = 0;
            for (int i = 0; i < 4; i++)
            {
                suma += m[i, col];
            }
            return suma;
        }

        static void laMatriz(float[,] m)
        {
            Console.WriteLine("Ingrese los valores de la matriz 3x5");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("Elemento[" + i + "][" + j + "]: ");
                    m[i, j] = float.Parse(Console.ReadLine());
                }
            }
        }

        static float mayorMatriz(float[,] m)
        {
            float mayor = m[0, 0]; 

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (m[i, j] > mayor)
                    {
                        mayor = m[i, j];
                    }
                }
            }

            return mayor;
        }

        static void LlenarMatriz(int[,] m, int filas, int columnas)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("Elemento[" + i + "][" + j + "]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void Multiplicar(int[,] A, int[,] B, int[,] R)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    R[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        R[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
        }

        static void fill(int[,] m)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("Elemento[" + i + "][" + j + "]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static int Principal(int[,] m)
        {
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma += m[i, i];
            }
            return suma;
        }

        static int Secundaria(int[,] m)
        {
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma += m[i, 4 - i];
            }
            return suma;
        }
    }
}
    