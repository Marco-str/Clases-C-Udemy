﻿class EjemploFunciones2
{
    static int Duplicar(int n)
    {
        return n * 2;
    }

    static int Sumar(int a, int b)
    {
        return a + b;
    }

    static int SumarHasta(int limite)
    {
        int suma = 0;
        for(int i = 0; i <= limite; i++)
        {
            suma += i;
        }
            return suma;
    }
    static void Main(string[] args)
    {
        int x;
        Console.WriteLine(Duplicar(5));

        x = Duplicar(10);
        Console.WriteLine(x);

        Console.WriteLine(Sumar(12,33));

        Console.WriteLine(SumarHasta(5));

    }

    
}