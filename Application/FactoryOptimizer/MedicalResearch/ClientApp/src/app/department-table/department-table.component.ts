import { LiveAnnouncer } from '@angular/cdk/a11y';
import { WeekDay } from '@angular/common';
import { Component, Inject, OnInit, ViewChild } from '@angular/core';
import { MatSort, MatPaginator, MatTableDataSource, MatDialog, Sort, MAT_DIALOG_DATA } from '@angular/material';
import { Router } from '@angular/router';
import { DialogDataExampleDialog } from '../add-research/research-table/research-table.component';
import { DayOfWeek } from '../models/DayWeek.model';
import { Department } from '../models/department.model';
import { WorkSchedule } from '../models/work-schedule.model';
import { DepartmentService } from '../services/department.service';

@Component({
  selector: 'app-department-table',
  templateUrl: './department-table.component.html',
  styleUrls: ['./department-table.component.css']
})
export class DepartmentTableComponent implements OnInit {
  @ViewChild(MatSort, {static: false}) sort: MatSort;
  @ViewChild(MatPaginator, {static: false}) paginator: MatPaginator;
  id: number;

  displayedColumns: string[] = ['name', 'cabinet', 'deadlineInDays', 'groupName', 'preparationDescription', 'cost', 'btn'];
  dataSource: Department;
  data = new MatTableDataSource();
  auth = false;

  constructor(private _liveAnnouncer: LiveAnnouncer, private router: Router, private service: DepartmentService, public dialog: MatDialog) {}

  ngOnInit(): void {
    this.auth = localStorage.getItem('auth') === 'true';
    this.id = Number(this.router.url.split('/').pop());
    if(this.id) {
      this.service.getOne(this.id).subscribe((response) =>{
        this.dataSource = response;
        console.log(this.dataSource);
        this.service.getDepartmentDetails(this.id).subscribe((resp) => {
          this.dataSource.WorkSchedules = resp.WorkSchedules;
          this.dataSource.DepartmentResearches = resp.DepartmentResearches;
          this.data = new MatTableDataSource(this.dataSource.departmentResearches);
          this.data.paginator = this.paginator;
          this.data.sort = this.sort;
          console.log(this.dataSource);
        })
      })
    }
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    console.log(filterValue.trim())
    this.data.filter = filterValue.trim().toLowerCase();

    if (this.data.paginator) {
      this.data.paginator.firstPage();
    }
  }

  openDialog(data: string) {
    this.dialog.open(DialogDataExampleDialog, {
      data: data
    });
  }

  processEnum(id: number): string {
    return DayOfWeek[id];
  }

  edit(id: number) {
    this.router.navigateByUrl('/add-research/' + id);
  }

  /** Announce the change in sort state for assistive technology. */
  announceSortChange(sortState: Sort) {
    console.log('test');
    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }
}

