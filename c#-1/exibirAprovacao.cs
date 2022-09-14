using System;

class exibirAprovacao 
{
  public static void Main (string[] args) 
  {
    const int number = 6;
    int nota_inserida;

    Console.WriteLine("Digite sua nota");
    nota_inserida = Convert.ToInt32(Console.ReadLine());

    if(nota_inserida >= number) {
      Console.WriteLine("Você foi aprovado");
    } 
    else {
      Console.WriteLine("Você foi reprovado");
    }
  }
}