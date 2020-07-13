import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { StudentComponent } from './student/student.component';
import { CreateStudentComponent } from './student/create-student.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';

const routes: Routes = [
  {path:'list', component:StudentComponent},
  {path:'create',component:CreateStudentComponent},
  {path:'pagenotfound', component:PageNotFoundComponent},
  {path:'', redirectTo:'/list',pathMatch:'full'},

];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
