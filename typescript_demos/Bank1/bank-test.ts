//import Bank,{Account,Customer} from './bank-module'
//let obj=new Bank("hdfc","kurla")

import * as b from './bank-module'
let a=new b.Account(100)
let c=new b.Customer(1,"kunal");
let b1=new b.default("indian","bhusawal");
console.log(a,c,b1);