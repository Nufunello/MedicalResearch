import { LiveAnnouncer } from '@angular/cdk/a11y';
import { AfterViewInit, Component, Inject, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatPaginator, MatSort, MatTableDataSource, MAT_DIALOG_DATA, Sort } from '@angular/material';
import { Router } from '@angular/router';
import { Research } from 'src/app/models/research.model';
import { ResearchService } from 'src/app/services/research.service';
import { environment } from 'src/environments/environment';


@Component({
  selector: 'app-research-table',
  templateUrl: './research-table.component.html',
  styleUrls: ['./research-table.component.css']
})
export class ResearchTableComponent implements OnInit {
  @ViewChild(MatSort, {static: false}) sort: MatSort;
  @ViewChild(MatPaginator, {static: false}) paginator: MatPaginator;

  displayedColumns: string[] = ['id', 'name', 'deadlineInDays', 'groupName', 'preparationDescription', 'cost', 'btn'];
  dataSource = new MatTableDataSource();
  auth = false;

  constructor(private _liveAnnouncer: LiveAnnouncer, private router: Router, private service: ResearchService, public dialog: MatDialog) {}

  ngOnInit(): void {
      this.auth = localStorage.getItem('auth') === 'true';
      this.service.list().subscribe(response => {
        this.dataSource = new MatTableDataSource(response);
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
      })
  }

  openDialog(data: string) {
    this.dialog.open(DialogDataExampleDialog, {
      data: data
    });
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
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

@Component({
  selector: 'dialog-data-example-dialog',
  templateUrl: 'dialog-data.html',
})
export class DialogDataExampleDialog {
  constructor(@Inject(MAT_DIALOG_DATA) public data: string) {}
}
