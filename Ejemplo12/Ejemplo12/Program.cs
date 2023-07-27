class EjemploFunciones
{
    static void Main(string[] args)
    {
        //...
        Felicitar(2);

        //...
        Felicitar(56);

        //...
        Felicitar(3);

    }

    static void Felicitar(int admiraciones)
    {
        Console.WriteLine("Lo estas haciendo muy bien!!");
        for (int i = 0; i < admiraciones; i++)
        {
            Console.Write("!");
        }
        Console.WriteLine();
    }
}