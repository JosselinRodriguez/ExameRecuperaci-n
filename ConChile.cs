class ConChile:Decorador
{
    public ConChile(OrdenBase orden) : base(orden)
    {
    }

    public override double CalcularTotalPrecio()
    {
        return base.CalcularTotalPrecio() + 0.50;
    }
}