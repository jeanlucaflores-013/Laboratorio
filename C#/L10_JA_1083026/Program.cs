using System;
class Program
{
    static void Main()
    {
        //Ejercicio 1
        Console.WriteLine("Ejercicio 1");
        Console.Write("Ingresa un número: ");
        int num = int.Parse(Console.ReadLine());

        while(num < 0)
        {
            Console.WriteLine("Numero incorrecto, intente nuevamente");
            num = int.Parse(Console.ReadLine());
        }

        int resultado = SumaDigitos(num);
        Console.WriteLine("El resultado es: " + resultado);

        //Ejercicio 2
        Console.WriteLine();
        Console.WriteLine("Ejercicio 2");
        Console.Write("Ingrese un número entero: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Número ingresado: " + n);
        string mensaje = Cuadrado(ref n);
        Console.WriteLine("Número elevado al cuadrado: " + n);
        Console.WriteLine(mensaje);

        //Ejercicio 3
        Console.WriteLine();
        Console.WriteLine("Ejercicio 3");
        Console.Write("Ingrese el precio del producto: ");
        float precio = float.Parse(Console.ReadLine());

        Console.Write("Ingrese el descuento del producto (Ejemplo: 0.25): ");
        float descuento = float.Parse(Console.ReadLine());
        while(descuento < 0.00 || descuento > 1.00)
        {
            Console.WriteLine("Intenta nuevamente el descuento");
            descuento = float.Parse(Console.ReadLine());
        }

        Console.WriteLine("Antes --> Precio: " + precio + " Descuento: " + descuento);
        float monto = tienda(ref precio, descuento);
        Console.WriteLine("Despues --> Precio: " + precio + " Descuento: " + monto);

        //Ejercicio 4
        Console.WriteLine();
        Console.WriteLine("Ejercicio 4");
        Console.WriteLine("Ingrese las unidades de energia del jugador (Max:20): ");
        int energiaJugador = int.Parse(Console.ReadLine());

        while(energiaJugador > 20 || energiaJugador < 1 )
        {
            Console.WriteLine("Energia inválida, intente nuevamente");
            energiaJugador = int.Parse(Console.ReadLine());
        }
        consumirEnergia(ref energiaJugador);
        Console.WriteLine("Energia restante: "+ energiaJugador);
        recargarEnergia(ref energiaJugador);
        Console.WriteLine("Energia recargada: " + energiaJugador);
        string estado = obtenerEstado(energiaJugador);
        Console.WriteLine("Estado de la energia: " + estado);
        char rendimiento = calcularRendimiento(energiaJugador);
        Console.WriteLine("Rendimiento: " + rendimiento);

    }

    static int SumaDigitos(int num)
    {
        int suma = 0;
        while (num > 0)
        {
            suma += num % 10;
            num = num / 10;
        }
        return suma;
    }

    static string Cuadrado(ref int numero)
    {
        numero = numero * numero;
        return "Operación Exitosa";
    }

    static float tienda(ref float precio, float descuento)
    {
        float montoDescuento = precio * descuento;
        precio -= montoDescuento;
        return montoDescuento;
    }

    static int consumirEnergia(ref int energiaJugador)
    {
        energiaJugador -= 4;
        if(energiaJugador < 0)
        {
            energiaJugador = 0;
        }
        return energiaJugador;
    }

    static int recargarEnergia(ref int energiaJugador)
    {
        energiaJugador += 6;
        if (energiaJugador > 20)
        {
            energiaJugador = 20;
        }
        return energiaJugador;
    }

    static string obtenerEstado(int energiaJugador)
    {
        string estado;
        if (energiaJugador <= 20 && energiaJugador >= 15)
        {
            estado = "Alta";
        }
        else
        {
            if(energiaJugador <= 14 && energiaJugador >= 8)
            {
                estado = "Media";
            }
            else
            {
                estado = "Baja";
            }
        }
        return estado;
    }

    static char calcularRendimiento(int energiaJugador)
    {
        char calif;
        if (energiaJugador == 20)
        {
            calif = 'S';
        }
        else
        {
            if (energiaJugador <= 19 && energiaJugador >= 15)
            {
                calif = 'A';
            }
            else
            if(energiaJugador <= 14 && energiaJugador >= 8)
            {
                calif = 'B';
            }
            else
            {
                calif = 'C';
            }
        }
        return calif;
    }
}