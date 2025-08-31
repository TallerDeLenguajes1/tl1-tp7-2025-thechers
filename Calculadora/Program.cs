using EspacioCalculadora;

Console.WriteLine("Ingrese el primer numero: ");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero: ");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la operacion: " + Environment.NewLine + "1. Sumar" + Environment.NewLine + "2. Restar" + Environment.NewLine + "3. Multiplicar" + Environment.NewLine + "4. Dividir" + Environment.NewLine + "5. Salir");
string preOperador = Console.ReadLine();
int operador = int.Parse(preOperador);

Calculadora calculador = new Calculadora();

while (operador != 5)
{
    switch (operador)
    {
        case 1: calculador.Sumar(num1, num2);
            break;
        case 2: calculador.Restar(num1, num2);
            break;
        case 3: calculador.Multiplicar(num1, num2);
            break;
        case 4: calculador.Dividir(num1, num2);
            break;
    }

    Console.WriteLine($"El resultado es: {calculador.Resultado}");
    Console.WriteLine("Ingrese la operacion: " + Environment.NewLine + "1. Sumar" + Environment.NewLine + "2. Restar" + Environment.NewLine + "3. Multiplicar" + Environment.NewLine + "4. Dividir" + Environment.NewLine + "5. Salir");
    preOperador = Console.ReadLine();
    operador = int.Parse(preOperador);
    
}







