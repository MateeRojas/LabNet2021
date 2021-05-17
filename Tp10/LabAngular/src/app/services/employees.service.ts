import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Employee } from '../models/Employee';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmployeesService {
  url = 'https://localhost:44348/api/Employees'

  constructor(
    private http: HttpClient
  ){}
   getEmployees(){
     let header = new HttpHeaders()
     .set('Type-content','aplication/json')  

     return this.http.get(this.url,{
       headers: header
     });

   }

   public postEmployees(request: Employee){
     return this.http.post(environment.employees, request).subscribe();
   }

   public putEmployees(request: Employee){
    return this.http.put(environment.employees, request);
  }

   public deleteEmployee(request: number){
    return this.http.delete(environment.employees + '/' + request);
   }
}
