import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import {Room} from './room';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  endpoint = 'https://localhost:5001/api';
  headers = new HttpHeaders().set('Content-Type', 'application/json');
  constructor(private http: HttpClient) { }

  AddRoom(data: Room): Observable<any> {
    const API_URL = `${this.endpoint}/rooms/add-room`;
    return this.http.post(API_URL, data)
      .pipe(
        catchError(this.errorMgmt)
      );
  }

  GetRooms() {
    return this.http.get(`${this.endpoint}/rooms`);
  }

  GetRoom(id): Observable<any> {
    const API_URL = `${this.endpoint}/rooms/read-room/${id}`;
    return this.http.get(API_URL, {headers: this.headers}).pipe(
      map((res: Response) => {
        return res || {};
      }),
      catchError(this.errorMgmt)
    );
  }

  UpdateRoom(id, data: Room): Observable<any> {
    const API_URL = `${this.endpoint}/rooms/update/${id}`;
    return this.http.put(API_URL, data, { headers: this.headers }).pipe(
      catchError(this.errorMgmt)
    );
  }

  DeleteRoom(id): Observable<any> {
    const API_URL = `${this.endpoint}/rooms/delete-room/${id}`;
    return this.http.delete(API_URL).pipe(
      catchError(this.errorMgmt)
    );
  }

  errorMgmt(error: HttpErrorResponse) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      // Get client-side error
      errorMessage = error.error.message;
    } else {
      // Get server-side error
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    console.log(errorMessage);
    return throwError(errorMessage);
  }
}
