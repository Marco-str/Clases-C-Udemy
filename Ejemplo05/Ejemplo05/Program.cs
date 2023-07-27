

class Conddicionales
{
    static void Main(string[] args)
    {
        Console.Write("Dime algun numero");
        int numero = Convert.ToInt32(Console.ReadLine());

        if(numero >0)
        {
            Console.WriteLine("Este numero es popsoitvo");
            Console.WriteLine("...");
        }
        else
        {
            Console.WriteLine("Este numero es 0 o es negativo");
            Console.WriteLine("...");
        }

        if (numero < 0) {
            Console.WriteLine("Este numero es negativo");
            Console.WriteLine("...");

        }
        
        // <=Menor o igual
        // >= Mayor o igual
        // == Igual a
        // != Distinto a

        if(numero == 5)
        {
            Console.WriteLine("El nmumero es 5");
        }
        if(numero!= 3)
        {
            Console.WriteLine("El numero no e el 3");
        }


        // && y
        // || o
        // ! no

        if(numero == 2 || numero == 3)
        {
            Console.WriteLine( "Es un 2 o es un 3");
        }

        if (numero > 0 && numero % 2 == 0)
        {
            Console.WriteLine("El numero es par y es positivo");
        }

        if (!(numero < 0))
        {
            Console.WriteLine("El numero no es negativo");
        }

        if (numero == 2)
        {
            Console.WriteLine("El un 2");
        }
        else if (numero == 3)
        {
            Console.WriteLine("El un 3");
        }
        else
        {
            Console.WriteLine( " No es 2 ni es 5");
        }

        Console.Write("Dime tu nombre: ");
        string name = Console.ReadLine();
        if (name != "Marco") {
            Console.WriteLine("Quien te conoce?");
        }
        else { Console.WriteLine("Hola bebe!");
        }


    }
}