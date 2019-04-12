import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Options } from 'selenium-webdriver/firefox';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public Departments: Department[];

  constructor(http: HttpClient) {
    http.get<Department[]>('http://localhost:51320/api/GetDepartments').subscribe(result => {
      this.Departments = result;
    }, error => console.error(error));
  }
}


interface Department {
  DepartmentID: number;
  Name: string;
  GroupName: string;
  ModifiedDate: string;
}
