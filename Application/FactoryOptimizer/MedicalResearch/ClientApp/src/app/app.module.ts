import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { AddResearchComponent } from './add-research/add-research.component';
import { MatButtonModule, MatCardModule, MatDatepickerModule, MatFormFieldModule, MatInputModule, MatNativeDateModule, MatRadioModule, MatSelectModule, MatSliderModule } from '@angular/material';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AddResearchRuleComponent } from './add-research-rule/add-research-rule.component';
import { ResearchRuleTableComponent } from './add-research-rule/research-rule-table/research-rule-table.component';
import { DialogDataExampleDialog, ResearchTableComponent } from './add-research/research-table/research-table.component';
import { MatTableModule } from '@angular/material/table';
import { MaterialExampleModule } from './material.module';
import { ResearchService } from './services/research.service';
import { DepartmentService } from './services/department.service';
import { DepartmentTableComponent } from './department-table/department-table.component';
import { UserAuthorizationComponent } from './user-authorization/user-authorization.component';
import { UserRegistrationComponent } from './user-registration/user-registration.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatDividerModule } from '@angular/material/divider';
import { UserService } from './services/user.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    AddResearchComponent,
    AddResearchRuleComponent,
    ResearchRuleTableComponent,
    ResearchTableComponent,
    DepartmentTableComponent,
    DialogDataExampleDialog,
    UserAuthorizationComponent,
    UserRegistrationComponent,
  ],
  entryComponents: [DialogDataExampleDialog],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MaterialExampleModule,
    HttpClientModule,
    FormsModule,
    MatDividerModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'departments', component: HomeComponent },
      { path: 'departments/:id', component: DepartmentTableComponent },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'add-research', component: AddResearchComponent },
      { path: 'add-research/:id', component: AddResearchComponent },
      { path: 'research-table', component: ResearchTableComponent },
      { path: 'add-research-rule', component: AddResearchRuleComponent },
      { path: 'research-rule-table', component: ResearchRuleTableComponent },
      { path: 'login', component: UserAuthorizationComponent },
      { path: 'registration', component: UserRegistrationComponent},
    ])
  ],
  providers: [ResearchService, DepartmentService, UserService],
  bootstrap: [AppComponent],
  exports:[
    MatToolbarModule,
    MatCardModule,
    MatInputModule,
    MatFormFieldModule,
    MatButtonModule,
  ]
})
export class AppModule { }
