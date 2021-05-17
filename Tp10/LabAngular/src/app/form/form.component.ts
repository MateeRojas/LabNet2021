import { HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Employee } from '../models/Employee';
import { EmployeesService } from '../services/employees.service';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.scss']
})
export class FormComponent implements OnInit {

  form: FormGroup;

  constructor(private readonly fb: FormBuilder, private service: EmployeesService) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      nombre: new FormControl('', Validators.required),
      apellido: new FormControl('', Validators.required),
      ciudad: new FormControl('', Validators.required),
      pais: new FormControl('', Validators.required),
    });
  }

  onSubmit(): void{
    var empleado = new Employee();
    empleado.FirstName = this.form.get('nombre').value;
    empleado.LastName = this.form.get('apellido').value;
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


    this.service.postEmployees(empleado);
    window.location.reload();
  }
  onClickLimpiar(): void{
    const nombreCtrl = this.form.get('nombre');
    const apellidoCtrl = this.form.get('apellido');
    const ciudadCtrl = this.form.get('ciudad');
    const paisCtrl = this.form.get('pais');
    if(nombreCtrl || apellidoCtrl || ciudadCtrl || paisCtrl){
      nombreCtrl.setValue('');
      apellidoCtrl.setValue('');
      ciudadCtrl.setValue('');
      paisCtrl.setValue('');
    }
  }
}
