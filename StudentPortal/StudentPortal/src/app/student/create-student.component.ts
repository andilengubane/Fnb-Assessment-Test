import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { DepartmentService } from '../department/department.service';
import { StudentService } from '../student/student.service';

@Component({
  selector: 'app-create-student',
  templateUrl: './create-student.component.html',
  styleUrls: ['./create-student.component.css']
})
export class CreateStudentComponent implements OnInit {
 departments
  constructor(public _dep:DepartmentService ,public _stud:StudentService) { }

  ngOnInit() {
    this._dep.getDepartment().subscribe((posts)=>
    this.departments = posts)
  }

  SaveStudent(stdForm:NgForm):void{
  this._stud.saveStudent(stdForm.value);
  }
}
