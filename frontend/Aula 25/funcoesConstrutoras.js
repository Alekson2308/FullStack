function Pessoa(nome, idade) {
  this.nome = nome;
  this.idade = idade;
}

const pessoa1 = new Pessoa("Angélica", 19)
const pessoa2 = new Pessoa("Bob", 25)

pessoa1.nome = "Jonathan"

console.log(pessoa1)