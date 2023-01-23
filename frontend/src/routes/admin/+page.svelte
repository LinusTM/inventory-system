<script lang="ts">
	let files: any;
</script>

<h1>Tilføj ny reservedel</h1>

<div id="container">
	<div>
		<h2>Beskrivelse</h2>
		<label for="ftz-number-input">FTZ nummer</label>
		<input type="text" id="ftz-number-input" />
		<label for="alt-name-input">Alternativt navn</label>
		<input type="text" id="alt-name-input" />
		<label for="description-input">Beskrivelse af reservedel</label>
		<textarea id="description-input" />
		<label for="image-selector">Tilføj billede</label>
		<input type="file" accept="image/*" id="image-selector" bind:files hidden />
		{#if files && files[0]}
			<p>
				{#if files[0].size > 3145728}
					File is too big. (Must be smaller than 3mb)
				{:else}
					{files[0].name.replace(/(.{12})..+/, '$1…')}
				{/if}
			</p>
		{/if}
		<button type="button">Tilføj reservedel til inventar</button>
	</div>

	<div>
		<h2>Placering</h2>
		<label for="section-input">Sektion</label>
		<input type="text" id="section-input" />
		<label for="section-name">Evt. sektion navn</label>
		<input type="text" id="section-name" />
		<label for="note-input">Note til placering</label>
		<textarea id="note-input" />
		<label for="amount-input">Mængde</label>
		<input type="number" id="amount-input" min="0" />
	</div>
</div>

<style lang="scss">
	#container {
		display: grid;
		grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
		margin-left: calc(50px + 15%);
		row-gap: 2rem;

		div {
			display: flex;
			flex-direction: column;
			align-items: flex-start;
		}
	}

	:not(h2) {
		font-size: 1.1rem;
	}

	:not(label),
	label[for='image-selector'] {
		margin-bottom: 1.5rem;
	}

	input {
		box-shadow: var(--box-shadow);
		color: var(--text-primary);
		border: 2px solid var(--background-quaternary);
		border-radius: 8px;
		height: 2rem;
		width: 9rem;
		background-color: var(--background-secondary);
		transition: background-color 0.2s ease, color 0.2s linear;

		&:hover,
		&:focus {
			outline: none;
			background-color: var(--background-quaternary);
			color: var(--text-secondary);
		}
	}

	button {
		box-shadow: var(--box-shadow);
		background-color: var(--background-secondary);
		color: var(--text-primary);
		transition: background-color 0.2s ease, color 0.2s linear;
		border: 2px solid var(--accent-tertiary);
		border-radius: 10px;
		font-weight: bold;
		cursor: pointer;
		padding: 1rem;

		&:hover {
			background-color: var(--accent-tertiary);
			color: var(--accent-text);
		}
	}

	label[for='image-selector'] {
		@extend button;
		padding-block: 0.65rem;
		border: 2px solid var(--background-quaternary);

		&:hover {
			background-color: var(--background-quaternary);
			color: var(--text-secondary);
		}
	}

	textarea {
		@extend input;
		resize: none;
		width: 16.5rem;
		height: 8rem;
	}
</style>
