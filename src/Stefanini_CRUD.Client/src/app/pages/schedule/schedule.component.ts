import { Component } from '@angular/core';
import { CalendarView, CalendarEvent, CalendarEventTimesChangedEvent } from 'angular-calendar';
import { Subject } from 'rxjs';

@Component({
	selector: 'app-schedule',
	templateUrl: './schedule.component.html',
	styleUrls: ['./schedule.component.css']
})
export class ScheduleComponent {
	view: CalendarView = CalendarView.Week;

	viewDate = new Date();

	events: CalendarEvent[] = [
		{
			title: 'Draggable event',
			start: new Date(),
			draggable: true,
		},
		{
			title: 'A non draggable event',
			start: new Date(),
		},
	];

	refresh = new Subject<void>();

	eventTimesChanged({
		event,
		newStart,
		newEnd,
	}: CalendarEventTimesChangedEvent): void {
		event.start = newStart;
		event.end = newEnd;
		this.refresh.next();
	}
}
