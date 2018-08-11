import { Event } from '../model/event';

export class Day {

  events: Event[] = [];

  constructor(public numberInMonth: number, public name: string, public enabled: boolean = true ) {
  }

  addEvent(event: Event) {
    this.events.push(event);
  }
}
