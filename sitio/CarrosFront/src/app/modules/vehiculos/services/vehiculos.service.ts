import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Marca, TipoVehiculo, Vehiculo } from '../../Modelos/Vehiculos';

@Injectable()
export class VehiculosService {

  constructor(private http: HttpClient) { }


  obtenerMarca(): Promise<any> {

    return this.http.get<any>('https://localhost:44311/api/marca').toPromise();
  }
  obtenerTipoVehiculo(): Promise<any> {

    return this.http.get<any>('https://localhost:44311/api/Vehiculo/TipoVehiculo').toPromise();
  }

  obtenerVehiculos(): Promise<any> {

    return this.http.get<any>('https://localhost:44311/api/Vehiculo').toPromise();
  }

  guardarVehiculo(modelo:Vehiculo):Promise<any>{
    return this.http.post<any>('https://localhost:44311/api/Vehiculo',modelo).toPromise();
  }
}
