using System;
class program
{
    static void Main()
    {
        //Ejercicio 1
        Console.Write("Ingrese su id --> ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su pin --> ");
        int pin = int.Parse(Console.ReadLine());

        Console.Write("Token de seguridad --> ");
        int token = int.Parse(Console.ReadLine());

        Console.Write("Modo seguro: 1= Si, 0 = No --> ");
        int modoSeguro = int.Parse(Console.ReadLine());

        if(id == 2026)
        {
            Console.WriteLine("Usuario reconocido");
        } else
        {
            Console.WriteLine("Usuario no reconocido");
        }

        if(pin == 1234)
        {
            Console.WriteLine("PIN CORRECTO");
        }else
        {
            Console.WriteLine("PIN INCORRECTO");
        }

        if(token == 777)
        {
            Console.WriteLine("Token correcto");
        }
        else
        {
            Console.WriteLine("Token incorrecto");
        }
        if (modoSeguro == 1)
        {
            Console.WriteLine("Modo seguro activado, se aplican reglas extra");
        }
        else
        {
            Console.WriteLine("Modo seguro desactivado");
        }
        if(id ==2026 && pin == 1234 && token == 777)
        {
            Console.WriteLine("Ingreso concedido");
        }else
        {
            Console.WriteLine("Ingreso denegado");
        }
        if (modoSeguro == 1 && token >= 700)
        {
            Console.WriteLine("Regla extra aprobada");
        }
        else
        {
            Console.WriteLine("Regla extra denegada");
        }

        //Ejercicio 2
        Console.WriteLine("------------------------------------------------------");
        Console.Write("Ingrese su pin");
        int pin4 = int.Parse(Console.ReadLine());
        if(pin4 > 999 && pin4 < 10000)
        {
            Console.WriteLine("PIN valido");
        }
        else
        {
            Console.WriteLine("PIN invalido, debe tener 4 digitos");
        }
        if(pin4 % 2 == 0)
        {
            Console.WriteLine("El pin es par");
        }
        else
        {
            Console.WriteLine("El pin es impar");
        }

        if(pin4 % 5 == 0)
        {
            Console.WriteLine("Es multiplo de 5");
        }
        else
        {
            Console.WriteLine("No es multiplo de 5");
        }

        if (pin4 > 999 && pin4 < 10000 && pin4 % 2 == 0 && pin4 % 5 != 0)
        {
            Console.WriteLine("PIN aceptado por politica");
        }
        else
        {
            Console.WriteLine("PIN rechazado por politica");
        }

        //Ejercicio 3
        Console.WriteLine("------------------------------------------------------");
        Console.Write("Codigo de activación --> ");
        int codigo = int.Parse(Console.ReadLine());
        Console.Write("Ingresa edad --> ");
        int edad = int.Parse(Console.ReadLine());
        Console.Write("Acepto terminos y condiciones (1. Si , 2. No) --> ");
        int terminos = int.Parse(Console.ReadLine());
        bool aceptoTerminos = terminos == 1;
        Console.Write("2FA --> ");
        int dosfa = int.Parse(Console.ReadLine());
        bool fa2 = dosfa == 1;
        Console.Write("Ingrese el puntaje de verificación (0-100) --> ");
        int verif = int.Parse(Console.ReadLine());

        if (verif >= 0 && verif <= 100)
        {
            Console.WriteLine("Puntaje valido");
        }
        else
        {
            Console.WriteLine("Puntaje debe ser entre 0-100");
        }

        if (codigo == 2026)
        {
            Console.WriteLine("Codigo correcto");
        }
        else
        {
            Console.WriteLine("Codigo incorrecto");
        }
        if (edad >= 18)
        {
            Console.WriteLine("Edad valida");
        }else
        {
            Console.WriteLine("Edad no valida");
        }
        if (aceptoTerminos == true)
        {
            Console.WriteLine("Terminos aceptados");
        }
        else
        {
            Console.WriteLine("Debe aceptar terminos");
        }
        if (fa2 == true)
        {
            Console.WriteLine("2FA activado");
        }
        else
        {
            Console.WriteLine("2FA no activo");
        }
        if (verif >= 70)
        {
            Console.WriteLine("Puntaje suficiente");
        }
        else
        {
            Console.WriteLine("Puntaje no suficiente");
        }
        if(codigo == 2026 && edad >= 18 && aceptoTerminos == true && fa2 == true && verif >= 70)
        {
            Console.WriteLine("Cuenta activada exitosamente");
        } 
        else
        {
            Console.WriteLine("Cuenta no activada");
        }
        //Ejercicio 4
        Console.WriteLine("------------------------------------------------------");
        Console.Write("Ingrese la nota previa (0-100) --> ");
        int nota = int.Parse(Console.ReadLine());

        if (nota <= 100 && nota >= 0)
        {
            Console.WriteLine("Puntaje valido");
        }
        else
        {
            Console.WriteLine("Puntaje debe ser entre 0-100");
        }
        Console.Write("Minutos de llegada tarde --> ");
        int tarde = int.Parse(Console.ReadLine());

        Console.Write("Tiene solvencia de pagos (1. Si 0. No) -->");
        int solvencia = int.Parse(Console.ReadLine());
        bool pagos = solvencia == 1;

        Console.Write("Trae identificación física (1. Si, 0. No) --> ");
        int fisica = int.Parse(Console.ReadLine());
        bool identificacion = fisica == 1;

        Console.Write("Trae calculadora permitida (1. Si, 0. No) --> ");
        int permitida = int.Parse(Console.ReadLine());
        bool calcu = permitida == 1;

        if(nota >= 61)
        {
            Console.WriteLine("Requisito académico aprobado.");
        }
        else
        {
            Console.WriteLine("Requisito académico NO aprobado.");
        }
        if (tarde <= 10)
        {
            Console.WriteLine("Hora valida");
        }
        else
        {
            Console.WriteLine("Hora no valida");
        }
        if (pagos == true)
        {
            Console.WriteLine("Solvencia validada");
        }
        else 
        {
            Console.WriteLine("Sin solvencia");
        }
        if (identificacion == true)
        {
            Console.WriteLine("Identificación validada");
        }
        else
        {
            Console.WriteLine("Identificacion no valida");
        }
        if (calcu == true)
            {
            Console.WriteLine("Calculadora permitida");
            }
        else
        {
            Console.WriteLine("Calculadora no permitida");
        }
        if (nota >= 61 && tarde <= 10 && pagos == true && identificacion == true)
        {
            Console.WriteLine("Acceso a sala de examen concedido");
        }
        else
        {
            Console.WriteLine("Acceso denegado");
        }

        if (tarde > 0 && tarde <= 10)
        {
            Console.WriteLine("Advertencia: llegó tarde, pero aún puede ingresar.");
        }




    }
}