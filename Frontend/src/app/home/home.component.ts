import { Component, OnInit } from '@angular/core';
import { LoginService } from '../services/login.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  item = {
    Pno: "",
    password: "",
    name: ""
  } 
  constructor( private loginservice:LoginService) { }
  


  ngOnInit(): void {

let Empid = localStorage.getItem("Empid");
console.log(Empid);
this.loginservice.getEmployer(Empid)
      .subscribe((data)=>{
        console.log(data);
        this.item=JSON.parse(JSON.stringify(data))
          })


  }
}
