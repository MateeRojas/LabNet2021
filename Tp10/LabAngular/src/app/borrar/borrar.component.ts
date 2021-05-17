import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { EmployeesService } from '../services/employees.service';

@Component({
  selector: 'app-borrar',
  templateUrl: './borrar.component.html',
  styleUrls: ['./borrar.component.scss']
})
export class BorrarComponent implements OnInit {

  form: FormGroup;

  
  constructor(private readonly fb: FormBuilder, private service: EmployeesService) {
  }
  
  ngOnInit(): void {
    this.form = this.fb.group({
      id: new FormControl('', Validators.required),
    });
  }
  
  onSubmit(): void{
    var conf = confirm("Esta seguro que desea eliminar al empleado?")
    if(conf){
      var ID = this.form.get('id').value;
      console.log(ID);
      this.service.deleteEmployee(ID).subscribe((response:number)=>console.log(response), 
            (error:any)=> alert('Ocurrió un error, no se puede eliminar.'),  
            ()=> window.location.reload());
    }
  }
}
