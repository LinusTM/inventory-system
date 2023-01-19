<script lang="ts">
	import type { Entry } from '$lib/ts/entry';

	export let data: Entry;
</script>

<h2>
	FTZ nummer: <span>{data.ftzNumber}</span>
</h2>

<div id="container">
	<div>
		<p>altName: {data.altName}</p>
		<p>altName: {data.altName}</p>
		<p>description: {data.description}</p>
		<p>section: {data.section}</p>
	</div>
	<div>
		<p>sectionName: {data.sectionName}</p>
		<p>placementNotes: {data.placementNotes}</p>
		<p>amount: {data.amount}</p>
		<p>picture: {data.picture}</p>
	</div>
</div>

<style lang="scss">
	span {
		text-decoration: underline;
	}

	#container {
		grid-template-columns: 2, 1fr;
		display: grid;
		justify-items: left;
		justify-content: stretch;
		font-size: 1.05rem;
		gap: 1rem;
		height: calc(200px + 30vh);

		div {
			display: inline-flex;
			flex-direction: column;
			align-content: flex-start;
			overflow: hidden;
		}
	}
</style>
