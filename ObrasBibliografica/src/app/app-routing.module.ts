import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { NomesAutoresComponent } from './NomesAutores/NomesAutores.component';
import { ObrasBibliograficasComponent } from './ObrasBibliograficas/ObrasBibliograficas.component';


const routes: Routes = [
  {path: '', redirectTo: 'inicio',pathMatch: 'full'},
  {path: 'inicio',component: NomesAutoresComponent },
  {path: 'listaAutores',component: ObrasBibliograficasComponent }
 
  
  
  
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
