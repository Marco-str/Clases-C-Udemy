class DoWhile
{
    static void Main(string[] args)
    {

        int n1, n2;

        Console.WriteLine("Dime un numero");
        n1 = Convert.ToInt32(Console.ReadLine());

        do
        {

            Console.WriteLine("Dime otro numero");
            n2 = Convert.ToInt32(Console.ReadLine());
            if(n2 == 0)
            {
                Console.WriteLine("No debe ser 0");
            }

        }

        while (n2 == 0);
        

        Console.WriteLine("Su resultado es");
        Console.WriteLine(n1 / n2);


    }
}