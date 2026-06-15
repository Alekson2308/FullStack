const personagensherois = ["Sonic", "Tails", "Amy", "Knuckles"];
const personagensviloes = ["Dr. Eggman", "Infinite", "Metal Sonic"];
const outrospersonagens = ["Shadow", "Silver", "Blaze", "Sally", "Shard", "Manic"];
const personagenssecundarios = outrospersonagens.slice(0, 3);
personagenssecundarios.splice(3, 0, "Cream", "Big", "Rouge", "E-123 Omega");
personagensviloes.splice(1, 1, "Sage");

const personagens = personagensherois.concat(personagensviloes).concat(personagenssecundarios);

console.log(personagens);
console.log(personagens.indexOf('Sonic'));
console.log(personagens.lastIndexOf('Shadow'));