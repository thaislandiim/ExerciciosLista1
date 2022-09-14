using System;

class exibirIdade 
{
  public static void Main (string[] args) 
  {
    const int atual = 2022;
    int ano_inserido;
    int idade;
    string nome;

    Console.WriteLine("Digite seu nome");
    nome = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Digite o ano que você nasceu");
    ano_inserido = Convert.ToInt32(Console.ReadLine());

    idade = atual - ano_inserido;

    Console.WriteLine(nome + " sua idade é " + idade + " anos");
  }
}