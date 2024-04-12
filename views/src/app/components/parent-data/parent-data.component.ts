import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Console } from 'node:console';

@Component({
  selector: 'app-parent-data',
  standalone: true,
  imports: [],
  templateUrl: './parent-data.component.html',
  styleUrl: './parent-data.component.css'
})
export class ParentDataComponent implements OnInit {
  @Output() clickNumber: EventEmitter<any> =  new EventEmitter();

  number: number = 0;

  constructor(){}

  ngOnInit(): void {
      
  }

  ShowingMessage(): void{
    
  }

  handleclick(){
    this.number++;
  }
  
}
