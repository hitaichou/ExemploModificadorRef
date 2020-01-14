using System;

namespace ExemploModificadorRef
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modificador de parâmetro REF
            //o modificador ref exige que a variável seja iniciada
            int a = 10;
            Calculadora.Triplo(ref a);
            Console.WriteLine(a);

            //Abaixo está um exemplo de saída, é preciso informar que a variável é de saída usando o OUT
            //não é preciso iniciar a variável.
            int triplo;
            Calculadora.Triplo2(a, out triplo);
            Console.WriteLine(triplo);

            //ambos são considerados "code smells" (design ruim) e devem ser evitados.

        }
    }
}
