const lista_programadores = ["Edison", "Ferney"];
console.log(nombres);
lista_programadores.forEach((programador, posicion) => {
  console.log(programador);
  console.log(posicion);
  nombres[posicion] = programador;
});

/* nombres = [...lista_programadores] */

/* console.log(posicion) */
console.log(nombres);

/* arr.forEach(function callback(currentValue, index, array) {
  // tu iterador
}[, thisArg]); */
