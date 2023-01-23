using System;
using System.ComponentModel;

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
                "las veces que decida el usuario\n\t5.- Repetir cada ocurrencia de una cadena\n\t6.- Dado 2 strings borrar del primero las apariencias del segundo\n\n\t" +
                "0.- Salir\n\n\tElija una opción: ");
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
        
        // Rafa: Compruebo que la cadena no sea vacia
        while (cadena.Length == 0) 
        {
            Console.Write("\nIntroduce una cadena no vacia: ");
            cadena = Console.ReadLine();
        }

        string cadenaReverse = Reverse(cadena);
        if (cadenaReverse == cadena)
            Console.WriteLine("Es palíndromo");
        else
            Console.WriteLine("No es palíndromo");
        Console.ReadKey();

        static string Reverse(string cadena)
        {
            string rev = "";
            for (int i = cadena.Length - 1; i >= 0; --i)
                rev += cadena[i];
            return rev;
        }
    }

    static void Parte2()
    {
        // Escribir el nombre todo en mayúsculas y todo en minúsculas
        Console.Write("Introduce tu nombre: ");
        string nombre = Console.ReadLine();
        
        // Compruebo que la cadena no sea vacia
        while (nombre.Length == 0) 
        {
            Console.Write("\nIntroduce una cadena no vacia: ");
            nombre = Console.ReadLine();
        }
        Console.WriteLine(nombre + " en mayúscula es " + nombre.ToUpper());
        Console.WriteLine(nombre + " en minúscula es " + nombre.ToLower());
        Console.Write("\nIntroduce una letra para salir al menu...");
        Console.ReadKey();
    }

    static void Parte3()
    {
        // Devuelve el número de ocurrencias de una letra. Pido una cadena
        Console.Write("Introduce una cadena: ");
        string cadena = Console.ReadLine();
        
        // Compruebo que la cadena no sea vacia
        while (cadena.Length == 0) 
        {
            Console.Write("\nIntroduce una cadena no vacia: ");
            cadena = Console.ReadLine();
         }

        // Pido un caracter
        Console.Write("\n\nIntroduce un caracter: ");
        char caracter;
        
        // Compruebo que sea un caracter
        while (!char.TryParse(Console.ReadLine(), out caracter)) 
        {
            Console.Write("\nERROR. Introduzca un caracter: ");
        }
    
        // Recorro la cadena y si alguno de sus caracteres coincide con caracter numeroOcurrencias suma
        int numeroOcurrencias = 0;
        for (int i = 0; i < cadena.Length; i++) 
        {
            if (cadena[i] == caracter) 
            {
                numeroOcurrencias++;
            }
        }
 
        Console.WriteLine(cadena + " contiene " + caracter + " " + numeroOcurrencias + " veces.");
        Console.Write("\nIntroduce una letra para salir al menu...");
        Console.ReadKey();
    }

    static void Parte4()
    {
        //Código aquí
    }

    static void Parte5()
    {
        Console.WriteLine("Introduce una cadena no vacía");
        string cadena = Console.ReadLine() ?? "", cadenaFinal = "";
        for (int i = 0; i < cadena.Length; i++)
        {
            cadenaFinal += cadena[i].ToString() + cadena[i].ToString();
        }
        Console.WriteLine(cadenaFinal);
        Console.WriteLine("Pulse una tecla para continuar");
        Console.ReadKey();
    }

    static void Parte6()
    {
        Console.WriteLine("Introduce una cadena no vacía");
        string cadena = Console.ReadLine() ?? "";
        Console.WriteLine("Introduce que deseas borrar de la cadena original");
        string cadena2 = Console.ReadLine() ?? "", cadenaFinal = "";
        cadena = cadena.ToLower();
        cadena2 = cadena2.ToLower();
        cadenaFinal = cadena.Replace(cadena2, "");
        Console.WriteLine(cadenaFinal);
        Console.WriteLine("Pulse una tecla para continuar");
        Console.ReadKey();
        
        //Código aquí
    }
}
