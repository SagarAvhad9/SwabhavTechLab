import {Account,Bank,Customer} from './bank-module'
let a=new Account(101)
let n=new Bank("HDFC","Thane")
let c=new Customer(1,"Sagar")
console.log(a,n,c);
console.log({a,n,c});

