internal class Program
{
    private static void Main(string[] args)
    {
        int actual;

        do
        {
            Console.Clear(); //Limpiamos la pantalla a cada vuelta al menú
                             //Creamos el menú \n nueva línea, \t tabulación
            Console.Write("\tDECIMALES\n\n\t1.- Redondear al alza\n\t" +
                          "2.- Eliminar decimales de numero introducido\n\t" +
                          "3.- Realizar ecuacion de segundo grado.\n\t" +
                          "\n\n\t0.- Salir" +
                          "\n\n\tElija una opción: ");
            //Console readkey para que no haga falta pulsar enter
            actual = Console.ReadKey().KeyChar - 48;
            Console.Clear();
            switch (actual) //Según la opción seleccionada actuamos
            {
                case 1:
                    Parte1(); //Invocación de la función redondear al alza
                    break;
                case 2:
                    Parte2(); //Invocación de la función eliminar decimales
                    break;
                case 3:
                    Parte3(); //Invocación de la función realizar ecuacion de segundo grado
                    break;
            }
        } while (actual >= 1 && actual <= 3);
    }

    private static void Parte1()
    {
        Console.WriteLine("\nRedondear al alza de un número introducido\n");
        decimal valor = LeerDecimal(true); //Definimos la variable decimal valor y le pasamos un valor DECIMAL validado
        decimal result = (int)valor; // Definimos result que recoge el valor entero del numero decimal introducido (TRUNCANDO)
        if (result < valor) // Si el valor introducido al ser truncado son diferentes, le suma 1 al resultado asi redondeando hacia arriba (CEIL)
        {
            result++;
        }
        Console.WriteLine("\nReadondeo al alza (CEIL): {0}", result);
        Console.ReadKey(); //Finalizar programa
    }

    private static void Parte2()
    {

    }

    private static void Parte3()
    {

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
}
