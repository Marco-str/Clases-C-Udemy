class Variables
{
    static void Main(string[] args)
    {

        string nombre;
        Console.WriteLine("Diume tu nombre: ");
        nombre = Console.ReadLine();

        int numero;
        int numero2;
        int numero3;
        numero = 5;
        numero2 = 7;
        Console.WriteLine(  "Dime algun dato apra ingresdar: ");
         numero3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(  "Dime algun otro dato apra ingresdar: ");
         numero2 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Hola ");
        Console.WriteLine(nombre);
        Console.WriteLine(" La suma es: ");
        Console.WriteLine(numero2+numero3);
        Console.WriteLine("Eaaaa");


        Console.Write("Dime el nombre: ");
        Console.WriteLine(nombre);
        Console.Write("La suma definitica es: ");
        Console.WriteLine(numero3+numero2+numero);

        double numero4;
        Console.Write(" Dime un numero mas (real): ");
        numero4= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(numero4*numero4);
    }
}