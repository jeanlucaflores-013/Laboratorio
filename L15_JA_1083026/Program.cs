using System;
// Error encontrado: En el código original faltaba ; después de using System
// Tipo de error: sintaxis 
// Corrección realizada: Agregar ";" al final de la linea de codigo
// Explicación: El punto y coma nos indica que una instrucción ha terminado
class Program
{
    static void Main()
    {
        Console.WriteLine("---EJERCICIO 1---");
        string nombre;
        // Error encontrado: Declaración de variable "nombre" incorrecto
        // Tipo de error: sintaxis 
        // Corrección realizada: Agregarle punto y coma (;) al final de la linea de codigo
        // Explicación: Toda declaración debe terminar con punto y coma
        int edad;
        Console.WriteLine("Ingrese su nombre:");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su edad:");
        edad = int.Parse(Console.ReadLine());
        // Error encontrado: Asignarle valor a variable edad mal escrito
        // Tipo de error: sintaxis 
        // Corrección realizada: Agregar punto y coma (;) al final de la lectura de edad
        // Explicación: Las instrucciones deben terminar con ;
        Console.WriteLine("Hola " + nombre);
        Console.WriteLine("Tienes " + edad + " años");
        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad");
        }
        else
        // Error encontrado: No compilaba porque no se cerraba el if 
        // Tipo de error: sintaxis 
        // Corrección realizada: Se agregó la llave } antes del else. 
        // Explicación: El bloque if debe cerrarse correctamente antes de iniciar el else.
        {
            Console.WriteLine("Eres menor de edad");
        }
        //Casos prueba:   p#1 -> edad 20, eres mayor de edad / p#2 -> edad 15, eres menor de edad 



        Console.WriteLine("---EJERCICIO 2---");
        double nota1, nota2, nota3, promedio;
        Console.WriteLine("Ingrese la primera nota:");
        nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la segunda nota:");
        nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la tercera nota:");
        nota3 = double.Parse(Console.ReadLine());
        promedio = (nota1 + nota2 + nota3) / 3;

        // Error encontrado: Error al obtener el promedio de 3 notas
        // Tipo de error: Lógico
        // Corrección realizada: agregar parentesis entre nota1 y nota3
        // Explicación: Al no tener parentesis por jerarquia de operaciones realizaba primero la division y solo nota3 se dividia entre 3, compilaba y daba un resultado pero este era incorrecto.

        Console.WriteLine("El promedio es: " + promedio);

        // Error encontrado: Se excluia al 61
        // Tipo de error: lógico
        // Corrección realizada: Se agregó signo = para que tomara en cuenta al 61 también
        // Explicación: Al ser > 61, con nota 61 reprobaría, en cambio >=61 aprueba

        if (promedio >= 61)
        {
            Console.WriteLine("El estudiante aprobó");
        }
        else
        {
            Console.WriteLine("El estudiante reprobó");
        }

        //Caso 1: Nota1=60, Nota2=60, Nota3=60, promedio=60, resultado=reprobado
        //Caso 2: Nota1=61, Nota2=61, Nota3=61, promedio=61, resultado=aprobado
        //Caso 3: Nota1=90, Nota2=70, Nota3=80, promedio=80, resultado=aprobado

        Console.WriteLine("---EJERCICIO 3---");
        int[] numeros = new int[5];
        int suma = 0;

        //Error encontrado: Posición inexistente
        //Tipo de error: ejecución
        //Corrección realizada: Se cambio la condición i<=5 por i<5
        //Explicación: La posición 5 no existe, por eso ocurria un error.

