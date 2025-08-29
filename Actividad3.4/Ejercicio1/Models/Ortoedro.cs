

namespace Ejercicio1.Models;

internal class Ortoedro : Figura
{
    public double Ancho { get; set; }
    public double Alto { get; set; }
    public double Largo { get; set; }  

    public Ortoedro (double ancho, double alto, double largo)
    {
        Ancho= ancho;
        Alto= alto;
        Largo= largo;

    }
    override public double CalcularVolumen()
    {
        return Ancho * Alto * Largo;
    }

    public override string Describrir()
    {
        return $"Ortoedro: Ancho= {Ancho:f2}, Alto= {Alto:f2}, Largo= {Largo:f2}";

    }

    
}
