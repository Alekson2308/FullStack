const numeros = [10, 20, 30, 40, 50];

// numeros.splice(2, 0, 35, 37, 100); // A partir do índice 2, remove 0 elementos e adiciona 35, 37 e 100
numeros.splice(3, 1, 35, 37, 100); // A partir do índice 3, remove 1 elementos e adiciona 35, 37 e 100

console.log(numeros);

//splice(posição, remoção, adição)