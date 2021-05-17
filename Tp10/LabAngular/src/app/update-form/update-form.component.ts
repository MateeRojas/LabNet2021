import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Employee } from '../models/Employee';
import { EmployeesService } from '../services/employees.service';

@Component({
  selector: 'app-update-form',
  templateUrl: './update-form.component.html',
  styleUrls: ['./update-form.component.scss']
})
export class UpdateFormComponent implements OnInit {

  form: FormGroup;

  constructor(private readonly fb: FormBuilder, private service: EmployeesService) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      id: new FormControl('', Validators.required),
      ciudad: new FormControl('', Validators.required),
      pais: new FormControl('', Validators.required),
    });
  }
  onSubmit(): void{
    var empleado = new Employee();
    empleado.EmployeeID = this.form.get('id').value;
    empleado.FirstName = null;
    empleado.LastName = null;
    empleado.City = this.form.get('ciudad').value;
    empleado.Country = this.form.get('pais').value;
    empleado.Title = null;
    empleado.TitleOfCourtesy= null;
    empleado.BirthDate= null;
    empleado.HireDate= null;
    empleado.Address= null;
    empleado.Region= null;
    empleado.PostalCode= null;
    empleado.HomePhone= null;
    empleado.Extension= null;
    empleado.Notes= null;
    empleado.ReportsTo= null;
    empleado.PhotoPath= null;

    this.service.putEmployees(empleado).subscribe((response:number)=>console.log(response), 
    (error:any)=> alert('Ocurrió un error, no se puede actualizar.'),  
    ()=> window.location.reload());
  }

  onClickLimpiar(): void{
    const idCtrl = this.form.get('id');
    const ciudadCtrl = this.form.get('ciudad');
    const paisCtrl = this.form.get('pais');
    if(idCtrl || ciudadCtrl || paisCtrl){
      idCtrl.setValue('');
      ciudadCtrl.setValue('');
      paisCtrl.setValue('');
    }
  }
}


