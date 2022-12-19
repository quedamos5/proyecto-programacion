internal class Program
{
    private static void Main()
    {
        int actual;

        do
        {   //Creamos el menú \n nueva línea, \t tabulación
            Console.Write("\n\n\tElija una opción:\n\n\t1.- ¿Número primo?\n\t2.- Factorial\n\t3.- Convertir número de segundos a H : M : S\n\t4.- 15 primeros números de la " +
                "serie de Pell\n\t5.- ¿Número de Armstrong?\n\t6.- ¿El número introducido está conformado por cifras totalmente distintas?\n\n\t0.- Salir");
            actual = Console.ReadKey().KeyChar - 48; //Console readkey para que no haga falta pulsar enter. Cualquier input distinto a las opciones dada saldrá del programa.
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
                    break;
            }
        } while (actual < 1 || actual > 6);
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
        //Aquí código
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