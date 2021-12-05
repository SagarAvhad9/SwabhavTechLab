"use strict";
exports.__esModule = true;
var bank_module_1 = require("./bank-module");
var a = new bank_module_1.Account(101);
var n = new bank_module_1.Bank("HDFC", "Thane");
var c = new bank_module_1.Customer(1, "Sagar");
console.log(a, n, c);
console.log({ a: a, n: n, c: c });

