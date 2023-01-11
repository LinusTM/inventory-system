<script>
	import { page } from '$app/stores';
	import Zbc from '../icons/Zbc.svelte';

	const navItems = [
			{ label: 'ADMIN', href: '/admin' },
			{ label: 'SØG', href: '/' }
		],
		education = 'Automekaniker';
</script>

<div class="box-shadow">
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
		@media screen and (max-width: 512px) {
			display: none;
		}
	}

	div {
		display: flex;
		height: 4rem;
		background-color: var(--background-medium);
		align-items: center;
		gap: 1rem;
		padding: 0 max(1rem, 4%);

		* {
			font-weight: bold;
			color: var(--text);
		}
	}

	a {
		text-decoration: none;
		transition: all 0.1s ease;
		font-size: 1.3rem;
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
		padding: 2px 8px 2px 0;
		border-right: 2.5px solid var(--text);
	}

	#img {
		border-bottom: none;
	}
</style>
