using System;
using System.Linq;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main()
    {
        int actual;

        do
        {
            Console.Clear(); //Limpiamos la pantalla a cada vuelta al menú
                             //Creamos el menú \n nueva línea, \t tabulación
            Console.Write("\n\n\t1.- ¿Calcular máximo?\n\t" +
                          "2.- ¿Calcular mínimo?\n\t" +
                          "3.- ¿Calcular la mediana?\n\t" +
                          "4.- ¿Calcular la media?\n\t" +
                          "5.- ¿Ordenar un Array de menor a mayor?\n\t" +
                          "6.- ¿Calcular la desviación típica de un array?\n\t" +
                          "7.- Binarizar un array en base a un número n. Esta función devolverá un nuevo array, cuyos elementos valdrán 0 o 1.\n\t" +
                          "Si el componente i del array original es menor que n, el componente i del array resultado será 0, y 1 en el caso contrario." +
                          "\n\n\t0.- Salir" +
                          "\n\n\tElija una opción: ");
            //Console readkey para que no haga falta pulsar enter
            actual = Console.ReadKey().KeyChar - 48;
            Console.Clear();
            switch (actual) //Según la opción seleccionada actuamos
            {
                case 1:
                    Parte1(); //Invocación de la función
                    break;
                case 2:
                    Parte2(); //Invocación de la función
                    break;
                case 3:
                    Parte3(); //Invocación de la función
                    break;
                case 4:
                    Parte4(); //Invocación de la función
                    break;
                case 5:
                    Parte5(); //Invocación de la función
                    break;
                case 6:
                    Parte6(); //Invocación de la función
                    break;
                case 7:
                    Parte7(); //Invocación de la función
                    break;
                default:
                    //Cualquier input distinto a las opciones dadas saldrá del programa sin acciones
                    break;
            }
        } while (actual >= 1 && actual <= 7);
    }

    private static void Parte1()
    {
        // Pido el tamaño del array
        Console.WriteLine("Número de elementos del array.\n");
        int maximoElemento = LeerEntero(false, true);

        // Los voy introduciendo dentro de elementosArray
        decimal[] elementosArray = new decimal[maximoElemento];
        for (int i = 0; i < maximoElemento; i++)
        {
            Console.Write("\nIntroduce los elementos del array (" + i + ") : ");
            // Comprobando que sean números
            while (!decimal.TryParse(Console.ReadLine(), out elementosArray[i]))
            {
                Console.Write("\nERROR. Introduzca un número: ");
            }
        }

        // Imprimo la array introducida por el usuario
        Console.Write("\t\nArray introducida.\n");
        foreach (decimal elementos in elementosArray)
        {
            Console.Write(elementos + " ");
        }

        Console.Write("\t\n\nEl máximo elemento del array es: " + elementosArray.Max() + ".");
        Console.WriteLine("Pulse una tecla para continuar");
        Console.ReadKey();
    }

    private static void Parte2()
    {
        // Pido el tamaño del array
        Console.WriteLine("Número de elementos del array.\n");
        int maximoElemeto = LeerEntero(false, true);

        // Los voy introduciendo dentro de elementosArray
        decimal[] elementosArray = new decimal[maximoElemeto];
        for (int i = 0; i < maximoElemeto; i++)
        {
            Console.Write("\nIntroduce los elementos del array (" + i + ") : ");
            // Comprobando que sean números
            while (!decimal.TryParse(Console.ReadLine(), out elementosArray[i]))
            {
                Console.Write("\nERROR. Introduzca un número: ");
            }
        }

        // Imprimo la array introducida por el usuario
        Console.Write("\t\nArray introducida.\n");
        foreach (decimal elementos in elementosArray)
        {
            Console.Write(elementos + " ");
        }

        Console.Write("\t\n\nEl mínimo elemento del array es: " + elementosArray.Min() + ".");
        Console.ReadKey();
    }

    private static void Parte3()
    {
        decimal[] arr;

        Console.WriteLine("Número de elementos del array.\n"); //Pedimos el total de elementos
        arr = new decimal[LeerEntero(false, true)]; //Inicializamos el array
        for (int i = 0; i < arr.Length; i++)
            arr[i] = LeerDecimal(true, false, i + 1); //Rellenamos el array
        Console.Write($"La mediana de [{String.Join(", ", arr)}] es: {Median(arr)}");
        Console.ReadKey();

        static decimal Median(decimal[] xs)
        {
            var ys = xs.OrderBy(x => x).ToList();
            double mid = (ys.Count - 1) / 2.0;
            return (ys[(int)(mid)] + ys[(int)(mid + 0.5)]) / 2;
        }
    }

    private static void Parte4()
    {
        decimal[] arr;

        Console.WriteLine("Número de elementos del array.\n"); //Pedimos el total de elementos
        arr = new decimal[LeerEntero(false, true)]; //Inicializamos el array
        for (int i = 0; i < arr.Length; i++)
            arr[i] = LeerDecimal(true, false, i + 1); //Rellenamos el array
        Console.Write($"La media de [{String.Join(", ", arr)}] es: {arr.Average()}");
        Console.ReadKey();
    }

    private static void Parte5()
    {
        Console.WriteLine("Introduce el tamaño de la array");
        int tamanioArray = LeerEntero(false, true); //Lee el tamaño que tendra la array de valores
        Console.WriteLine($"Introduce los {tamanioArray} valores.");
        decimal[] array = new decimal[tamanioArray];
        //Ir pidiendo al usuario tantos valores como espacios en la array
        for (int i = 0; i < tamanioArray; i++)
            array[i] = LeerDecimal(true, true, i+1);
        Array.Sort(array);  //Ordena a traves de .Sort la array 
        Console.WriteLine("Array ordenada: (MAYOR A MENOR)");
        Console.WriteLine("[{0}]", string.Join(", ", array));
        Console.ReadKey();
    }

    private static void Parte6()
    {
        Console.WriteLine("Introduce el tamaño de la array");
        int tamanioArray = LeerEntero(false, true); //Lee el tamaño que tendra la array de valores
        Console.WriteLine($"Introduce los {tamanioArray} valores.");
        double[] array = new double[tamanioArray];
        //Ir pidiendo al usuario tantos valores como espacios en la array
        for (int i = 0; i < tamanioArray; i++)
            array[i] = LeerDouble(true, true, i + 1);
        //A partir de aqui se calcula la desviacion tipica, sacando medias, sumas y etc.
        double avg = array.Average();       
        double sum = array.Sum(d => Math.Pow(d - avg, 2));
        Console.Write($"La desviacion de tipica de {string.Join(", ", array)} es: ");
        Console.WriteLine(Math.Sqrt((sum)/tamanioArray-1));
        Console.ReadKey();
    }

    private static void Parte7()
    {
        //Aquí código
    }

    private static int LeerEntero(bool borrar = false, bool positivo = false, int sucesion = -1)
    {
        int num;
        // Pedimos la variable y validamos que es un número entero
        if (borrar)
            Console.Clear();
        if (sucesion == -1)
            Console.Write($"Introduzca un número entero {(positivo ? "positivo " : "")}por favor: ");
        else
            Console.Write($"Introduzca el número {sucesion}: ");
        while (!Int32.TryParse(Console.ReadLine(), out num) && (!positivo || num > 0))
            Console.WriteLine("Introduzca un número válido por favor: ");
        return num;
    }

    private static Decimal LeerDecimal(bool borrar = false, bool positivo = false, int sucesion = -1)
    {
        decimal num;
        // Pedimos la variable y validamos que es un número entero
        if (borrar)
            Console.Clear();
        if (sucesion == -1)
            Console.Write($"Introduzca un número {(positivo ? "positivo " : "")}por favor: ");
        else
            Console.Write($"Introduzca el número {sucesion}: ");
        while (!Decimal.TryParse(Console.ReadLine(), out num) && (!positivo || num > 0))
            Console.WriteLine("Introduzca un número válido por favor: VALOR VALIDO: DECIMAL");
        return num;
    }
    private static Double LeerDouble(bool borrar = false, bool positivo = false, int sucesion = -1)
    {
        double num;
        // Pedimos la variable y validamos que es un número entero
        if (borrar)
            Console.Clear();
        if (sucesion == -1)
            Console.Write($"Introduzca un número {(positivo ? "positivo " : "")}por favor: ");
        else
            Console.Write($"Introduzca el número {sucesion}: ");
        while (!Double.TryParse(Console.ReadLine(), out num) && (!positivo || num > 0))
            Console.WriteLine("Introduzca un número válido por favor: ");
        return num;
    }
}