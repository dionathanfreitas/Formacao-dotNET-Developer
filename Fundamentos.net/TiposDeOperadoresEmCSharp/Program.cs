using TiposDeOperadoresEmCSharp.Modules;

internal class Program
{
    private static void Main(string[] args)
    {
        //Operadores aritméticos em C#
        Calculadora calc = new Calculadora();

        // calc.Somar(10,10);
        // calc.Subtrair(10,10);
        // calc.Multiplicar(10,10);
        // calc.Dividir(10,10);
        //calc.Potencia(2,2);

        calc.Seno(30);
        calc.Coseno(30);
        calc.Tangente(30);
        

    }
}