/*19 - Escreva um programa para aprovar ou não o empréstimo bancário para a compra de
uma casa. O programa deve ler o valor do imóvel, o salário do comprador e em quantos
anos ele pretende pagar. Calcule o valor da prestação mensal, sabendo que ela não pode
exceder 30% do salário ou então o empréstimo será negado.*/
using System;

class Program{

    public static void Main(string[] args){

        double ValorDoImovel;
        double Salario;
        int Anos;
        int Parcelas;
        double PrestacaoMensal;
        
        Console.WriteLine("Digite o valor do imóvel: R$ ");
        ValorDoImovel = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do seu salário: R$ ");
        Salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de parcelas em anos: ");
        Anos = int.Parse(Console.ReadLine());

        Parcelas = Anos * 12;
        PrestacaoMensal = ValorDoImovel / Parcelas;

        if(PrestacaoMensal > (Salario * 0.3)){
        Console.WriteLine("Empréstimo negado!");
        Console.ReadLine();
        }
        else{
        Console.WriteLine("Empréstimo liberado!");
        Console.ReadLine();
        }
        Console.WriteLine("Pressione enter para sair...");
        Console.ReadLine();
    }
}