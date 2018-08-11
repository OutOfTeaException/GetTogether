import { Component, OnInit } from '@angular/core';
import { Day } from '../model/day';
import { Event } from '../model/event';

@Component({
  selector: 'app-calendar',
  templateUrl: './calendar.component.html',
  styleUrls: ['./calendar.component.css']
})
export class CalendarComponent implements OnInit {

  constructor() { }

  yearAndMonth: string = "August 2018";
  daysInWeek: string[] = ["Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag"];
  days: Day[] = [];

  ngOnInit() {
    this.buildMonth(8, 2018);
    this.days[7].addEvent(new Event("Wandern"));
    this.days[7].addEvent(new Event("Wandern 2"));
    this.days[7].addEvent(new Event("Wandern 3"));
    this.days[7].addEvent(new Event("Wandern 4 bla bla bla bla bla"));
  }

  private buildMonth(month: number, year: number): void {

    const daysDisplayed = 35;
    const daysInMonth = new Date(year, month, 0).getDate();
    const leadingDaysCount = this.getMondayStartDayIndex(new Date(year, month - 1, 1).getDay());
    const trailingDaysCount = 6 - this.getMondayStartDayIndex(new Date(year, month - 1, daysInMonth).getDay())

    this.days = new Array(daysDisplayed);

    for (let dayNumber = 1; dayNumber <= leadingDaysCount; dayNumber++) {
      let dayDate = new Date(year, month - 1, 1);
      dayDate.setDate(1 - dayNumber);
      let day = new Day(dayDate.getDate(), this.getDayNameByIndex(dayDate.getDay()), false);
      this.days[trailingDaysCount - dayNumber] = day;
    }

    for (let dayNumber = 1; dayNumber <= daysInMonth; dayNumber++) {
      let dayDate = new Date(year, month - 1, dayNumber);
      let day = new Day(dayNumber, this.getDayNameByIndex(dayDate.getDay()));
      this.days[dayNumber - 1 + leadingDaysCount] = day;
    }

    for (let dayNumber = 1; dayNumber <= trailingDaysCount; dayNumber++) {
      let dayDate = new Date(year, month - 1, daysInMonth);
      dayDate.setDate(dayDate.getDate() + dayNumber);
      let day = new Day(dayDate.getDate(), this.getDayNameByIndex(dayDate.getDay()), false);
      this.days[leadingDaysCount + daysInMonth + dayNumber - 1] = day;
    }
  }

  private getDayNameByIndex(dayIndex: number): string {

    return this.daysInWeek[this.getMondayStartDayIndex(dayIndex)];
  }

  private getMondayStartDayIndex(sundayStartDayIndex: number): number {
    let index = sundayStartDayIndex - 1;

    if (index === -1) {
      index = 6;
    }

    return index;
  }
}
