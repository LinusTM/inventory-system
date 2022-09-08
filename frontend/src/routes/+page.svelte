<script lang="ts">
	const items = [
		{
			label: 'dill',
			id: 'aaa1350',
			description:
				'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.',
			image: 'https://upload.wikimedia.org/wikipedia/commons/d/de/Anethum_graveolens_001.JPG'
		},
		{
			label: 'iceberg lettuce',
			id: 'g177013',
			description:
				'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.',
			image: 'https://upload.wikimedia.org/wikipedia/commons/d/da/Iceberg_lettuce_in_SB.jpg'
		},
		{
			label: 'lavender',
			id: '',
			description:
				'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.',
			image: 'https://upload.wikimedia.org/wikipedia/commons/7/7e/Single_lavender_flower02.jpg'
		},
		{
			label: 'dates',
			id: '',
			description:
				'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.',
			image:
				'https://upload.wikimedia.org/wikipedia/commons/3/38/Mazafati_dates_-_whole%2C_halved_and_seed.jpg'
		},
		{
			label: 'oats',
			id: '',
			description:
				'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.',
			image: 'https://upload.wikimedia.org/wikipedia/commons/6/6c/Avena_sativa_004.JPG'
		}
	];
</script>

<h1>Søg på reservedel</h1>

<form id="form">
	<input type="search" id="query" name="q" placeholder="FTZ nummer eller lign." />
	<button>Søg</button>
</form>

<div id="container">
	{#each items as item}
		<div id="result">
			<img src={item.image} alt={item.label} />
			<div>
				<h3>{item.id} - {item.label}</h3>
				<p>{item.description}</p>
			</div>
		</div>
	{/each}
</div>

<style lang="scss">
	@import '../scss/text.scss';

	#container {
		@media screen and (max-width: 800px) {
			margin: 0 5%;
		}
	}

	#result {
		display: flex;
		margin-bottom: 1rem;
		background-color: var(--background-dark);
		color: var(--text-light);
		border-color: var(--text);
		border-width: 3px;
		box-shadow: 0px 12px 13px -16px rgba(0, 0, 0, 0.5);
	}

	img {
		max-width: 10rem;
		margin-right: 1rem;
	}

	h3,
	p {
		margin: 0;
	}

	form {
		color: var(--text);
		width: 100%;
		height: 2.75em;
		border-radius: 2px;
		display: flex;
		flex-direction: row;
		align-items: center;
		background-color: var(--background-medium);
		border-bottom: 2px solid var(--text);
		margin: auto;
		margin-bottom: 4.5em;
	}

	input {
		all: unset;
		height: 100%;
		width: 100%;
		padding: 6px 10px;
	}

	button {
		all: unset;
		cursor: pointer;
		width: 44px;
		height: 44px;
		color: var(--text);
		font-weight: bold;
		padding-right: 1.2em;
	}

	::placeholder {
		opacity: 0.7;
	}
</style>
