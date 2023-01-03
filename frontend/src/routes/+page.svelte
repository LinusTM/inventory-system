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
			this.ftzNumber = 'temp';
			this.altName = 'temp';
			this.description = 'temp';
			this.section = 'temp';
			this.sectionName = 'temp';
			this.placementNotes = 'temp';
			this.amount = 0;
			this.picture = 'temp';
		}
	}

	const randomEntry = () => {
		return {
			ftzNumber: faker.random.alpha(1) + faker.random.numeric(3),
			altName: faker.commerce.productAdjective() + faker.commerce.product(),
			description: faker.commerce.productName(),
			section: faker.random.alphaNumeric(2),
			sectionName: faker.random.words(2),
			placementNotes: faker.lorem.words(4),
			amount: Math.floor(Math.random() * 500),
			picture: faker.image.image(420, 420, true)
		};
	};

	const randomEntries = (amount = 5) => {
		return new Array(amount).fill(undefined).map(randomEntry);
	};

	const data = randomEntries(1000);

	const className = {
		table: 'table',
		header: 'table-header',
		tbody: 'table-body',
		td: 'table-td',
		th: 'table-th'
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
		border-radius: 12px;
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
