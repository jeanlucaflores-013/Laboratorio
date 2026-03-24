using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("¡Bienvenido a SmartPark!");
        Console.Write("Ingrese nombre del operador: ");
        string operador = Console.ReadLine();
        Console.Write("Código de turno: ");
        string turno = Console.ReadLine();

        while(turno.Length != 4)
        {
            Console.WriteLine("Código inválido, intenta otra vez");
            turno = Console.ReadLine();

        }

        Console.Write("Ingrese capacidad de parqueo (Minimo 10)");
        int capacidad = int.Parse(Console.ReadLine());

        while(capacidad < 10)
        {
            Console.WriteLine("Capacidad incorrecta, minimo 10 ");
            capacidad = int.Parse(Console.ReadLine());
        }
        
        int ticketsCreados = 0, ticketsCerrados = 0, tiempoSimulado = 0, minutoEntrada = 0;
        double dineroRecaudado = 0.00;
        bool ticketActivo = false;
        char opcionMenu;
        string placaActual = "", clienteActual = "";

        while (true)
        {
            Console.WriteLine("======== MENU ========");
            Console.WriteLine(" A. CREAR TICKET DE ENTRADA");
            Console.WriteLine(" B. REGISTRAR SALIDA Y CALCULAR COBRO");
            Console.WriteLine(" C. VER ESTADO DE PARQUEO");
            Console.WriteLine(" D. SIMULAR PASO DEL TIEMPO");
            Console.WriteLine(" E. SALIR");
            opcionMenu = char.Parse(Console.ReadLine().ToUpper());

            switch (opcionMenu)
            {
                case 'A':
                    CrearTicket(ref ticketActivo, ref ticketsCreados, ticketsCerrados, capacidad, ref minutoEntrada, ref placaActual, ref clienteActual);
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 'B':
                    Console.WriteLine("HOLA");
                    break;

                case 'C':
                    int espaciosOcupados = ticketsCreados - ticketsCerrados;
                    int espaciosDisponibles = capacidad - espaciosOcupados;
                    estadoParqueo(capacidad, espaciosOcupados, espaciosDisponibles, tiempoSimulado, dineroRecaudado, ticketsCreados, ticketsCerrados);
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 'D':
                    simularTiempo(ref tiempoSimulado);
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 'E':
                    Console.WriteLine("Fin del programa.");
                    break;
                    

            }
        }
        static void CrearTicket(ref bool ticketActivo, ref int ticketsCreados, int ticketsCerrados, int capacidad, ref minutoEntrada, ref string placaActual, ref string clienteActual)
        {
            if (ticketActivo)
                {
                    Console.WriteLine("Ya existe un ticket activo");
                    return;
                }

                if((ticketsCreados - ticketsCerrados) >= capacidad)
                {
                    Console.WriteLine("Parqueo lleno");
                    return;
                }

                Console.Write("Ingrese la placa del vehiculo: ");
                string placa = Console.ReadLine();

                if(placa.Length < 6 || placa.Length > 8 || placa.Contains(" "))
                {
                    Console.WriteLine("Placa ingresada incorrectamente");
                    return;
                }

                Console.WriteLine("Ingrese su tipo de vehiculo (1 = Moto, 2 = Auto, 3 = Pickup/SUV)");
                int tipoVehiculo = int.Parse(Console.ReadLine());

                if(tipoVehiculo > 3 || tipoVehiculo < 1)
                {
                    Console.WriteLine("Tipo de vehiculo incorrecto");
                    return;
                }

                Console.WriteLine("Nombre del cliente: ");
                string usuario = Console.ReadLine();

                placaActual = placa;
                ticketActivo = true;
                ticketsCreados += 1;
                clienteActual = usuario;
                minutoEntrada = tiempoSimulado;

                Console.WriteLine("Ticket creado");
                
                return;
        }

        static void estadoParqueo(int capacidad, int espaciosOcupados, int espaciosDisponibles, int tiempoSimulado, double dineroRecaudado, int ticketsCreados, int ticketsCerrados)
        {
            Console.WriteLine("La capacidad total es: " + capacidad);

            Console.WriteLine("Los espacios ocupados son: " + espaciosOcupados);

            Console.WriteLine("Los espacios libres son: " + espaciosDisponibles);

            Console.WriteLine("El tiempo es: " + tiempoSimulado);

            Console.WriteLine("El total recaudado es: " + dineroRecaudado + "Q");

            Console.WriteLine("Los tickets creados han sido: " + ticketsCreados);

            Console.WriteLine("Los tickets cerrados han sido: " + ticketsCerrados);

            return;
        }

        static void simularTiempo(ref int tiempoSimulado)
        {
            Console.Write("Ingrese minutos de 1 a 1440: ");
            int minutosSimulacion = int.Parse(Console.ReadLine());

            while (minutosSimulacion < 1 || minutosSimulacion > 1440)
            {
                Console.WriteLine("No valido, debe ser entre 1 y 1440. ");
                minutosSimulacion = int.Parse(Console.ReadLine());
            }

            tiempoSimulado = tiempoSimulado + minutosSimulacion;
            Console.WriteLine("Tiempo acumulado: " + tiempoSimulado);
        }
    }
}