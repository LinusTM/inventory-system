<script lang="ts">
	import { Entry } from '$lib/shared/ts/entry';
	import Grid from 'gridjs-svelte';
	import Modal from 'svelte-simple-modal';

	// Creates an array with a length of 1000, filled with random entries.
	// Currently used for testing purposes.
	const data: any = Array.from({ length: 1000 }, () => new Entry()),
		// We are assigning parts of the table to classes, so that we can modify the styling.
		className = {
			table: 'table',
			header: 'table-header',
			tbody: 'table-body',
			td: 'table-td',
			th: 'table-th',
			search: 'table-search',
		},
		// Choosing which columns are shown, what name they should have.
		columns = [
			{ name: 'FTZ', id: 'ftzNumber' },
			{ name: 'Navn', id: 'altName' },
			{ name: 'Beskrivelse', id: 'description' },
			{ name: 'Sektion', id: 'section' },
			{ name: 'Sektion navn', id: 'sectionName', hidden: true },
			{ name: 'Placerings noter', id: 'placementNotes', hidden: true },
			{ name: 'Mængde', id: 'amount' },
			{ name: 'Billede', id: 'picture', hidden: true },
		],
		// Enableing pagination, and setting entry limit per page to 50.
		pagination = { enabled: true, summary: false, limit: 50 },
		// Changing the default text to customized ones.
		language = {
			pagination: { next: '→', previous: '←' },
			search: { placeholder: 'Søg...' },
		};
</script>

<h1>Søg på reservedel</h1>

<!-- Defines the container div with the table in it -->
{#if data.length !== 0}
	<Grid
		{data}
		{columns}
		{className}
		{pagination}
		{language}
		search={true}
		autoWidth={true}
		sort={false}
	/>
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
		margin-block: 2rem;

		:global(input) {
			outline: none;
			border: none;
			font-size: 0.8rem;
			width: calc(400px + 35%);
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
