const numeros = [100, 95, 86, 43 ,53];

for (const indice in numeros) {
  console.log(Number(indice) + 1 + " - " + numeros[indice]);
}