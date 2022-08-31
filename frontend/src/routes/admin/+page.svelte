<script lang="ts">
</script>

<h1>Tilføj ny reservedel</h1>

<div id="container">
	<div id="add_image">
		<button type="button">Tilføj billede</button>
	</div>

	<div id="names">
		<div id="ftz_number">
			<label for="ftz_number_input">FTZ nummer</label><br>
			<input type="text" id="ftz_number_input"><br>
		</div>

		<div id="alt_name">
			<label for="ftz_number_input">Alternativt navn</label><br>
			<input type="text" id="alt_name_input"><br>
		</div>
	</div>

	<div id="placement">
		<h4>Placering</h4>
		<div id="placement_box">
			<div id="section">
				<label for="section_input">Sektion</label><br>
				<input type="text" id="alt_name_input"><br><br>
			</div>

			<div id="name">
				<label for="name_input">Evt. sektion navn</label><br>
				<input type="text" id="alt_name_input"><br><br>
			</div>

			<div id="note">
				<label for="note_input">Note</label><br>
				<input type="text" id="note_input">
			</div>
		</div>
	</div>

	<div id="description">
		<label for="description_input">Beskrivelse</label><br>
		<input type="text" id="description_input"><br>
	</div>

	<div id="add_part">
		<label for="amount_input">Mængde</label><br>
		<input type="number" id="amount_input"><br>
		<button type="button">Tilføj</button>
	</div>
</div>


<style lang="scss">
	#container {
		display: grid;
		grid-template-columns: 30% 40% 30%;
		grid-template-areas:
			"add_image names placement"
			"description description placement"
			"add_part . .";
	}

	#add_image {
		grid-area: add_image;
	}

	#names {
		grid-area: names;
	}

	#placement {
		grid-area: placement;
	}

	#placement_box {
		border: 2px solid #000;
		padding: 1em;
	}

	#note_input {
		border: 2px solid #000;
		height: 8em;
		width: 98%;
	}

	#description {
		grid-area: description;
	}

	#description input {
		border: 2px solid #000;
		height: 10em;
		width: 33em;
	}

	#add_part {
		grid-area: add_part;
		display: flex;
	}

	h4 {
		margin-top: 0;
	}

	label {
		font-style: italic;
	}

	input {
		border: none;
		border-bottom: 2px solid #000;
	}

</style>

