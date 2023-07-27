class EjemploListas
{
    static void Main(string[] args)
    {
        int dato;
        //int[] datos;

        List<int> datos = new List<int>();


        int i;
        int numero;

        Console.WriteLine("Dame datos (-1) para terminar");
        do
        {
            Console.WriteLine("Dame un Dato: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if(numero != -1)
                datos.Add(numero);
        }
        while (numero != -1);


        Console.WriteLine("Los  datos son: ");
        for (i = 0; i < datos.Count; i++)
        {
            Console.Write(datos[i] + " ");
        }
        Console.WriteLine();


        string nombreDeDia;

        Console.WriteLine("Dime un dato: ");
        int datoBuscar = Convert.ToInt32( Console.ReadLine());

        if (datos.Contains(datoBuscar) )
        {
            Console.WriteLine("Está en la lista");
        }
        else
        {
            Console.WriteLine("Dato no encontrtado");
        }


    }
}