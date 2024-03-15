

int w = 1;

while( w != 0){

    Console.WriteLine("Calculadora - Console");
    Console.WriteLine("1) Soma");
    Console.WriteLine("2) Subtração");
    Console.WriteLine("3) Divisão");
    Console.WriteLine("4) Multiplicação");
    Console.WriteLine("5) Sair");
    int op = int.Parse(Console.ReadLine());

    if(op == 1)
    {
        soma();
    }
    else if(op == 2)
    {
        subtracao();
    }
    else if(op == 3)
    {
        divisao();
    }
    else if(op == 4)
    {
        multiplicacao();
    }
    else
    { 
        Console.WriteLine("Até Logo!");
        break;
    }
    

}


void soma()
{
    Console.WriteLine("Opção - Soma");
    Console.WriteLine("Insira um número: ");
    double num1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Insira outro número");
    double num2 = double.Parse(Console.ReadLine());

    double resultado = num1 + num2;

    Console.WriteLine("Resultado: " + resultado);
}

void subtracao()
{
    Console.WriteLine("Opção - Subtracao");
    Console.WriteLine("Insira um número: ");
    double num1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Insira outro número");
    double num2 = double.Parse(Console.ReadLine());

    double resultado = num1 - num2;

    Console.WriteLine("Resultado: " + resultado);
}

void divisao()
{
    Console.WriteLine("Opção - Divisão");
    Console.WriteLine("Insira um número: ");
    double num1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Insira outro número");
    double num2 = double.Parse(Console.ReadLine());

    double resultado = num1 / num2;

    Console.WriteLine("Resultado: " + resultado);
}

void multiplicacao()
{
    Console.WriteLine("Opção - Multiplicação");
    Console.WriteLine("Insira um número: ");
    double num1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Insira outro número");
    double num2 = double.Parse(Console.ReadLine());

    double resultado = num1 * num2;

    Console.WriteLine("Resultado: " + resultado);
}