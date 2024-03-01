{
        int numero;
        char opcion;
        bool salir = false;
        do 
        {
            Console.Write("Ingrese un numero entero positivo: ");
            numero = int.Parse(Console.ReadLine());
            if (numero <= 0)
            {
                Console.WriteLine("Debe ingresar un numero entero positivo.");
                continue;
            }

            Console.WriteLine("Menu de opciones:");
            Console.WriteLine("a) Calcular el factorial del numero.");
            Console.WriteLine("b) Calcular la raiz cuadrada del numero.");
            Console.WriteLine("c) Salir del programa.");
            Console.Write("Elija una opcion: ");
            opcion = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();
            switch(opcion)
            {
                case 'a':
                    {
                        int factorial = 1;
                        for (int i = 1; i <= numero; ++i)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine("El factorial de {0} es: {1}", numero, factorial);
                    }
                    break;
                case 'b':
                    Console.WriteLine("La raiz cuadrada de {0} es: {1}", numero, Math.Sqrt(numero));
                    break;
                case 'c':
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opcion no valida. Intente de nuevo.");
                    break;
            }
        } while (!salir);
        Console.WriteLine("Fin del programa.");
}


{
    Console.WriteLine("\nCalculadora básica");
    Console.Write("Ingrese el primer número entero: ");
    if (!int.TryParse(Console.ReadLine(), out int num1))
    {
        Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
        return;
    }
    Console.Write("Ingrese el segundo número entero: ");
    if (!int.TryParse(Console.ReadLine(), out int num2))
    {
        Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
        return;
    }
    Console.Write("Ingrese el operador matemático (+, -, *, /): ");
    char operador = Console.ReadKey().KeyChar;
    Console.WriteLine();
    double resultado = 0;
    switch (operador)
    {
        case '+':
            resultado = num1 + num2;
            break;
        case '-':
            resultado = num1 - num2;
            break;
        case '*':
            resultado = num1 * num2;
            break;
        case '/':
            if (num2 == 0)
            {
                Console.WriteLine("División por cero.");
                return;
            }
            resultado = (double)num1 / num2;
            break;
        default:
            Console.WriteLine("Operador no válido. Debe ingresar uno de los siguientes: +, -, *, /");
            return;
    }
    Console.WriteLine($"El resultado de {num1} {operador} {num2} es: {resultado}");
}

{
    int num3;
    Console.WriteLine("\nTablas de Multiplicar");
    Console.Write("Ingrese un numero para mostrar su tabla de multiplicar: ");
    num3 = int.Parse(Console.ReadLine());

    Console.WriteLine($"Tabla de multiplicar del {num3} :");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("{0} x {1} = {2}", num3, i, num3 * i);
    }
}

{
    Random random = new Random();
    int num4 = random.Next(1, 101);
    int intento, intentosr = 0;
    bool adivinado = false;
    Console.WriteLine("\nBienvenido al juego de adivinar el número secreto.");
    Console.WriteLine("El número secreto está entre 1 y 100.");
    do
    {
        Console.Write("Ingrese un número: ");
        intento = int.Parse(Console.ReadLine());
        intentosr++;

        if (intento == num4)
        {
            Console.WriteLine("Has adivinado el número secreto en {0} intentos", intentosr);
            adivinado = true;
        }
        else if (intento < num4)
        {
            Console.WriteLine("El número secreto es mayor que {0}.", intento);
        }
        else
        {
            Console.WriteLine("El número secreto es menor que {0}.", intento);
        }
    } while (!adivinado);
    Console.WriteLine("Gracias por jugar.");
}




