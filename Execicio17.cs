using System;

class Program{

    public static void Main(string[] args){

        char Nome;
        double Salario;
        int TempoDeTrabalho;
        double NovoSalario;

        Console.WriteLine("Digite seu nome: ");
        Nome = char.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu salário: ");
        Salario = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite seu tempo de trabalhos (em anos inteiros): ");
        TempoDeTrabalho = int.Parse(Console.ReadLine());

        if(TempoDeTrabalho == 3 ){
            NovoSalario = Salario * 0.03 + Salario;
            Console.WriteLine("Seu novo salário é: R$ " + NovoSalario);
        }
        if(TempoDeTrabalho >= 4 || TempoDeTrabalho >= 9 ){
            NovoSalario = Salario * 0.125 + Salario;
            Console.WriteLine("Seu novo salário é: R$ " + NovoSalario);
        }
        if(TempoDeTrabalho >= 11 ){
            NovoSalario = Salario * 0.2 + Salario;
            Console.WriteLine("Seu novo salário é: R$ " + NovoSalario);
        }
    }
}