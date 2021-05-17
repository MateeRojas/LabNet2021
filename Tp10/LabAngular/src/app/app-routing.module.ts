import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ActualizarComponent } from './actualizar/actualizar.component';
import { AgregarComponent } from './agregar/agregar.component';
import { BorrarComponent } from './borrar/borrar.component';

const routes: Routes = [
  {path: 'agregar', component: AgregarComponent},
  {path: 'actualizar', component: ActualizarComponent},
  {path: 'borrar', component: BorrarComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [AgregarComponent, ActualizarComponent];
