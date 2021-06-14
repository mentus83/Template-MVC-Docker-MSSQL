import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { Client } from './services/client.service';
import MyObjectListView from './views/myobjectListView.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    MyObjectListView
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [
    Client
  ],
  bootstrap: [MyObjectListView]
})
export class AppModule { }
