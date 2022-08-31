<script lang="ts">
	const items = [
		{
			label: 'dill',
			description:
				'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.',
			image: 'https://upload.wikimedia.org/wikipedia/commons/d/de/Anethum_graveolens_001.JPG'
		},
		{
			label: 'iceberg lettuce',
			description:
				'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.',
			image: 'https://upload.wikimedia.org/wikipedia/commons/d/da/Iceberg_lettuce_in_SB.jpg'
		},
		{
			label: 'lavender',
			description:
				'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.',
			image: 'https://upload.wikimedia.org/wikipedia/commons/7/7e/Single_lavender_flower02.jpg'
		},
		{
			label: 'dates',
			description:
				'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.',
			image:
				'https://upload.wikimedia.org/wikipedia/commons/3/38/Mazafati_dates_-_whole%2C_halved_and_seed.jpg'
		},
		{
			label: 'oats',
			description:
				'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.',
			image: 'https://upload.wikimedia.org/wikipedia/commons/6/6c/Avena_sativa_004.JPG'
		}
	];
</script>

<form id="form">
	<input type="search" id="query" name="q" placeholder="Query..." />
	<button>Search</button>
</form>

{#each items as item}
	<div id="result">
		<img src={item.image} alt={item.label} />
		<div>
			<h3>1350aaaaaaaa - {item.label}</h3>
			<p>{item.description}</p>
		</div>
	</div>
{/each}

<style lang="scss">
	#result {
		display: flex;
		margin-bottom: 1rem;
		background-color: var(--background-dark);
		color: var(--text-light);
		border-color: var(--text);
		border-width: 3px;
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
		color: var(--text-light);
		width: 30em;
		height: 44px;
		border-radius: 5px;
		display: flex;
		flex-direction: row;
		align-items: center;
		margin-bottom: 1rem;
		background-color: var(--background-dark);
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
		color: var(--text-light);
		padding-right: 1.2em;
	}

	::placeholder {
		opacity: 0.7;
	}
</style>
