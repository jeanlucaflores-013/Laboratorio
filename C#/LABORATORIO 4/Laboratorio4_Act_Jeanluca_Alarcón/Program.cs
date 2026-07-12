using System;
class Program{ 
    static void Main(){

        // Ejercicio 1
        string modelo = "PCfordummies";
        Console.WriteLine("Modelo de la nave: " + modelo);

        int capacidad = 3000;
        Console.WriteLine("Capacidad de carga: " + capacidad);

        float nivelCombustible = 33.1f;
        Console.WriteLine("El nivel de combustible esta en: " + nivelCombustible);

        bool salto = true;
        Console.WriteLine("¿Motor de salto activo? " + salto);

        // Ejercicio 2
        short sensoresActivos = 128;
        int registroProcesador = sensoresActivos;
        double precisionTotal = registroProcesador;
        Console.WriteLine("Precisión total: " + precisionTotal);

        // Ejercicio 3
        double energiaGenerada = 987.65;
        int energiaLimitada = (int)energiaGenerada;
        Console.WriteLine("Energia Generada: " + energiaGenerada);
        Console.WriteLine("Energia Limitada: " + energiaLimitada);

        // Ejercicio 4

        Console.Write("Ingrese la distancia al planeta más cercano: ");
        string entradaRadar = Console.ReadLine();

        int distancia = int.Parse(entradaRadar);
        distancia = distancia + 100;
        Console.WriteLine("Distancia con margen de seguridad: " + distancia);

        // Ejercicio 5

        string señalOxigeno = "true";
        bool oxigeno = Convert.ToBoolean(señalOxigeno);
        string temperaturaCabina = "22.8";
        double temperatura = Convert.ToDouble(temperaturaCabina);
        Console.WriteLine("Señal oxígeno:" + oxigeno);
        Console.WriteLine("Temperatura cabina " + temperatura);

        // Ejercicio 6

        double velocidadLuz = 299792.458;
        string t1 = velocidadLuz.ToString();
        string t2 = velocidadLuz.ToString("N3");
        Console.WriteLine("Normal: " + t1);
        Console.WriteLine("Texto N3: " + t2);

        //Ejercicio 7
        Console.Write("Ingrese el valor del galon: ");
        string precioGalon = Console.ReadLine();

        double precio = Convert.ToDouble(precioGalon);
        double precioImpuesto = precio * (0.12);
        double precioTotal = precio + precioImpuesto;
        int precioFinal = (int)precioTotal;
        Console.WriteLine("El costo final del suministro es: " + precioFinal);




    }
}