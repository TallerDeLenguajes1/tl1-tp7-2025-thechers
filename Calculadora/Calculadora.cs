namespace EspacioCalculadora;


public class Calculadora 
{
    private double dato;
    public void Sumar(double a, double b)
    {
        dato = a + b;
    }


    public void Restar(double a, double b)
    {
        dato = a - b;
    }

    public void Multiplicar(double a, double b)
    {
        dato = a * b;
    }


    public void Dividir(double a, double b)
    {
        dato = a / b;
    }

    public double Resultado 
    {
        get => dato;
    }
}

