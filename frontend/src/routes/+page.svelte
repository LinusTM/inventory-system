<script lang="ts">
	import Grid from 'gridjs-svelte';

	const data = [
		{
			ftzNumber: 'FTZ-5678',
			altName: 'Engine Oil',
			description: 'High-quality engine oil for improved performance.',
			section: 'B2',
			sectionName: 'Vehicle Fluids',
			placementNotes: 'Located on shelf 2, in the back corner of the room.',
			amount: 10,
			picture: 'base-64 encoded image string'
		},
		{
			ftzNumber: 'FTZ-9101',
			altName: 'Tire Pressure Gauge',
			description: 'Digital tire pressure gauge with LCD display.',
			section: 'C3',
			sectionName: 'Tire Tools',
			placementNotes: 'Located on shelf 3, next to the air compressor.',
			amount: 3
		},
		{
			ftzNumber: 'FTZ-1234',
			altName: 'Spare Part',
			description: 'A spare part for use in repair.',
			section: 'A1',
			sectionName: 'Spare Parts',
			placementNotes: 'Located on shelf 1, next to the blue tools.',
			amount: 5,
			picture: 'base-64 encoded image string'
		},
		{
			ftzNumber: 'FTZ-5678',
			altName: 'Engine Oil',
			description: 'High-quality engine oil for improved performance.',
			section: 'B2',
			sectionName: 'Vehicle Fluids',
			placementNotes: 'Located on shelf 2, in the back corner of the room.',
			amount: 10,
			picture: 'base-64 encoded image string'
		},
		{
			ftzNumber: 'FTZ-9101',
			altName: 'Tire Pressure Gauge',
			description: 'Digital tire pressure gauge with LCD display.',
			section: 'C3',
			sectionName: 'Tire Tools',
			placementNotes: 'Located on shelf 3, next to the air compressor.',
			amount: 3
		},
		{
			ftzNumber: 'FTZ-1234',
			altName: 'Spare Part',
			description: 'A spare part for use in repair.',
			section: 'A1',
			sectionName: 'Spare Parts',
			placementNotes: 'Located on shelf 1, next to the blue tools.',
			amount: 5,
			picture: 'base-64 encoded image string'
		},
		{
			ftzNumber: 'FTZ-5678',
			altName: 'Engine Oil',
			description: 'High-quality engine oil for improved performance.',
			section: 'B2',
			sectionName: 'Vehicle Fluids',
			placementNotes: 'Located on shelf 2, in the back corner of the room.',
			amount: 10,
			picture: 'base-64 encoded image string'
		},
		{
			ftzNumber: 'FTZ-9101',
			altName: 'Tire Pressure Gauge',
			description: 'Digital tire pressure gauge with LCD display.',
			section: 'C3',
			sectionName: 'Tire Tools',
			placementNotes: 'Located on shelf 3, next to the air compressor.',
			amount: 3
		},
		{
			ftzNumber: 'FTZ-1234',
			altName: 'Spare Part',
			description: 'A spare part for use in repair.',
			section: 'A1',
			sectionName: 'Spare Parts',
			placementNotes: 'Located on shelf 1, next to the blue tools.',
			amount: 5,
			picture: 'base-64 encoded image string'
		},
		{
			ftzNumber: 'FTZ-5678',
			altName: 'Engine Oil',
			description: 'High-quality engine oil for improved performance.',
			section: 'B2',
			sectionName: 'Vehicle Fluids',
			placementNotes: 'Located on shelf 2, in the back corner of the room.',
			amount: 10,
			picture: 'base-64 encoded image string'
		},
		{
			ftzNumber: 'FTZ-9101',
			altName: 'Tire Pressure Gauge',
			description: 'Digital tire pressure gauge with LCD display.',
			section: 'C3',
			sectionName: 'Tire Tools',
			placementNotes: 'Located on shelf 3, next to the air compressor.',
			amount: 3
		},
		{
			ftzNumber: 'FTZ-1234',
			altName: 'Spare Part',
			description: 'A spare part for use in repair.',
			section: 'A1',
			sectionName: 'Spare Parts',
			placementNotes: 'Located on shelf 1, next to the blue tools.',
			amount: 5,
			picture: 'base-64 encoded image string'
		}
	];

	const className = {
		table: 'table',
		header: 'table-header',
		tbody: 'table-body',
		td: 'table-td',
		th: 'table-th'
	};
</script>

<h1>Søg på reservedel</h1>

<div id="container">
	<Grid {data} {className} search={true} autoWidth={true} sort={false} />
</div>

<style lang="scss">
	@import '../scss/text.scss';

	:global(.table) {
		border: solid var(--background-dark);
		border-radius: 20px;
		margin: 0;
	}

	:global(.table-td, .table-th) {
		padding: 0;
	}

	:global(.table-body > tr) {
		background-color: var(--background-light);
		color: var(--text-dark);
		transition: background-color 0.2s linear;
		transition: color 0.3 linear;
	}

	:global(.table-body > tr:nth-child(odd)) {
		background-color: var(--background-medium);
		color: var(--text-dark);
	}

	:global(.table-body > tr:hover, .table-body > tr:nth-child(odd):hover) {
		background-color: var(--background-grayish);
		color: var(--text-light);
		transition: background-color 0.3s ease;
		transition: color 0.3s linear;
	}

	:global(.table-body > th) {
		text-align: center;
	}

	#container {
		@media screen and (max-width: 800px) {
			margin: 0 5%;
		}
	}
</style>
