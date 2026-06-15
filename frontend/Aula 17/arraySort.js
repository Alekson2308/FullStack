const numeros = [30, 2, 1, 0, 50, 7, 13, 32, 147];
const nomes = ["daniel", "beto", "carlos", "ana", "eduardo"];
numeros.sort((a, b) => a - b); //Isso é somente para numeros, letras não precisa.
nomes.sort();

console.log(numeros.reverse());
console.log(nomes.reverse());