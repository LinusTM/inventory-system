<script lang="ts">
	import { Entry } from '$lib/ts/entry';
	import PopupComponent from '$lib/components/PopupComponent.svelte';
	import Grid from 'gridjs-svelte';
	import { SvelteWrapper } from 'gridjs-svelte/plugins';

	const data: any = Array.from({ length: 1000 }, () => new Entry()),
		className = {
			table: 'table',
			header: 'table-header',
			tbody: 'table-body',
			td: 'table-td',
			th: 'table-th',
			search: 'table-search',
		},
		columns = [
			{ name: 'FTZ', id: 'ftzNumber' },
			{ name: 'Navn', id: 'altName' },
			{ name: 'Beskrivelse', id: 'description' },
			{ name: 'Sektion', id: 'section' },
			{ name: 'Sektion navn', id: 'sectionName', hidden: true },
			{ name: 'Placerings noter', id: 'placementNotes', hidden: true },
			{ name: 'Mængde', id: 'amount' },
			{ name: 'Billede', id: 'picture', hidden: true },
			{
				name: 'Handlinger',
				data: (cell: any) => cell,
				plugin: {
					component: SvelteWrapper,
					props: {
						component: PopupComponent,
					},
				},
			},
		],
		pagination = { enabled: true, summary: false, limit: 50 },
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
	<h1>No data in database</h1>
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

		&:nth-child(odd) {
			background-color: var(--background-secondary);
			color: var(--text-dark);
		}

		&:hover {
			background-color: var(--background-quaternary);
			color: var(--text-secondary);
		}

		& > th {
			text-align: center;
		}
	}
</style>
