﻿
namespace Ejercicio1.Models;

//un cilindro es una figura? si, en mi modelo
//una figura es un cilindro? no necesariamente
public class Cilindro : Figura
{
    public double Radio { get; set; }
    public double Altura { get; set; }
    public Cilindro(double radio, double altura)
    {
        this.Radio = radio;
        this.Altura = altura;
    }
    public override double CalcularVolumen()
    {
        return Math.PI * Math.Pow(Radio, 2) * Altura;
    }

    public override string Describrir()
    {

        return $"Cilindro: Radio={Radio:2}, Altura={Altura:f2}, Vol={CalcularVolumen():f2}";

    }

}
