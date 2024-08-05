import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ErrorComponent } from './_helpers/error/error.component';

const routes: Routes = [
  {path:'', loadChildren: () => import('./auth/auth.module').then(m =>m.AuthModule)},
  {path:'main', loadChildren: () => import('./main/main.module').then(m =>m.MainModule)},
  { path: '**', component: ErrorComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
