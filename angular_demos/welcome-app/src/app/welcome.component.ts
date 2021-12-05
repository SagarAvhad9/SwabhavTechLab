import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-welcome',
  templateUrl: './welcome.component.html',
  
})
export class WelcomeComponent implements OnInit {
  message:string
  today:string
  randomValue:number
  constructor(){
    console.log("constructor created");
    
    this.message="Welcome to swabhav tech";
    this.today=new Date().toString();
    this.randomValue=Math.random();
  }
  ngOnInit(){
    console.log("component and view loaded successfully ");
    setTimeout(() => {
      this.message="welocme to data binding after 3 sec";
      this.today=new Date().toString();
    }, 3000);
  }
}
