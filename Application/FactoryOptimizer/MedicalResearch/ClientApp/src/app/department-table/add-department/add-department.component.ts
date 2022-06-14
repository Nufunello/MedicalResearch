import { AfterContentInit, Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import {Location} from '@angular/common';
import { DepartmentService } from 'src/app/services/department.service';
import { Department } from 'src/app/models/department.model';

@Component({
  selector: 'app-add-research',
  templateUrl: './add-research.component.html',
  styleUrls: ['./add-research.component.css']
})
export class AddDepartmentComponent implements AfterContentInit {
  id: number;

  constructor(private fb: FormBuilder, private service: DepartmentService, private router: Router, private _location: Location) {}

  ngAfterContentInit(): void {
    this.id = Number(this.router.url.split('/').pop());
    if(this.id) {
      this.service.getOne(this.id).subscribe((response) => this.researchForm.reset(this.mapResponse(response)));
    }
  }

  researchForm = this.fb.group({
    CityID: [],
    Street: [''],
    Building: [''],
    PhoneNumber: [],
    WorkSchedules: [this.fb.group({
      DayOfWeek: [],
      StartTime: [],
      EndTime: [],
    })],
  });

  onSubmit() {
    let rquest = this.researchForm.getRawValue();
    console.log(rquest);
    if (!this.id) {
      this.service.create(rquest).subscribe(() => this._location.back());
    } else {
      this.service.update(rquest).subscribe(() => this._location.back());
    }
  }

  mapResponse(response: any): Department {
    let mapedResult = {} as Department;
    /* mapedResult.Id = response.id;
    mapedResult.Name = response.name;
    mapedResult.Cost = response.cost;
    mapedResult.DeadlineInDays = response.deadlineInDays;
    mapedResult.Description = response.description;
    mapedResult.PreparationDescription = response.preparationDescription;
    mapedResult.GroupResearchID = response.groupID; */
    return mapedResult;
  }
}
