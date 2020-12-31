import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {ListarVehiculosComponent } from './pages/listar-vehiculos/listar-vehiculos.component';
import { InsertarVehiculosComponent } from "./pages/insertar-vehiculos/insertar-vehiculos.component";
const routes: Routes = [
  {
    path:'',
    component: ListarVehiculosComponent
  },
  {
    path:'crear',
    component:InsertarVehiculosComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class VehiculosRoutingModule { }
