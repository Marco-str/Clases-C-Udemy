class Arrays
{
    static void Main(string[] args)
    {
        int dato;
        int[] datos;

        datos = new int[5];
        datos[0] = 20;
        datos[1] = 30;
        datos[2] = 50;
        int i;
        for (i = 0; i < 5; i++)
        {
            Console.WriteLine("Dame un Dato: ");
            datos[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Los  datos son: ");
        for (i = 0; i < 5; i++)
        {
            Console.Write(datos[i] + " ");
        }
        Console.WriteLine();


        int dia;
        string[] diasDeSemana = { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };
        Console.WriteLine("Dime un numero de dia: ");
        dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El nombre del dia es: " +
            diasDeSemana[dia - 1]);

        string nombreDeDia;
        Console.WriteLine("Dime el nombre de un dia: ");
        nombreDeDia = Console.ReadLine();
        int posicion = -1;
        for (i = 0; i < diasDeSemana.Length; i++)
        {
            if (nombreDeDia == diasDeSemana[i])
                posicion = i + 1;

        }
        if (posicion == -1)
            Console.WriteLine("No encontrado");
        else
            Console.WriteLine("Encontador en " + posicion);


    }
}