using System;
class Estudiante
{
    public string nombre;
    public int edad;
    public string grado;
    public double[] notas;

    public Estudiante(string nombre, int edad, string grado, double[] notas)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.grado = grado;
        this.notas = notas;
    }

    public double calcularPromedio()
    {
        double suma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
        }

        return suma / notas.Length;
    }
        public void info()
        {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Grado: " + grado);
        Console.Write("Notas: ");

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write(notas[i] + " ");
        }
        Console.WriteLine("Promedio: " + calcularPromedio());
        Console.WriteLine();
    }

    public void aprobar()
    {
        if (calcularPromedio() >= 61)
        {
            Console.WriteLine(nombre + " aprobó.");
        }
        else
        {
            Console.WriteLine(nombre + " no aprobó.");
        }
}
    public void agregar(double nuevaNota)
    {
        double[] nuevasNotas = new double[notas.Length + 1];

        for (int i = 0; i < notas.Length; i++)
        {
            nuevasNotas[i] = notas[i];
        }

        nuevasNotas[nuevasNotas.Length - 1] = nuevaNota;

        notas = nuevasNotas;

        Console.WriteLine("Nueva nota agregada: " + nuevaNota);
    }
}
class Mascota
{
    public string nombre;
    public string especie;
    public int edad;
    public bool vacunado;

    public Mascota(string nombre, string especie, int edad, bool vacunado)
    {
        this.nombre = nombre;
        this.especie = especie;
        this.edad = edad;
        this.vacunado = vacunado;
    }
    public void mostrarInformacion()
    {
        Console.WriteLine("Nombre: " +nombre);
        Console.WriteLine("Especie: " +especie);
        Console.WriteLine("Edad: " +edad);
        Console.WriteLine("Vacunado: " +vacunado);
        Console.WriteLine();
    }
    public void vacunar()
    {
        vacunado = true;
        Console.WriteLine(nombre + "fue vacunado");
    }

    public void anios()
    {
        edad++;
        Console.WriteLine(nombre + " cumplio años!!! ahora tiene: " + edad);
    }
}
class Libro
{
    public string titulo;
    public string autor;
    public int anioPublicacion;
    public bool disponible;


    public Libro(string titulo, string autor, int anioPublicacion, bool disponible)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.anioPublicacion = anioPublicacion;
        this.disponible = disponible;
    }

    public void mostrar()
    {
        Console.WriteLine("Titulo: " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Año de publicación: " + anioPublicacion);
        Console.WriteLine("Disponible: " + disponible);
        Console.WriteLine();
    }

    public void prestarLibro()
    {
        if (disponible)
        {
            disponible = false;
                Console.WriteLine("El libro: " + titulo + " fue prestado ");
        }
        else
        {
            Console.WriteLine("El libro: " + titulo + " no esta disponible ");
        }
    }

    public void devolverLibro()
    {
        disponible = true;
        Console.WriteLine("El libro: " + titulo + " fue devuelto");
    }
}
class Program
{


    static void Main(string[] args)
    {
        //Ejercicio 1
        Libro libro1 = new Libro("Percy Jackson y el ladrón del rayo", "Rick Riordan", 2007, true);
        Libro libro2 = new Libro("Terapia para llevar", "Ana Pérez", 2020, true);

        Console.WriteLine("INFO: ");
        libro1.mostrar();
        libro2.mostrar();

        libro1.prestarLibro();
        libro1.mostrar();

        libro1.devolverLibro();
        libro1.mostrar();

        libro2.prestarLibro();
        libro2.mostrar();

        libro2.devolverLibro();
        libro2.mostrar();

        //Ejercicio 2
        Mascota mascota1 = new Mascota("Bombon", "Perro", 12, false);
        Mascota mascota2 = new Mascota("Peter", "Gato", 2, true);

        Console.WriteLine("INFO: ");
        mascota1.mostrarInformacion();
        mascota2.mostrarInformacion();

        Console.WriteLine("Vacunar mascota ");
        mascota1.vacunar();
        mascota1.mostrarInformacion();

        Console.WriteLine("Cumpleaños");
        mascota2.anios();
        mascota2.mostrarInformacion();

        //Ejercicio 3
        double[] notas1 = { 60, 80, 36 };
        double[] notas2 = { 50, 95, 87 };

        Estudiante estudiante1 = new Estudiante("Samuel", 18, "5to Bach", notas1);
        Estudiante estudiante2 = new Estudiante("Pamela", 17, "3ro Basico", notas2);

        estudiante1.info();
        estudiante2.info();
        Console.WriteLine();

        estudiante1.aprobar();
        estudiante2.aprobar();
        Console.WriteLine();

        Console.WriteLine("Nueva nota: ");
        estudiante1.agregar(99);

        estudiante1.info();
        estudiante1.aprobar();
    }
}

