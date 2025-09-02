using Empresa.Empleados;

Empleado[] empleados = new Empleado[3];


    empleados[0] = new Empleado("Juan","Perez",new DateTime(1994,02,13),'S',new DateTime(2020,10,12),500000,Cargos.Investigador);
    empleados[1] = new Empleado("Ana", "Gómez", new DateTime(1985, 11, 3), 'C',new DateTime(2010, 6, 15), 250000, Cargos.Administrativo);
    empleados[2] = new Empleado("Carlos", "Ruiz", new DateTime(1978, 1, 25), 'C',new DateTime(2005, 9, 20), 400000, Cargos.Ingeniero);

double montoFinal = 0;
foreach (Empleado emp in empleados)
{
    montoFinal += emp.salario();
    emp.MostrarDatos();
    
}

Console.WriteLine($"Monto Total: {montoFinal}");