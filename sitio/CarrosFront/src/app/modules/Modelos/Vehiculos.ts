export interface Vehiculo {
    vehId: number;
    vehModelo: string;
    vehFecha: number;
    vehCilindraje: number;
    vehTipoVehiculo: number;
    vehMarca: number;
}


export interface ConsultarVehiculosDTO extends Vehiculo {

    marNombre: string;
    tipVehNombre: string;
    tipVehDescripcion: string;
}   

export interface Marca {
    marId: number;
    marNombre: string;
}

export interface TipoVehiculo {
    tipVehId: number;
    tipVehNombre: string;
}