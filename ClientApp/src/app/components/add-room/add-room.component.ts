import {Component, OnInit, ViewChild, NgZone} from '@angular/core';
import {ApiService} from '../../shared/api.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { COMMA, ENTER } from '@angular/cdk/keycodes';
import {MatChipInputEvent, MatPaginator} from '@angular/material';
import { Router } from '@angular/router';



export interface Subject {
  name: string;
}

@Component({
  selector: 'app-add-room',
  templateUrl: './add-room.component.html',
  styleUrls: ['./add-room.component.css']
})

export class AddRoomComponent implements OnInit {

  visible = true;
  selectable = true;
  removable = true;
  addOnBlur = true;
  roomForm: FormGroup;
  subjectArray: Subject[] = [];


  @ViewChild('resetRoomForm', {static: false}) myNgForm;
  constructor(
    public fb: FormBuilder,
    private router: Router,
    private ngZone: NgZone,
    private roomApi: ApiService
  ) { }

  submitBookForm() {
    this.roomForm = this.fb.group({
      roomName: ['', [Validators.required]]
    });
  }

  ngOnInit() {
    this.submitBookForm();
  }

  public handleError = (controlName: string, errorName: string) => {
    return this.roomForm.controls[controlName].hasError(errorName);
  }

  submitRoomForm() {
    console.log('1');
    console.log(this.roomForm.value);
    if (this.roomForm.valid) {
      this.roomApi.AddRoom(this.roomForm.value).subscribe(res => {
        this.ngZone.run(() => this.router.navigateByUrl('/rooms-list'));
      });
    }
  }
}
