import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {ReactiveFormsModule} from '@angular/forms';
import { AppComponent } from './app.component';
import {ROUTES} from './app.routes'
import { RouterModule } from '@angular/router';
import { ListAirplaneComponent } from './components/list-airplane/list-airplane.component';
import { HttpClientModule } from '@angular/common/http';
import { EditAirplaneComponent } from './components/edit-airplane/edit-airplane.component';
import { AddAirplaneComponent } from './components/add-airplane/add-airplane.component';

@NgModule({
  declarations: [
    AppComponent,
    ListAirplaneComponent,
    EditAirplaneComponent,
    AddAirplaneComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(ROUTES),
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
