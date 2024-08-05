import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MainRoutingModule } from './main-routing.module';
import { LayoutComponent } from './layout/layout.component';
import { SearchComponent } from './search/search.component';
import { PortofolioComponent } from './portofolio/portofolio.component';
import {RouterModule} from '@angular/router';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatButtonModule} from '@angular/material/button';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatIconModule} from '@angular/material/icon';
import { MatTableModule } from '@angular/material/table';
import {MatInputModule} from '@angular/material/input';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { AddEditStockComponent } from './add-edit-stock/add-edit-stock.component';
import {MatDialogModule} from '@angular/material/dialog';


@NgModule({
  declarations: [
    LayoutComponent,
    SearchComponent,
    PortofolioComponent,
    AddEditStockComponent
  ],
  imports: [
    CommonModule,
    MainRoutingModule,
    RouterModule,
    MatToolbarModule,
    MatButtonModule,
    MatFormFieldModule,
    MatPaginatorModule,
    MatIconModule,
    MatTableModule,
    MatInputModule,
    TabsModule,
    MatDialogModule
  ]
})
export class MainModule { }
