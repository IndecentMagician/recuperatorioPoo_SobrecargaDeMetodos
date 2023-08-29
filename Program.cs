using recuperatorioPoo_SobrecargaDeMetodos.Entidades;
class Program
{
    static void Main(string[] args)
    {
        Kilo kilo1 = new Kilo(5);
        Kilo kilo2 = new Kilo(3);
        Libra libra1 = new Libra(12);

        Console.WriteLine($"Kilo1: {kilo1}, Kilo2: {kilo2}, Libra1: {libra1}");

        Kilo suma = kilo1 + libra1;
        Kilo resta = kilo2 - libra1;

        Console.WriteLine($"Kilo1 + Libra1 = {suma}");
        Console.WriteLine($"Kilo2 - Libra1 = {resta}");

        Console.WriteLine($"Kilo1 es igual a Libra1: {kilo1 == (Kilo)libra1}");
        Console.WriteLine($"Kilo2 es igual a Libra1: {kilo2 == (Kilo)libra1}");
        Console.WriteLine($"Kilo1 es igual a Kilo2: {kilo1 == kilo2}");
    }
}
