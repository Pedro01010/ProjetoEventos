import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EventosComponent } from './eventos/eventos.component';  // Importe seus componentes aqui

const routes: Routes = [
  { path: 'eventos', component: EventosComponent },
  // Adicione mais rotas conforme necessário
  { path: '', redirectTo: '/eventos', pathMatch: 'full' },  // Rota padrão
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
