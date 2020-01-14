namespace ExemploModificadorRef
{
    class Calculadora
    {
        // quando coloca ref no parâmetro da função e na chamada dele também tiver o ref
        //o programa criará uma referencia da variável original
        public static void Triplo(ref int x)
        {
            x = x * 3;
        }
    }
}
