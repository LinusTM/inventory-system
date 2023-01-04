<script lang="ts">
	import Grid from 'gridjs-svelte';
	import { faker } from '@faker-js/faker';

	class Entry {
		ftzNumber: string;
		altName: string;
		description: string;
		section: string;
		sectionName: string;
		placementNotes: string;
		amount: number;
		picture: string;

		constructor() {
			this.ftzNumber = faker.random.alpha(1) + faker.random.numeric(3);
			this.altName = faker.commerce.productAdjective() + faker.commerce.product();
			this.description = faker.commerce.productName();
			this.section = faker.random.alphaNumeric(2);
			this.sectionName = faker.random.words(2);
			this.placementNotes = faker.lorem.words(4);
			this.amount = Math.floor(Math.random() * 500);
			this.picture = faker.image.image(420, 420, true);
		}
	}

	const data = new Array(1000).fill(undefined).map(() => new Entry());

	const className = {
		table: 'table',
		header: 'table-header',
		tbody: 'table-body',
		td: 'table-td',
		th: 'table-th',
		search: 'table-search'
	};

	const pagination = {
		enabled: true,
		limit: 50
	};
</script>

<h1>Søg på reservedel</h1>

<div id="container">
	<Grid {data} {className} {pagination} search={true} autoWidth={true} sort={false} />
</div>

<style lang="scss">
	@import '../scss/text.scss';

	:global(.table) {
		border: solid var(--background-dark) 2px;
		margin: 0;
		border-spacing: 0;
		border-radius: 12px;
		width: 100%;
	}

	:global(.table-td, .table-th) {
		padding: 2px;
		text-align: center;
	}

	:global(.table-body > tr) {
		background-color: var(--background-light);
		color: var(--text-dark);
		transition: background-color 0.1s ease;
		transition: color 0.1s linear;
	}

	:global(.table-body > tr:nth-child(odd)) {
		background-color: var(--background-medium);
		color: var(--text-dark);
	}

	:global(.table-body > tr:hover, .table-body > tr:nth-child(odd):hover) {
		background-color: var(--background-grayish);
		color: var(--text-light);
		transition: background-color 0.1s ease;
		transition: color 0.1s linear;
	}

	:global(.table-body > th) {
		text-align: center;
	}

	#container {
		overflow: auto;
	}
</style>
