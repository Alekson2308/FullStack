const letras = [1, 2, 3, 4, 5];
const numeros = ["Daniel", "Carlos", "Ana", "Braga"];

//const encontrado = numeros.find((numero) => numero > 3);
const encontrado = letras.find((letra) => letra === "Ana");
//const encontrado = letras.find((letra) => letra.lenght > 5);
//const encontrado = letras.find((letra) => letra.includes("Br"));
//const encontrado = letras.find((letra) => letra.startWith("Br"));

console.log(encontrado);