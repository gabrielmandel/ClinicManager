import { Component } from '@angular/core';

// import { navItems } from './_nav';

@Component({
	selector: 'app-dashboard',
	templateUrl: './layout.component.html',
	styleUrls: ['./layout.component.css'],
})
export class LayoutComponent {

	public navItems: any[] = [
		{
			path: 'dashboard',
			name: 'Dashboard'
		},
		{
			path: 'schedule',
			name: 'Schedule'
		},
		{
			path: 'budget',
			name: 'Budget'
		},

	];

	constructor() { }


}
