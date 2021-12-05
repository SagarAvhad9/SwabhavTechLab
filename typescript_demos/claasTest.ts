class Student{
    constructor(public firstName:string,public lastName:string){

    }
    get FullName(){
        return `${this.firstName} - ${this.lastName}`
    }
    set FullName(value:string){
        let values:string[]=value.split(" ")
        console.log(values);
        this.firstName=values[0];
        this.lastName=values[1];
        
    }
}
let s1=new Student("Sagar","Avhad")

console.log(s1);
s1.firstName="SAGAR"
s1.lastName="Avhad"
console.log(s1);
console.log(s1.FullName);

let s2=new Student("kunal","sarode")
s2.FullName="akshay sawant" 


