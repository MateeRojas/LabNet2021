import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule, routingComponents } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormComponent } from './form/form.component';
import {ReactiveFormsModule} from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { UpdateFormComponent } from './update-form/update-form.component';
import { EmployeesComponent } from './Employees/employees/employees.component';
import { BorrarComponent } from './borrar/borrar.component';


@NgModule({
  declarations: [
    AppComponent,
    FormComponent,
    routingComponents,
    UpdateFormComponent,
    EmployeesComponent,
    BorrarComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
