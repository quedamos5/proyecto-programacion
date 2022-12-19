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
        } while (actual >= 1 || actual <= 6);
        Console.ReadKey();
    }

    private static void Parte1()
    {
        //Aquí código
    }

    private static void Parte2()
    {
        //Aquí código
    }

    private static void Parte3()
    {
        //Aquí código
    }

    private static void Parte4()
    {
        //La fórmula de la sucesión de pell dados el 0 y el 1 como números iniciales, es:
        // 2 * numero previo + numero previo al previo
        // osea el tercer número se calcularía: 2 * 1 + 0 = 2.
        // el cuarto: 2 * 2 + 1 = 5

        int[] sucesionPell = { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        for (int i = 2; i < 15; i++)
            sucesionPell[i] = 2 * sucesionPell[i - 1] + sucesionPell[i - 2];
        Console.Write($"\n\n\tLos primeros 15 números de la sucesión de Pell son:\n\t{string.Join(", ", sucesionPell)}\n\n\tPulsa una tecla para continuar");
        Console.ReadKey();
    }

    private static void Parte5()
    {
        //Aquí código
    }

    private static void Parte6()
    {
        //Aquí código
    }
}