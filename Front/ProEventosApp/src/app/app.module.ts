// app.module.ts
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventosComponent } from './eventos/eventos.component';
import { PalestrantesComponent } from './palestrantes/palestrantes.component';
import { NavComponent } from './nav/nav.component';

import { CollapseModule } from 'ngx-bootstrap/collapse';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
    EventosComponent,
    PalestrantesComponent,
      NavComponent,

   ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    CollapseModule.forRoot(),
    BrowserAnimationsModule,
    FormsModule,



  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }