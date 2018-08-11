import { Component, OnInit, Input } from '@angular/core';
import { Day } from '../model/day';

@Component({
  selector: 'app-calendar-day',
  templateUrl: './calendar-day.component.html',
  styleUrls: ['./calendar-day.component.css']
})
export class CalendarDayComponent implements OnInit {

  @Input() day: Day;

  constructor() { }

  ngOnInit() {
  }

}
