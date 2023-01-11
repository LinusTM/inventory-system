<script lang="ts">
	let files: any;
</script>

<h1>Tilføj ny reservedel</h1>

<div id="container">
	<div id="names">
		<h2>Beskrivelse</h2>
		<div id="ftz_number">
			<label for="ftz_number_input">FTZ nummer</label><br />
			<input type="text" id="ftz_number_input" />
		</div>

		<div id="alt_name">
			<label for="ftz_number_input">Alternativt navn</label><br />
			<input type="text" id="alt_name_input" />
		</div>

		<div id="description">
			<label for="description_input">Beskrivelse af reservedel</label><br />
			<textarea id="description_input" />
		</div>

		<div id="add_part">
			<div id="image_select">
				<input type="file" name="chosen_image" id="chosen_image" bind:files hidden />
				<label for="chosen_image">Tilføj billede</label>
				{#if files && files[0]}
					{files[0].name.replace(/(.{12})..+/, '$1…')}
				{/if}
			</div>
		</div>

		<button type="button">Tilføj reservedel til inventar</button>
	</div>

	<div id="placement">
		<h2>Placering</h2>
		<div id="placement_box">
			<div id="section">
				<label for="section_input">Sektion</label><br />
				<input type="text" id="alt_name_input" />
			</div>

			<div id="name">
				<label for="name_input">Evt. sektion navn</label><br />
				<input type="text" id="alt_name_input" />
			</div>

			<div id="note">
				<label for="note_input">Note til placering</label><br />
				<textarea id="description_input" />
			</div>

			<div id="amount">
				<label for="amount_input">Mængde</label><br />
				<input type="number" id="amount_input" min="0" /><br />
			</div>
		</div>
	</div>
</div>

<style lang="scss">
	#container {
		display: grid;
	}

	@media screen and (max-width: 796px) {
		#container {
			grid-template-areas:
				'placement'
				'names';
		}

		#container > div {
			margin: 0 Min(25%, 20% + 100px);
		}

		#names h2 {
			padding-top: 3rem;
		}
	}

	@media screen and (min-width: 797px) {
		#container {
			grid-template-areas: 'names placement';
		}

		#placement {
			margin-left: 8rem;
		}

		#names {
			justify-self: end;
			width: Min(98%, 25% + 200px);
		}
	}

	#image_select label {
		padding: 0.5rem;
		font-weight: 600;
		border-radius: 2px;
		cursor: pointer;
		padding: 1rem;
	}

	#image_select label,
	button {
		background-color: var(--background-secondary);
		color: var(--text-primary);
		transition: background-color 0.1s ease, color 0.1s linear;
	}

	#image_select label:hover,
	button:hover {
		background-color: var(--background-tertiary);
		color: var(--text-secondary);
	}

	#names {
		grid-area: names;
	}

	#description {
		margin-bottom: 1.8em;
	}

	#add_part {
		display: flex;

		input {
			margin-left: 2em;
			height: 50px;
			width: 100px;
			font-size: 1rem;
		}
	}

	h2 {
		font-style: italic;
	}

	label {
		font-style: italic;
	}

	input {
		color: var(--text-primary);
		font-size: 1rem;
		border: none;
		height: 2rem;
		width: 9rem;
		background-color: var(--background-secondary);
		border-bottom: 2px solid var(--text-primary);
		appearance: textfield;
		margin-bottom: 2em;
	}

	button {
		border: none;
		border-radius: 2px;
		font-style: italic;
		font-weight: 600;
		font-size: 1em;
		margin-top: 2em;
		padding: 1rem;
	}

	textarea {
		border: none;
		background-color: var(--background-secondary);
		border-bottom: 2px solid var(--text-primary);
		resize: none;
		width: 16.5rem;
		height: 8rem;
		color: var(--text-primary);
		font-size: 1rem;
	}

	button:hover {
		cursor: pointer;
	}
</style>
