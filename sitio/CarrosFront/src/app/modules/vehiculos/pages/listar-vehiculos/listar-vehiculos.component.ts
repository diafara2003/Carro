import { Component, OnInit } from '@angular/core';
import { VehiculosService } from '../../services/vehiculos.service';
import { ConsultarVehiculosDTO } from '../../../Modelos/Vehiculos';


@Component({
  selector: 'app-listar-vehiculos',
  templateUrl: './listar-vehiculos.component.html',
  styleUrls: ['./listar-vehiculos.component.css']
})
export class ListarVehiculosComponent implements OnInit {

  fecha: string;
  vehiculos: ConsultarVehiculosDTO[];

  constructor(private service: VehiculosService) { }

  ngOnInit(): void {
    this.service.obtenerVehiculos().then((res) => {
      this.vehiculos = res;

      console.log(this.vehiculos);
    }).catch((e) => console.log(e));
  }




}

