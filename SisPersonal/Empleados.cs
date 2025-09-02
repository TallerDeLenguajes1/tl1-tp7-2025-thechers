namespace Empresa.Empleados;

public enum Cargos 
{
   Auxiliar,
   Administrativo,
   Ingeniero,
   Especialista,
   Investigador 
}


public class Empleado
{
    private string nombre;
    private string apellido;

    private DateTime fechaNac;

    private char estCiv;

    private DateTime fechIng;

    private double sueldoBase;

    private Cargos cargo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public char EstCiv { get => estCiv; set => estCiv = value; }
    public DateTime FechIng { get => fechIng; set => fechIng = value; }
    public double SueldoBase { get => sueldoBase; set => sueldoBase = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }


    public Empleado(string nombre, string apellido, DateTime fechaNac, char estCiv, DateTime fechIng, double sueldoBase, Cargos cargo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNac = fechaNac;
        this.estCiv = estCiv;
        this.fechIng = fechIng;
        this.sueldoBase = sueldoBase;
        this.cargo = cargo;
    }

    public int antiguedad()
    {
        int anioActual = DateTime.Now.Year;
        int anioIngreso = FechIng.Year;

        int antiguedad = anioActual - anioIngreso;

        return antiguedad;
    }

    public int edadEmp()
    {
        int anioNac = FechaNac.Year;
        int anioActual = DateTime.Now.Year;
        int edad = anioActual - anioNac;

        return edad;
    }


    public int jubilacion()
    {
        int anioNac = fechaNac.Year;
        int anioActual = DateTime.Now.Year;
        int edad = anioActual - anioNac;

        if (edad < 65)
        {
            int estimado = anioNac + 65;
            int faltante = estimado - anioActual;

            return faltante;
        }

        else
        {
            return 0;
        }

    }

    public double salario()
    {
        int anioActual = DateTime.Now.Year;
        int anioIngreso = FechIng.Year;
        int antiguedad = anioActual - anioIngreso;
        double adicional, salario;

        if (antiguedad <= 20)
        {
            adicional = (sueldoBase * (antiguedad / 100));
        }
        else
        {
            adicional = (sueldoBase * 0.25);
        }

        if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
        {
            adicional += adicional * 0.5;
        }

        if (EstCiv == 'C')
        {
            adicional += 150000;
        }

        salario = sueldoBase + adicional;

        return salario;
    }

    public void MostrarDatos()
    {

        Console.WriteLine($"{Nombre} {Apellido} | Nac: {FechaNac.ToShortDateString()} | " + $"Estado Civil: {EstCiv} | Ingreso: {FechIng.ToShortDateString()} | " + $"Cargo: {Cargo}");

    }

}