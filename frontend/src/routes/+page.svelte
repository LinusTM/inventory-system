<script lang="ts">
	import Grid from 'gridjs-svelte';
	import Modal from 'svelte-simple-modal';
	import { faker } from '@faker-js/faker';

	// Defines the "Entry" class, so that we can easily couple the data together
	class Entry {
		ftzNumber: string;
		altName: string;
		description: string;
		section: string;
		sectionName: string;
		placementNotes: string;
		amount: number;
		picture: string;

		// The constructor will generate random values if no parameters are given.
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

	// Creates an array with a length of 1000, filled with random data.
	// Currently used for testing purposes.
	const data: any = Array.from({ length: 1000 }, () => new Entry());

	// We are assigning parts of the table to classes, so that we can modify the styling.
	const className = {
		table: 'table',
		header: 'table-header',
		tbody: 'table-body',
		td: 'table-td',
		th: 'table-th',
		search: 'table-search'
	};

	const columns = [
		{
			name: 'FTZ',
			id: 'ftzNumber'
		},
		{
			name: 'Navn',
			id: 'altName'
		},
		{
			name: 'Beskrivelse',
			id: 'description'
		},
		{
			name: 'Sektion',
			id: 'section'
		},
		{
			name: 'Sektion navn',
			id: 'sectionName',
			hidden: true
		},
		{
			name: 'Placerings noter',
			id: 'placementNotes',
			hidden: true
		},
		{
			name: 'Mængde',
			id: 'amount'
		},
		{
			name: 'Billede',
			id: 'picture',
			hidden: true
		}
	];

	// Enableing pagination, and setting entry limit per page to 50.
	const pagination = {
		enabled: true,
		limit: 50
	};
</script>

<h1>Søg på reservedel</h1>

<!-- Defines the container div with the table in it -->
{#if data.length != 0}
	<Grid {data} {columns} {className} {pagination} search={true} autoWidth={true} sort={false} />
{:else}
	<h1 class="header">No data in database</h1>
{/if}

<style lang="scss">
	/* A lot of stuff is selected using the ":global()" modifier,
		 as it is required in order to select elements inside of the gridjs table.*/

	/* TABLE */
	:global(.table) {
		border: solid var(--background-quaternary) 2px;
		margin: 0;
		border-spacing: 0;
		border-radius: 12px;
		width: 100%;
		overflow: hidden;
		box-shadow: var(--box-shadow);
	}

	:global(.table-search) {
		display: flex;
		align-items: center;
		justify-content: center;
		margin: 2rem 1rem;

		:global(input) {
			outline: none;
			border: none;
			font-size: 0.8rem;
			width: min(400px + 40%, 100%);
			border-radius: 6px;
			color: var(--text-primary);
			background-color: var(--background-secondary);
			border: solid var(--background-quaternary) 2px;
			height: 2rem;
			box-shadow: var(--box-shadow);
		}
	}

	:global(.table-td) {
		font-size: 0.8rem;
	}

	:global(.table-th) {
		font-size: 0.9rem;
	}

	:global(.table-td, .table-th) {
		padding: 2px;
		text-align: center;
	}

	:global(.table-body > tr) {
		background-color: var(--background-light);
		color: var(--text-dark);
		transition: background-color 0.1s ease, color 0.1s linear;
	}

	:global(.table-body > tr:nth-child(odd)) {
		background-color: var(--background-secondary);
		color: var(--text-dark);
	}

	:global(.table-body > tr:hover) {
		background-color: var(--background-quaternary);
		color: var(--text-secondary);
	}

	:global(.table-body > th) {
		text-align: center;
	}
</style>
