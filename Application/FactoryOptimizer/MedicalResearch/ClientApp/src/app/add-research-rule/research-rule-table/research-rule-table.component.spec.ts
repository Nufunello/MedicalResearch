import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResearchRuleTableComponent } from './research-rule-table.component';

describe('ResearchRuleTableComponent', () => {
  let component: ResearchRuleTableComponent;
  let fixture: ComponentFixture<ResearchRuleTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResearchRuleTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResearchRuleTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
