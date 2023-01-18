<script>
	import { page } from '$app/stores';
	import Zbc from '$lib/icons/Zbc.svelte';

	const navItems = [
			{ label: 'ADMIN', href: '/admin' },
			{ label: 'SØG', href: '/' },
		],
		education = 'Automekaniker';
</script>

<header>
	<a href="/"><Zbc /></a>
	<p>{education}</p>
	<span />

	<!-- looping throug the navItems object, and putting them all in the navbar -->
	{#each navItems as navItem}
		{#if $page.url.pathname == navItem.href}
			<a id="selected" href={navItem.href}>{navItem.label}</a>
		{:else}
			<a href={navItem.href}>{navItem.label}</a>
		{/if}
	{/each}
</header>

<style lang="scss">
	header {
		position: sticky;
		top: 0;
		display: flex;
		height: 4rem;
		background-color: var(--background-secondary);
		align-items: center;
		gap: 1rem;
		padding-inline: max(3% + 0.5rem, 1rem);
		box-shadow: var(--box-shadow);

		* {
			font-weight: bold;
			color: var(--text-primary);
		}

		a:first-child {
			padding: 2px 8px 2px 0;
			border-right: 2px solid;
		}
	}

	p {
		@media screen and (max-width: 512px) {
			display: none;
		}

		&::before {
			content: '[';
		}

		&::after {
			content: ']';
		}
	}

	span ~ a {
		text-decoration: none;
		transition: all 0.1s ease;
		font-size: 1.3rem;

		&:hover,
		&#selected {
			border-bottom: 2px solid;
		}
	}

	span {
		flex-grow: 1;
	}
</style>
