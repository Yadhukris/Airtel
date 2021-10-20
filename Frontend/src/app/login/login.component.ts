import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from '../services/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  emp = {
    Pno: "",
    password: ""
  }

  item = {
    EPno: "",
    password: "",
    name: ""
  }

  constructor(private loginservice: LoginService, private router: Router) { }

  ngOnInit(): void {
  }

  loginEmp() {

    this.loginservice.getEmployer(this.emp.Pno)
      .subscribe((data) => {
        console.log(data);
        this.item = JSON.parse(JSON.stringify(data))
        if (this.item.password == this.emp.password) {
          localStorage.setItem("Empid", this.emp.Pno)
          localStorage.setItem("Ename", this.item.name)
          this.router.navigate(["Home"]);
        }
        else{
          alert("invalid details")
        }
      })
  }



}


