using System.Runtime.Intrinsics.Arm.Arm64;
class SinChile:Decorador
{
    public SinChile(OrdenBase orden) : base(orden)
    {
    }

    public override double CalcularTotalPrecio()
    {
        return base.CalcularTotalPrecio() + 0.25;
    }
}