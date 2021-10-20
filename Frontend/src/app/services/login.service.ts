import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  

  constructor(private http:HttpClient) { }

  getEmployer(id:any){
   return this.http.get('https://localhost:44392/api/Users/'+id)

  }
}
