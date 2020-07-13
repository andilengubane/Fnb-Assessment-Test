import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms'
import {HttpModule} from '@angular/http';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { StudentComponent } from './student/student.component';
import { CreateStudentComponent } from './student/create-student.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';

import { StudentService } from './student/student.service';
import { DepartmentService } from './department/department.service';
import { PageNotFoundService } from './page-not-found/page-not-found.service';

@NgModule({
  declarations: [
    AppComponent,
    StudentComponent,
    CreateStudentComponent,
    PageNotFoundComponent,
      
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpModule
  ],
  providers: [StudentService,DepartmentService,PageNotFoundService],
  bootstrap: [AppComponent]
})
export class AppModule { }
