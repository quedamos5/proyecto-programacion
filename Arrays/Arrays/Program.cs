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

  private static void Parte7() 
  {
    //Aquí código
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