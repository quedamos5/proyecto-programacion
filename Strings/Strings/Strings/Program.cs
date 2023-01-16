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
            Console.Write("\n\n\t1.- ¿Es palíndromo?\n\t2.- Nombre en mayusculas y minusculas\n\t3.- Número de ocurrencias de una letra\n\t4.- Repetir un string" +
                "las veces que decida el usuario\n\t5.- Repetir cada ocurrencia de una cadena\n\t6.- Dado 2 strings borrar del primero las apariencias del segundo\n\n\t0.- Salir\n\n\tElija una opción: ");
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

    static void Parte1()
    {
        //Funcion Para ver si un string es Palíndromo
        Console.WriteLine("Introduzca la string");
        string cadena = Console.ReadLine() ?? "";

        string cadenaReverse = Reverse(cadena);
        if (cadenaReverse == cadena)
            Console.WriteLine("Es palíndromo");
        else
            Console.WriteLine("No es palíndromo");
        Console.ReadKey();
    }

    static string Reverse(string cadena)
    {
        string rev = "";
        for (int i = cadena.Length - 1; i >= 0; --i)
            rev += cadena[i];
        return rev;
    }
}
