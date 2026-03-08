using System;
class Program
{
    static void Main()
    {
        //Ejercicio 1
        Console.WriteLine("Ingrese su vehiculo 1. Bicicleta, 2. Motocicleta, 3. Auto, 4. Camión, 5. Autobús");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Vehiculo no motorizado");
                break;

            case 2:
                Console.WriteLine("Vehiculo Ligero");
                break;
            case 3:
                Console.WriteLine("Vehiculo mediano");
                break;
            case 4:
                Console.WriteLine("Vehiculo pesado");
                break;
            case 5:
                Console.WriteLine("Transporte publico");
                break;
            default:
                Console.WriteLine("Debe ingresar un tipo de vehiculo");
                break;
        }

        //Ejercicio 2
        Console.Write("¿Cuanto es su limite de credito? --> ");
        double limite = double.Parse(Console.ReadLine());
        Console.Write("Que tipo de tarjeta tiene?");
        int tarjeta = int.Parse(Console.ReadLine());
        double r;
        switch (tarjeta)
        {
            case 1:
                r = limite * (1.25);
                break;
            case 2:
                r = limite * (1.35);
                break;
            case 3:
                r = limite * (1.40);
                break;
            default:
                r = limite * (1.50);
                break;
        }
        Console.WriteLine("Su nuevo limite es de: " + r);

        // Ejercicio 3:
        Console.Write("Nombre del empleado --> ");
        string nom = Console.ReadLine();
        float puntuacion = -1;
        while (puntuacion != 0.0f && puntuacion != 0.4f && puntuacion < 0.6f)
        {
            Console.Write("Ingrese puntuación del empleado --> ");
            puntuacion = float.Parse(Console.ReadLine());
        }
        if (puntuacion <= 0.0f)
        {
            Console.WriteLine("Nivel inaceptable");
        }
        else if (puntuacion == 0.4f)
        {
            Console.WriteLine("Nivel Aceptable");
        }
        else
        {
            Console.WriteLine("Nivel meritorio");
        }


        float dinero = 2400 * puntuacion;
        Console.WriteLine("Cantidad de dinero recibida: " + dinero);

        //Ejercicio 4
        Console.WriteLine("Bienvenido a pizzeria Bella Napoli, usted es vegetariano? 1. Si 2. No");
        int vegetariano = int.Parse(Console.ReadLine());

        string ingrediente = "";
        if (vegetariano == 1)
        {
            Console.WriteLine("Ingredientes vegetariano: ");
            Console.WriteLine("1. Pimiento");
            Console.WriteLine("2. Tofu");

            int opcionn = int.Parse(Console.ReadLine());

            if (opcionn == 1)
            {
                ingrediente = "Pimiento";
            }
            else if (opcionn == 2)
            {
                ingrediente = "Tofu";
            }
            else
            {
                Console.WriteLine("Opción inválida");
                return;
            }
            Console.WriteLine("Su pizza es vegetariana.");
        }
        else
        {
            Console.WriteLine("Ingredientes no vegetarianos: Peperoni, Jamon, Salmón");
            Console.WriteLine("1. Peperoni");
            Console.WriteLine("2. Jamon");
            Console.WriteLine("3. Salmón");
            int opcionn = int.Parse(Console.ReadLine());

            if (opcionn == 1)
            {
                ingrediente = "Peperoni";
            }
            else if (opcionn == 2)
            {
                ingrediente = "Jamon";
            }
            else if (opcionn == 3)
            {
                ingrediente = "Salmón";
            }
            else
            {
                Console.Writeline("Opción Invalida");
                return;
            }else
            {
                Console.WriteLine("Opción Inválida");
                return;
            }
            Console.WriteLine("Su pizza no es vegetariana");
        }
        Console.WriteLine("Sus ingredientes son: Tomate, Mozzarella, " + ingrediente);

    }
}