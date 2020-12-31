# Proyecto de vehiculos

Para este proyecto se realiza diferente servicios APIREST, y un ejemplo de con angular 10, para el consumo de los servicios.
Las tegnologias utilizadas fueron:
- **angular 10**
- **netcore 3.1**

framework de diseño:
- **bootstrap**

*No se utilizo entity framework, en cambio se utilizo procedimientos almacenados

## Requisitos

- Visual studio 2019
- nodejs
- sql server management studio 2014


## Installation

- Una vez clonado el repositorio abrir la solucion y compilarlo para poder ejecutarlo
- para cambiar la cadena de conexion es necesario modificar el archivo  **Config.json** ubicado en la raiz del proyecto
- ejecutar en la base datos el archivo **Script_initial.sql** ubicado en la carperta BaseDatos/SQL/Procedimientos


```bash
git clone https://github.com/diafara2003/Carro.git
```

## Ejecucion

**BackEnd**
- Compilar la solucion y ejecutar el proyecto de **API**

**FrontEnd**
- ejecutar los siguientes comando
- npm i
- npm start


## Servicios

Servicio para obtener la fecha de hoy con formato HH:mm:ss 

```bash
GET
https://localhost:44311/api/fecha
```

Servicio para poder dividir 2 numeros

```bash
POST
https://localhost:44311/api/Operaciones/dividir

{
"numero1":10,
"numero2":5
}

```

Servicio para obtener todos los vehiculos

```bash
GET
https://localhost:44311/api/vehiculo
```

Servicio para obtener todos los tipos de vehiculos

```bash
GET
https://localhost:44311/api/vehiculo/TipoVehiculo
```


Servicio para obtener todas las marcas

```bash
GET
https://localhost:44311/api/marca
```

