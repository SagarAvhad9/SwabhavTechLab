class Account{
    constructor(private _accno:number ,private _name:string,private _balance:number){

    }
    deposit(amount){
        this._balance+=amount;
    }
    get balance(){
        return this._balance;
    }
    get accno(){
        return this._accno;
    }
    get name(){
        return this._name;
    }
}
let acc1=new Account(101,"Sagar",1000);
acc1.deposit(4000);
console.log(acc1.balance);
console.log(acc1);

