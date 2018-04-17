var dt = require('./dateService');
var fibService = require('./fibonacciService');
var factService = require('./factorialService');
var myArgs = process.argv.slice(2);
console.log(myArgs);
console.log(fibService.fib(20));
console.log(factService.fact(20));

