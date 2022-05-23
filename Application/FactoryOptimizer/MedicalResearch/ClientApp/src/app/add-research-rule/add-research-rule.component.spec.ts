import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddResearchRuleComponent } from './add-research-rule.component';

describe('AddResearchRuleComponent', () => {
  let component: AddResearchRuleComponent;
  let fixture: ComponentFixture<AddResearchRuleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddResearchRuleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddResearchRuleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
