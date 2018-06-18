import { Injectable, group } from '@angular/core';
import { Group } from '../model/group';
import { DateSearch } from '../model/date-search';

@Injectable()
export class AdminService {

  private groups: Group[] = [
    { "id": 1, "name": "Die SpazierGang" },
    { "id": 2, "name": "Kino" },
    { "id": 3, "name": "Bla" }
  ];

  private dateSearches: DateSearch[] = [
    { "id": 1, "groupId": 1, "name": "Altes Land", "description": "Wir wollen zur Kirschblüte im alten Land eine Tagestour machen" },
    { "id": 2, "groupId": 1, "name": "Lüneburger Heide", "description": "Mal wieder zur Heideblüte :)" },
    { "id": 3, "groupId": 2, "name": "Deadpool 2", "description": "Böse. :) " },
    { "id": 4, "groupId": 3, "name": "blablabla", "description": "jadda jadda jadda" }
  ];

  constructor() { }

  getGroups(): Group[] {
    return this.groups;
  }

  getDateSearches(groupId: number) {
    return this.dateSearches.filter(d => d.groupId === groupId);
  }
}
