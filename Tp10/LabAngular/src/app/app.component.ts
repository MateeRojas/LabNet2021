import { Component } from '@angular/core';
import { EmployeesService } from './services/employees.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'LabAngular';
  public employees: Array<any> = [];

  constructor(
    private employeesService: EmployeesService         
  ){
    this.employeesService.getEmployees().subscribe((resp:any) =>{
      console.log(resp)
      this.employees = resp
    })
  }

}
