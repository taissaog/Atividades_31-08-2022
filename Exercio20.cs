/*20 - O Índice de Massa Corporal (IMC) é um valor calculado baseado na altura e no peso de
uma pessoa. De acordo com o valor do IMC, podemos classificar o indivíduo dentro de
certas faixas:
- Abaixo de 18.5: Abaixo do peso
- Entre 18.5 e 25: Peso ideal
- Entre 25 e 30: Sobrepeso
- Entre 30 e 40: Obesidade 
- Acima de 40: Obesidade mórbida
Obs: O IMC é calculado pela expressão: Peso / altura2 (peso dividido pelo quadrado da
altura)*/
using System;

class Program{

    public static void Main(string[] args){

        double Altura;
        double Peso;
        double Imc;

        Console.WriteLine("Digite sua altura em metros:  ");
        Altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu peso em Kg:  ");
        Peso = double.Parse(Console.ReadLine());

        Imc = (Altura * Altura) / Peso;

        if(Imc <= 18.5 ){
        Console.WriteLine("Abaixo do peso!");
        Console.ReadLine();
        }
        if(Imc >= 18.6 && Imc <= 25){
        Console.WriteLine("Peso ideal!");
        Console.ReadLine();
        }
        if(Imc >= 26 && Imc <= 30 ){
        Console.WriteLine("Sobrepeso!");
        Console.ReadLine();
        }
        if(Imc >= 31 && Imc <= 40 ){
        Console.WriteLine("Obesidade!");
        Console.ReadLine();
        }
        if(Imc >= 41 ){
        Console.WriteLine("Obesidade mórbida!");
        Console.ReadLine();
        }
        Console.WriteLine("Pressione enter para sair...");
        Console.ReadLine();
    }
}