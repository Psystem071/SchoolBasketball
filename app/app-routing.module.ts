import { TimesComponent } from './times/times.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TecnicosComponent } from './tecnicos/tecnicos.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { PerfilComponent } from './perfil/perfil.component';

const routes: Routes = [
  { path: '', redirectTo: 'dashboard' , pathMatch: 'full' },
  { path: 'dashboard', component: DashboardComponent},
  { path: 'times', component: TimesComponent },
  { path: 'perfil', component: PerfilComponent },
  { path: 'tecnicos', component: TecnicosComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
