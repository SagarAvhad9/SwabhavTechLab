"use strict";
//import Bank,{Account,Customer} from './bank-module'
//let obj=new Bank("hdfc","kurla")
exports.__esModule = true;
var b = require("./bank-module");
var a = new b.Account(100);
var c = new b.Customer(1, "kunal");
var b1 = new b["default"]("indian", "bhusawal");
console.log(a, c, b1);
