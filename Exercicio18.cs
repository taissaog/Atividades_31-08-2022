/*14 - Crie um programa que leia o tamanho de três segmentos de reta. Analise seus
comprimentos e diga se é possível formar um triângulo com essas retas. Matematicamente,
para três segmentos formarem um triângulo, o comprimento de cada lado deve ser menor
que a soma dos outros dois.*/

using System;

class Program{

    public static void Main(string[] args){

        double Segmento1;
        double Segmento2;
        double Segmento3;

        Console.WriteLine("Digite o valor do primeiro segmento: ");
        Segmento1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do segundo segmento: ");
        Segmento2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do terceiro segmento: ");
        Segmento3 = double.Parse(Console.ReadLine());

        if(Segmento1 + Segmento2 >= Segmento3  && Segmento2 + Segmento1 >= Segmento3){
            Console.WriteLine("É possível formar um triângulo!");
            Console.ReadLine();

//SEGUNDA PARTE!
/*  18 - Refaça o exercício 14 , acrescentando o recurso e mostrar que tipo de triângulo será
formado:
- EQUILÁTERO: Todos os lados iguais
- ISÓSCELES: Dois lados iguais
- ESCALENO: Todos os lados diferentes*/

            if(Segmento1 == Segmento2 && Segmento3 == Segmento1 && Segmento2 == Segmento3){
            Console.WriteLine("Tipo de triângulo: EQUILÁTERO!");
            Console.ReadLine();
            }
            if(Segmento1 == Segmento2 && Segmento2 != Segmento3 || (Segmento2 == Segmento3 && Segmento3 != Segmento1) || (Segmento3 == Segmento1 && Segmento1 != Segmento2)){
            Console.WriteLine("Tipo de triângulo: ISÓSCELES!");
            Console.ReadLine();   
            }
            if(Segmento1 != Segmento2 && Segmento3 != Segmento1 && Segmento2 != Segmento3){
            Console.WriteLine("Tipo de triângulo: ESCALENO!");
            Console.ReadLine();
            }
        }
        else{
            Console.WriteLine("Não é possível formar um triângulo!");
            Console.ReadLine();
        }

            Console.WriteLine("Pressione enter para sair...");
            Console.ReadLine();


}
}

