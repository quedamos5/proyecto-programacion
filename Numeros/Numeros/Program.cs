using System;

internal class Program
{
    private static void Main()
    {
        int actual;

        do
        {
            Console.Clear(); //Limpiamos la pantalla a cada vuelta al menú
            //Creamos el menú \n nueva línea, \t tabulación
            Console.Write("\n\n\t1.- ¿Número primo?\n\t2.- Factorial\n\t3.- Convertir número de segundos a H : M : S\n\t4.- 15 primeros números de la " +
                "serie de Pell\n\t5.- ¿Número de Armstrong?\n\t6.- ¿El número introducido está conformado por cifras totalmente distintas?\n\n\t0.- Salir\n\n\tElija una opción: ");
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
                default:
                    //Cualquier input distinto a las opciones dadas saldrá del programa sin acciones
                    break;
            }
        } while (actual >= 1 && actual <= 6);
        Console.ReadKey();
    }

    private static void Parte1()
    {
        int num = LeerNúmero();
        int primo = 0;
        //Un número primo es aquel cuyos divisores son el 1 y el mismo.
        for (int i = 2; i < num; i++)
            if (num % i == 0)
                primo++;
        if (primo == 0)
            Console.WriteLine("El número introducido es primo");
        else
            Console.WriteLine("El número introducido no es primo");
        Console.WriteLine("Pulse una tecla para continuar");
        Console.ReadKey();
    }

    private static void Parte2()
    {
        int num = LeerNúmero();
        
        Console.WriteLine($"El factorial de {num} es: {Factorial(num)}"); // Invocación de factorial.
        Console.ReadKey();

        // El factorial de un número es una multiplicación de ese número
        // por los números anteriores hasta uno, ej: fact(n) = n * n-1 * n-2...1;
        // Este trozo de codigo se realizo con una función recursiva para realizar
        // esta tarea.
        static int Factorial(int num)
        {
            int resta = num >= 1 ? -1 : 1;
            if (num == 1 || num == -1)
                return num;
            return num * Factorial(num + resta); // Se invoca de forma recursiva factorial para recorrer los valores de num.
        }
    }

    private static void Parte3()
    {
        // Se le pasa como parámetro un número de segundos
        // y devuelve su conversión a horas, minutos y segundos.
        int nseg = LeerNúmero();
        int min = 0;
        int horas = 0;
        int reshoras = 0;
        horas = nseg / 3600;
        reshoras = nseg % 3600;
        min = reshoras / 60;
        nseg = nseg % 60;
        Console.WriteLine("{0,0:D2} : {1,0:D2} : {2,0:D2}", horas, min, nseg);
        Console.WriteLine("Pulse una tecla para continuar");
        Console.ReadKey();
    }

    private static void Parte4()
    {
        //La fórmula de la sucesión de pell dados el 0 y el 1 como números iniciales, es:
        // 2 * numero previo + numero previo al previo
        // osea el tercer número se calcularía: 2 * 1 + 0 = 2
        // el cuarto: 2 * 2 + 1 = 5

        int[] sucesionPell = { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        for (int i = 2; i < 15; i++)
            sucesionPell[i] = 2 * sucesionPell[i - 1] + sucesionPell[i - 2];
        Console.Write($"\n\n\tLos primeros 15 números de la sucesión de Pell son:\n\t{string.Join(", ", sucesionPell)}\n\n\tPulsa una tecla para continuar");
        Console.ReadKey();
    }

    private static void Parte5()
    {
        // Un número de n dígitos es un número de Armstrong si es
        // igual a la suma de las n-ésimas potencias de sus dígitos 
        // ej: 371 -> 3^3 + 7^3 + 1^3 -> 27 + 343 + 1 = 371 -> es Armstrong.
        string num = LeerNúmero().ToString(); 
        double numDigitos = num.Length, sumaDigitos = 0;

        foreach (int elem in num)
            sumaDigitos += Math.Pow(Convert.ToDouble(elem) - 48, numDigitos); // Bucle for para calcular la suma de los digitos elevados al numero de digitos.
        Console.WriteLine($"{num}{(sumaDigitos.ToString() == num ? "" : " no")} es un número de Armstrong");
        Console.ReadKey();
    }

    private static void Parte6()
    {
        List<int> ocurrencias = new List<int>(); //Creamos lista para las cifras
        bool rep = true; // Con el Bool determinamos si hemos encontrado una cifra repetida

        string num = LeerNúmero().ToString();
        for (int i = 0; i < num.Length && rep; i++) //Añadimos rep para no continuar en el bucle si sabemos que no hay cifras repetidas
        {
            if (!ocurrencias.Contains(num[i])) //Verificamos que la cifra actual no está dentro de la lista
                ocurrencias.Add(num[i]); // Añadimos la cifra actual a la lista
            else
            {
                Console.WriteLine("El número no tiene todas las cifras distintas");
                rep = false;
            }
        }
        if (rep)
            Console.WriteLine("El número tiene todas las cifras distintas");
        Console.WriteLine("Pulse una tecla para continuar");
        Console.ReadKey();

    }

    private static int LeerNúmero()
    {
        int num;
        // Pedimos la variable y validamos que es un número entero
        Console.Write("Introduzca un número entero por favor: ");
        while (!Int32.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Introduzca un número válido por favor: ");
        }
        return num;
    }
}