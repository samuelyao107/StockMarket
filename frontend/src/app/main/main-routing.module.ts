import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutComponent } from './layout/layout.component';
import { SearchComponent } from './search/search.component';
import { PortofolioComponent } from './portofolio/portofolio.component';

const routes: Routes = [
  {path: '', component: LayoutComponent, children : [
    {path:'', redirectTo:'search', pathMatch:'full'},
    {path:'search', component: SearchComponent},
    {path:'portofolio', component: PortofolioComponent}
  ]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MainRoutingModule { }
