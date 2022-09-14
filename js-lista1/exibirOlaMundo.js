let valor = 1;

let valor_inserido = prompt("Digite um número maior que 0");

if (valor_inserido <= 0) {
  console.log("Erro! Digite um número maior que 0");
} else {
  while (valor <= valor_inserido) {
    console.log("Ola mundo");
    valor ++;
  }
}