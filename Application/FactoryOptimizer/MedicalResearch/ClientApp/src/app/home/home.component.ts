import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, Inject, ViewChild } from '@angular/core';
import { MatSort, MatPaginator, MatTableDataSource, MatDialog, Sort, MAT_DIALOG_DATA } from '@angular/material';
import { Router } from '@angular/router';
import { DialogDataExampleDialog } from '../add-research/research-table/research-table.component';
import { WorkSchedule } from '../models/work-schedule.model';
import { DepartmentService } from '../services/department.service';
import { ResearchService } from '../services/research.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent {
  @ViewChild(MatSort, {static: false}) sort: MatSort;
  @ViewChild(MatPaginator, {static: false}) paginator: MatPaginator;

  displayedColumns: string[] = ['region', 'address', 'phone', 'open', 'btn'];
  dataSource = new MatTableDataSource();

  constructor(private _liveAnnouncer: LiveAnnouncer, private router: Router, private service: DepartmentService, public dialog: MatDialog) {}

  ngOnInit(): void {
      this.service.list().subscribe(response => {
        this.dataSource = new MatTableDataSource(response);
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
      })
  }

  openDialog(data: string) {
    this.router.navigateByUrl('/departments/' + data);

  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  edit(id: number) {
    this.router.navigateByUrl('/add-department/' + id);
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
