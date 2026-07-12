using System;
class Persona
{
    public string nombre;
    public int edad;
    public double altura;
    public bool estudiante;

}

class Vehiculo
{
    public string marca;
    public string modelo;
    public int anio;
    public string color;
    public string placa;
}

class Producto
{
    public string codigo;
    public string nombre;
    public double precio;
    public int stock;
    public bool disponible;
}

class Mascota
{
    public string nombre;
    public string especie;
    public int edad;
    public double peso;
    public bool vacunado;
}
class Program
{
    static void Main()
    {
        //Ejercicio 1
        Persona pers = new Persona();
        pers.nombre = "Jean";
        pers.edad = 18;
        pers.altura = 1.71;
        pers.estudiante = true;

        Console.WriteLine();
        Console.WriteLine("Nombre: " + pers.nombre);
        Console.WriteLine("Edad: " + pers.edad);
        Console.WriteLine("Altura: " + pers.altura);
        Console.WriteLine("Estudiante: " + pers.estudiante);


        //Ejercicio 2
        Vehiculo carro = new Vehiculo();
        carro.marca = "Audi";
        carro.modelo = "Sedan";
        carro.anio = 2006;
        carro.color = "azul";
        carro.placa = "999KLK"; 

        Console.WriteLine();
        Console.WriteLine("Marca: " + carro.marca);
        Console.WriteLine("Modelo: "+ carro.modelo);
        Console.WriteLine("Año: "+  carro.anio);
        Console.WriteLine("Color: " + carro.color);
        Console.WriteLine("Placa: " + carro.placa);

        //Ejercicio 3

        Producto p1 = new Producto();
        p1.codigo = "J301";
        p1.nombre = "Laptop";
        p1.precio = 3743.23;
        p1.stock = 10;
        p1.disponible = true;

        Producto p2 = new Producto();
        p2.codigo = "P302";
        p2.nombre = "Mouse";
        p2.precio = 250.35;
        p2.stock = 15;
        p2.disponible = true;

        Console.WriteLine();
        Console.WriteLine("Producto 1: ");
        Console.WriteLine("Código: "+ p1.codigo);
        Console.WriteLine("Nombre: " + p1.nombre);
        Console.WriteLine("Precio: " + p1.precio);
        Console.WriteLine("Stock: " + p1.stock);
        Console.WriteLine("Disponible: " + p1.disponible);

        Console.WriteLine();
        Console.WriteLine("Producto 2");
        Console.WriteLine("Código: " + p2.codigo);
        Console.WriteLine("Nombre: "+ p2.nombre);
        Console.WriteLine("Precio: "+ p2.precio);
        Console.WriteLine("Stock: " + p2.stock);
        Console.WriteLine("Disponible: " + p2.disponible);

        //Ejercicio 
        Mascota m = new Mascota();
        m.nombre = "Max";
        m.especie = "Perro";
        m.edad = 1;
        m.peso = 6.5;
        m.vacunado = true;

        Console.WriteLine();
        Console.WriteLine("Nombre: " + m.nombre);
        Console.WriteLine("Especie: " + m.especie);
        Console.WriteLine("Edad: " + m.edad);
        Console.WriteLine("Peso: " + m.peso);
        Console.WriteLine("Vacunado: " + m.vacunado);
    }
}


