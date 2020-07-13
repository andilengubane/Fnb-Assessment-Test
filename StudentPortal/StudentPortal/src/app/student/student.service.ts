import { Injectable, AnimationStyles } from '@angular/core';
import { Student } from '../models/student.model';
import {Http , Response, Headers, RequestOptions, RequestMethod} from '@angular/http';
import 'rxjs/add/operator/map'
import {Observable} from 'rxjs/Observable'
import { environment } from '../../environments/environment';


@Injectable()
export class StudentService {

  student:Student;
  studentList: Student[];
  constructor( public _http: Http) { }

  getStudentDetails(){   
    const url = environment.baseUrl+'/Student/GetAllStudents';
    this._http.get(url)
    .map((response: Response) => {
      return response.json() as Student[];
    }).toPromise().then(x =>{
      this.studentList = x;
    })
   }

   getStudentByStudentNumber(studentNumber:number):Observable<Student>{ 
    const url = `${environment.baseUrl+"/Student/"}?${"studentNumber="+studentNumber}`;
                 return this._http.get(url)
                            .map((response:Response)=> <Student>response.json())
   }

   saveStudent(student:any){
    var body = JSON.stringify(student);
    console.log('body',body);
    const url = environment.baseUrl+'/Student/SaveStudent';
              this._http.post(url,student)
                        .map((response:Response)=> <Student>response.json());
  }
}