        for (int i = 0; i < 5; i++) //Un arreglo de tamaño 5, no tiene una posición 5 porque empieza en 0 hasta 4
        {
            int numero;
            bool valido = false;
            while (!valido)
            {
                Console.WriteLine("Ingrese un número:");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    numeros[i] = numero;
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Entrada no valida, tiene que ser numero entero");
                }
            }
        }
        for (int i = 0; i < 5; i++) //Corrección 1, i<=5 a i<5
        {
            suma = suma + numeros[i];
        }
        Console.WriteLine("La suma total es: " + suma);
        //Prueba 1,2,3,4,5 -> Suma = 15
        //Prueba texto -> Pide nuevamente la entrada sin cerrarse o tener error

        Console.WriteLine("---EJERCICIO 4---");
        double baseRectangulo = 0, alturaRectangulo = 0;
        bool entradaValida = false;

        while (!entradaValida)
        {
            Console.WriteLine("Ingrese la base del rectángulo:");
            if (double.TryParse(Console.ReadLine(), out baseRectangulo))
            {
                if (baseRectangulo > 0)
                    entradaValida = true;
                else
                    Console.WriteLine("La base debe ser mayor que cero, intente otra vez");
            }
            else
            {
                Console.WriteLine("Entrada inválida, debe ser un número");
            }
        }
        entradaValida = false;
        while (!entradaValida)
        {
            Console.WriteLine("Ingrese la altura del rectángulo:");
            if (double.TryParse(Console.ReadLine(), out alturaRectangulo))
            {
                if (alturaRectangulo > 0)
                    entradaValida = true;
                else
                    Console.WriteLine("La altura debe ser mayor que cero. Intente de nuevo.");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Ingrese un número.");
            }
        }
        Console.WriteLine("Base ingresada: " + baseRectangulo);
        Console.WriteLine("Altura ingresada: " + alturaRectangulo);
        double area = CalcularArea(baseRectangulo, alturaRectangulo);
        Console.WriteLine("El área es: " + area);
        if (area >= 100) //Se agrego = para considerar 100 grande.
        {
            Console.WriteLine("El área es grande");
        }
        else
        {
            Console.WriteLine("El área es pequeña");
        }

        // Casos de prueba:
        // base=10, altura=10 -> área=100   Grande
        // base=5,  altura=8  -> área=40  Pequeño
        // base=20, altura=6  -> área=120  Grande   
        // base=-5, altura=8  -> pide valor válido 

        Console.WriteLine("---EJERCICIO 5---");

        // Análisis de la solución generada por IA:
        // Error 1: El ciclo empieza en i=1 y llega hasta edades[5], el arreglo tiene
        // indices del 0-4 por lo que edades[5] no existe.
        // Error 2: La condición para contar mayores de edad es "edades[i]>18", eso excluye a
        //los que tienen 18.
        // Error 3:"promedio = suma / 5" realiza división entera porque 'suma' como '5' son enteros. El resultado debe ser double.
        // Limitación encontrada: La IA no agrego validaciones de entrada
        // Importancia de la validación humana: El código parece correcto a primera vista, contiene 
        // algunos errores.

        int[] edades = new int[5];
        suma = 0;
        int mayores = 0;
        promedio = 0;

        //Error encontrado: (Error 1) Indice 5 fuera de rango
        //Tipo de error: ejecución
        //Corrección realizada: i = 0, i < 5
        //Explicación: Los arreglos son base 0, provoca un error en la ultima iteración
        for (int i = 0; i < 5; i++)
        {
            int edadIngresada;
            bool valido = false;

            while (!valido)
            {
                Console.WriteLine("Ingrese la edad de la persona " + (i + 1) + ":");

                // Validación: entrada debe ser número entero
                if (int.TryParse(Console.ReadLine(), out edadIngresada))
                {
                    // Validación: la edad no puede ser negativa
                    if (edadIngresada >= 0)
                    {
                        edades[i] = edadIngresada;
                        suma += edadIngresada;

                        // Error encontrado (Error 2): condición > 18 excluye a personas de 18 años
                        // Tipo de error: lógico
                        // Corrección realizada: >= 18
                        // Explicación: El tener 18 te hace mayor de edad

                        if (edades[i] >= 18)
                        {
                            mayores++;
                        }
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("La edad no puede ser negativa.");
                    }
                }
                else
                {
                    Console.WriteLine("Debe ser un número entero");
                }
            }
        }
        // Error encontrado (Error 3): suma/5 es división entera
        // Tipo de error: lógico
        // Corrección realizada: (double)suma / 5
        //Explicación: Al convertir 'suma' a double antes de dividir, el resultado es float y se mantienen los decimales
        promedio = (double)suma / 5;

        Console.WriteLine("El promedio de edades es: " + promedio);
        Console.WriteLine("Cantidad de mayores de edad: " + mayores);

        // Caso 1: 10,15,18,20,30 -> promedio=18.6 -> mayores=3
        // Caso 2: 18,18,18,18,18 -> promedio = 18.0 -> mayores=5
        // Caso 3: 5,6,7,8,9 -> promedio 7.0 -> mayores=0
        // Caso 4: Texto o edad negativa -> No aceptar datos
    }
    static double CalcularArea(double baseRectangulo, double alturaRectangulo)
    {
        double resultado = baseRectangulo * alturaRectangulo;
        //Error encontrado: Formula incorrecta
        //Tipo de error: logico
        //Corrección realizada: en vez de +, se cambio por *
        //Explicación: Estaba sumando Base y altura en vez de multiplicarlas.
        return resultado;
    }
}

// ¿Por qué una solución generada por Inteligencia Artificial debe ser revisada, probada y
// validada por una persona antes de considerarse correcta?

// Porqué La IA puede cometer errores de sintaxis, lógica o ejecución, no realiza el analisis para
// comprender realmente el problema, puede darte un código que 
// pueda parecer que este bien pero que pueda estar incompleto o no cumpla con todo lo solicitado.
//Por eso hay que realizar pruebas, para comprobar que todo funcione correctamente, y que la solución sea 
// correcta y adecuada para el problema planteado