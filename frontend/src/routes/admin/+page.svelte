<script lang="ts">
	let files: any;
</script>

<h1>Tilføj ny reservedel</h1>

<div id="container">
	<div>
		<h2>Beskrivelse</h2>
		<label for="ftz-number-input">FTZ nummer</label>
		<input type="text" id="ftz-number-input" />
		<label for="ftz-number-input">Alternativt navn</label>
		<input type="text" id="alt-name-input" />
		<label for="description-input">Beskrivelse af reservedel</label>
		<textarea id="description-input" />
		<label for="chosen-image">Tilføj billede</label>
		<div id="image-select">
			<input type="file" id="chosen-image" bind:files hidden />
			{#if files && files[0]}
				{files[0].name.replace(/(.{12})..+/, '$1…')}
			{/if}
		</div>
		<button type="button">Tilføj reservedel til inventar</button>
	</div>

	<div>
		<h2>Placering</h2>
		<label for="section-input">Sektion</label>
		<input type="text" id="alt-name-input" />
		<label for="name-input">Evt. sektion navn</label>
		<input type="text" id="alt-name-input" />
		<label for="note-input">Note til placering</label>
		<textarea id="description-input" />
		<label for="amount-input">Mængde</label>
		<input type="number" id="amount-input" min="0" />
	</div>
</div>

<style lang="scss">
	#container {
		display: grid;
		grid-template-columns: repeat(auto-fit, minmax(350px, 1fr));
		margin-left: min(300px + 10%, 20%);
		column-gap: 10%;

		div {
			display: flex;
			flex-direction: column;
			align-items: flex-start;

			:not(h2) {
				font-size: 1.1rem;
			}
		}
	}

	:not(label),
	label[for='chosen-image'] {
		margin-bottom: 1.5rem;
	}

	input {
		color: var(--text-primary);
		border: none;
		height: 2rem;
		width: 9rem;
		background-color: var(--background-secondary);
		border-bottom: 2px solid var(--text-primary);
	}

	label[for='chosen-image'],
	button {
		background-color: var(--background-secondary);
		color: var(--text-primary);
		transition: background-color 0.1s ease, color 0.1s linear;
		border: none;
		font-style: italic;
		font-weight: bold;
		cursor: pointer;
		padding: 1rem;

		&:hover {
			background-color: var(--background-tertiary);
			color: var(--text-secondary);
		}
	}

	label[for='chosen-image'] {
		padding: 0.65rem 1rem;
	}

	textarea {
		border: none;
		background-color: var(--background-secondary);
		border-bottom: 2px solid var(--text-primary);
		resize: none;
		width: 16.5rem;
		height: 8rem;
		color: var(--text-primary);
	}
</style>
