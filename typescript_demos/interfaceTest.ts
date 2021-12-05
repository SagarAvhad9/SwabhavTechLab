interface iCustomer{
    id:number;
    firstName:string;
    lastName:string;
    Location ?:string;
}
PrinDetails([{firstName:'Sagar',id:101,lastName:'Avhad'},
{firstName:'Kunal',id:201,lastName:'Sarode',Location:'Mumbai'}]);
function PrinDetails(customers:Array<iCustomer>){
    for(let c of customers){
        console.log(c);  
    }
}