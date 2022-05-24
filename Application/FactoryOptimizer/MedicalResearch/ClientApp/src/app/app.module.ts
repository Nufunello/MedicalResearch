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
    DialogDataExampleDialog,
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
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'add-research', component: AddResearchComponent },
      { path: 'add-research/:id', component: AddResearchComponent },
      { path: 'research-table', component: ResearchTableComponent },
      { path: 'add-research-rule', component: AddResearchRuleComponent },
      { path: 'research-rule-table', component: ResearchRuleTableComponent },
    ])
  ],
  providers: [ResearchService],
  bootstrap: [AppComponent]
})
export class AppModule { }
