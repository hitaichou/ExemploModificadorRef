using System;

namespace ExemploModificadorRef
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modificador REF
            int a = 10;
            Calculadora.Triplo(ref a);
            Console.WriteLine(a);
        }
    }
}
