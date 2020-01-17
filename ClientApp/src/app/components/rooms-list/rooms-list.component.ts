import {Component, OnInit, ViewChild} from '@angular/core';
import {Room} from '../../shared/room';
import { MatPaginator, MatTableDataSource } from '@angular/material';
import {ApiService} from '../../shared/api.service';

@Component({
  selector: 'app-rooms-list',
  templateUrl: './rooms-list.component.html',
  styleUrls: ['./rooms-list.component.css']
})
export class RoomsListComponent implements OnInit {

  navTitle = 'Lista sal';
  RoomData: any = [];
  dataSource: MatTableDataSource<Room>;
  @ViewChild(MatPaginator, {static: false}) paginator: MatPaginator;
  displayedColumns: string[] = ['Id', 'Name', 'Edit', 'Delete'];

  constructor(private studentApi: ApiService) {
    this.studentApi.GetRooms().subscribe(data => {
      this.RoomData = data;
      console.log(this.RoomData);
      this.dataSource = new MatTableDataSource<Room>(this.RoomData);
      setTimeout(() => {
        this.dataSource.paginator = this.paginator;
      }, 0);
    });
  }

  ngOnInit() { }

  deleteRoom(index: number, e) {
    if (window.confirm('Czy chcesz skasować salę?')) {
      const data = this.dataSource.data;
      data.splice((this.paginator.pageIndex * this.paginator.pageSize) + index, 1);
      this.dataSource.data = data;
      this.studentApi.DeleteRoom(e._id).subscribe();
    }
  }

}
