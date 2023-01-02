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
		}
	];
</script>

<h1>Søg på reservedel</h1>

<div id="container">
	<Grid {data} search={true} autoWidth={false} fixedHeader={false} resizable={true} />
</div>

<style lang="scss">
	@import '../scss/text.scss';

	#container {
		@media screen and (max-width: 800px) {
			margin: 0 5%;
		}
	}

	#result {
		display: flex;
		margin-bottom: 1rem;
		background-color: var(--background-dark);
		color: var(--text-light);
		border-color: var(--text);
		border-width: 3px;
		box-shadow: 0px 12px 13px -16px rgba(0, 0, 0, 0.5);
	}

	img {
		max-width: 10rem;
		margin-right: 1rem;
	}

	h3,
	p {
		margin: 0;
	}

	form {
		color: var(--text);
		width: 100%;
		height: 2.75em;
		border-radius: 2px;
		display: flex;
		flex-direction: row;
		align-items: center;
		background-color: var(--background-medium);
		border-bottom: 2px solid var(--text);
		margin: auto;
		margin-bottom: 4.5em;
	}

	input {
		all: unset;
		height: 100%;
		width: 100%;
		padding: 6px 10px;
	}

	button {
		all: unset;
		cursor: pointer;
		width: 44px;
		height: 44px;
		color: var(--text);
		font-weight: bold;
		padding-right: 1.2em;
	}

	::placeholder {
		opacity: 0.7;
	}
</style>
