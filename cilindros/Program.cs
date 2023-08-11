// See https://aka.ms/new-console-template for more information
double radio;
double altura;
double area;
double volumen;
double basee;
int contador=0;
do
{
    Console.WriteLine("Ingrese radio");
    while(!double.TryParse(Console.ReadLine(), out radio))
    {
        Console.WriteLine("error ingrese un numero");
    }

    Console.WriteLine("Ingrese altura");
    while(!double.TryParse(Console.ReadLine(), out altura))
    {
        Console.WriteLine("error ingrese un numero");
    }

    if (radio < 0 || altura < 0)
    {
        Console.WriteLine("Datos Incorrectos");
    }
    else if (radio == 0 && altura == 0)
    {
        Console.WriteLine("fin del ciclo");
    }
    else
    {
        area = FuncionArea(altura, radio);

        basee = FuncionBase(radio);

        volumen = FuncionVolumen(basee, altura);
        Console.WriteLine($"El area es {area} y el volumen es {volumen}");
        contador = contador + 1;
    }

} while (radio!=0 && altura!=0);
Console.WriteLine($"Se ingresaron {contador} Cilindros");
double FuncionVolumen(double basee, double altura)
{
    double resultado;
    resultado = basee * altura;
    return resultado;
}

double FuncionBase(double radio)
{
    double resultado;
    resultado = Math.PI*Math.Pow(radio, 2);
    return resultado;
}

double FuncionArea(double altura, double radio)
{
    double resultado;
    resultado = 2 * Math.PI * radio * (altura + radio);
    return resultado;
}