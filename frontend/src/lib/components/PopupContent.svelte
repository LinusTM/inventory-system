<script lang="ts">
	import type { Entry } from '$lib/ts/entry';

	export let data: Entry;
</script>

<h2>
	FTZ nummer: <span>{data.ftzNumber}</span>
</h2>

<div>
	<p>altName: <b>{data.altName}</b></p>
	<p>altName: <b>{data.altName}</b></p>
	<p>description: <b>{data.description}</b></p>
	<p>section: <b>{data.section}</b></p>
	<p>sectionName: <b>{data.sectionName}</b></p>
	<p>placementNotes: <b>{data.placementNotes}</b></p>
	<p>amount: <b>{data.amount}</b></p>
	<img src={data.picture} alt={data.picture} />
</div>

<style lang="scss">
	span {
		text-decoration: underline;
	}

	div {
		grid-template-columns: 1fr 1fr;
		display: grid;
		justify-items: left;
		justify-content: stretch;
		font-size: 1.05rem;
		gap: 1rem;
		margin-inline: 2em;
		height: calc(200px + 30vh);
		padding-bottom: 2rem;
	}

	img {
		box-shadow: var(--box-shadow);
	}
</style>
