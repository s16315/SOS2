import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {AddRoomComponent} from './components/add-room/add-room.component';
import {EditRoomComponent} from './components/edit-room/edit-room.component';
import {RoomsListComponent} from './components/rooms-list/rooms-list.component';
import {CoursesListComponent} from './components/courses-list/courses-list.component';
import {AddCourseComponent} from './components/add-course/add-course.component';
import {AddLessonComponent} from './components/add-lesson/add-lesson.component';
import {StudentsListComponent} from './components/students-list/students-list.component';
import {AddStudentComponent} from './components/add-student/add-student.component';
import {ScheduleComponent} from './components/schedule/schedule.component';


const routes: Routes = [
  {path: 'add-room', component: AddRoomComponent},
  {path: 'edit-room', component: EditRoomComponent},
  {path: 'rooms-list', component: RoomsListComponent},
  {path: 'add-lesson', component: AddLessonComponent},
  {path: 'courses-list', component: CoursesListComponent},
  {path: 'add-course', component: AddCourseComponent},
  {path: 'student-list', component: StudentsListComponent},
  {path: 'add-student', component: AddStudentComponent},
  {path: 'schedule', component: ScheduleComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
