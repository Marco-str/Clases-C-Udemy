

class OperadorSwitch
{
    static void Main(string[] args)
    {
        int numero;
        Console.Write("Porfa infggresa un nuemro: ");
        numero = Convert.ToInt32(Console.ReadLine());

        switch (numero)
        {
                case 2:
                Console.WriteLine("Es 2");
                break;
                case 3:
                Console.WriteLine("Es 3");
                break;
                case 4:
                Console.WriteLine("Es 4");
                break;
                default: Console.WriteLine("No esta entre 2l 2 y el 4");
                break;

        }

        Console.Write("Dime el numero de un dia de la smena: ");
        int dia = Convert.ToInt32(Console.ReadLine());

        switch(dia)
        {
            case 1: Console.WriteLine("Es lunes");
                break;
            case 2:
                Console.WriteLine("Es Martes");
                break;
            case 3:
                Console.WriteLine("Es Miercoles");
                break;
            case 4:
                Console.WriteLine("Es Jueves");
                break;
            case 5:
                Console.WriteLine("Es Viernes");
                break;
            case 6:
                Console.WriteLine("Es Sabado");
                break;
            case 7:
                Console.WriteLine("Es Domingo");
                break;
                default : Console.WriteLine("No es un dia valido"); break;

        }

    }
}