import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-add-research-rule',
  templateUrl: './add-research-rule.component.html',
  styleUrls: ['./add-research-rule.component.css']
})
export class AddResearchRuleComponent {

  constructor(private fb: FormBuilder) {}

  researchForm = this.fb.group({
    Description: [''],
  });

  onSubmit() {
   console.log('form data is ', this.researchForm.value);
  }
}
