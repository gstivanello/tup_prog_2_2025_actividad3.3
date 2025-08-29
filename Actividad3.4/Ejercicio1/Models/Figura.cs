


namespace Ejercicio1.Models;

abstract public class Figura
{
    //se puede usar el abstract o el virtual

    abstract public string Describrir();

    //abstract public double CalcularVolumen();

    public override string ToString()
    {
        return Describrir();
    }

    virtual public double CalcularVolumen() //el virtual exige un cuerpo.
    {
        return 0;
    }
    
    public int CompareTo(object otra)
    {

        Figura otraFigura = otra as Figura;
        if (otraFigura == null)
        {
            return CalcularVolumen().CompareTo(otraFigura.CalcularVolumen());
        }
        return -1;
    }
}
