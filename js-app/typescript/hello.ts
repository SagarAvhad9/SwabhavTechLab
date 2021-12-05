let name1: string="Sagar";
let cgpa: number=9.2;
let activeuser=true;
let displaytext=`
username:    ${name1}
cgpa:        ${cgpa}
activeuser:  ${activeuser}

` 
console.log(displaytext);
function fun(name1:string):string{
    return "hello "+name1;
}
console.log(fun("sagar"));
