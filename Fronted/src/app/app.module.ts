import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmpresaComponent } from './components/empresa/empresa.component';
import { ListadoEmpresasComponent } from './components/listado-empresas/listado-empresas.component';

@NgModule({
  declarations: [
    AppComponent,
    EmpresaComponent,
    ListadoEmpresasComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
