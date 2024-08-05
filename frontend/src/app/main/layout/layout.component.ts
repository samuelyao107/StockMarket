import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { AddEditStockComponent } from '../add-edit-stock/add-edit-stock.component';

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrl: './layout.component.css'
})
export class LayoutComponent {
  constructor(private _dialog: MatDialog){}

  openStockForm(){
     this._dialog.open(AddEditStockComponent)
  }
}
