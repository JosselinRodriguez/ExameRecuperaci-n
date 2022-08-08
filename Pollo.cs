class Pollo:Decorador
{
    public Pollo (OrdenBase orden) : base(orden)
    {
    }

    public override double CalcularTotalPrecio()
    {
        return base.CalcularTotalPrecio() + 1.25 ;
    }
}