import { Component, group, OnInit } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AdminService } from '../service/admin.service';
import { Group } from '../model/group';
import { DateSearch } from '../model/date-search';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {

  constructor(private adminService: AdminService) {
  }

  groups: Group[] = [];
  dateSearches: DateSearch[] = [];

  selectedGroup: Group = null;
  selectedDateSearch: DateSearch = null;


  ngOnInit() {
    this.adminService.getGroups().subscribe(data => { this.groups = data; });
  }


  GroupChanged(selectedGroup: Group) {
    this.selectedGroup = selectedGroup;
    console.log('Gruppe ausgewählt: ' + selectedGroup.name);
    this.dateSearches = this.adminService.getDateSearches(selectedGroup.id);
    this.selectedDateSearch = null;
  }

  DateSearchChanged(selectedDateSearch: DateSearch) {
    this.selectedDateSearch = selectedDateSearch;
  }

  private DisplayMonth(year: number, month: number) {

  }
}
