/*21 - Uma empresa de aluguel de carros precisa cobrar pelos seus serviços. O aluguel de
um carro popular custa R$ 90 por dia para carro popular e R$ 150 por dia para carro de
luxo. Além disso, o cliente paga por Km percorrido. Faça um programa que leia o tipo de
carro alugado (popular ou luxo), quantos dias de aluguel e quantos Km foram percorridos.
No final mostre o preço a ser pago de acordo com a tabela a seguir:
- Carros populares( aluguel R$ 90 por dia)
- Até 100 km percorridos: R$ 0,20 por Km
- Acima de 100 km percorridos: R$ 0,10 por Km
- Carros de luxo (aluguel R$ 150 por dia)
- Até 200 Km percorridos: R$ 0,30 por Km
- Acima de 200 Km percorridos: R$ 0,25 por Km*/

using System;

class Program{

    public static void Main(string[] args){
    
    bool carro;
    double d;
    int dia;

    Console.WriteLine("true/false");
    Console.WriteLine("é um carro popular");
    carro =bool.Parse (Console.ReadLine());
    Console.WriteLine("quantos dias voce ficou com o carro");
    dia =int.Parse( Console.ReadLine());
    Console.WriteLine("quanto foi andado (em km)");
    d =double.Parse( Console.ReadLine());

    if(carro){
        if(d<100){
             Console.WriteLine("o total é "+((90*dia)+(d*0.2)));
        }else{
            Console.WriteLine("o total é "+((90*dia)+(d*0.1)));
        }
    }else{
        if(d<200){
             Console.WriteLine("o total é "+((150*dia)+(d*0.3)));
        }else{
            Console.WriteLine("o total é "+((150*dia)+(d*0.25)));
        }
    }
}}
