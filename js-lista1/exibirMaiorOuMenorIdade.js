const atual = 2022;

let nome = prompt("Digite seu nome: ");
let ano_inserido = prompt("Digite o ano em que você nasceu: ");

idade = atual - ano_inserido;

if (idade >= 18) {
  console.log("Você é maior de idade");
} else {
  console.log("Você é menor de idade");
}