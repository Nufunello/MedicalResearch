import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-add-research',
  templateUrl: './add-research.component.html',
  styleUrls: ['./add-research.component.css']
})
export class AddResearchComponent {

  constructor(private fb: FormBuilder) {}

  researchForm = this.fb.group({
    name: [''],
    description: [''],
    handingTerm: [],
    deliveryTerm: [],
  });

  onSubmit() {
   console.log('form data is ', this.researchForm.value);
  }

}
