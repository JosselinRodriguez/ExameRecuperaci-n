class Carne:Decorador
{
    public Carne(OrdenBase orden) : base(orden)
    {
    }

    public override double CalcularTotalPrecio()
    {
        return base.CalcularTotalPrecio() + 1.25 ;
    }
}