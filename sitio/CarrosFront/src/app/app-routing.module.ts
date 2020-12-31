import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [

  {
    path: '',
    redirectTo:'vehiculo',
    pathMatch:'full'
  },
  {
    path: 'vehiculo',
    loadChildren: () =>
      import('./modules/vehiculos/vehiculos.module').then((m) => m.VehiculosModule)
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
