import { Component } from '@angular/core';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrl: './search.component.css'
})
export class SearchComponent {
  displayedColumns: string[] = ['Id', 'Symbol', 'CompanyName', 'Purchase','MarketCap', 'Action'];
}
