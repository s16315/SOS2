import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {AddRoomComponent} from './components/add-room/add-room.component';
import {EditRoomComponent} from './components/edit-room/edit-room.component';
import {RoomsListComponent} from './components/rooms-list/rooms-list.component';



const routes: Routes = [
  {path: 'add-room', component: AddRoomComponent},
  {path: 'edit-room', component: EditRoomComponent},
  {path: 'rooms-list', component: RoomsListComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
