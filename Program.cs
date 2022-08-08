internal class Program
{
    private static void Main(string[] args)
    {
     
        Console.WriteLine("TACOS");
       var tacos = new Tacos();
       Console.WriteLine($"El precio de los Tacos es de: {Tacos.CalcularTotalPrecio()}");
       var sinchile = new SinChile(Tacos);
       Console.WriteLine($"El precio de los Tacos sin chile es de: {SinChile.CalcularTotalPrecio()}");
       var conchile = new ConChile(Tacos);
       Console.WriteLine($"El precio de los Tacos con chile  es de: {ConChile.CalcularTotalPrecio()}");
       var carne = new Carne(Tacos);
       Console.WriteLine($"El precio de los Tacos con Carne es de: {Carne.CalcularTotalPrecio()}");
       Console.WriteLine();
       var pollo = new Pollo(Tacos);
       Console.WriteLine($"El precio de los Tacos con Pollo es de: {Pollo.CalcularTotalPrecio()}");
       Console.WriteLine();
       
        Console.WriteLine("BURRITOS");
       var Burritos = new Burritos();
       Console.WriteLine($"El precio de los burritos es de: {Burritos.CalcularTotalPrecio()}");
       var sinchile = new SinChile(Burritos);
       Console.WriteLine($"El precio de los Burritos sin chile es de: {SinChile.CalcularTotalPrecio()}");
       var conchile = new ConChile(Burritos);
       Console.WriteLine($"El precio de los Burritos con chile  es de: {ConChile.CalcularTotalPrecio()}");
       var carne = new Carne(Burritos);
       Console.WriteLine($"El precio de los Burritos con Carne es de: {Carne.CalcularTotalPrecio()}");
       Console.WriteLine();
       var pollo = new Pollo(Burritos);
       Console.WriteLine($"El precio de los Burritos con Pollo es de: {Pollo.CalcularTotalPrecio()}");
       Console.WriteLine();
       
        Console.WriteLine("TAMALES");
       var tamales = new Tamales();
       Console.WriteLine($"El precio del Tamales es de: {Tamales.CalcularTotalPrecio()}");
       var sinchile = new SinChile(Tamales);
       Console.WriteLine($"El precio de los Tamales sin chile es de: {SinChile.CalcularTotalPrecio()}");
       var conchile = new ConChile(Tamales);
       Console.WriteLine($"El precio de los Tamales con chile  es de: {ConChile.CalcularTotalPrecio()}");
       var carne = new Carne(Tamales);
       Console.WriteLine($"El precio de los Tamales con Carne es de: {Carne.CalcularTotalPrecio()}");
       Console.WriteLine();
       var pollo = new Pollo(Tamales);
       Console.WriteLine($"El precio de los Tamales con Pollo es de: {Pollo.CalcularTotalPrecio()}");
       Console.WriteLine();
    }
}