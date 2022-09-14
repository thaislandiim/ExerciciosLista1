class Program 
{
  public static void Main (string[] args) 
  {
    int valor_inserido;
    int valor = 1;

    Console.WriteLine("Digite um número maior que 0");
    valor_inserido = Convert.ToInt32(Console.ReadLine());

    if(valor_inserido <= 0) {
      Console.WriteLine("Erro! Digite um número MAIOR que 0");
    } 
    else {
      while(valor <= valor_inserido) {
        Console.WriteLine("Olá Mundo");
        valor++;
      }
    }
  }
}