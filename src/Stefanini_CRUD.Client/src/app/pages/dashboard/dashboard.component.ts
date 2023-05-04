import { Component, ViewChild } from '@angular/core';
import { ApexAxisChartSeries, ApexChart, ApexTitleSubtitle, ApexXAxis, ChartComponent } from 'ng-apexcharts';

@Component({
	selector: 'app-dashboard',
	templateUrl: './dashboard.component.html',
	styleUrls: ['./dashboard.component.css']
})

export class DashboardComponent {

	@ViewChild("chart") chart: ChartComponent | undefined;
	public chartOptions: any;

	constructor() {
		
		this.chartOptions = {
			series: [
				{
					name: "Amount",
					data: [10, 41, 35, 51, 49, 62, 69, 91, 148]
				}
			],
			chart: {
				height: 350,
				type: "bar"
			},
			title: {
				text: "Anual Attendances"
			},
			xaxis: {
				categories: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep"]
			}
		};
	}
}

  
