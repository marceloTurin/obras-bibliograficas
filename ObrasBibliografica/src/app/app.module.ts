import {HttpClient,HttpClientModule} from '@angular/common/http'
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ObrasBibliograficasComponent } from './ObrasBibliograficas/ObrasBibliograficas.component';
import { NavComponent } from './nav/nav.component';
import { NomesAutoresComponent } from './NomesAutores/NomesAutores.component';

@NgModule({
   declarations: [
      AppComponent,
      ObrasBibliograficasComponent,
      NavComponent,
      NomesAutoresComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      HttpClientModule
   ],
   providers: [
      HttpClient
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
