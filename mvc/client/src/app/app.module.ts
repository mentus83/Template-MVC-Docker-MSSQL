import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { Client } from './services/client.service';
import MyObjectListView from './views/myobjectListView.component';

@NgModule({
  declarations: [
    MyObjectListView
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [
    Client
  ],
  bootstrap: [MyObjectListView]
})
export class AppModule { }
