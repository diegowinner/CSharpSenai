using System.Globalization;

/*
double teste = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine(teste.ToString("F2", CultureInfo.InvariantCulture));    
*/
/*
Console.WriteLine(Math.Min(10, 50));
Console.WriteLine(Math.Max(10, 50));
Console.WriteLine(Math.Sqrt(9));
Console.WriteLine(Math.Pow(9,3));
Console.WriteLine(Math.Round(9.559,2));
Console.WriteLine(Math.PI * 2);
*/

/*
 Crie um programa para receber do usuário, dois números e imprimir o maior deles. Pode usar a biblioteca Math;

Crie um Programa que peça do usuário 4 notas, calcule a media. Se a media do aluno for maior ou igual 7 ele esta aprovado, se a media for menor que 7 e maior ou igual a 6 ele esta de recuperação, se a media for menor que 6 ele está reprovado.
 */



Console.WriteLine("####Programa Mostra Maior Número####");
double numero1;
double numero2;
Console.WriteLine("Entre com o Primeiro Número:");
numero1 = double.Parse(Console.ReadLine());
Console.WriteLine("Entre com o Primeiro Número:");
numero2 = double.Parse(Console.ReadLine());

Console.WriteLine("O Maior Número é: "+Math.Max(numero1,numero2));

Console.WriteLine("##Programa Calcula Média##");
double nota1;
double nota2;
double nota3;
double nota4;
double media;

Console.WriteLine("Digite a primeira nota: ");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota: ");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota: ");
nota3 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a quarta nota: ");
nota4 = double.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;

if(media>=7)
{
    Console.WriteLine("Aluno Aprovado, média é igual à: "+media);
}
else if(media<7 && media>=6)
{
    Console.WriteLine("Aluno está de Recuperação, média igual à: " + media);
}
else 
{
    Console.WriteLine("Aluno está reprovado, média igual à: " + media);
}