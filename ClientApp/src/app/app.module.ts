import { BrowserModule } from '@angular/platform-browser';
// import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AddRoomComponent } from './components/add-room/add-room.component';
import { EditRoomComponent } from './components/edit-room/edit-room.component';
import { RoomsListComponent } from './components/rooms-list/rooms-list.component';
import { AngularMaterialModule } from './material.module';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import {ApiService} from './shared/api.service';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import {MatCardModule} from "@angular/material";

@NgModule({
  declarations: [
    AppComponent,
    AddRoomComponent,
    EditRoomComponent,
    RoomsListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    AngularMaterialModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    MatCardModule
  ],
  providers: [ApiService],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AppModule { }
