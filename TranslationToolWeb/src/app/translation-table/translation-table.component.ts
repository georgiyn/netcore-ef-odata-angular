import { Component, OnInit } from '@angular/core';
import {MatTableDataSource} from '@angular/material';
import {ODataQuery, ODataResponse, ODataService} from 'odata-v4-ng';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-translation-table',
  templateUrl: './translation-table.component.html',
  styleUrls: ['./translation-table.component.css']
})
export class TranslationTableComponent implements OnInit {
  displayedColumns: string[] = ['Id', 'Key', 'OriginalText', 'TranslatorNotes'];
  private dataSource: any;
  private odataQuery: any;

  private SERVICE_ROOT = 'http://localhost/odata/';
  private response: string;
  private oDataService: any

  constructor(private http: HttpClient) {
    console.log('constructor');
    this.oDataService = new ODataService(http);
  }

  ngOnInit() {
    console.log('init');
    this.odataQuery = new ODataQuery(this.oDataService, this.SERVICE_ROOT)
      .entitySet('Translations?$expand=Translations');
    this.odataQuery.get().subscribe(
      (odataResponse: ODataResponse) => {
        this.response = odataResponse.getBodyAsJson().value;
        console.log(this.response);
        this.dataSource = new MatTableDataSource(JSON.parse(JSON.stringify(this.response)));
      },
      (error: string) => {
        this.response = error;
        console.log(this.response);
      }
    );
  }
  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
}
