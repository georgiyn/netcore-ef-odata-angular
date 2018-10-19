import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MatTableModule, MatFormFieldModule, MatInputModule } from '@angular/material';
import { TranslationTableComponent } from './translation-table/translation-table.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ODataModule } from 'odata-v4-ng';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    TranslationTableComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatTableModule,
    MatFormFieldModule,
    MatInputModule,
    BrowserAnimationsModule,
    HttpClientModule,
    ODataModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
