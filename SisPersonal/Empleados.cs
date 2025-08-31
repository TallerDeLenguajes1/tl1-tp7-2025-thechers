namespace Empresa.Empleados;

enum Cargos 
{
   Auxiliar,
   Administrativo,
   Ingeniero,
   Especialista,
   Investigador 
}


public class Empleado
{
    private string Nombre;
    private string Apellido;

    private DateTime FechaNac;

    private char EstCiv;

    private DateTime FechIng;

    private double SueldoBase;

    private Cargos Cargo;


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
        int anioNac = FechaNac.Year;
        int anioActual = DateTime.Now.Year;
        int edad = anioActual - anioNac;

        if (edad < 65)
        {
            int estimado = anioNac + 65;
            int faltante = anioActual - estimado;

            return faltante;
        }

        else
        {
            return 0;
        }

    }

}