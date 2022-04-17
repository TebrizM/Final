

$(function () {
    "use strict";

     // chart 1
	 
	var ctx = document.getElementById('chart1').getContext('2d');


		
		
			var myChart = new Chart(ctx, {
				type: 'line',
				data: {
					labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct"],
					datasets: [{
						label: 'New Visitor',
						data: [3, 3, 8, 5, 7, 4, 6, 4, 6, 3],
						backgroundColor: '#fff',
						borderColor: "transparent",
						pointRadius :"0",
						borderWidth: 3
					} ]
				},
			options: {
				maintainAspectRatio: false,
				legend: {
				  display: false,
				  labels: {
					fontColor: '#ddd',  
					boxWidth:40
				  }
				},
				tooltips: {
				  displayColors:false
				},	
			  scales: {
				  xAxes: [{
					ticks: {
						beginAtZero:true,
						fontColor: '#ddd'
					},
					gridLines: {
					  display: true ,
					  color: "rgba(221, 221, 221, 0.08)"
					},
				  }],
				   yAxes: [{
					ticks: {
						beginAtZero:true,
						fontColor: '#ddd'
					},
					gridLines: {
					  display: true ,
					  color: "rgba(221, 221, 221, 0.08)"
					},
				  }]
				 }

			 }
			});  
		
		
    // chart 2

	
		

		
		
   });	 
   