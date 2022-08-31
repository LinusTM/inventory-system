<script type="ts">
	import { page } from '$app/stores';
	const navItems = [
		{ label: 'ADMIN', href: '/admin' },
		{ label: 'SØG', href: '/' }
	];

	var education = 'Automekaniker';
</script>

<div>
	<a id="img" href="/"><img src="./images/logo.png" alt="ZBC logo" /></a>
	<p>{education}</p>
	<span />
	{#each navItems as navItem}
		{#if $page.url.pathname == navItem.href}
			<a id="selected" href={navItem.href}>{navItem.label}</a>
		{:else}
			<a href={navItem.href}>{navItem.label}</a>
		{/if}
	{/each}
</div>

<style lang="scss">
	div {
		display: flex;
		flex-direction: row;
		position: sticky;
		width: 100%;
		height: 4rem;
		color: var(--text-light);
		background-color: var(--background-dark);
		font-size: 16px;
		align-items: center;
		box-shadow: 0 1px 2px hsla(0, 0%, 0%, 0.05), 0 1px 4px hsla(0, 0%, 0%, 0.05),
			0 2px 8px hsla(0, 0%, 0%, 0.05);

		* {
			margin-right: 1em;
			margin-left: 0.5em;
		}
	}

	a {
		text-decoration: none;
		transition: all 0.1s ease;
		font-size: 1.3rem;
		font-weight: 600;
	}

	a:hover {
		border-bottom-width: 2px;
	}

	#selected {
		border-bottom-style: solid;
		border-bottom-width: 2px;
	}

	span {
		flex: 1 1 auto;
	}

	img {
		max-height: 2.3em;
		margin-top: 4.5%;
		padding-right: 2px;
		border-right: 2.5px solid #fff;
		margin-right: 0;
	}

	#img {
		border-bottom: none;
	}

	p {
		margin-left: 0;
		font-weight: bold;
	}
</style>
