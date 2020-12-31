import { Component, OnInit } from '@angular/core';
import { VehiculosService } from '../../services/vehiculos.service';
import { Marca, TipoVehiculo, Vehiculo } from '../../../Modelos/Vehiculos';


@Component({
  selector: 'app-insertar-vehiculos',
  templateUrl: './insertar-vehiculos.component.html',
  styleUrls: ['./insertar-vehiculos.component.css']
})
export class InsertarVehiculosComponent implements OnInit {

  constructor(private service: VehiculosService) { }

  mostrarAlerta: boolean = false;
  TipoVehiculos: TipoVehiculo[];
  Marcas: Marca[];
  vehiculoModel: Vehiculo = {

    vehCilindraje: 0,
    vehFecha: 0,
    vehId: 0,
    vehMarca: 1,
    vehModelo: '',
    vehTipoVehiculo: 1
  };

  ngOnInit(): void {
    this.cargarTipoVehiculo();
    this.cargarMarca();
  }


  cargarTipoVehiculo() {
    this.service.obtenerTipoVehiculo().then((res) => {
      this.TipoVehiculos = res;
    });
  }

  cargarMarca() {
    this.service.obtenerMarca().then((res) => {
      this.Marcas = res;
    });
  }


  onSave() {

    this.service.guardarVehiculo(this.vehiculoModel).then(() => {


      this.mostrarAlerta = true;

      setTimeout(() => {
        this.mostrarAlerta = false;
      }, 2000);

      this.vehiculoModel = {

        vehCilindraje: 0,
        vehFecha: 0,
        vehId: 0,
        vehMarca: 1,
        vehModelo: '',
        vehTipoVehiculo: 1
      };
    });
  }
}
