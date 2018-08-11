import { Injectable, Inject } from '@angular/core';
import { DateSearch } from '../model/date-search';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { Group } from '../model/group';

@Injectable()
export class AdminService {

  private dateSearches: DateSearch[] = [
    { 'id': 1, 'groupId': 1, 'name': 'Altes Land', 'description': 'Wir wollen zur Kirschblüte im alten Land eine Tagestour machen' },
    { 'id': 2, 'groupId': 1, 'name': 'Lüneburger Heide', 'description': 'Mal wieder zur Heideblüte :)' },
    { 'id': 3, 'groupId': 2, 'name': 'Deadpool 2', 'description': 'Böse. :) ' },
    { 'id': 4, 'groupId': 3, 'name': 'blablabla', 'description': 'jadda jadda jadda' }
  ];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getGroups(): Observable<Group[]> {
    return this.http.get<Group[]>(this.baseUrl + '/api/DateSearch/Groups/1');
  }

  getDateSearches(groupId: number) {
    return this.dateSearches.filter(d => d.groupId === groupId);
  }
}
