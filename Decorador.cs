class Decorador : OrdenBase
{
    protected OrdenBase orden;

    public Decorador (OrdenBase orden)
    {
        this.orden = orden;
    }
    public virtual double CalcularTotalPrecio()
    {
        Console.WriteLine("Precio Calculado  de la venta de comida desde el decorador");
        return orden.CalcularTotalPrecio();
    }
}