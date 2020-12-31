import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {FormsModule  } from "@angular/forms";
import { VehiculosRoutingModule } from './vehiculos-routing.module';
import { ListarVehiculosComponent } from './pages/listar-vehiculos/listar-vehiculos.component';
import { InsertarVehiculosComponent } from './pages/insertar-vehiculos/insertar-vehiculos.component';
import {HttpClientModule  } from "@angular/common/http";
import { VehiculosService } from "./services/vehiculos.service";

@NgModule({
  declarations: [ListarVehiculosComponent, InsertarVehiculosComponent],
  imports: [
    CommonModule,
    VehiculosRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers:[
    VehiculosService
  ]
})
export class VehiculosModule { }
