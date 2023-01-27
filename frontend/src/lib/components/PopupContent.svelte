<script lang="ts">
	import type { Entry } from '$lib/ts/entry';

	export let data: Entry;
</script>

<h2>
	FTZ nummer: <span>{data.ftzNumber}</span>
</h2>

<div>
	<label for="altName">altName: <input id="altName" placeholder={data.altName} /></label>
	<label for="altName">altName: <input id="altName" placeholder={data.altName} /></label>
	<label for="description"
		>description: <input id="description" placeholder={data.description} /></label
	>
	<label for="section">section: <input id="section" placeholder={data.section} /></label>
	<label for="sectionName"
		>sectionName: <input id="sectionName" placeholder={data.sectionName} /></label
	>
	<label for="placementNotes"
		>placementNotes: <input id="placementNotes" placeholder={data.placementNotes} /></label
	>
	<label>amount: <input placeholder={data.amount.toString()} /></label>
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

	label,
	input {
		display: block;
	}
</style>
