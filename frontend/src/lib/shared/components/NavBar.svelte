<script>
	import { page } from '$app/stores';
	import Zbc from '../icons/Zbc.svelte';

	const navItems = [
			{ label: 'ADMIN', href: '/admin' },
			{ label: 'SØG', href: '/' }
		],
		education = 'Automekaniker';
</script>

<div>
	<a id="img" href="/"><Zbc /></a>
	<p id="education">{education}</p>
	<span />

	<!-- looping throug the navItems object, and putting them all in the navbar -->
	{#each navItems as navItem}
		{#if $page.url.pathname == navItem.href}
			<a id="selected" href={navItem.href}>{navItem.label}</a>
		{:else}
			<a href={navItem.href}>{navItem.label}</a>
		{/if}
	{/each}
</div>

<style lang="scss">
	#education {
		@media screen and (max-width: 796px) {
			display: none;
		}
	}

	div {
		display: flex;
		height: 4rem;

		color: var(--text);
		background-color: var(--background-medium);

		font-size: 1.05rem;
		align-items: center;
		box-shadow: 0 1px 2px hsla(0, 0%, 0%, 0.05), 0 1px 4px hsla(0, 0%, 0%, 0.05),
			0 2px 8px hsla(0, 0%, 0%, 0.05);

		* {
			margin-right: 1.5em;
			margin-left: 0.5em;
		}
	}

	a {
		text-decoration: none;
		transition: all 0.1s ease;
		font-size: 1.3rem;
		font-weight: 600;

		color: var(--text);
	}

	a:hover,
	#selected {
		border-bottom-width: 2px;
		border-bottom-style: solid;
	}

	span {
		flex: 1 1 auto;
	}

	#img {
		padding: 2px 8px;
		border-right: 2.5px solid var(--text);
	}

	#img {
		border-bottom: none;
	}

	p {
		margin-left: 0;
		font-weight: bold;
	}
</style>
