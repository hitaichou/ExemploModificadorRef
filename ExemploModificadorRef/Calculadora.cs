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

        //para um modificador OUT, é preciso estar declarado nos parâmetros do método
        public static void Triplo2(int origem, out int resultado)
        {
            resultado = origem * 3;
        }
    }
}
