import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
    headerTittle:string 
  constructor() { 
    this.headerTittle="this is company header";
  }

  ngOnInit(): void {
  }

}
