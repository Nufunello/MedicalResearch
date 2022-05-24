import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { environment } from 'src/environments/environment';
import { ResearchService } from '../services/research.service';
import {Location} from '@angular/common';

@Component({
  selector: 'app-add-research',
  templateUrl: './add-research.component.html',
  styleUrls: ['./add-research.component.css']
})
export class AddResearchComponent {

  constructor(private fb: FormBuilder, private service: ResearchService, private router: Router, private _location: Location) {}

  researchForm = this.fb.group({
    Name: [''],
    Description: [''],
    DeadlineInDays: [],
    Cost: [],
    PreparationDescription: [''],
    GroupResearchID: [1]
  });

  onSubmit() {
    let rquest = this.researchForm.getRawValue();
    console.log(rquest);
    this.service.create(rquest).subscribe(() => this._location.back());
  }

}
