import { Component } from '@angular/core';

@Component({
	selector: 'app-budget',
	templateUrl: './budget.component.html',
	styleUrls: ['./budget.component.css']
})

export class BudgetComponent {

	displayedColumns: string[] = ['budgetNumber', 'clientName', 'value', 'approved'];
	dataSource = ELEMENT_DATA;
	clickedRows = new Set<BudgetDataList>();
}

export interface BudgetDataList {
	budgetNumber: number;
	clientName: string;
	value: number;
	approved: boolean;
}

const ELEMENT_DATA: BudgetDataList[] = [
	{ budgetNumber: 58522,  clientName: 'Marcus', 	value: 1.0079,  approved: true	},
	{ budgetNumber: 52573,  clientName: 'Aline', 		value: 4.0026,  approved: false 	},
	{ budgetNumber: 19620,  clientName: 'PotatoWoman', 		value: 6.941, 	approved: true 	},
	{ budgetNumber: 69185,  clientName: 'Juan',	value: 9.0122,  approved: false 	},
	{ budgetNumber: 2876,  	clientName: 'Nyck', 		value: 10.811,  approved: true	},
	{ budgetNumber: 50845,  clientName: 'Sarah', 		value: 12.0107, approved: true	},
	{ budgetNumber: 59911,  clientName: 'PotatoMan', 	value: 14.0067, approved: false	},
	{ budgetNumber: 65432,  clientName: 'Heisenberg', 		value: 15.9994, approved: true	},
	{ budgetNumber: 99454,  clientName: 'Jackie Boy', 	value: 18.9984, approved: true	},
	{ budgetNumber: 12356, 	clientName: 'Tig', 		value: 20.1797, approved: false },
];

